using iamsng.Core.Entities;

namespace iamsng.Core.Interfaces;

/// <summary>
/// Service for audit logging operations
/// Compliant with FIPS 140-3 standards for centralized audit logging with tamper protection
/// Provides comprehensive audit trail functionality for DoD compliance
/// </summary>
public interface IAuditService
{
    #region Core Audit Operations

    /// <summary>
    /// Logs an audit entry asynchronously
    /// DoD Requirement: All operations must be audited with tamper-evident logs
    /// </summary>
    /// <param name="auditEntry">Audit entry to log</param>
    /// <returns>Task representing the async operation</returns>
    Task LogAsync(AuditEntry auditEntry);

    /// <summary>
    /// Logs multiple audit entries in a batch operation
    /// Performance optimization: Bulk audit logging for high-volume operations
    /// </summary>
    /// <param name="auditEntries">Collection of audit entries to log</param>
    /// <returns>Task representing the async operation</returns>
    Task LogBatchAsync(IEnumerable<AuditEntry> auditEntries);

    /// <summary>
    /// Retrieves audit entries based on search criteria
    /// DoD Security: Controlled access to audit logs for forensic analysis
    /// </summary>
    /// <param name="searchCriteria">Search criteria for audit entries</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Matching audit entries</returns>
    Task<IEnumerable<AuditEntry>> SearchAsync(AuditSearchCriteria searchCriteria, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets audit entries for a specific entity
    /// Audit trail: Complete history of entity operations
    /// </summary>
    /// <param name="entityType">Type of entity</param>
    /// <param name="entityId">Entity identifier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Audit entries for the entity</returns>
    Task<IEnumerable<AuditEntry>> GetEntityAuditTrailAsync(string entityType, string entityId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets audit entries for a specific user
    /// User activity: Track all operations performed by a user
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <param name="startDate">Start date for search</param>
    /// <param name="endDate">End date for search</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Audit entries for the user</returns>
    Task<IEnumerable<AuditEntry>> GetUserAuditTrailAsync(string userId, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets audit entries for a specific session
    /// Session tracking: All operations within a session
    /// </summary>
    /// <param name="sessionId">Session identifier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Audit entries for the session</returns>
    Task<IEnumerable<AuditEntry>> GetSessionAuditTrailAsync(string sessionId, CancellationToken cancellationToken = default);

    #endregion

    #region Audit Integrity

    /// <summary>
    /// Validates the integrity of audit entries
    /// FIPS 140-3 Compliance: Cryptographic verification of audit log integrity
    /// </summary>
    /// <param name="auditEntries">Audit entries to validate</param>
    /// <returns>Validation results</returns>
    Task<AuditIntegrityResult> ValidateIntegrityAsync(IEnumerable<AuditEntry> auditEntries);

    /// <summary>
    /// Validates the integrity of a specific audit entry
    /// Tamper detection: Individual entry verification
    /// </summary>
    /// <param name="auditEntry">Audit entry to validate</param>
    /// <returns>True if integrity is intact</returns>
    Task<bool> ValidateEntryIntegrityAsync(AuditEntry auditEntry);

    /// <summary>
    /// Creates a cryptographic hash chain for audit entries
    /// DoD Security: Tamper-evident audit log chains
    /// </summary>
    /// <param name="entries">Audit entries to chain</param>
    /// <returns>Hash chain for the entries</returns>
    Task<string> CreateAuditHashChainAsync(IEnumerable<AuditEntry> entries);

    #endregion

    #region Reporting and Analytics

    /// <summary>
    /// Generates audit reports based on specified criteria
    /// DoD Compliance: Standardized audit reporting
    /// </summary>
    /// <param name="reportCriteria">Report generation criteria</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generated audit report</returns>
    Task<AuditReport> GenerateReportAsync(AuditReportCriteria reportCriteria, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets audit statistics for a specific time period
    /// Analytics: Audit activity analysis
    /// </summary>
    /// <param name="startDate">Start date for statistics</param>
    /// <param name="endDate">End date for statistics</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Audit statistics</returns>
    Task<AuditStatistics> GetAuditStatisticsAsync(DateTimeOffset startDate, DateTimeOffset endDate, CancellationToken cancellationToken = default);

    #endregion

    #region Data Retention

    /// <summary>
    /// Archives old audit entries based on retention policy
    /// DoD Compliance: Automated data retention management
    /// </summary>
    /// <param name="retentionPolicyId">Retention policy identifier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entries archived</returns>
    Task<int> ArchiveAuditEntriesAsync(string retentionPolicyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Purges expired audit entries based on retention policy
    /// Data lifecycle: Automated cleanup of expired audit data
    /// </summary>
    /// <param name="retentionPolicyId">Retention policy identifier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entries purged</returns>
    Task<int> PurgeExpiredAuditEntriesAsync(string retentionPolicyId, CancellationToken cancellationToken = default);

    #endregion

    #region Security Monitoring

    /// <summary>
    /// Detects suspicious patterns in audit logs
    /// DoD Security: Automated threat detection
    /// </summary>
    /// <param name="detectionCriteria">Pattern detection criteria</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Detected suspicious activities</returns>
    Task<IEnumerable<SuspiciousActivity>> DetectSuspiciousActivityAsync(PatternDetectionCriteria detectionCriteria, CancellationToken cancellationToken = default);

    /// <summary>
    /// Monitors for failed operations and security violations
    /// Security alerting: Real-time security event monitoring
    /// </summary>
    /// <param name="monitoringCriteria">Monitoring criteria</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Security violations detected</returns>
    Task<IEnumerable<SecurityViolation>> MonitorSecurityViolationsAsync(SecurityMonitoringCriteria monitoringCriteria, CancellationToken cancellationToken = default);

    #endregion
}

/// <summary>
/// Search criteria for audit entries
/// </summary>
public class AuditSearchCriteria
{
    /// <summary>
    /// Start date for search
    /// </summary>
    public DateTimeOffset? StartDate { get; set; }

    /// <summary>
    /// End date for search
    /// </summary>
    public DateTimeOffset? EndDate { get; set; }

    /// <summary>
    /// User identifier filter
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// Entity type filter
    /// </summary>
    public string? EntityType { get; set; }

    /// <summary>
    /// Operation type filter
    /// </summary>
    public string? Operation { get; set; }

    /// <summary>
    /// Session identifier filter
    /// </summary>
    public string? SessionId { get; set; }

    /// <summary>
    /// Result filter (Success, Failed, etc.)
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// IP address filter
    /// </summary>
    public string? IpAddress { get; set; }

    /// <summary>
    /// Page number for pagination
    /// </summary>
    public int PageNumber { get; set; } = 1;

    /// <summary>
    /// Page size for pagination
    /// </summary>
    public int PageSize { get; set; } = 50;
}

/// <summary>
/// Audit integrity validation result
/// </summary>
public class AuditIntegrityResult
{
    /// <summary>
    /// Overall integrity status
    /// </summary>
    public bool IsValid { get; set; }

    /// <summary>
    /// Number of entries validated
    /// </summary>
    public int TotalEntries { get; set; }

    /// <summary>
    /// Number of valid entries
    /// </summary>
    public int ValidEntries { get; set; }

    /// <summary>
    /// Number of tampered entries
    /// </summary>
    public int TamperedEntries { get; set; }

    /// <summary>
    /// Details of validation failures
    /// </summary>
    public List<AuditIntegrityViolation> Violations { get; set; } = new();
}

/// <summary>
/// Audit integrity violation details
/// </summary>
public class AuditIntegrityViolation
{
    /// <summary>
    /// Audit entry ID with violation
    /// </summary>
    public string EntryId { get; set; } = string.Empty;

    /// <summary>
    /// Type of violation
    /// </summary>
    public string ViolationType { get; set; } = string.Empty;

    /// <summary>
    /// Description of the violation
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Timestamp when violation was detected
    /// </summary>
    public DateTimeOffset DetectedAt { get; set; } = DateTimeOffset.UtcNow;
}

/// <summary>
/// Audit report generation criteria
/// </summary>
public class AuditReportCriteria
{
    /// <summary>
    /// Report type
    /// </summary>
    public string ReportType { get; set; } = string.Empty;

    /// <summary>
    /// Start date for report
    /// </summary>
    public DateTimeOffset StartDate { get; set; }

    /// <summary>
    /// End date for report
    /// </summary>
    public DateTimeOffset EndDate { get; set; }

    /// <summary>
    /// Filters to apply
    /// </summary>
    public Dictionary<string, object> Filters { get; set; } = new();

    /// <summary>
    /// Output format
    /// </summary>
    public string OutputFormat { get; set; } = "JSON";
}

/// <summary>
/// Audit statistics
/// </summary>
public class AuditStatistics
{
    /// <summary>
    /// Total number of audit entries
    /// </summary>
    public long TotalEntries { get; set; }

    /// <summary>
    /// Breakdown by operation type
    /// </summary>
    public Dictionary<string, long> OperationBreakdown { get; set; } = new();

    /// <summary>
    /// Breakdown by result type
    /// </summary>
    public Dictionary<string, long> ResultBreakdown { get; set; } = new();

    /// <summary>
    /// Top users by activity
    /// </summary>
    public Dictionary<string, long> TopUsers { get; set; } = new();

    /// <summary>
    /// Activity by hour of day
    /// </summary>
    public Dictionary<int, long> HourlyActivity { get; set; } = new();
}

/// <summary>
/// Suspicious activity detection result
/// </summary>
public class SuspiciousActivity
{
    /// <summary>
    /// Activity identifier
    /// </summary>
    public string Id { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Type of suspicious activity
    /// </summary>
    public string ActivityType { get; set; } = string.Empty;

    /// <summary>
    /// Description of the activity
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Severity level
    /// </summary>
    public string Severity { get; set; } = string.Empty;

    /// <summary>
    /// Related audit entries
    /// </summary>
    public List<string> RelatedEntryIds { get; set; } = new();

    /// <summary>
    /// Detection timestamp
    /// </summary>
    public DateTimeOffset DetectedAt { get; set; } = DateTimeOffset.UtcNow;
}

/// <summary>
/// Security violation detection result
/// </summary>
public class SecurityViolation
{
    /// <summary>
    /// Violation identifier
    /// </summary>
    public string Id { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Type of security violation
    /// </summary>
    public string ViolationType { get; set; } = string.Empty;

    /// <summary>
    /// Description of the violation
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Severity level
    /// </summary>
    public string Severity { get; set; } = string.Empty;

    /// <summary>
    /// User involved in the violation
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Detection timestamp
    /// </summary>
    public DateTimeOffset DetectedAt { get; set; } = DateTimeOffset.UtcNow;
}

/// <summary>
/// Pattern detection criteria
/// </summary>
public class PatternDetectionCriteria
{
    /// <summary>
    /// Pattern types to detect
    /// </summary>
    public List<string> PatternTypes { get; set; } = new();

    /// <summary>
    /// Time window for pattern detection
    /// </summary>
    public TimeSpan TimeWindow { get; set; } = TimeSpan.FromHours(1);

    /// <summary>
    /// Threshold values for detection
    /// </summary>
    public Dictionary<string, object> Thresholds { get; set; } = new();
}

/// <summary>
/// Security monitoring criteria
/// </summary>
public class SecurityMonitoringCriteria
{
    /// <summary>
    /// Monitoring rules to apply
    /// </summary>
    public List<string> MonitoringRules { get; set; } = new();

    /// <summary>
    /// Real-time monitoring flag
    /// </summary>
    public bool RealTimeMonitoring { get; set; } = true;

    /// <summary>
    /// Alert thresholds
    /// </summary>
    public Dictionary<string, object> AlertThresholds { get; set; } = new();
}