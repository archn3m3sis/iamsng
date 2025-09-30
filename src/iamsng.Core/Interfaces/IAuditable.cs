namespace iamsng.Core.Interfaces;

/// <summary>
/// Interface for entities that support comprehensive audit tracking
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// Provides automatic audit trail for all data modifications
/// </summary>
public interface IAuditable
{
    #region Creation Audit

    /// <summary>
    /// Timestamp when the entity was created
    /// DoD Requirement: All data creation must be timestamped with UTC precision
    /// </summary>
    DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// User who created the entity
    /// DoD Requirement: All data modifications must be attributed to a user
    /// </summary>
    string CreatedBy { get; set; }

    /// <summary>
    /// IP address from which the entity was created
    /// DoD Security: Track origin of all data creation operations
    /// </summary>
    string? CreatedFromIp { get; set; }

    /// <summary>
    /// Application or service that created the entity
    /// Security monitoring: Track source applications
    /// </summary>
    string? CreatedByApplication { get; set; }

    #endregion

    #region Modification Audit

    /// <summary>
    /// Timestamp when the entity was last updated
    /// FIPS 140-3 Compliance: Track all modifications with precise timing
    /// </summary>
    DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// User who last updated the entity
    /// DoD Requirement: Attribution of all data modifications
    /// </summary>
    string UpdatedBy { get; set; }

    /// <summary>
    /// IP address from which the entity was last updated
    /// DoD Security: Track origin of all modification operations
    /// </summary>
    string? UpdatedFromIp { get; set; }

    /// <summary>
    /// Application or service that last updated the entity
    /// Security monitoring: Track modifying applications
    /// </summary>
    string? UpdatedByApplication { get; set; }

    /// <summary>
    /// Number of times this entity has been modified
    /// Audit trail: Track modification frequency
    /// </summary>
    int ModificationCount { get; set; }

    #endregion

    #region Concurrency Control

    /// <summary>
    /// Row version for optimistic concurrency control
    /// DoD Security: Prevent lost update scenarios in multi-user environments
    /// </summary>
    byte[]? RowVersion { get; set; }

    /// <summary>
    /// ETag for HTTP-based concurrency control
    /// Web API security: Prevent concurrent modification conflicts
    /// </summary>
    string? ETag { get; set; }

    #endregion

    #region Data Classification

    /// <summary>
    /// Security classification of the entity data
    /// DoD Requirement: All data must have appropriate classification markings
    /// </summary>
    string DataClassification { get; set; }

    /// <summary>
    /// Compartment or special access program markings
    /// DoD Security: Compartmentalized access control
    /// </summary>
    string? CompartmentMarkings { get; set; }

    /// <summary>
    /// Handling caveats and special instructions
    /// DoD Compliance: Proper data handling requirements
    /// </summary>
    string? HandlingCaveats { get; set; }

    #endregion

    #region Retention and Lifecycle

    /// <summary>
    /// Data retention period in years
    /// DoD Compliance: Configurable data retention policies
    /// </summary>
    int RetentionYears { get; set; }

    /// <summary>
    /// Indicates if the entity is eligible for archival
    /// Data lifecycle management
    /// </summary>
    bool IsArchivalEligible { get; set; }

    /// <summary>
    /// Timestamp when the entity should be reviewed for retention
    /// DoD Requirement: Periodic data review and disposition
    /// </summary>
    DateTimeOffset? RetentionReviewDate { get; set; }

    #endregion

    #region Digital Signature

    /// <summary>
    /// Digital signature of the entity for integrity verification
    /// FIPS 140-3 Compliance: Cryptographic data integrity protection
    /// </summary>
    string? DigitalSignature { get; set; }

    /// <summary>
    /// Certificate thumbprint used for digital signature
    /// PKI integration: Track signing certificates
    /// </summary>
    string? SigningCertificateThumbprint { get; set; }

    /// <summary>
    /// Timestamp when the digital signature was applied
    /// Audit trail: Track when data integrity was established
    /// </summary>
    DateTimeOffset? SignedAt { get; set; }

    #endregion
}

/// <summary>
/// Extended auditable interface with additional security features
/// Enhanced audit capabilities for high-security environments
/// </summary>
public interface IExtendedAuditable : IAuditable
{
    #region Access Tracking

    /// <summary>
    /// Timestamp when the entity was last accessed (read)
    /// DoD Security: Track all data access for security monitoring
    /// </summary>
    DateTimeOffset? LastAccessedAt { get; set; }

    /// <summary>
    /// User who last accessed the entity
    /// Security monitoring: Track data access patterns
    /// </summary>
    string? LastAccessedBy { get; set; }

    /// <summary>
    /// Number of times this entity has been accessed
    /// Analytics: Track data usage patterns
    /// </summary>
    int AccessCount { get; set; }

    /// <summary>
    /// List of users who have accessed this entity
    /// Security audit: Complete access history
    /// </summary>
    string? AccessHistory { get; set; } // JSON serialized list

    #endregion

    #region Security Monitoring

    /// <summary>
    /// Indicates if this entity has been flagged for security review
    /// DoD Security: Automated security flagging
    /// </summary>
    bool IsSecurityFlagged { get; set; }

    /// <summary>
    /// Reason for security flagging
    /// Security audit: Track security concerns
    /// </summary>
    string? SecurityFlagReason { get; set; }

    /// <summary>
    /// User who flagged the entity for security review
    /// Attribution: Track security reviewers
    /// </summary>
    string? SecurityFlaggedBy { get; set; }

    /// <summary>
    /// Timestamp when security flag was applied
    /// Audit trail: Track security review timeline
    /// </summary>
    DateTimeOffset? SecurityFlaggedAt { get; set; }

    #endregion

    #region Compliance Tracking

    /// <summary>
    /// Compliance framework versions that apply to this entity
    /// DoD Compliance: Track applicable compliance requirements
    /// </summary>
    string? ComplianceFrameworks { get; set; } // JSON serialized list

    /// <summary>
    /// Last compliance review date
    /// DoD Requirement: Periodic compliance validation
    /// </summary>
    DateTimeOffset? LastComplianceReview { get; set; }

    /// <summary>
    /// Next scheduled compliance review date
    /// Compliance management: Automated review scheduling
    /// </summary>
    DateTimeOffset? NextComplianceReview { get; set; }

    /// <summary>
    /// Compliance status of the entity
    /// Compliance tracking: Current compliance state
    /// </summary>
    string ComplianceStatus { get; set; }

    #endregion
}