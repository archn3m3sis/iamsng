using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// User entity representing system users with CAC authentication support.
/// FIPS 140-3 compliant with DoD STIG requirements for user management.
/// </summary>
[Table("user")]
public class User : BaseEntity
{
    [Key]
    [Column("user_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }

    [Required]
    [Column("user_first")]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [Column("user_last")]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [Column("user_email")]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Column("user_phone")]
    [MaxLength(20)]
    [Phone]
    public string? Phone { get; set; }

    [Required]
    [Column("user_dodid")]
    [Range(1000000000, 9999999999, ErrorMessage = "DoD ID must be exactly 10 digits")]
    public long DodId { get; set; }

    [Required]
    [Column("user_certificate_dn")]
    [MaxLength(500)]
    public string CertificateDn { get; set; } = string.Empty;

    [Required]
    [Column("user_certificate_serial")]
    [MaxLength(100)]
    public string CertificateSerial { get; set; } = string.Empty;

    [Required]
    [Column("user_account_status")]
    public AccountStatus AccountStatus { get; set; } = AccountStatus.Inactive;

    [Column("user_last_cac_auth")]
    public DateTimeOffset? LastCacAuth { get; set; }

    [Required]
    [Column("user_requires_cac")]
    public bool RequiresCac { get; set; } = true;

    [Column("user_piv_auth_cert_hash")]
    [MaxLength(64)]
    public string? PivAuthCertHash { get; set; }

    [Column("user_affiliation")]
    [MaxLength(20)]
    public string? Affiliation { get; set; }

    [Column("user_person_designator")]
    [MaxLength(20)]
    public string? PersonDesignator { get; set; }

    [Column("user_cac_expiry")]
    public DateTimeOffset? CacExpiry { get; set; }

    // Foreign Keys
    [Required]
    [Column("user_role")]
    [ForeignKey(nameof(Role))]
    public int RoleId { get; set; }

    [Column("sme_role")]
    [ForeignKey(nameof(SmeRole))]
    public int? SmeRoleId { get; set; }

    // Navigation Properties
    public virtual Role Role { get; set; } = null!;
    public virtual SmeRole? SmeRole { get; set; }

    // Computed Properties
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    [NotMapped]
    public bool IsCacExpired => CacExpiry.HasValue && CacExpiry.Value <= DateTimeOffset.UtcNow;

    [NotMapped]
    public bool IsActive => AccountStatus == AccountStatus.Active && !IsCacExpired;

    // Methods for security validation
    public bool ValidateCertificatePin(string certificateHash)
    {
        if (string.IsNullOrEmpty(PivAuthCertHash))
            return true; // First authentication, will be pinned

        return string.Equals(PivAuthCertHash, certificateHash, StringComparison.OrdinalIgnoreCase);
    }

    public void UpdateCacAuthentication()
    {
        LastCacAuth = DateTimeOffset.UtcNow;
    }
}

/// <summary>
/// Account status enumeration for DoD compliance
/// </summary>
public enum AccountStatus : byte
{
    Inactive = 0,
    Active = 1,
    Suspended = 2,
    Locked = 3
}

/// <summary>
/// Military affiliation enumeration
/// </summary>
public static class MilitaryAffiliation
{
    public const string Army = "ARMY";
    public const string Navy = "NAVY";
    public const string AirForce = "USAF";
    public const string SpaceForce = "USSF";
    public const string Marines = "USMC";
    public const string CoastGuard = "USCG";
    public const string Civilian = "CIVILIAN";
    public const string Contractor = "CONTRACTOR";
}

/// <summary>
/// Person designator enumeration
/// </summary>
public static class PersonDesignator
{
    public const string Military = "MILITARY";
    public const string Civilian = "CIVILIAN";
    public const string Contractor = "CONTRACTOR";
    public const string ForeignNational = "FOREIGN_NATIONAL";
}