namespace iamsng.Core.Interfaces;

/// <summary>
/// Interface for entities that support soft deletion functionality
/// Compliant with DoD security requirements where audit trail preservation is mandatory
/// Provides logical deletion while maintaining data integrity for forensic analysis
/// </summary>
public interface ISoftDeletable
{
    #region Soft Deletion Properties

    /// <summary>
    /// Indicates whether the entity is logically deleted
    /// DoD Requirement: Preserve audit trail through soft deletion
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// Timestamp when the entity was soft deleted
    /// FIPS 140-3 Compliance: Precise timing of all deletion operations
    /// </summary>
    DateTimeOffset? DeletedAt { get; set; }

    /// <summary>
    /// User who performed the soft deletion
    /// DoD Requirement: Attribution of all data lifecycle operations
    /// </summary>
    string? DeletedBy { get; set; }

    /// <summary>
    /// IP address from which the deletion was performed
    /// DoD Security: Track origin of all deletion operations
    /// </summary>
    string? DeletedFromIp { get; set; }

    /// <summary>
    /// Application or service that performed the deletion
    /// Security monitoring: Track source applications for deletions
    /// </summary>
    string? DeletedByApplication { get; set; }

    /// <summary>
    /// Reason for the soft deletion
    /// Audit trail: Maintain justification for data deletion
    /// </summary>
    string? DeletionReason { get; set; }

    /// <summary>
    /// Category of deletion (User Request, System Cleanup, Compliance, etc.)
    /// Data governance: Classify deletion operations
    /// </summary>
    string? DeletionCategory { get; set; }

    #endregion

    #region Restoration Support

    /// <summary>
    /// Indicates if the entity can be restored after soft deletion
    /// DoD Policy: Some deletions may be permanent for security reasons
    /// </summary>
    bool IsRestorable { get; set; }

    /// <summary>
    /// Expiration date after which the entity cannot be restored
    /// Data lifecycle: Automated transition to permanent deletion
    /// </summary>
    DateTimeOffset? RestoreExpirationDate { get; set; }

    /// <summary>
    /// Timestamp when the entity was restored (if applicable)
    /// Audit trail: Track restoration operations
    /// </summary>
    DateTimeOffset? RestoredAt { get; set; }

    /// <summary>
    /// User who restored the entity (if applicable)
    /// Attribution: Track restoration operations
    /// </summary>
    string? RestoredBy { get; set; }

    /// <summary>
    /// Reason for restoration
    /// Audit trail: Justify restoration operations
    /// </summary>
    string? RestorationReason { get; set; }

    #endregion

    #region Approval Workflow

    /// <summary>
    /// Indicates if the deletion requires approval before becoming effective
    /// DoD Security: Controlled deletion for sensitive data
    /// </summary>
    bool RequiresDeletionApproval { get; set; }

    /// <summary>
    /// Status of deletion approval workflow
    /// Workflow management: Track approval process
    /// </summary>
    string? DeletionApprovalStatus { get; set; }

    /// <summary>
    /// User who approved the deletion
    /// DoD Requirement: Supervisory approval for sensitive deletions
    /// </summary>
    string? DeletionApprovedBy { get; set; }

    /// <summary>
    /// Timestamp when deletion was approved
    /// Audit trail: Track approval timeline
    /// </summary>
    DateTimeOffset? DeletionApprovedAt { get; set; }

    /// <summary>
    /// Comments from the deletion approver
    /// Documentation: Capture approval rationale
    /// </summary>
    string? DeletionApprovalComments { get; set; }

    #endregion

    #region Data Retention

    /// <summary>
    /// Number of days to retain the soft-deleted entity before permanent deletion
    /// DoD Compliance: Configurable retention policies
    /// </summary>
    int SoftDeleteRetentionDays { get; set; }

    /// <summary>
    /// Indicates if the entity is eligible for permanent deletion (hard delete)
    /// Data lifecycle: Automated cleanup eligibility
    /// </summary>
    bool IsEligibleForPermanentDeletion { get; set; }

    /// <summary>
    /// Date when the entity becomes eligible for permanent deletion
    /// Computed property based on deletion date and retention period
    /// </summary>
    DateTimeOffset? PermanentDeletionEligibleDate { get; }

    #endregion

    #region Security and Compliance

    /// <summary>
    /// Security classification that affects deletion policies
    /// DoD Requirement: Classification-based deletion controls
    /// </summary>
    string? DeletionSecurityClassification { get; set; }

    /// <summary>
    /// Compliance requirements that must be met before deletion
    /// DoD Compliance: Regulatory deletion constraints
    /// </summary>
    string? DeletionComplianceRequirements { get; set; }

    /// <summary>
    /// Legal hold status that prevents deletion
    /// Legal compliance: Litigation hold management
    /// </summary>
    bool IsUnderLegalHold { get; set; }

    /// <summary>
    /// Legal hold identifier if applicable
    /// Legal compliance: Track specific legal holds
    /// </summary>
    string? LegalHoldId { get; set; }

    /// <summary>
    /// Date when legal hold was placed
    /// Legal audit: Track hold timeline
    /// </summary>
    DateTimeOffset? LegalHoldPlacedAt { get; set; }

    #endregion
}

/// <summary>
/// Extended soft deletable interface with advanced deletion management features
/// Enhanced functionality for enterprise and government environments
/// </summary>
public interface IExtendedSoftDeletable : ISoftDeletable
{
    #region Cascade Deletion

    /// <summary>
    /// Indicates if deletion should cascade to related entities
    /// Data integrity: Manage referential deletion
    /// </summary>
    bool CascadeDeletion { get; set; }

