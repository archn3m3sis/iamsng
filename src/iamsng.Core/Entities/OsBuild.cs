using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

[Table("os_build")]
public class OsBuild : BaseEntity
{
    [Key]
    [Column("os_build_id")]
    public int OsBuildId { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("os_build_name")]
    public string OsBuildName { get; set; } = string.Empty;

    [MaxLength(500)]
    [Column("os_build_description")]
    public string? OsBuildDescription { get; set; }
}