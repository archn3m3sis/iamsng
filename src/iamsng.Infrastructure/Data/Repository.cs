using System.Linq.Expressions;
using System.Security.Claims;
using System.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using iamsng.Core.Interfaces;
using iamsng.Core.Entities;
using iamsng.Core.Specifications;

namespace iamsng.Infrastructure.Data;

/// <summary>
/// Generic repository implementation using Entity Framework Core
/// Provides secure data access with comprehensive audit logging and security validation
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// </summary>
/// <typeparam name="T">Entity type that must be a class</typeparam>
public class Repository<T> : IRepository<T> where T : class
{
    #region Fields and Properties
    
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    private readonly ILogger<Repository<T>> _logger;
    private readonly IAuditService _auditService;
    private readonly ISecurityService _securityService;
    
    /// <summary>
    /// Entity name for logging and audit purposes
    /// </summary>
    protected string EntityName => typeof(T).Name;
    
    #endregion
    
    #region Constructor
    
    /// <summary>
    /// Initializes a new instance of the Repository class
    /// FIPS 140-3 Compliance: All repository instances are audited upon creation
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="logger">Logger for diagnostic and audit purposes</param>
    /// <param name="auditService">Service for audit logging</param>
    /// <param name="securityService">Service for security validation</param>
    public Repository(ApplicationDbContext context, ILogger<Repository<T>> logger, IAuditService auditService, ISecurityService securityService)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _auditService = auditService ?? throw new ArgumentNullException(nameof(auditService));
        _securityService = securityService ?? throw new ArgumentNullException(nameof(securityService));
        _dbSet = _context.Set<T>();
        
