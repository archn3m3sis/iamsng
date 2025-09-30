using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents hardware enclosure types for physical asset categorization
/// Defines the form factor and mounting style of hardware assets
/// </summary>
[Table("hw_enclosure")]
public class HwEnclosure : BaseEntity
{
    [Key]
    [Column("hw_enclosure_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HwEnclosureId { get; set; }

    [Required]
    [Column("enclosure_name")]
    [MaxLength(100)]
    public string EnclosureName { get; set; } = string.Empty;

    [Column("enclosure_description")]
    [MaxLength(500)]
    public string? EnclosureDescription { get; set; }
}