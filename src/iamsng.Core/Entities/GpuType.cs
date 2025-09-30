using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents GPU types and models from various manufacturers
/// Links to hardware manufacturer for vendor association
/// </summary>
[Table("gpu_types")]
public class GpuType : BaseEntity
{
    [Key]
    [Column("gpu_type_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GpuTypeId { get; set; }

    [Required]
    [Column("gpu_type_name")]
    [MaxLength(100)]
    public string GpuTypeName { get; set; } = string.Empty;

    [Required]
    [Column("hardware_manufacturer_id")]
    public int HardwareManufacturerId { get; set; }

    // Navigation property
    [ForeignKey(nameof(HardwareManufacturerId))]
    public virtual HardwareManufacturer? HardwareManufacturer { get; set; }
}