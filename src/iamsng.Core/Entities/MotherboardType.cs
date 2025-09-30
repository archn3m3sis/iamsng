using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

[Table("motherboard_type")]
public class MotherboardType : BaseEntity
{
    [Key]
    [Column("mobo_type_id")]
    public int MoboTypeId { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("mobo_type_name")]
    public string MoboTypeName { get; set; } = string.Empty;

    [Column("hardware_manufacturer_id")]
    public int HardwareManufacturerId { get; set; }

    // Navigation property
    [ForeignKey(nameof(HardwareManufacturerId))]
    public virtual HardwareManufacturer? HardwareManufacturer { get; set; }
}