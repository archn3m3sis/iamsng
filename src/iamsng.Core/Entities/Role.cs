using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Role entity representing user roles within the system.
/// Implements RBAC (Role-Based Access Control) for DoD compliance.
/// </summary>
[Table("role")]
public class Role : BaseEntity
{
    [Key]
    [Column("role_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RoleId { get; set; }

    [Required]
    [Column("role_name")]
    [MaxLength(50)]
    public string RoleName { get; set; } = string.Empty;

    // Navigation Properties
    public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

    // Predefined roles for the system
    public static class SystemRoles
    {
        public const string Administrator = "Administrator";
        public const string Manager = "Manager";
        public const string Technician = "Technician";
        public const string Auditor = "Auditor";
        public const string ReadOnly = "ReadOnly";
        public const string MaintenanceSupervisor = "MaintenanceSupervisor";
        public const string AssetManager = "AssetManager";
        public const string SecurityOfficer = "SecurityOfficer";
    }

    // Helper method to check if this is a privileged role
    [NotMapped]
    public bool IsPrivileged => 
        RoleName == SystemRoles.Administrator || 
        RoleName == SystemRoles.SecurityOfficer ||
        RoleName == SystemRoles.Auditor;

    // Helper method to check if role has write permissions
    [NotMapped]
    public bool HasWriteAccess => 
        RoleName != SystemRoles.ReadOnly && 
        RoleName != SystemRoles.Auditor;
}