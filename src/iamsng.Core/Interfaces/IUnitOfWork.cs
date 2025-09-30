using System.Data;
using System.Security.Claims;
using iamsng.Core.Entities;

namespace iamsng.Core.Interfaces;

/// <summary>
/// Unit of Work interface implementing the Unit of Work pattern
/// Provides transactional consistency across multiple repository operations
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// </summary>
public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    #region Repository Access
    
    /// <summary>
    /// Gets repository for specified entity type with lazy initialization
    /// Repositories are cached for the lifetime of the UoW instance
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <returns>Repository instance for the entity type</returns>
    IRepository<T> Repository<T>() where T : class;
    
    /// <summary>
    /// Gets repository for specified entity type with explicit type parameter
    /// Used when generic type inference is not possible
    /// </summary>
    /// <param name="entityType">Type of entity</param>
    /// <returns>Repository instance for the entity type</returns>
    object Repository(Type entityType);
    
    #endregion
    
    #region Transaction Management
    
    /// <summary>
    /// Begins a new database transaction with specified isolation level
    /// DoD Requirement: All multi-table operations must be transactional
    /// FIPS 140-3 Compliance: Transaction boundaries are audited
    /// </summary>
    /// <param name="isolationLevel">Transaction isolation level</param>
    /// <param name="securityContext">Security context for audit logging</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Transaction object for manual control</returns>
    Task<IDbTransaction> BeginTransactionAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, ClaimsPrincipal? securityContext = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Commits the current transaction with audit logging
    /// DoD Requirement: All transaction commits must be logged with user context
    /// </summary>
    /// <param name="securityContext">Security context for audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task representing the async operation</returns>
    Task CommitTransactionAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Rolls back the current transaction with audit logging
    /// FIPS 140-3 Compliance: Rollbacks are logged for security analysis
    /// </summary>
    /// <param name="securityContext">Security context for audit</param>
    /// <param name="reason">Reason for rollback (for audit trail)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task representing the async operation</returns>
    Task RollbackTransactionAsync(ClaimsPrincipal securityContext, string? reason = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Gets the current transaction if one exists
    /// </summary>
    /// <returns>Current transaction or null if none exists</returns>
    IDbTransaction? GetCurrentTransaction();
    
    /// <summary>
    /// Indicates whether a transaction is currently active
    /// </summary>
    bool HasActiveTransaction { get; }
    
    #endregion
    
    #region Change Tracking and Persistence
    
    /// <summary>
    /// Saves all pending changes to the database with security validation
    /// DoD Requirement: All changes must be validated against security policies
    /// FIPS 140-3 Compliance: Cryptographic integrity checks on sensitive data
    /// </summary>
    /// <param name="securityContext">Security context for validation and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entities successfully saved</returns>
    Task<int> SaveChangesAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Saves changes within an explicit transaction scope
    /// Provides additional control over transaction boundaries
    /// </summary>
    /// <param name="securityContext">Security context for validation and audit</param>
    /// <param name="isolationLevel">Transaction isolation level</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entities successfully saved</returns>
    Task<int> SaveChangesInTransactionAsync(ClaimsPrincipal securityContext, IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Discards all pending changes without saving
    /// Useful for implementing cancel operations or error recovery
    /// </summary>
    /// <param name="securityContext">Security context for audit logging</param>
    /// <returns>Task representing the async operation</returns>
    Task DiscardChangesAsync(ClaimsPrincipal securityContext);
    
    /// <summary>
    /// Gets the number of entities currently being tracked with pending changes
    /// Performance monitoring: High change counts may indicate batch operation needs
    /// </summary>
    /// <returns>Count of entities with pending changes</returns>
    int GetPendingChangesCount();
    
    /// <summary>
    /// Detaches entity from change tracking
    /// Performance optimization for read-heavy scenarios
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entity">Entity to detach</param>
    void DetachEntity<T>(T entity) where T : class;
    
    /// <summary>
    /// Reloads entity from database, discarding local changes
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entity">Entity to reload</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Reloaded entity</returns>
    Task<T> ReloadEntityAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class;
    
    #endregion
    
    #region Bulk Operations
    
    /// <summary>
    /// Executes bulk insert operation with security validation
    /// Performance optimization for large data sets while maintaining audit requirements
    /// DoD Requirement: Bulk operations must maintain audit trail integrity
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entities">Entities to insert</param>
    /// <param name="securityContext">Security context for validation and audit</param>
    /// <param name="batchSize">Size of batches for processing (default: 1000)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entities inserted</returns>
    Task<int> BulkInsertAsync<T>(IEnumerable<T> entities, ClaimsPrincipal securityContext, int batchSize = 1000, CancellationToken cancellationToken = default) where T : class;
    
    /// <summary>
    /// Executes bulk update operation with security validation
    /// FIPS 140-3 Compliance: Maintains integrity of cryptographic protections during bulk updates
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entities">Entities to update</param>
    /// <param name="securityContext">Security context for validation and audit</param>
    /// <param name="batchSize">Size of batches for processing</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entities updated</returns>
    Task<int> BulkUpdateAsync<T>(IEnumerable<T> entities, ClaimsPrincipal securityContext, int batchSize = 1000, CancellationToken cancellationToken = default) where T : class;
    
    /// <summary>
    /// Executes bulk delete operation with security validation
    /// DoD Requirement: Bulk deletes must be logged with detailed audit information
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entities">Entities to delete</param>
    /// <param name="securityContext">Security context for validation and audit</param>
    /// <param name="batchSize">Size of batches for processing</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entities deleted</returns>
    Task<int> BulkDeleteAsync<T>(IEnumerable<T> entities, ClaimsPrincipal securityContext, int batchSize = 1000, CancellationToken cancellationToken = default) where T : class;
    
    #endregion
    
    #region Audit and Compliance
    
    /// <summary>
    /// Validates all pending changes against security policies
    /// DoD Requirement: Pre-commit validation of all data modifications
    /// </summary>
    /// <param name="securityContext">Security context for validation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Validation result with any violations</returns>
    Task<ValidationResult> ValidatePendingChangesAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Generates comprehensive audit report for current UoW session
    /// FIPS 140-3 Compliance: Detailed audit logs for all database operations
    /// </summary>
    /// <param name="securityContext">Security context for audit report</param>
    /// <returns>Audit report containing all operations in this UoW session</returns>
    Task<AuditReport> GenerateAuditReportAsync(ClaimsPrincipal securityContext);
    
    /// <summary>
    /// Enables or disables automatic audit logging for this UoW instance
    /// Performance consideration: Can be disabled for read-only operations
    /// </summary>
    /// <param name="enabled">Whether to enable automatic audit logging</param>
    void SetAutoAuditLogging(bool enabled);
    
    /// <summary>
    /// Gets the current audit session ID for correlating related operations
    /// </summary>
    string AuditSessionId { get; }
    
    #endregion
    
    #region Performance and Monitoring
    
    /// <summary>
    /// Enables query logging for performance analysis
    /// Development/Debugging: Should be disabled in production for performance
    /// </summary>
    /// <param name="enabled">Whether to enable query logging</param>
    void EnableQueryLogging(bool enabled);
    
    /// <summary>
    /// Gets performance metrics for current UoW session
    /// Monitoring: Track database operation performance and resource usage
    /// </summary>
    /// <returns>Performance metrics object</returns>
    UnitOfWorkMetrics GetPerformanceMetrics();
    
    /// <summary>
    /// Sets timeout for database operations in this UoW
    /// DoD Requirement: Prevent long-running operations that could impact system availability
    /// </summary>
    /// <param name="timeoutSeconds">Timeout in seconds</param>
    void SetCommandTimeout(int timeoutSeconds);
    
    #endregion
}

/// <summary>
/// Validation result for pending changes
/// </summary>
public class ValidationResult
{
    /// <summary>
    /// Indicates whether validation passed
    /// </summary>
    public bool IsValid { get; set; }
    
    /// <summary>
    /// List of validation errors
    /// </summary>
    public List<string> Errors { get; set; } = new();
    
    /// <summary>
    /// List of validation warnings
    /// </summary>
    public List<string> Warnings { get; set; } = new();
    
    /// <summary>
    /// Additional validation metadata
    /// </summary>
    public Dictionary<string, object> Metadata { get; set; } = new();
}

/// <summary>
/// Audit report for UoW operations
/// </summary>
public class AuditReport
{
    /// <summary>
    /// Unique identifier for this audit report
    /// </summary>
    public string ReportId { get; init; } = Guid.NewGuid().ToString();
    
    /// <summary>
    /// Session ID correlating related operations
    /// </summary>
    public string SessionId { get; init; } = string.Empty;
    
    /// <summary>
    /// Timestamp when report was generated
    /// </summary>
    public DateTimeOffset GeneratedAt { get; init; } = DateTimeOffset.UtcNow;
    
    /// <summary>
    /// User who performed the operations
    /// </summary>
    public string UserId { get; init; } = string.Empty;
    
    /// <summary>
    /// List of all operations performed in this UoW
    /// </summary>
    public List<AuditEntry> Operations { get; init; } = new();
    
    /// <summary>
    /// Summary statistics for the UoW session
    /// </summary>
    public Dictionary<string, object> Summary { get; init; } = new();
}


/// <summary>
/// Performance metrics for UoW operations
/// </summary>
public class UnitOfWorkMetrics
{
    /// <summary>
    /// Total number of queries executed
    /// </summary>
    public int QueryCount { get; set; }
    
    /// <summary>
    /// Total execution time for all operations
    /// </summary>
    public TimeSpan TotalExecutionTime { get; set; }
    
    /// <summary>
    /// Average query execution time
    /// </summary>
    public TimeSpan AverageQueryTime { get; set; }
    
    /// <summary>
    /// Number of entities tracked by change tracking
    /// </summary>
    public int TrackedEntitiesCount { get; set; }
    
    /// <summary>
    /// Memory usage for change tracking
    /// </summary>
    public long MemoryUsageBytes { get; set; }
    
    /// <summary>
    /// Number of database round trips
    /// </summary>
    public int DatabaseRoundTrips { get; set; }
    
    /// <summary>
    /// Cache hit ratio if caching is enabled
    /// </summary>
    public double CacheHitRatio { get; set; }
    
    /// <summary>
    /// Additional performance metrics
    /// </summary>
    public Dictionary<string, object> AdditionalMetrics { get; set; } = new();
}