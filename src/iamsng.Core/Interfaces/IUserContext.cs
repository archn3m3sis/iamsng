using System.Security.Claims;

namespace iamsng.Core.Interfaces;

/// <summary>
/// Interface for managing user security context throughout the application
/// Provides secure access to user identity and claims information
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// </summary>
public interface IUserContext
{
    #region User Identity

    /// <summary>
    /// Gets the current user's claims principal
    /// DoD Requirement: All operations must be performed within authenticated context
    /// </summary>
    ClaimsPrincipal? CurrentUser { get; }

    /// <summary>
    /// Gets the current user's unique identifier
    /// FIPS 140-3 Compliance: Secure user identification
    /// </summary>
    string? UserId { get; }

    /// <summary>
    /// Gets the current user's username/login name
    /// </summary>
    string? UserName { get; }

    /// <summary>
    /// Gets the current user's email address
    /// </summary>
    string? Email { get; }

    /// <summary>
    /// Gets the current user's display name
    /// </summary>
    string? DisplayName { get; }

    /// <summary>
    /// Indicates whether the current user is authenticated
    /// DoD Security: Authentication validation for all operations
    /// </summary>
    bool IsAuthenticated { get; }

    #endregion

    #region Security Context

    /// <summary>
    /// Gets the current user's security clearance level
    /// DoD Requirement: Security clearance-based access control
    /// </summary>
    string? SecurityClearance { get; }

    /// <summary>
    /// Gets the current user's organizational unit
    /// DoD Requirement: Organizational-based access control
    /// </summary>
    string? OrganizationalUnit { get; }

    /// <summary>
    /// Gets the current user's roles
    /// Role-based access control (RBAC) implementation
    /// </summary>
    IEnumerable<string> Roles { get; }

    /// <summary>
    /// Gets the current user's permissions
    /// Fine-grained permission-based access control
    /// </summary>
    IEnumerable<string> Permissions { get; }

    /// <summary>
    /// Gets the current session identifier
    /// FIPS 140-3 Compliance: Session tracking for audit purposes
    /// </summary>
    string? SessionId { get; }

    /// <summary>
    /// Gets the time when the current session was established
    /// DoD Security: Session timeout and monitoring
    /// </summary>
    DateTimeOffset? SessionStartTime { get; }

    /// <summary>
    /// Gets the IP address of the current session
    /// DoD Security: Network-based access monitoring
    /// </summary>
    string? IpAddress { get; }

    /// <summary>
    /// Gets the user agent string of the current session
    /// Security monitoring: Client application identification
    /// </summary>
    string? UserAgent { get; }

    #endregion

    #region Session Management

    /// <summary>
    /// Checks if the current session is valid and not expired
    /// DoD Security: Automatic session timeout enforcement
    /// </summary>
    /// <returns>True if session is valid</returns>
    bool IsSessionValid();

    /// <summary>
    /// Gets the remaining time before session expires
    /// </summary>
    /// <returns>Time remaining until session expiration</returns>
    TimeSpan? GetSessionTimeRemaining();

    /// <summary>
    /// Refreshes the current session, extending its validity
    /// DoD Security: Controlled session extension
    /// </summary>
    /// <returns>Task representing the async operation</returns>
    Task RefreshSessionAsync();

    /// <summary>
    /// Invalidates the current session
    /// Security operation: Forced session termination
    /// </summary>
    /// <returns>Task representing the async operation</returns>
    Task InvalidateSessionAsync();

    #endregion

    #region Authorization

    /// <summary>
    /// Checks if the current user has the specified role
    /// DoD Security: Role-based access validation
    /// </summary>
    /// <param name="role">Role to check</param>
    /// <returns>True if user has the role</returns>
    bool IsInRole(string role);

    /// <summary>
    /// Checks if the current user has any of the specified roles
    /// </summary>
    /// <param name="roles">Roles to check</param>
    /// <returns>True if user has any of the roles</returns>
    bool IsInAnyRole(params string[] roles);

    /// <summary>
    /// Checks if the current user has all of the specified roles
    /// </summary>
    /// <param name="roles">Roles to check</param>
    /// <returns>True if user has all of the roles</returns>
    bool IsInAllRoles(params string[] roles);

    /// <summary>
    /// Checks if the current user has the specified permission
    /// DoD Security: Fine-grained permission validation
    /// </summary>
    /// <param name="permission">Permission to check</param>
    /// <returns>True if user has the permission</returns>
    bool HasPermission(string permission);

    /// <summary>
    /// Checks if the current user has any of the specified permissions
    /// </summary>
    /// <param name="permissions">Permissions to check</param>
    /// <returns>True if user has any of the permissions</returns>
    bool HasAnyPermission(params string[] permissions);

