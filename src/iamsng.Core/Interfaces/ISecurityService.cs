using System.Linq.Expressions;
using System.Security.Claims;

namespace iamsng.Core.Interfaces;

/// <summary>
/// Service for security validation and filtering
/// Implements DoD security requirements for centralized security policy enforcement
/// Provides comprehensive access control and data protection capabilities
/// </summary>
public interface ISecurityService
{
    #region Entity Access Validation

    /// <summary>
    /// Validates entity access for the given operation and user
    /// DoD Security: Row-level security enforcement
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entity">Entity being accessed (null for type-level checks)</param>
    /// <param name="operation">Operation being performed (Read, Create, Update, Delete)</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if access is authorized</returns>
    Task<bool> ValidateEntityAccessAsync<T>(T? entity, string operation, ClaimsPrincipal securityContext) where T : class;

    /// <summary>
    /// Validates access to multiple entities in batch
    /// Performance optimization: Bulk security validation
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="entities">Entities being accessed</param>
    /// <param name="operation">Operation being performed</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>Dictionary mapping entities to authorization results</returns>
    Task<Dictionary<T, bool>> ValidateBatchEntityAccessAsync<T>(IEnumerable<T> entities, string operation, ClaimsPrincipal securityContext) where T : class;

    /// <summary>
    /// Validates access to entity type (not specific instances)
    /// Type-level security: Permission to work with entity type
    /// </summary>
    /// <param name="entityType">Type of entity</param>
    /// <param name="operation">Operation being performed</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if type-level access is authorized</returns>
    Task<bool> ValidateEntityTypeAccessAsync(Type entityType, string operation, ClaimsPrincipal securityContext);

    #endregion

    #region Query Security Filtering

    /// <summary>
    /// Applies security filters to a query based on user context
    /// DoD Requirement: Row-level security implementation
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="query">Query to filter</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>Filtered query with security predicates applied</returns>
    Task<IQueryable<T>> ApplySecurityFilterAsync<T>(IQueryable<T> query, ClaimsPrincipal securityContext) where T : class;

    /// <summary>
    /// Creates security predicate for an entity type
    /// Dynamic security: Generate runtime security filters
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="securityContext">User security context</param>
    /// <returns>Security predicate expression</returns>
    Task<Expression<Func<T, bool>>?> CreateSecurityPredicateAsync<T>(ClaimsPrincipal securityContext) where T : class;

    /// <summary>
    /// Applies data classification filtering to query
    /// DoD Security: Classification-based access control
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="query">Query to filter</param>
    /// <param name="maxClassification">Maximum classification level user can access</param>
    /// <returns>Classification-filtered query</returns>
    IQueryable<T> ApplyClassificationFilterAsync<T>(IQueryable<T> query, string maxClassification) where T : class;

    #endregion

    #region Permission Management

    /// <summary>
    /// Checks if user has specific permission
    /// Fine-grained access control: Permission-based security
    /// </summary>
    /// <param name="permission">Permission to check</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user has the permission</returns>
    Task<bool> HasPermissionAsync(string permission, ClaimsPrincipal securityContext);

    /// <summary>
    /// Checks if user has any of the specified permissions
    /// Flexible access control: Multiple permission options
    /// </summary>
    /// <param name="permissions">Permissions to check</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user has any of the permissions</returns>
    Task<bool> HasAnyPermissionAsync(IEnumerable<string> permissions, ClaimsPrincipal securityContext);

    /// <summary>
    /// Checks if user has all of the specified permissions
    /// Strict access control: All permissions required
    /// </summary>
    /// <param name="permissions">Permissions to check</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user has all of the permissions</returns>
    Task<bool> HasAllPermissionsAsync(IEnumerable<string> permissions, ClaimsPrincipal securityContext);

    /// <summary>
    /// Gets all permissions for the current user
    /// Permission discovery: List user capabilities
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <returns>List of user permissions</returns>
    Task<IEnumerable<string>> GetUserPermissionsAsync(ClaimsPrincipal securityContext);

    #endregion

    #region Role-Based Access Control

    /// <summary>
    /// Validates role-based access for an operation
    /// RBAC: Role-based authorization
    /// </summary>
    /// <param name="requiredRoles">Roles required for the operation</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user has required roles</returns>
    Task<bool> ValidateRoleAccessAsync(IEnumerable<string> requiredRoles, ClaimsPrincipal securityContext);

    /// <summary>
    /// Gets effective roles for the current user
    /// Role resolution: Including inherited and group roles
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <returns>List of effective roles</returns>
    Task<IEnumerable<string>> GetEffectiveRolesAsync(ClaimsPrincipal securityContext);

