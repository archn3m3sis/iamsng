using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents operating system vendors and developers
/// Used to categorize operating systems by their vendor/maintainer
/// </summary>
[Table("os_vendor")]
public class OsVendor : BaseEntity
{
    [Key]
    [Column("os_vendor_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OsVendorId { get; set; }

    [Required]
    [Column("os_vendor_name")]
    [MaxLength(100)]
    public string OsVendorName { get; set; } = string.Empty;

    [Column("os_vendor_description")]
    [MaxLength(500)]
    public string? OsVendorDescription { get; set; }
}