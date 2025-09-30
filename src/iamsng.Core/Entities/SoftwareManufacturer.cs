using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// SoftwareManufacturer entity representing software vendors and manufacturers.
/// Tracks manufacturer details and production focus for software asset management.
/// </summary>
[Table("software_manufacturer")]
public class SoftwareManufacturer : BaseEntity
{
    [Key]
    [Column("software_manufacturer_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoftwareManufacturerId { get; set; }

    [Required]
    [Column("software_manufacturer_name")]
    [MaxLength(200)]
    public string SoftwareManufacturerName { get; set; } = string.Empty;

    [Required]
    [Column("swmanu_production_focus")]
    [MaxLength(100)]
    public string ProductionFocus { get; set; } = string.Empty;

    [Column("swmanu_icon_file")]
    [MaxLength(255)]
    public string? IconFile { get; set; }

    // Navigation Properties
    // These will be added when related entities are created
    // public virtual ICollection<SoftwareAsset> SoftwareAssets { get; set; } = new HashSet<SoftwareAsset>();
    // public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; } = new HashSet<SoftwareLicense>();

    // Helper properties
    [NotMapped]
    public string IconPath => string.IsNullOrEmpty(IconFile) 
        ? "/images/sw_manufacturers/default.svg" 
        : $"/images/sw_manufacturers/{IconFile}";

    [NotMapped]
    public string DisplayName => $"{SoftwareManufacturerName} ({ProductionFocus})";
}