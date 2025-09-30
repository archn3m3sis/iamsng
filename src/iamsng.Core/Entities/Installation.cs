using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Installation entity representing military installations/bases.
/// Tracks installation location and area of excellence for DoD asset management.
/// </summary>
[Table("installation")]
public class Installation : BaseEntity
{
    [Key]
    [Column("installation_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int InstallationId { get; set; }

    [Required]
    [Column("installation_name")]
    [MaxLength(100)]
    public string InstallationName { get; set; } = string.Empty;

    [Required]
    [Column("installation_state")]
    [MaxLength(50)]
    public string InstallationState { get; set; } = string.Empty;

    [Required]
    [Column("installation_city")]
    [MaxLength(100)]
    public string InstallationCity { get; set; } = string.Empty;

    [Required]
    [Column("installation_area_of_excellence")]
    [MaxLength(200)]
    public string InstallationAreaOfExcellence { get; set; } = string.Empty;

    // Navigation Properties
    // This will be added when Asset entity is created
    // public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();

    // Helper properties
    [NotMapped]
    public string FullLocation => $"{InstallationName}, {InstallationCity}, {InstallationState}";
}