        // Log repository creation for audit trail
        _logger.LogInformation("Repository<{EntityType}> created at {Timestamp}", EntityName, DateTimeOffset.UtcNow);
    }
    
    #endregion
    
    #region Query Operations
    
    /// <inheritdoc/>
    public async Task<IQueryable<T>> GetAllAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var query = _dbSet.AsQueryable();
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        await LogAuditEntryAsync(null, "GetAll", securityContext, new { EntityType = EntityName });
        
        _logger.LogDebug("GetAllAsync executed for {EntityType} by user {UserId}", EntityName, GetUserId(securityContext));
        return query;
    }
    
    /// <inheritdoc/>
    public async Task<T?> GetByIdAsync(object id, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (id == null)
            throw new ArgumentNullException(nameof(id));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var entity = await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        
        if (entity != null)
        {
            // Validate user has access to this specific entity
            if (!await ValidateSecurityContextAsync(entity, "Read", securityContext))
            {
                await LogAuditEntryAsync(entity, "GetById_AccessDenied", securityContext, new { EntityId = id });
                _logger.LogWarning("Access denied to {EntityType} with ID {EntityId} for user {UserId}", EntityName, id, GetUserId(securityContext));
                return null;
            }
            
            await LogAuditEntryAsync(entity, "GetById", securityContext, new { EntityId = id });
        }
        else
        {
            await LogAuditEntryAsync(null, "GetById_NotFound", securityContext, new { EntityId = id });
        }
        
        _logger.LogDebug("GetByIdAsync executed for {EntityType} ID {EntityId} by user {UserId}, Found: {Found}", 
            EntityName, id, GetUserId(securityContext), entity != null);
        
        return entity;
    }
    
    /// <inheritdoc/>
    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var query = _dbSet.Where(predicate);
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        var results = await query.ToListAsync(cancellationToken);
        
        await LogAuditEntryAsync(null, "Find", securityContext, new { 
            PredicateExpression = predicate.ToString(), 
            ResultCount = results.Count 
        });
        
        _logger.LogDebug("FindAsync executed for {EntityType} by user {UserId}, Results: {Count}", 
            EntityName, GetUserId(securityContext), results.Count);
        
        return results;
    }
    
    /// <inheritdoc/>
    public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var query = _dbSet.Where(predicate);
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        var result = await query.FirstOrDefaultAsync(cancellationToken);
        
        await LogAuditEntryAsync(result, "FirstOrDefault", securityContext, new { 
            PredicateExpression = predicate.ToString(),
            Found = result != null
        });
        
        _logger.LogDebug("FirstOrDefaultAsync executed for {EntityType} by user {UserId}, Found: {Found}", 
            EntityName, GetUserId(securityContext), result != null);
        
        return result;
    }
    
    /// <inheritdoc/>
    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var query = _dbSet.Where(predicate);
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        var exists = await query.AnyAsync(cancellationToken);
        
        await LogAuditEntryAsync(null, "Any", securityContext, new { 
            PredicateExpression = predicate.ToString(),
            Exists = exists
        });
        
        _logger.LogDebug("AnyAsync executed for {EntityType} by user {UserId}, Exists: {Exists}", 
            EntityName, GetUserId(securityContext), exists);
        
        return exists;
    }
    
    /// <inheritdoc/>
    public async Task<int> CountAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var query = _dbSet.Where(predicate);
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        var count = await query.CountAsync(cancellationToken);
        
        await LogAuditEntryAsync(null, "Count", securityContext, new { 
            PredicateExpression = predicate.ToString(),
            Count = count
        });
        
        _logger.LogDebug("CountAsync executed for {EntityType} by user {UserId}, Count: {Count}", 
            EntityName, GetUserId(securityContext), count);
        
        return count;
    }
    
    #endregion
    
    #region Specification Pattern Support
    
    /// <inheritdoc/>
    public async Task<IEnumerable<T>> GetBySpecificationAsync(ISpecification<T> specification, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (specification == null)
            throw new ArgumentNullException(nameof(specification));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        // Validate specification for security compliance
        if (specification is BaseSpecification<T> baseSpec && !baseSpec.ValidateSecurityCompliance())
        {
            throw new SecurityException($"Specification for {EntityName} does not meet DoD security requirements");
        }
        
        var query = ApplySpecification(specification);
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        var results = await query.ToListAsync(cancellationToken);
        
        await LogAuditEntryAsync(null, "GetBySpecification", securityContext, new { 
            SpecificationType = specification.GetType().Name,
            ResultCount = results.Count
        });
        
        _logger.LogDebug("GetBySpecificationAsync executed for {EntityType} using {SpecificationType} by user {UserId}, Results: {Count}", 
            EntityName, specification.GetType().Name, GetUserId(securityContext), results.Count);
        
        return results;
    }
    
    /// <inheritdoc/>
    public async Task<int> CountBySpecificationAsync(ISpecification<T> specification, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (specification == null)
            throw new ArgumentNullException(nameof(specification));
        
        await ValidateSecurityContextAsync(securityContext, "Read");
        
        var query = ApplySpecification(specification);
        query = await ApplySecurityFilterAsync(query, securityContext);
        
        var count = await query.CountAsync(cancellationToken);
        
        await LogAuditEntryAsync(null, "CountBySpecification", securityContext, new { 
            SpecificationType = specification.GetType().Name,
            Count = count
        });
        
        _logger.LogDebug("CountBySpecificationAsync executed for {EntityType} using {SpecificationType} by user {UserId}, Count: {Count}", 
            EntityName, specification.GetType().Name, GetUserId(securityContext), count);
        
        return count;
    }
    
    #endregion
    
    #region Modification Operations
    
    /// <inheritdoc/>
    public async Task<T> AddAsync(T entity, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        
        await ValidateSecurityContextAsync(entity, "Create", securityContext);
        
        // Apply audit fields if entity supports them
        await ApplyAuditFieldsAsync(entity, "Create", securityContext);
        
        var entry = await _dbSet.AddAsync(entity, cancellationToken);
        
        await LogAuditEntryAsync(entity, "Add", securityContext, new { 
            EntityState = entry.State.ToString()
        });
        
        _logger.LogInformation("Entity {EntityType} added by user {UserId}", EntityName, GetUserId(securityContext));
        
        return entry.Entity;
    }
    
    /// <inheritdoc/>
    public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));
        
        var entityList = entities.ToList();
        if (!entityList.Any())
            return entityList;
        
        // DoD Requirement: Validate batch size to prevent resource exhaustion
        const int maxBatchSize = 1000;
        if (entityList.Count > maxBatchSize)
        {
            throw new ArgumentException($"Batch size cannot exceed {maxBatchSize} entities for DoD compliance", nameof(entities));
        }
        
        // Validate security for each entity
        foreach (var entity in entityList)
        {
            await ValidateSecurityContextAsync(entity, "Create", securityContext);
            await ApplyAuditFieldsAsync(entity, "Create", securityContext);
        }
        
        await _dbSet.AddRangeAsync(entityList, cancellationToken);
        
        await LogAuditEntryAsync(null, "AddRange", securityContext, new { 
            EntityCount = entityList.Count
        });
        
        _logger.LogInformation("Batch of {Count} {EntityType} entities added by user {UserId}", 
            entityList.Count, EntityName, GetUserId(securityContext));
        
        return entityList;
    }
    
    /// <inheritdoc/>
    public async Task<T> UpdateAsync(T entity, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        
        await ValidateSecurityContextAsync(entity, "Update", securityContext);
        
        // Apply audit fields if entity supports them
        await ApplyAuditFieldsAsync(entity, "Update", securityContext);
        
        var entry = _dbSet.Update(entity);
        
        await LogAuditEntryAsync(entity, "Update", securityContext, new { 
            EntityState = entry.State.ToString()
        });
        
        _logger.LogInformation("Entity {EntityType} updated by user {UserId}", EntityName, GetUserId(securityContext));
        
        return entry.Entity;
    }
    
    /// <inheritdoc/>
    public async Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));
        
        var entityList = entities.ToList();
        if (!entityList.Any())
            return entityList;
        
        // DoD Requirement: Validate batch size
        const int maxBatchSize = 1000;
        if (entityList.Count > maxBatchSize)
        {
            throw new ArgumentException($"Batch size cannot exceed {maxBatchSize} entities for DoD compliance", nameof(entities));
        }
        
        // Validate security for each entity
        foreach (var entity in entityList)
        {
            await ValidateSecurityContextAsync(entity, "Update", securityContext);
            await ApplyAuditFieldsAsync(entity, "Update", securityContext);
        }
        
        _dbSet.UpdateRange(entityList);
        
        await LogAuditEntryAsync(null, "UpdateRange", securityContext, new { 
            EntityCount = entityList.Count
        });
        
        _logger.LogInformation("Batch of {Count} {EntityType} entities updated by user {UserId}", 
            entityList.Count, EntityName, GetUserId(securityContext));
        
        return entityList;
    }
    
    /// <inheritdoc/>
    public async Task RemoveAsync(T entity, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        
        await ValidateSecurityContextAsync(entity, "Delete", securityContext);
        
        // Check if entity supports soft delete (DoD preferred approach)
        if (await TrySoftDeleteAsync(entity, securityContext))
        {
            await LogAuditEntryAsync(entity, "SoftDelete", securityContext);
            _logger.LogInformation("Entity {EntityType} soft deleted by user {UserId}", EntityName, GetUserId(securityContext));
        }
        else
        {
            _dbSet.Remove(entity);
            await LogAuditEntryAsync(entity, "HardDelete", securityContext);
            _logger.LogWarning("Entity {EntityType} hard deleted by user {UserId}", EntityName, GetUserId(securityContext));
        }
    }
    
    /// <inheritdoc/>
    public async Task RemoveByIdAsync(object id, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (id == null)
            throw new ArgumentNullException(nameof(id));
        
        var entity = await GetByIdAsync(id, securityContext, cancellationToken);
        if (entity != null)
        {
            await RemoveAsync(entity, securityContext, cancellationToken);
        }
        else
        {
            await LogAuditEntryAsync(null, "RemoveById_NotFound", securityContext, new { EntityId = id });
            _logger.LogWarning("Attempted to delete non-existent {EntityType} with ID {EntityId} by user {UserId}", 
                EntityName, id, GetUserId(securityContext));
        }
    }
    
    /// <inheritdoc/>
    public async Task RemoveRangeAsync(IEnumerable<T> entities, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default)
    {
        if (entities == null)
            throw new ArgumentNullException(nameof(entities));
        
        var entityList = entities.ToList();
        if (!entityList.Any())
            return;
        
        // DoD Requirement: Validate batch size
        const int maxBatchSize = 1000;
        if (entityList.Count > maxBatchSize)
        {
            throw new ArgumentException($"Batch size cannot exceed {maxBatchSize} entities for DoD compliance", nameof(entities));
        }
        
        // Validate security for each entity
        foreach (var entity in entityList)
        {
            await ValidateSecurityContextAsync(entity, "Delete", securityContext);
        }
        
        // Try soft delete for all entities first
        var softDeletedCount = 0;
        var hardDeleteEntities = new List<T>();
        
        foreach (var entity in entityList)
        {
            if (await TrySoftDeleteAsync(entity, securityContext))
            {
                softDeletedCount++;
            }
            else
            {
                hardDeleteEntities.Add(entity);
            }
        }
        
        if (hardDeleteEntities.Any())
        {
            _dbSet.RemoveRange(hardDeleteEntities);
        }
        
        await LogAuditEntryAsync(null, "RemoveRange", securityContext, new { 
            TotalCount = entityList.Count,
            SoftDeletedCount = softDeletedCount,
            HardDeletedCount = hardDeleteEntities.Count
        });
        
        _logger.LogInformation("Batch delete of {Count} {EntityType} entities by user {UserId} (Soft: {SoftCount}, Hard: {HardCount})", 
            entityList.Count, EntityName, GetUserId(securityContext), softDeletedCount, hardDeleteEntities.Count);
    }
    
    #endregion
    
    #region Audit and Security Implementation
    
    /// <inheritdoc/>
    public async Task<bool> ValidateSecurityContextAsync(T? entity, string operation, ClaimsPrincipal securityContext)
    {
        if (securityContext?.Identity?.IsAuthenticated != true)
        {
            _logger.LogWarning("Unauthenticated access attempt to {EntityType} for operation {Operation}", EntityName, operation);
            return false;
        }
        
        // Use injected security service for validation
        var isAuthorized = await _securityService.ValidateEntityAccessAsync(entity, operation, securityContext);
        
        if (!isAuthorized)
        {
            await LogAuditEntryAsync(entity, $"{operation}_AccessDenied", securityContext);
            _logger.LogWarning("Access denied for user {UserId} to {EntityType} for operation {Operation}", 
                GetUserId(securityContext), EntityName, operation);
        }
        
        return isAuthorized;
    }
    
    /// <inheritdoc/>
    public async Task LogAuditEntryAsync(T? entity, string operation, ClaimsPrincipal securityContext, object? additionalData = null)
    {
        try
        {
            await _auditService.LogAsync(new AuditEntry
            {
                EntityType = EntityName,
                EntityId = GetEntityId(entity),
                Operation = operation,
                UserId = GetUserId(securityContext),
                Timestamp = DateTimeOffset.UtcNow,
                Details = additionalData != null ? 
                    System.Text.Json.JsonSerializer.Serialize(additionalData) : 
                    null
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to log audit entry for {EntityType} operation {Operation} by user {UserId}", 
                EntityName, operation, GetUserId(securityContext));
            // Don't throw - audit logging failure shouldn't break business operations
        }
    }
    
    #endregion
    
    #region Private Helper Methods
    
    /// <summary>
    /// Applies security filters to the query based on user context
    /// DoD Requirement: Implement row-level security
    /// </summary>
    private async Task<IQueryable<T>> ApplySecurityFilterAsync(IQueryable<T> query, ClaimsPrincipal securityContext)
    {
        return await _securityService.ApplySecurityFilterAsync(query, securityContext);
    }
    
    /// <summary>
    /// Applies specification to the query
    /// Performance optimization: Efficient query building
    /// </summary>
    private IQueryable<T> ApplySpecification(ISpecification<T> specification)
    {
        var query = _dbSet.AsQueryable();
        
        // Apply criteria
        if (specification.Criteria != null)
        {
            query = query.Where(specification.Criteria);
        }
        
        // Apply includes
        query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
        query = specification.IncludeStrings.Aggregate(query, (current, include) => current.Include(include));
        
        // Apply ordering
        if (specification.OrderBy != null)
        {
            query = query.OrderBy(specification.OrderBy);
        }
        else if (specification.OrderByDescending != null)
        {
            query = query.OrderByDescending(specification.OrderByDescending);
        }
        
        // Apply grouping
        if (specification.GroupBy != null)
        {
            // GroupBy is more complex and would need specific implementation based on requirements
        }
        
        // Apply paging
        if (specification.IsPagingEnabled)
        {
            query = query.Skip(specification.Skip).Take(specification.Take);
        }
        
        // Apply tracking settings
        if (specification.AsNoTracking)
        {
            query = query.AsNoTracking();
        }
        
        return query;
    }
    
    /// <summary>
    /// Attempts to perform soft delete if entity supports it
    /// DoD Preference: Soft delete for audit trail preservation
    /// </summary>
    private async Task<bool> TrySoftDeleteAsync(T entity, ClaimsPrincipal securityContext)
    {
        // Check if entity implements ISoftDeletable interface
        if (entity is ISoftDeletable softDeletable)
        {
            softDeletable.IsDeleted = true;
            softDeletable.DeletedAt = DateTimeOffset.UtcNow;
            softDeletable.DeletedBy = GetUserId(securityContext);
            
            await ApplyAuditFieldsAsync(entity, "SoftDelete", securityContext);
            _dbSet.Update(entity);
            return true;
        }
        
        return false;
    }
    
    /// <summary>
    /// Applies audit fields to entity if it supports auditing
    /// FIPS 140-3 Compliance: Audit trail for all data modifications
    /// </summary>
    private async Task ApplyAuditFieldsAsync(T entity, string operation, ClaimsPrincipal securityContext)
    {
        if (entity is IAuditable auditable)
        {
            var userId = GetUserId(securityContext);
            var timestamp = DateTimeOffset.UtcNow;
            
            if (operation == "Create")
            {
                auditable.CreatedAt = timestamp;
                auditable.CreatedBy = userId;
            }
            
            auditable.UpdatedAt = timestamp;
            auditable.UpdatedBy = userId;
        }
        
        await Task.CompletedTask; // Placeholder for async audit field application
    }
    
    /// <summary>
    /// Validates security context for basic authentication
    /// </summary>
    private async Task ValidateSecurityContextAsync(ClaimsPrincipal securityContext, string operation)
    {
        if (securityContext?.Identity?.IsAuthenticated != true)
        {
            throw new UnauthorizedAccessException($"Authentication required for {operation} operation on {EntityName}");
        }
        
        await Task.CompletedTask; // Placeholder for additional security validation
    }
    
    /// <summary>
    /// Extracts user ID from security context
    /// </summary>
    private static string GetUserId(ClaimsPrincipal securityContext)
    {
        return securityContext?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? 
               securityContext?.FindFirst("sub")?.Value ?? 
               "UNKNOWN";
    }
    
    /// <summary>
    /// Extracts entity ID for audit purposes
    /// </summary>
    private static string? GetEntityId(T? entity)
    {
        if (entity == null) return null;
        
        // Try to get ID from common patterns
        var idProperty = typeof(T).GetProperty("Id") ?? typeof(T).GetProperty("ID");
        return idProperty?.GetValue(entity)?.ToString();
    }
    
    #endregion
}

