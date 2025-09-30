using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

[Table("os_version")]
public class OsVersion : BaseEntity
{
    [Key]
    [Column("os_version_id")]
    public int OsVersionId { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("os_version_name")]
    public string OsVersionName { get; set; } = string.Empty;

    [MaxLength(500)]
    [Column("os_version_description")]
    public string? OsVersionDescription { get; set; }
}