    /// <summary>
    /// List of related entity types that will be cascade deleted
    /// Documentation: Track cascade deletion scope
    /// </summary>
    string? CascadeDeletionTargets { get; set; } // JSON serialized list

    /// <summary>
    /// Count of related entities affected by cascade deletion
    /// Impact assessment: Track deletion scope
    /// </summary>
    int CascadeDeletionCount { get; set; }

    #endregion

    #region Deletion History

    /// <summary>
    /// Number of times this entity has been soft deleted and restored
    /// Analytics: Track deletion patterns
    /// </summary>
    int DeletionCount { get; set; }

    /// <summary>
    /// Complete deletion and restoration history
    /// Audit trail: Comprehensive deletion timeline
    /// </summary>
    string? DeletionHistory { get; set; } // JSON serialized history

    #endregion

    #region Backup and Recovery

    /// <summary>
    /// Indicates if a backup was created before deletion
    /// DoD Security: Ensure data recovery capability
    /// </summary>
    bool BackupCreatedBeforeDeletion { get; set; }

    /// <summary>
    /// Location or identifier of the backup
    /// Recovery: Track backup locations
    /// </summary>
    string? BackupLocation { get; set; }

    /// <summary>
    /// Backup verification status
    /// Data integrity: Ensure backup quality
    /// </summary>
    string? BackupVerificationStatus { get; set; }

    #endregion

    #region Notification and Alerting

    /// <summary>
    /// Indicates if deletion notifications were sent
    /// Communication: Track stakeholder notifications
    /// </summary>
    bool DeletionNotificationSent { get; set; }

    /// <summary>
    /// List of users/groups notified about the deletion
    /// Communication audit: Track notification recipients
    /// </summary>
    string? DeletionNotificationRecipients { get; set; } // JSON serialized list

    /// <summary>
    /// Timestamp when deletion notifications were sent
    /// Communication timeline: Track notification timing
    /// </summary>
    DateTimeOffset? DeletionNotificationSentAt { get; set; }

    #endregion
}

/// <summary>
/// Soft deletion helper methods and utilities
/// Provides common functionality for soft deletion operations
/// </summary>
public static class SoftDeletableExtensions
{
    /// <summary>
    /// Performs a soft delete operation on the entity
    /// DoD Compliant: Sets all required audit fields
    /// </summary>
    /// <param name="entity">Entity to soft delete</param>
    /// <param name="deletedBy">User performing the deletion</param>
    /// <param name="reason">Reason for deletion</param>
    /// <param name="category">Category of deletion</param>
    /// <param name="ipAddress">IP address of the delete operation</param>
    /// <param name="application">Application performing the deletion</param>
    public static void SoftDelete(
        this ISoftDeletable entity,
        string deletedBy,
        string? reason = null,
        string? category = "User Request",
        string? ipAddress = null,
        string? application = null)
    {
        entity.IsDeleted = true;
        entity.DeletedAt = DateTimeOffset.UtcNow;
        entity.DeletedBy = deletedBy;
        entity.DeletionReason = reason;
        entity.DeletionCategory = category;
        entity.DeletedFromIp = ipAddress;
        entity.DeletedByApplication = application;

        // Set default retention period if not specified
        if (entity.SoftDeleteRetentionDays <= 0)
        {
            entity.SoftDeleteRetentionDays = 30; // Default 30-day retention
        }
    }

    /// <summary>
    /// Restores a soft-deleted entity
    /// DoD Compliant: Maintains complete audit trail
    /// </summary>
    /// <param name="entity">Entity to restore</param>
    /// <param name="restoredBy">User performing the restoration</param>
    /// <param name="reason">Reason for restoration</param>
    public static void Restore(
        this ISoftDeletable entity,
        string restoredBy,
        string? reason = null)
    {
        if (!entity.IsDeleted)
        {
            throw new InvalidOperationException("Entity is not soft deleted and cannot be restored");
        }

        if (!entity.IsRestorable)
        {
            throw new InvalidOperationException("Entity is not restorable");
        }

        if (entity.RestoreExpirationDate.HasValue && 
            DateTimeOffset.UtcNow > entity.RestoreExpirationDate.Value)
        {
            throw new InvalidOperationException("Restoration period has expired");
        }

        entity.IsDeleted = false;
        entity.RestoredAt = DateTimeOffset.UtcNow;
        entity.RestoredBy = restoredBy;
        entity.RestorationReason = reason;
    }

    /// <summary>
    /// Checks if the entity is eligible for permanent deletion
    /// DoD Policy: Enforces retention and legal hold requirements
    /// </summary>
    /// <param name="entity">Entity to check</param>
    /// <returns>True if eligible for permanent deletion</returns>
    public static bool IsEligibleForPermanentDeletion(this ISoftDeletable entity)
    {
        if (!entity.IsDeleted)
            return false;

        if (entity.IsUnderLegalHold)
            return false;

        if (!entity.DeletedAt.HasValue)
            return false;

        var retentionExpired = entity.DeletedAt.Value.AddDays(entity.SoftDeleteRetentionDays) <= DateTimeOffset.UtcNow;
        return retentionExpired && entity.IsEligibleForPermanentDeletion;
    }

    /// <summary>
    /// Gets the computed permanent deletion eligible date
    /// </summary>
    /// <param name="entity">Entity to check</param>
    /// <returns>Date when permanent deletion becomes eligible</returns>
    public static DateTimeOffset? GetPermanentDeletionEligibleDate(this ISoftDeletable entity)
    {
        if (!entity.DeletedAt.HasValue)
            return null;

        return entity.DeletedAt.Value.AddDays(entity.SoftDeleteRetentionDays);
    }
}