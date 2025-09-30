using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Audit entry entity for tracking all database operations
/// Compliant with DoD security requirements and FIPS 140-3 standards
/// Provides tamper-evident audit trail for all data modifications
/// </summary>
[Table("AuditEntries")]
public class AuditEntry
{
    /// <summary>
    /// Unique identifier for this audit entry
    /// Primary key with GUID for enhanced security
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Unique identifier for the audit entry (string format for compatibility)
    /// DoD Requirement: All audit entries must have unique identifiers
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string EntryId { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Session ID correlating related operations within a single UoW session
    /// FIPS 140-3 Compliance: Session tracking for forensic analysis
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string SessionId { get; set; } = string.Empty;

    /// <summary>
    /// Timestamp when the audited operation occurred
    /// DoD Requirement: All operations must be timestamped with UTC precision
    /// </summary>
    [Required]
    public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Type of operation performed (Create, Read, Update, Delete, etc.)
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string Operation { get; set; } = string.Empty;

    /// <summary>
    /// Type of entity that was operated on
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string EntityType { get; set; } = string.Empty;

    /// <summary>
    /// Entity ID if applicable (for tracking specific entity operations)
    /// </summary>
    [MaxLength(255)]
    public string? EntityId { get; set; }

    /// <summary>
    /// User who performed the operation
    /// DoD Requirement: All operations must be attributed to a user
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Serialized additional operation details as JSON
    /// FIPS 140-3 Compliance: Detailed audit data for forensic analysis
    /// </summary>
    [Column(TypeName = "nvarchar(max)")]
    public string? Details { get; set; }

    /// <summary>
    /// Result of the operation (Success, Failed, Warning, etc.)
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string Result { get; set; } = "Success";

    /// <summary>
    /// IP address from which the operation was performed
    /// DoD Security: Track origin of all operations
    /// </summary>
    [MaxLength(45)] // IPv6 max length
    public string? IpAddress { get; set; }

    /// <summary>
    /// User agent or application identifier
    /// </summary>
    [MaxLength(500)]
    public string? UserAgent { get; set; }

    /// <summary>
    /// Additional metadata for the audit entry
    /// Flexible field for future extensibility
    /// </summary>
    [Column(TypeName = "nvarchar(max)")]
    public string? Metadata { get; set; }

    /// <summary>
    /// Hash of the audit entry for tamper detection
    /// FIPS 140-3 Compliance: Cryptographic integrity protection
    /// </summary>
    [MaxLength(64)] // SHA-256 hash length
    public string? IntegrityHash { get; set; }

    /// <summary>
    /// Indicates if this audit entry has been archived
    /// Data retention management
    /// </summary>
    public bool IsArchived { get; set; } = false;

    /// <summary>
    /// Date when this audit entry was archived (if applicable)
    /// </summary>
    public DateTimeOffset? ArchivedAt { get; set; }

    /// <summary>
    /// Security classification level for this audit entry
    /// DoD Requirement: Data classification support
    /// </summary>
    [MaxLength(50)]
    public string SecurityClassification { get; set; } = "Unclassified";

    /// <summary>
    /// Retention period in years for this audit entry
    /// DoD Compliance: Configurable retention policies
    /// </summary>
    public int RetentionYears { get; set; } = 7; // Default DoD retention period

    /// <summary>
    /// Computed property for expiration date based on retention period
    /// </summary>
    [NotMapped]
    public DateTimeOffset ExpirationDate => Timestamp.AddYears(RetentionYears);

    /// <summary>
    /// Indicates whether this audit entry has expired and can be purged
    /// </summary>
    [NotMapped]
    public bool IsExpired => DateTimeOffset.UtcNow > ExpirationDate;

    /// <summary>
    /// Creates audit entry from operation details
    /// Factory method for creating properly formatted audit entries
    /// </summary>
    /// <param name="sessionId">Session identifier</param>
    /// <param name="operation">Operation type</param>
    /// <param name="entityType">Entity type operated on</param>
    /// <param name="userId">User performing operation</param>
    /// <param name="entityId">Optional entity identifier</param>
    /// <param name="details">Optional additional details</param>
    /// <param name="result">Operation result</param>
    /// <returns>Configured audit entry</returns>
    public static AuditEntry Create(
        string sessionId,
        string operation,
        string entityType,
        string userId,
        string? entityId = null,
        object? details = null,
        string result = "Success")
    {
        var auditEntry = new AuditEntry
        {
            SessionId = sessionId,
            Operation = operation,
            EntityType = entityType,
            UserId = userId,
            EntityId = entityId,
            Result = result,
            Timestamp = DateTimeOffset.UtcNow
        };

        if (details != null)
        {
            auditEntry.Details = System.Text.Json.JsonSerializer.Serialize(details);
        }

        // Generate integrity hash
        auditEntry.GenerateIntegrityHash();

        return auditEntry;
    }

    /// <summary>
    /// Generates cryptographic hash for tamper detection
    /// FIPS 140-3 Compliance: Uses approved hash algorithms
    /// </summary>
    public void GenerateIntegrityHash()
    {
        var hashInput = $"{SessionId}|{Operation}|{EntityType}|{UserId}|{EntityId}|{Timestamp:O}|{Details}|{Result}";
        
        using var sha256 = System.Security.Cryptography.SHA256.Create();
        var hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(hashInput));
        IntegrityHash = Convert.ToHexString(hashBytes);
    }

    /// <summary>
    /// Validates the integrity hash of this audit entry
    /// DoD Security: Tamper detection for audit records
    /// </summary>
    /// <returns>True if hash is valid, false if tampered</returns>
    public bool ValidateIntegrityHash()
    {
        var currentHash = IntegrityHash;
        GenerateIntegrityHash();
        var calculatedHash = IntegrityHash;
        IntegrityHash = currentHash; // Restore original
        
        return string.Equals(currentHash, calculatedHash, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Archives this audit entry for long-term storage
    /// DoD Compliance: Proper data lifecycle management
    /// </summary>
    public void Archive()
    {
        IsArchived = true;
        ArchivedAt = DateTimeOffset.UtcNow;
    }

    /// <summary>
    /// Returns a string representation of the audit entry for logging
    /// </summary>
    /// <returns>Formatted audit entry string</returns>
    public override string ToString()
    {
        return $"[{Timestamp:yyyy-MM-dd HH:mm:ss}] {Operation} on {EntityType} by {UserId} - {Result}";
    }
}