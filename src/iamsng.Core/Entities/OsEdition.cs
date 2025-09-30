using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

[Table("os_edition")]
public class OsEdition : BaseEntity
{
    [Key]
    [Column("os_edition_id")]
    public int OsEditionId { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("os_edition_name")]
    public string OsEditionName { get; set; } = string.Empty;

    [MaxLength(500)]
    [Column("os_edition_description")]
    public string? OsEditionDescription { get; set; }
}