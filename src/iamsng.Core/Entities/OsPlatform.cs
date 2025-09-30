using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents operating system platforms and families
/// Used to categorize operating systems by their platform type
/// </summary>
[Table("os_platform")]
public class OsPlatform : BaseEntity
{
    [Key]
    [Column("os_platform_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OsPlatformId { get; set; }

    [Required]
    [Column("os_platform_name")]
    [MaxLength(100)]
    public string OsPlatformName { get; set; } = string.Empty;

    [Column("os_platform_description")]
    [MaxLength(500)]
    public string? OsPlatformDescription { get; set; }
}