using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// HardwareManufacturer entity representing hardware vendors and manufacturers.
/// Tracks manufacturer details and production focus for asset management.
/// </summary>
[Table("hardware_manufacturer")]
public class HardwareManufacturer : BaseEntity
{
    [Key]
    [Column("hardware_manufacturer_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HardwareManufacturerId { get; set; }

    [Required]
    [Column("hardware_manufacturer_name")]
    [MaxLength(200)]
    public string HardwareManufacturerName { get; set; } = string.Empty;

    [Required]
    [Column("hwmanu_production_focus")]
    [MaxLength(100)]
    public string ProductionFocus { get; set; } = string.Empty;

    [Column("hwmanu_icon_file")]
    [MaxLength(255)]
    public string? IconFile { get; set; }

    // Navigation Properties
    // These will be added when related entities are created
    // public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();
    // public virtual ICollection<HardwareModel> HardwareModels { get; set; } = new HashSet<HardwareModel>();

    // Helper properties
    [NotMapped]
    public string IconPath => string.IsNullOrEmpty(IconFile) 
        ? "/images/hw_manufacturers/default.svg" 
        : $"/images/hw_manufacturers/{IconFile}";

    [NotMapped]
    public string DisplayName => $"{HardwareManufacturerName} ({ProductionFocus})";
}