    /// <summary>
    /// Checks if user has administrative privileges
    /// Administrative access: Special privilege validation
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user is administrator</returns>
    Task<bool> IsAdministratorAsync(ClaimsPrincipal securityContext);

    #endregion

    #region Data Classification Security

    /// <summary>
    /// Validates access to classified data
    /// DoD Security: Classification-based access control
    /// </summary>
    /// <param name="dataClassification">Classification level of data</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user can access the classification level</returns>
    Task<bool> CanAccessClassificationAsync(string dataClassification, ClaimsPrincipal securityContext);

    /// <summary>
    /// Gets maximum classification level user can access
    /// Clearance validation: Highest classification access
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <returns>Maximum classification level</returns>
    Task<string> GetMaxClassificationAsync(ClaimsPrincipal securityContext);

    /// <summary>
    /// Validates compartment access
    /// DoD Security: Compartmentalized access control
    /// </summary>
    /// <param name="compartment">Compartment identifier</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if user can access the compartment</returns>
    Task<bool> CanAccessCompartmentAsync(string compartment, ClaimsPrincipal securityContext);

    /// <summary>
    /// Gets accessible compartments for user
    /// Compartment discovery: List accessible compartments
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <returns>List of accessible compartments</returns>
    Task<IEnumerable<string>> GetAccessibleCompartmentsAsync(ClaimsPrincipal securityContext);

    #endregion

    #region Resource-Level Security

    /// <summary>
    /// Validates access to a specific resource
    /// Resource security: Instance-level access control
    /// </summary>
    /// <param name="resourceType">Type of resource</param>
    /// <param name="resourceId">Resource identifier</param>
    /// <param name="operation">Operation being performed</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>True if access is authorized</returns>
    Task<bool> ValidateResourceAccessAsync(string resourceType, string resourceId, string operation, ClaimsPrincipal securityContext);

    /// <summary>
    /// Gets accessible resources of a specific type
    /// Resource discovery: List accessible resources
    /// </summary>
    /// <param name="resourceType">Type of resource</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>List of accessible resource identifiers</returns>
    Task<IEnumerable<string>> GetAccessibleResourcesAsync(string resourceType, ClaimsPrincipal securityContext);

    #endregion

    #region Security Context Validation

    /// <summary>
    /// Validates the security context for general authentication
    /// Authentication validation: Basic security checks
    /// </summary>
    /// <param name="securityContext">Security context to validate</param>
    /// <returns>True if context is valid and authenticated</returns>
    Task<bool> ValidateSecurityContextAsync(ClaimsPrincipal securityContext);

    /// <summary>
    /// Validates session expiration and security
    /// Session security: Timeout and security validation
    /// </summary>
    /// <param name="securityContext">Security context to validate</param>
    /// <returns>True if session is valid</returns>
    Task<bool> ValidateSessionSecurityAsync(ClaimsPrincipal securityContext);

    /// <summary>
    /// Gets security clearance level for user
    /// Clearance validation: User security clearance
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <returns>Security clearance level</returns>
    Task<string?> GetSecurityClearanceAsync(ClaimsPrincipal securityContext);

    #endregion

    #region Audit and Monitoring

    /// <summary>
    /// Logs security validation events
    /// Security audit: Track access control decisions
    /// </summary>
    /// <param name="operation">Operation being validated</param>
    /// <param name="resource">Resource being accessed</param>
    /// <param name="securityContext">User security context</param>
    /// <param name="authorized">Whether access was authorized</param>
    /// <param name="reason">Reason for decision</param>
    /// <returns>Task representing the async operation</returns>
    Task LogSecurityEventAsync(string operation, string? resource, ClaimsPrincipal securityContext, bool authorized, string? reason = null);

    /// <summary>
    /// Detects potential security violations
    /// Security monitoring: Automated threat detection
    /// </summary>
    /// <param name="securityContext">User security context</param>
    /// <param name="operation">Operation being performed</param>
    /// <param name="resource">Resource being accessed</param>
    /// <returns>Security violation alerts</returns>
    Task<IEnumerable<SecurityAlert>> DetectSecurityViolationsAsync(ClaimsPrincipal securityContext, string operation, string? resource = null);

    #endregion

    #region Policy Management

    /// <summary>
    /// Evaluates security policies for an operation
    /// Policy engine: Dynamic security policy evaluation
    /// </summary>
    /// <param name="policyContext">Policy evaluation context</param>
    /// <returns>Policy evaluation result</returns>
    Task<PolicyEvaluationResult> EvaluateSecurityPolicyAsync(PolicyEvaluationContext policyContext);

