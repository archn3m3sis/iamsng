using System.Linq.Expressions;
using System.Security.Claims;

namespace iamsng.Core.Interfaces;

/// <summary>
/// Generic repository interface implementing Repository pattern
/// Provides secure data access with built-in security context validation
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// </summary>
/// <typeparam name="T">Entity type that must implement IEntity</typeparam>
public interface IRepository<T> where T : class
{
    #region Query Operations
    
    /// <summary>
    /// Retrieves all entities with security context validation
    /// </summary>
    /// <param name="securityContext">Security context containing user claims for authorization</param>
    /// <param name="cancellationToken">Cancellation token for async operation</param>
    /// <returns>Queryable collection of entities user is authorized to access</returns>
    Task<IQueryable<T>> GetAllAsync(ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Retrieves entity by ID with security validation
    /// FIPS 140-3 compliant: All data access is logged and audited
    /// </summary>
    /// <param name="id">Entity identifier</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Entity if found and user is authorized, null otherwise</returns>
    Task<T?> GetByIdAsync(object id, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Finds entities matching the specified predicate with security filtering
    /// </summary>
    /// <param name="predicate">Filter expression</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Entities matching predicate that user is authorized to access</returns>
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Retrieves single entity matching predicate with security validation
    /// </summary>
    /// <param name="predicate">Filter expression</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Single entity or null if not found/authorized</returns>
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Checks if any entity exists matching the predicate with security context
    /// </summary>
    /// <param name="predicate">Filter expression</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if any matching entity exists and user is authorized</returns>
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Gets count of entities matching predicate with security filtering
    /// </summary>
    /// <param name="predicate">Filter expression</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Count of authorized entities matching predicate</returns>
    Task<int> CountAsync(Expression<Func<T, bool>> predicate, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    #endregion
    
    #region Specification Pattern Support
    
    /// <summary>
    /// Retrieves entities using specification pattern with security context
    /// Specifications encapsulate business rules and query logic
    /// </summary>
    /// <param name="specification">Specification containing query logic</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Entities matching specification that user is authorized to access</returns>
    Task<IEnumerable<T>> GetBySpecificationAsync(ISpecification<T> specification, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Gets count of entities matching specification with security filtering
    /// </summary>
    /// <param name="specification">Specification containing query logic</param>
    /// <param name="securityContext">Security context for authorization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Count of authorized entities matching specification</returns>
    Task<int> CountBySpecificationAsync(ISpecification<T> specification, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    #endregion
    
    #region Modification Operations
    
    /// <summary>
    /// Adds new entity with security validation and audit logging
    /// DoD Requirement: All data modifications must be logged and audited
    /// </summary>
    /// <param name="entity">Entity to add</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Added entity with generated ID</returns>
    Task<T> AddAsync(T entity, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Adds multiple entities with security validation and batch audit logging
    /// FIPS 140-3 Compliant: Bulk operations maintain audit trail integrity
    /// </summary>
    /// <param name="entities">Entities to add</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Added entities with generated IDs</returns>
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Updates existing entity with security validation and audit logging
    /// DoD Requirement: Maintains complete audit trail of all changes
    /// </summary>
    /// <param name="entity">Entity to update</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated entity</returns>
    Task<T> UpdateAsync(T entity, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Updates multiple entities with security validation and batch audit logging
    /// </summary>
    /// <param name="entities">Entities to update</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated entities</returns>
    Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Removes entity with security validation and audit logging
    /// DoD Requirement: Soft delete with audit trail preferred for compliance
    /// </summary>
    /// <param name="entity">Entity to remove</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task representing the async operation</returns>
    Task RemoveAsync(T entity, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Removes entity by ID with security validation and audit logging
    /// </summary>
    /// <param name="id">ID of entity to remove</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task representing the async operation</returns>
    Task RemoveByIdAsync(object id, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Removes multiple entities with security validation and batch audit logging
    /// </summary>
    /// <param name="entities">Entities to remove</param>
    /// <param name="securityContext">Security context for authorization and audit</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task representing the async operation</returns>
    Task RemoveRangeAsync(IEnumerable<T> entities, ClaimsPrincipal securityContext, CancellationToken cancellationToken = default);
    
    #endregion
    
    #region Audit and Compliance
    
    /// <summary>
    /// Validates security context for entity access
    /// DoD Requirement: All data access must be authorized and logged
    /// </summary>
    /// <param name="entity">Entity being accessed</param>
    /// <param name="operation">Type of operation (Read, Write, Delete)</param>
    /// <param name="securityContext">Security context to validate</param>
    /// <returns>True if operation is authorized</returns>
    Task<bool> ValidateSecurityContextAsync(T entity, string operation, ClaimsPrincipal securityContext);
    
    /// <summary>
    /// Logs audit entry for data access or modification
    /// FIPS 140-3 Compliance: All operations must be audited with tamper-evident logs
    /// </summary>
    /// <param name="entity">Entity being accessed</param>
    /// <param name="operation">Operation performed</param>
    /// <param name="securityContext">Security context</param>
    /// <param name="additionalData">Additional audit data</param>
    /// <returns>Task representing the async operation</returns>
    Task LogAuditEntryAsync(T entity, string operation, ClaimsPrincipal securityContext, object? additionalData = null);
    
    #endregion
}

/// <summary>
/// Specification interface for implementing Specification pattern
/// Encapsulates query logic and business rules for reusable, testable queries
/// </summary>
/// <typeparam name="T">Entity type</typeparam>
public interface ISpecification<T>
{
    /// <summary>
    /// Primary criteria for the specification
    /// </summary>
    Expression<Func<T, bool>>? Criteria { get; }
    
    /// <summary>
    /// Include expressions for eager loading
    /// </summary>
    List<Expression<Func<T, object>>> Includes { get; }
    
    /// <summary>
    /// Include string expressions for eager loading
    /// </summary>
    List<string> IncludeStrings { get; }
    
    /// <summary>
    /// Order by expressions
    /// </summary>
    Expression<Func<T, object>>? OrderBy { get; }
    
    /// <summary>
    /// Order by descending expressions
    /// </summary>
    Expression<Func<T, object>>? OrderByDescending { get; }
    
    /// <summary>
    /// Group by expression
    /// </summary>
    Expression<Func<T, object>>? GroupBy { get; }
    
    /// <summary>
    /// Number of records to take (for paging)
    /// </summary>
    int Take { get; }
    
    /// <summary>
    /// Number of records to skip (for paging)
    /// </summary>
    int Skip { get; }
    
    /// <summary>
    /// Whether paging is enabled
    /// </summary>
    bool IsPagingEnabled { get; }
    
    /// <summary>
    /// Whether to track changes (for read-only scenarios)
    /// Performance optimization: Disable tracking for read-only operations
    /// </summary>
    bool AsNoTracking { get; }
    
    /// <summary>
    /// Security predicate to apply based on user context
    /// DoD Requirement: Row-level security implementation
    /// </summary>
    Expression<Func<T, ClaimsPrincipal, bool>>? SecurityPredicate { get; }
}