    /// <summary>
    /// Checks if the current user has all of the specified permissions
    /// </summary>
    /// <param name="permissions">Permissions to check</param>
    /// <returns>True if user has all of the permissions</returns>
    bool HasAllPermissions(params string[] permissions);

    /// <summary>
    /// Validates access to a specific resource based on user context
    /// DoD Security: Resource-level access control
    /// </summary>
    /// <param name="resourceType">Type of resource being accessed</param>
    /// <param name="resourceId">Identifier of the specific resource</param>
    /// <param name="operation">Operation being performed (Read, Write, Delete, etc.)</param>
    /// <returns>Task with boolean result indicating if access is authorized</returns>
    Task<bool> CanAccessResourceAsync(string resourceType, string? resourceId, string operation);

    #endregion

    #region Audit and Compliance

    /// <summary>
    /// Gets claims for audit logging purposes
    /// FIPS 140-3 Compliance: Complete audit trail of user actions
    /// </summary>
    /// <returns>Dictionary of claims for audit logging</returns>
    Dictionary<string, string> GetAuditClaims();

    /// <summary>
    /// Creates an audit context for the current user and operation
    /// DoD Requirement: All operations must be auditable
    /// </summary>
    /// <param name="operation">Operation being performed</param>
    /// <param name="resource">Resource being accessed</param>
    /// <returns>Audit context information</returns>
    AuditContext CreateAuditContext(string operation, string? resource = null);

    /// <summary>
    /// Logs a security event for the current user
    /// DoD Security: Security event monitoring and alerting
    /// </summary>
    /// <param name="eventType">Type of security event</param>
    /// <param name="description">Event description</param>
    /// <param name="severity">Event severity level</param>
    /// <returns>Task representing the async operation</returns>
    Task LogSecurityEventAsync(string eventType, string description, SecurityEventSeverity severity = SecurityEventSeverity.Information);

    #endregion

    #region Data Classification

    /// <summary>
    /// Gets the maximum data classification level the user can access
    /// DoD Requirement: Data classification-based access control
    /// </summary>
    string? MaxDataClassification { get; }

    /// <summary>
    /// Checks if the user can access data with the specified classification
    /// FIPS 140-3 Compliance: Classification-based data protection
    /// </summary>
    /// <param name="classification">Data classification level</param>
    /// <returns>True if user can access the classified data</returns>
    bool CanAccessClassification(string classification);

    /// <summary>
    /// Gets the compartments the user has access to
    /// DoD Security: Compartmentalized access control
    /// </summary>
    IEnumerable<string> AccessibleCompartments { get; }

    /// <summary>
    /// Checks if the user can access a specific compartment
    /// </summary>
    /// <param name="compartment">Compartment identifier</param>
    /// <returns>True if user can access the compartment</returns>
    bool CanAccessCompartment(string compartment);

    #endregion
}

/// <summary>
/// Audit context information for tracking user operations
/// FIPS 140-3 Compliance: Comprehensive audit data structure
/// </summary>
public class AuditContext
{
    /// <summary>
    /// Unique identifier for the audit context
    /// </summary>
    public string Id { get; init; } = Guid.NewGuid().ToString();

    /// <summary>
    /// User identifier
    /// </summary>
    public string UserId { get; init; } = string.Empty;

    /// <summary>
    /// Session identifier
    /// </summary>
    public string SessionId { get; init; } = string.Empty;

    /// <summary>
    /// Operation being performed
    /// </summary>
    public string Operation { get; init; } = string.Empty;

    /// <summary>
    /// Resource being accessed
    /// </summary>
    public string? Resource { get; init; }

    /// <summary>
    /// Timestamp of the operation
    /// </summary>
    public DateTimeOffset Timestamp { get; init; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// IP address of the user
    /// </summary>
    public string? IpAddress { get; init; }

    /// <summary>
    /// User agent information
    /// </summary>
    public string? UserAgent { get; init; }

    /// <summary>
    /// Additional context information
    /// </summary>
    public Dictionary<string, object> AdditionalData { get; init; } = new();
}

/// <summary>
/// Security event severity levels
/// DoD Classification: Security event categorization
/// </summary>
public enum SecurityEventSeverity
{
    /// <summary>
    /// Informational event - normal operation
    /// </summary>
    Information = 0,

    /// <summary>
    /// Warning event - potential security concern
    /// </summary>
    Warning = 1,

    /// <summary>
    /// Error event - security violation or failure
    /// </summary>
    Error = 2,

    /// <summary>
    /// Critical event - serious security breach
    /// </summary>
    Critical = 3,

    /// <summary>
    /// Fatal event - system compromise
    /// </summary>
    Fatal = 4
}