    /// <summary>
    /// Gets applicable security policies for a context
    /// Policy discovery: Find relevant security policies
    /// </summary>
    /// <param name="resourceType">Type of resource</param>
    /// <param name="operation">Operation being performed</param>
    /// <param name="securityContext">User security context</param>
    /// <returns>List of applicable security policies</returns>
    Task<IEnumerable<SecurityPolicy>> GetApplicablePoliciesAsync(string resourceType, string operation, ClaimsPrincipal securityContext);

    #endregion
}

/// <summary>
/// Security alert information
/// </summary>
public class SecurityAlert
{
    /// <summary>
    /// Alert identifier
    /// </summary>
    public string Id { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Alert type
    /// </summary>
    public string AlertType { get; set; } = string.Empty;

    /// <summary>
    /// Severity level
    /// </summary>
    public SecurityAlertSeverity Severity { get; set; } = SecurityAlertSeverity.Low;

    /// <summary>
    /// Alert message
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// User associated with the alert
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Resource associated with the alert
    /// </summary>
    public string? Resource { get; set; }

    /// <summary>
    /// Alert timestamp
    /// </summary>
    public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Additional alert details
    /// </summary>
    public Dictionary<string, object> Details { get; set; } = new();
}

/// <summary>
/// Security alert severity levels
/// </summary>
public enum SecurityAlertSeverity
{
    /// <summary>
    /// Low severity - informational
    /// </summary>
    Low = 0,

    /// <summary>
    /// Medium severity - warning
    /// </summary>
    Medium = 1,

    /// <summary>
    /// High severity - error
    /// </summary>
    High = 2,

    /// <summary>
    /// Critical severity - security breach
    /// </summary>
    Critical = 3
}

/// <summary>
/// Policy evaluation context
/// </summary>
public class PolicyEvaluationContext
{
    /// <summary>
    /// User security context
    /// </summary>
    public ClaimsPrincipal SecurityContext { get; set; } = new();

    /// <summary>
    /// Resource being accessed
    /// </summary>
    public string? Resource { get; set; }

    /// <summary>
    /// Resource type
    /// </summary>
    public string ResourceType { get; set; } = string.Empty;

    /// <summary>
    /// Operation being performed
    /// </summary>
    public string Operation { get; set; } = string.Empty;

    /// <summary>
    /// Additional context data
    /// </summary>
    public Dictionary<string, object> ContextData { get; set; } = new();

    /// <summary>
    /// Request timestamp
    /// </summary>
    public DateTimeOffset RequestTime { get; set; } = DateTimeOffset.UtcNow;
}

/// <summary>
/// Policy evaluation result
/// </summary>
public class PolicyEvaluationResult
{
    /// <summary>
    /// Whether access is authorized
    /// </summary>
    public bool IsAuthorized { get; set; }

    /// <summary>
    /// Reason for the decision
    /// </summary>
    public string Reason { get; set; } = string.Empty;

    /// <summary>
    /// Evaluated policies
    /// </summary>
    public List<string> EvaluatedPolicies { get; set; } = new();

    /// <summary>
    /// Policy violations found
    /// </summary>
    public List<PolicyViolation> Violations { get; set; } = new();

    /// <summary>
    /// Additional evaluation details
    /// </summary>
    public Dictionary<string, object> Details { get; set; } = new();
}

/// <summary>
/// Policy violation information
/// </summary>
public class PolicyViolation
{
    /// <summary>
    /// Policy identifier
    /// </summary>
    public string PolicyId { get; set; } = string.Empty;

    /// <summary>
    /// Violation type
    /// </summary>
    public string ViolationType { get; set; } = string.Empty;

    /// <summary>
    /// Violation description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Severity of the violation
    /// </summary>
    public string Severity { get; set; } = string.Empty;
}

/// <summary>
/// Security policy definition
/// </summary>
public class SecurityPolicy
{
    /// <summary>
    /// Policy identifier
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Policy name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Policy description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Policy rules
    /// </summary>
    public List<SecurityPolicyRule> Rules { get; set; } = new();

    /// <summary>
    /// Policy priority
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Whether policy is enabled
    /// </summary>
    public bool IsEnabled { get; set; } = true;
}

/// <summary>
/// Security policy rule
/// </summary>
public class SecurityPolicyRule
{
    /// <summary>
    /// Rule identifier
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Rule condition
    /// </summary>
    public string Condition { get; set; } = string.Empty;

    /// <summary>
    /// Rule action (Allow, Deny, etc.)
    /// </summary>
    public string Action { get; set; } = string.Empty;

    /// <summary>
    /// Rule description
    /// </summary>
    public string Description { get; set; } = string.Empty;
}