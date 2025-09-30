using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents CPU types and models from various manufacturers
/// Links to hardware manufacturer for vendor association
/// </summary>
[Table("cpu_type")]
public class CpuType : BaseEntity
{
    [Key]
    [Column("cpu_type_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CpuTypeId { get; set; }

    [Required]
    [Column("cpu_type_name")]
    [MaxLength(100)]
    public string CpuTypeName { get; set; } = string.Empty;

    [Required]
    [Column("hardware_manufacturer_id")]
    public int HardwareManufacturerId { get; set; }

    // Navigation property
    [ForeignKey(nameof(HardwareManufacturerId))]
    public virtual HardwareManufacturer? HardwareManufacturer { get; set; }
}