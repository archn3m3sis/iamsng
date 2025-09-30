using System.Collections.Concurrent;
using System.Data;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using iamsng.Core.Interfaces;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data;

/// <summary>
/// Unit of Work implementation providing transactional consistency across multiple repository operations
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// Implements comprehensive audit logging and security validation
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    #region Fields and Properties
    
    private readonly ApplicationDbContext _context;
    private readonly ILogger<UnitOfWork> _logger;
    private readonly IAuditService _auditService;
    private readonly ISecurityService _securityService;
    private readonly IServiceProvider _serviceProvider;
    
    private readonly ConcurrentDictionary<Type, object> _repositories = new();
    private readonly List<AuditEntry> _sessionAuditEntries = new();
    private readonly UnitOfWorkMetrics _metrics = new();
    
    private IDbContextTransaction? _currentTransaction;
    private bool _disposed;
    private bool _autoAuditLogging = true;
    private readonly string _auditSessionId = Guid.NewGuid().ToString();
    private readonly DateTimeOffset _sessionStartTime = DateTimeOffset.UtcNow;
    
    /// <inheritdoc/>
    public bool HasActiveTransaction => _currentTransaction != null && !_disposed;
    
    /// <inheritdoc/>
    public string AuditSessionId => _auditSessionId;
    
    #endregion
    
    #region Constructor
    
    /// <summary>
    /// Initializes a new instance of the UnitOfWork class
    /// FIPS 140-3 Compliance: All UoW instances are audited upon creation
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="logger">Logger for diagnostic and audit purposes</param>
    /// <param name="auditService">Service for audit logging</param>
    /// <param name="securityService">Service for security validation</param>
    /// <param name="serviceProvider">Service provider for repository creation</param>
    public UnitOfWork(
        ApplicationDbContext context,
        ILogger<UnitOfWork> logger,
        IAuditService auditService,
        ISecurityService securityService,
        IServiceProvider serviceProvider)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _auditService = auditService ?? throw new ArgumentNullException(nameof(auditService));
        _securityService = securityService ?? throw new ArgumentNullException(nameof(securityService));
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        
        _logger.LogInformation("UnitOfWork created with session ID {SessionId} at {Timestamp}", _auditSessionId, _sessionStartTime);
    }
    
    #endregion
    
    #region Repository Access
    
    /// <inheritdoc/>
    public IRepository<T> Repository<T>() where T : class
    {
        var type = typeof(T);
        return (IRepository<T>)_repositories.GetOrAdd(type, _ =>
        {
            // Use service provider to create repository with proper dependencies
            var repositoryType = typeof(Repository<>).MakeGenericType(type);
            var repository = Activator.CreateInstance(repositoryType, _context, 
                Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ILogger<Repository<T>>>(_serviceProvider),
                _auditService, _securityService);
            
            _logger.LogDebug("Repository<{EntityType}> created for session {SessionId}", type.Name, _auditSessionId);
            return repository ?? throw new InvalidOperationException($"Failed to create repository for type {type.Name}");
        });
    }
    
    /// <inheritdoc/>
    public object Repository(Type entityType)
    {
        if (entityType == null)
            throw new ArgumentNullException(nameof(entityType));
        
        return _repositories.GetOrAdd(entityType, type =>
        {
            var repositoryType = typeof(Repository<>).MakeGenericType(type);
            var loggerType = typeof(ILogger<>).MakeGenericType(repositoryType);
            var logger = _serviceProvider.GetService(loggerType);
            
            var repository = Activator.CreateInstance(repositoryType, _context, logger, _auditService, _securityService);
            
            _logger.LogDebug("Repository for {EntityType} created for session {SessionId}", type.Name, _auditSessionId);
            return repository ?? throw new InvalidOperationException($"Failed to create repository for type {type.Name}");
        });
    }
    
    #endregion
    
    #region Transaction Management
    
    /// <inheritdoc/>
    public async Task<IDbTransaction> BeginTransactionAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, ClaimsPrincipal? securityContext = null, CancellationToken cancellationToken = default)
    {
        if (_currentTransaction != null)
        {
            throw new InvalidOperationException("Transaction already active. Nested transactions are not supported for DoD compliance.");
        }
        
        _currentTransaction = await _context.Database.BeginTransactionAsync(isolationLevel, cancellationToken);
        
        var auditEntry = new AuditEntry
        {
            SessionId = _auditSessionId,
            Operation = "BeginTransaction",
            EntityType = "Transaction",
            UserId = GetUserId(securityContext),
            Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> { ["IsolationLevel"] = isolationLevel.ToString() })
        };
        
        await LogAuditEntryAsync(auditEntry);
        _logger.LogInformation("Transaction started with isolation level {IsolationLevel} for session {SessionId} by user {UserId}", 
            isolationLevel, _auditSessionId, GetUserId(securityContext));
        
        return _currentTransaction?.GetDbTransaction();
    }
    
    /// <inheritdoc/>
    public async Task CommitTransactionAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (_currentTransaction == null)
        {
            throw new InvalidOperationException("No active transaction to commit");
        }
        
        try
        {
            // Validate all pending changes before commit
            var validationResult = await ValidatePendingChangesAsync(securityContext, cancellationToken);
            if (!validationResult.IsValid)
            {
                var errors = string.Join("; ", validationResult.Errors);
                _logger.LogWarning("Transaction commit failed validation for session {SessionId}: {Errors}", _auditSessionId, errors);
                throw new ValidationException($"Pending changes failed validation: {errors}");
            }
            
            await _currentTransaction.CommitAsync(cancellationToken);
            
            var auditEntry = new AuditEntry
            {
                SessionId = _auditSessionId,
                Operation = "CommitTransaction",
                EntityType = "Transaction",
                UserId = GetUserId(securityContext),
                Result = "Success"
            };
            
            await LogAuditEntryAsync(auditEntry);
            _logger.LogInformation("Transaction committed successfully for session {SessionId} by user {UserId}", 
                _auditSessionId, GetUserId(securityContext));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Transaction commit failed for session {SessionId}", _auditSessionId);
            
            var auditEntry = new AuditEntry
            {
                SessionId = _auditSessionId,
                Operation = "CommitTransaction",
                EntityType = "Transaction",
                UserId = GetUserId(securityContext),
                Result = "Failed",
                Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> { ["Error"] = ex.Message })
            };
            
            await LogAuditEntryAsync(auditEntry);
            throw;
        }
        finally
        {
            await _currentTransaction.DisposeAsync();
            _currentTransaction = null;
        }
    }
    
    /// <inheritdoc/>
    public async Task RollbackTransactionAsync(ClaimsPrincipal securityContext, string? reason = null, CancellationToken cancellationToken = default)
    {
        if (_currentTransaction == null)
        {
            throw new InvalidOperationException("No active transaction to rollback");
        }
        
        try
        {
            await _currentTransaction.RollbackAsync(cancellationToken);
            
            var auditEntry = new AuditEntry
            {
                SessionId = _auditSessionId,
                Operation = "RollbackTransaction",
                EntityType = "Transaction",
                UserId = GetUserId(securityContext),
                Result = "Success",
                Details = System.Text.Json.JsonSerializer.Serialize(reason != null ? new Dictionary<string, object> { ["Reason"] = reason } : new Dictionary<string, object>())
            };
            
            await LogAuditEntryAsync(auditEntry);
            _logger.LogWarning("Transaction rolled back for session {SessionId} by user {UserId}. Reason: {Reason}", 
                _auditSessionId, GetUserId(securityContext), reason ?? "Not specified");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Transaction rollback failed for session {SessionId}", _auditSessionId);
            throw;
        }
        finally
        {
            await _currentTransaction.DisposeAsync();
            _currentTransaction = null;
        }
    }
    
    /// <inheritdoc/>
    public IDbTransaction? GetCurrentTransaction()
    {
        return _currentTransaction?.GetDbTransaction();
    }
    
    #endregion
    
    #region Change Tracking and Persistence
    
    /// <inheritdoc/>
    public async Task<int> SaveChangesAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (securityContext?.Identity?.IsAuthenticated != true)
        {
            throw new UnauthorizedAccessException("Authentication required for save operations");
        }
        
        var startTime = DateTimeOffset.UtcNow;
        var changeCount = GetPendingChangesCount();
        
        try
        {
            // Validate pending changes
            var validationResult = await ValidatePendingChangesAsync(securityContext, cancellationToken);
            if (!validationResult.IsValid)
            {
                var errors = string.Join("; ", validationResult.Errors);
                throw new ValidationException($"Pending changes failed validation: {errors}");
            }
            
            // Apply audit fields to modified entities
            await ApplyAuditFieldsToChangedEntitiesAsync(securityContext);
            
            var savedCount = await _context.SaveChangesAsync(cancellationToken);
            var duration = DateTimeOffset.UtcNow - startTime;
            
            // Update metrics
            UpdateMetrics(savedCount, duration);
            
            var auditEntry = new AuditEntry
            {
                SessionId = _auditSessionId,
                Operation = "SaveChanges",
                EntityType = "UnitOfWork",
                UserId = GetUserId(securityContext),
                Result = "Success",
                Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> 
                { 
                    ["SavedCount"] = savedCount,
                    ["ChangeCount"] = changeCount,
                    ["DurationMs"] = duration.TotalMilliseconds
                })
            };
            
            await LogAuditEntryAsync(auditEntry);
            _logger.LogInformation("SaveChanges completed for session {SessionId}: {SavedCount} entities saved in {DurationMs}ms by user {UserId}", 
                _auditSessionId, savedCount, duration.TotalMilliseconds, GetUserId(securityContext));
            
            return savedCount;
        }
        catch (Exception ex)
        {
            var duration = DateTimeOffset.UtcNow - startTime;
            
            var auditEntry = new AuditEntry
            {
                SessionId = _auditSessionId,
                Operation = "SaveChanges",
                EntityType = "UnitOfWork",
                UserId = GetUserId(securityContext),
                Result = "Failed",
                Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> 
                { 
                    ["ChangeCount"] = changeCount,
                    ["DurationMs"] = duration.TotalMilliseconds,
                    ["Error"] = ex.Message
                })
            };
            
            await LogAuditEntryAsync(auditEntry);
            _logger.LogError(ex, "SaveChanges failed for session {SessionId} after {DurationMs}ms", _auditSessionId, duration.TotalMilliseconds);
            
            throw;
        }
    }
    
    /// <inheritdoc/>
    public async Task<int> SaveChangesInTransactionAsync(ClaimsPrincipal securityContext, IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, CancellationToken cancellationToken = default)
    {
        var hadExistingTransaction = HasActiveTransaction;
        
        if (!hadExistingTransaction)
        {
            await BeginTransactionAsync(isolationLevel, securityContext, cancellationToken);
        }
        
        try
        {
            var result = await SaveChangesAsync(securityContext, cancellationToken);
            
            if (!hadExistingTransaction)
            {
                await CommitTransactionAsync(securityContext, cancellationToken);
            }
            
            return result;
        }
        catch
        {
            if (!hadExistingTransaction && HasActiveTransaction)
            {
                await RollbackTransactionAsync(securityContext, "SaveChanges failed", cancellationToken);
            }
            throw;
        }
    }
    
    /// <inheritdoc/>
    public async Task DiscardChangesAsync(ClaimsPrincipal securityContext)
    {
        var changeCount = GetPendingChangesCount();
        
        foreach (var entry in _context.ChangeTracker.Entries())
        {
            entry.State = EntityState.Unchanged;
        }
        
        var auditEntry = new AuditEntry
        {
            SessionId = _auditSessionId,
            Operation = "DiscardChanges",
            EntityType = "UnitOfWork",
            UserId = GetUserId(securityContext),
            Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> { ["DiscardedChangeCount"] = changeCount })
        };
        
        await LogAuditEntryAsync(auditEntry);
        _logger.LogInformation("Discarded {ChangeCount} pending changes for session {SessionId} by user {UserId}", 
            changeCount, _auditSessionId, GetUserId(securityContext));
    }
    
    /// <inheritdoc/>
    public int GetPendingChangesCount()
    {
        return _context.ChangeTracker.Entries()
            .Count(e => e.State == EntityState.Added || 
                       e.State == EntityState.Modified || 
                       e.State == EntityState.Deleted);
    }
    
    /// <inheritdoc/>
    public void DetachEntity<T>(T entity) where T : class
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        
        var entry = _context.Entry(entity);
        if (entry != null)
        {
            entry.State = EntityState.Detached;
            _logger.LogDebug("Entity {EntityType} detached from change tracking in session {SessionId}", typeof(T).Name, _auditSessionId);
        }
    }
    
    /// <inheritdoc/>
    public async Task<T> ReloadEntityAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        
        var entry = _context.Entry(entity);
        await entry.ReloadAsync(cancellationToken);
        
        _logger.LogDebug("Entity {EntityType} reloaded from database in session {SessionId}", typeof(T).Name, _auditSessionId);
        return entity;
    }
    
    #endregion
    
    #region Bulk Operations
    
    /// <inheritdoc/>
    public async Task<int> BulkInsertAsync<T>(IEnumerable<T> entities, ClaimsPrincipal securityContext, int batchSize = 1000, CancellationToken cancellationToken = default) where T : class
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));
        
        var entityList = entities.ToList();
        if (!entityList.Any())
            return 0;
        
        var totalInserted = 0;
        var batches = entityList.Chunk(batchSize);
        
        foreach (var batch in batches)
        {
            var repository = Repository<T>();
            var insertedEntities = await repository.AddRangeAsync(batch, securityContext, cancellationToken);
            var batchCount = await SaveChangesAsync(securityContext, cancellationToken);
            totalInserted += batchCount;
        }
        
        var auditEntry = new AuditEntry
        {
            SessionId = _auditSessionId,
            Operation = "BulkInsert",
            EntityType = typeof(T).Name,
            UserId = GetUserId(securityContext),
            Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> 
            { 
                ["TotalInserted"] = totalInserted,
                ["BatchSize"] = batchSize
            })
        };
        
        await LogAuditEntryAsync(auditEntry);
        _logger.LogInformation("Bulk insert completed for {EntityType}: {TotalInserted} entities inserted in session {SessionId}", 
            typeof(T).Name, totalInserted, _auditSessionId);
        
        return totalInserted;
    }
    
    /// <inheritdoc/>
    public async Task<int> BulkUpdateAsync<T>(IEnumerable<T> entities, ClaimsPrincipal securityContext, int batchSize = 1000, CancellationToken cancellationToken = default) where T : class
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));
        
        var entityList = entities.ToList();
        if (!entityList.Any())
            return 0;
        
        var totalUpdated = 0;
        var batches = entityList.Chunk(batchSize);
        
        foreach (var batch in batches)
        {
            var repository = Repository<T>();
            await repository.UpdateRangeAsync(batch, securityContext, cancellationToken);
            var batchCount = await SaveChangesAsync(securityContext, cancellationToken);
            totalUpdated += batchCount;
        }
        
        var auditEntry = new AuditEntry
        {
            SessionId = _auditSessionId,
            Operation = "BulkUpdate",
            EntityType = typeof(T).Name,
            UserId = GetUserId(securityContext),
            Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> 
            { 
                ["TotalUpdated"] = totalUpdated,
                ["BatchSize"] = batchSize
            })
        };
        
        await LogAuditEntryAsync(auditEntry);
        _logger.LogInformation("Bulk update completed for {EntityType}: {TotalUpdated} entities updated in session {SessionId}", 
            typeof(T).Name, totalUpdated, _auditSessionId);
        
        return totalUpdated;
    }
    
    /// <inheritdoc/>
    public async Task<int> BulkDeleteAsync<T>(IEnumerable<T> entities, ClaimsPrincipal securityContext, int batchSize = 1000, CancellationToken cancellationToken = default) where T : class
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));
        
        var entityList = entities.ToList();
        if (!entityList.Any())
            return 0;
        
        var totalDeleted = 0;
        var batches = entityList.Chunk(batchSize);
        
        foreach (var batch in batches)
        {
            var repository = Repository<T>();
            await repository.RemoveRangeAsync(batch, securityContext, cancellationToken);
            var batchCount = await SaveChangesAsync(securityContext, cancellationToken);
            totalDeleted += batchCount;
        }
        
        var auditEntry = new AuditEntry
        {
            SessionId = _auditSessionId,
            Operation = "BulkDelete",
            EntityType = typeof(T).Name,
            UserId = GetUserId(securityContext),
            Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> 
            { 
                ["TotalDeleted"] = totalDeleted,
                ["BatchSize"] = batchSize
            })
        };
        
        await LogAuditEntryAsync(auditEntry);
        _logger.LogInformation("Bulk delete completed for {EntityType}: {TotalDeleted} entities deleted in session {SessionId}", 
            typeof(T).Name, totalDeleted, _auditSessionId);
        
        return totalDeleted;
    }
    
    #endregion
    
    #region Audit and Compliance
    
    /// <inheritdoc/>
    public async Task<ValidationResult> ValidatePendingChangesAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        var errors = new List<string>();
        var warnings = new List<string>();
        
        var changeEntries = _context.ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added || 
                       e.State == EntityState.Modified || 
                       e.State == EntityState.Deleted)
            .ToList();
        
        // DoD Requirement: Validate security for all changes
        foreach (var entry in changeEntries)
        {
            var entityType = entry.Entity.GetType();
            var operation = entry.State switch
            {
                EntityState.Added => "Create",
                EntityState.Modified => "Update",
                EntityState.Deleted => "Delete",
                _ => "Unknown"
            };
            
            // Validate security context for each entity
            var isAuthorized = await _securityService.ValidateEntityAccessAsync(entry.Entity, operation, securityContext);
            if (!isAuthorized)
            {
                errors.Add($"Unauthorized {operation} operation on {entityType.Name}");
            }
            
            // Additional business rule validations would go here
            await ValidateBusinessRulesAsync(entry, errors, warnings);
        }
        
        // DoD Requirement: Enforce maximum batch size
        if (changeEntries.Count > 10000)
        {
            errors.Add("Batch size exceeds DoD maximum of 10,000 entities");
        }
        
        var result = new ValidationResult 
        { 
            IsValid = !errors.Any(),
            Errors = errors,
            Warnings = warnings
        };
        
        var auditEntry = new AuditEntry
        {
            SessionId = _auditSessionId,
            Operation = "ValidatePendingChanges",
            EntityType = "UnitOfWork",
            UserId = GetUserId(securityContext),
            Details = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object> 
            { 
                ["ValidationResult"] = result.IsValid ? "Passed" : "Failed",
                ["ErrorCount"] = errors.Count,
                ["WarningCount"] = warnings.Count,
                ["ChangeCount"] = changeEntries.Count
            })
        };
        
        await LogAuditEntryAsync(auditEntry);
        
        return result;
    }
    
    /// <inheritdoc/>
    public async Task<AuditReport> GenerateAuditReportAsync(ClaimsPrincipal securityContext)
    {
        var report = new AuditReport
        {
            SessionId = _auditSessionId,
            UserId = GetUserId(securityContext),
            Operations = new List<AuditEntry>(_sessionAuditEntries),
            Summary = new Dictionary<string, object>
            {
                ["SessionStartTime"] = _sessionStartTime,
                ["SessionDuration"] = DateTimeOffset.UtcNow - _sessionStartTime,
                ["TotalOperations"] = _sessionAuditEntries.Count,
                ["RepositoryTypes"] = _repositories.Keys.Select(t => t.Name).ToList(),
                ["HasActiveTransaction"] = HasActiveTransaction,
                ["Metrics"] = _metrics
            }
        };
        
        _logger.LogInformation("Audit report generated for session {SessionId} with {OperationCount} operations", 
            _auditSessionId, _sessionAuditEntries.Count);
        
        return report;
    }
    
    /// <inheritdoc/>
    public void SetAutoAuditLogging(bool enabled)
    {
        _autoAuditLogging = enabled;
        _logger.LogDebug("Auto audit logging {Status} for session {SessionId}", 
            enabled ? "enabled" : "disabled", _auditSessionId);
    }
    
    #endregion
    
    #region Performance and Monitoring
    
    /// <inheritdoc/>
    public void EnableQueryLogging(bool enabled)
    {
        // This would typically integrate with EF Core logging configuration
        _logger.LogDebug("Query logging {Status} for session {SessionId}", 
            enabled ? "enabled" : "disabled", _auditSessionId);
    }
    
    /// <inheritdoc/>
    public UnitOfWorkMetrics GetPerformanceMetrics()
    {
        var currentMetrics = new UnitOfWorkMetrics
        {
            QueryCount = _metrics.QueryCount,
            TotalExecutionTime = DateTimeOffset.UtcNow - _sessionStartTime,
            AverageQueryTime = _metrics.QueryCount > 0 ? 
                TimeSpan.FromMilliseconds(_metrics.TotalExecutionTime.TotalMilliseconds / _metrics.QueryCount) : 
                TimeSpan.Zero,
            TrackedEntitiesCount = _context.ChangeTracker.Entries().Count(),
            MemoryUsageBytes = GC.GetTotalMemory(false),
            DatabaseRoundTrips = _metrics.DatabaseRoundTrips,
            CacheHitRatio = _metrics.CacheHitRatio,
            AdditionalMetrics = new Dictionary<string, object>
            {
                ["SessionId"] = _auditSessionId,
                ["SessionDuration"] = DateTimeOffset.UtcNow - _sessionStartTime,
                ["RepositoryCount"] = _repositories.Count,
                ["AuditEntriesCount"] = _sessionAuditEntries.Count
            }
        };
        
        return currentMetrics;
    }
    
    /// <inheritdoc/>
    public void SetCommandTimeout(int timeoutSeconds)
    {
        if (timeoutSeconds <= 0)
            throw new ArgumentException("Timeout must be positive", nameof(timeoutSeconds));
        
        // DoD Requirement: Maximum timeout to prevent resource exhaustion
        const int maxTimeoutSeconds = 300; // 5 minutes
        if (timeoutSeconds > maxTimeoutSeconds)
        {
            throw new ArgumentException($"Timeout cannot exceed {maxTimeoutSeconds} seconds for DoD compliance", nameof(timeoutSeconds));
        }
        
        _context.Database.SetCommandTimeout(timeoutSeconds);
        _logger.LogDebug("Command timeout set to {TimeoutSeconds} seconds for session {SessionId}", 
            timeoutSeconds, _auditSessionId);
    }
    
    #endregion
    
    #region Private Helper Methods
    
    /// <summary>
    /// Logs audit entry to the session collection and audit service
    /// </summary>
    private async Task LogAuditEntryAsync(AuditEntry auditEntry)
    {
        if (_autoAuditLogging)
        {
            _sessionAuditEntries.Add(auditEntry);
            await _auditService.LogAsync(auditEntry);
        }
    }
    
    /// <summary>
    /// Applies audit fields to all changed entities
    /// </summary>
    private async Task ApplyAuditFieldsToChangedEntitiesAsync(ClaimsPrincipal securityContext)
    {
        var userId = GetUserId(securityContext);
        var timestamp = DateTimeOffset.UtcNow;
        
        var changedEntries = _context.ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
            .ToList();
        
        foreach (var entry in changedEntries)
        {
            if (entry.Entity is IAuditable auditable)
            {
                if (entry.State == EntityState.Added)
                {
                    auditable.CreatedAt = timestamp;
                    auditable.CreatedBy = userId;
                }
                
                auditable.UpdatedAt = timestamp;
                auditable.UpdatedBy = userId;
            }
        }
        
        await Task.CompletedTask; // Placeholder for async audit field application
    }
    
    /// <summary>
    /// Validates business rules for entity changes
    /// </summary>
    private async Task ValidateBusinessRulesAsync(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry, List<string> errors, List<string> warnings)
    {
        // Placeholder for business rule validation
        // This would be implemented based on specific business requirements
        await Task.CompletedTask;
    }
    
    /// <summary>
    /// Updates performance metrics
    /// </summary>
    private void UpdateMetrics(int savedCount, TimeSpan duration)
    {
        _metrics.QueryCount++;
        _metrics.DatabaseRoundTrips++;
        // Additional metric updates would be implemented here
    }
    
    /// <summary>
    /// Extracts user ID from security context
    /// </summary>
    private static string GetUserId(ClaimsPrincipal? securityContext)
    {
        return securityContext?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? 
               securityContext?.FindFirst("sub")?.Value ?? 
               "SYSTEM";
    }
    
    #endregion
    
    #region Disposal
    
    /// <inheritdoc/>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    /// <inheritdoc/>
    public async ValueTask DisposeAsync()
    {
        await DisposeAsyncCore();
        Dispose(false);
        GC.SuppressFinalize(this);
    }
    
    /// <summary>
    /// Synchronous disposal implementation
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            try
            {
                _currentTransaction?.Dispose();
                
                var sessionDuration = DateTimeOffset.UtcNow - _sessionStartTime;
                _logger.LogInformation("UnitOfWork session {SessionId} disposed after {Duration}ms with {RepositoryCount} repositories and {AuditEntryCount} audit entries", 
                    _auditSessionId, sessionDuration.TotalMilliseconds, _repositories.Count, _sessionAuditEntries.Count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during UnitOfWork disposal for session {SessionId}", _auditSessionId);
            }
            finally
            {
                _repositories.Clear();
                _sessionAuditEntries.Clear();
                _disposed = true;
            }
        }
    }
    
    /// <summary>
    /// Asynchronous disposal implementation
    /// </summary>
    protected virtual async ValueTask DisposeAsyncCore()
    {
        if (!_disposed)
        {
            try
            {
                if (_currentTransaction != null)
                {
                    await _currentTransaction.DisposeAsync();
                    _currentTransaction = null;
                }
                
                var sessionDuration = DateTimeOffset.UtcNow - _sessionStartTime;
                _logger.LogInformation("UnitOfWork session {SessionId} disposed asynchronously after {Duration}ms with {RepositoryCount} repositories and {AuditEntryCount} audit entries", 
                    _auditSessionId, sessionDuration.TotalMilliseconds, _repositories.Count, _sessionAuditEntries.Count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during async UnitOfWork disposal for session {SessionId}", _auditSessionId);
            }
            finally
            {
                _repositories.Clear();
                _sessionAuditEntries.Clear();
                _disposed = true;
            }
        }
    }
    
    #endregion
}

/// <summary>
/// Exception thrown when validation fails
/// </summary>
public class ValidationException : Exception
{
    public ValidationException(string message) : base(message) { }
    public ValidationException(string message, Exception innerException) : base(message, innerException) { }
}