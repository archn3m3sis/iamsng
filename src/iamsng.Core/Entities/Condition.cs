using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents the physical or operational condition of an asset
/// Used to track asset lifecycle and maintenance status
/// </summary>
[Table("condition")]
public class Condition : BaseEntity
{
    [Key]
    [Column("condition_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ConditionId { get; set; }

    [Required]
    [Column("condition_name")]
    [MaxLength(50)]
    public string ConditionName { get; set; } = string.Empty;

    [Column("condition_description")]
    [MaxLength(500)]
    public string? ConditionDescription { get; set; }
}