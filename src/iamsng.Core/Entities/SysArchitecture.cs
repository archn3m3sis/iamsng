using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents system architectures/instruction sets for hardware platforms
/// Used to categorize hardware assets by processor architecture
/// </summary>
[Table("sys_architecture")]
public class SysArchitecture : BaseEntity
{
    [Key]
    [Column("sys_architecture_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SysArchitectureId { get; set; }

    [Required]
    [Column("system_architecture")]
    [MaxLength(50)]
    public string SystemArchitecture { get; set; } = string.Empty;

    [Column("sys_architecture_description")]
    [MaxLength(500)]
    public string? SysArchitectureDescription { get; set; }
}