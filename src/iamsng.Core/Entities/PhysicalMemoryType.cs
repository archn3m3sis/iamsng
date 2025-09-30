using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Represents physical memory types for hardware asset specifications
/// Tracks various RAM technologies and form factors
/// </summary>
[Table("physical_memory_type")]
public class PhysicalMemoryType : BaseEntity
{
    [Key]
    [Column("physical_memtype_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PhysicalMemtypeId { get; set; }

    [Required]
    [Column("physical_memtype_name")]
    [MaxLength(100)]
    public string PhysicalMemtypeName { get; set; } = string.Empty;

    [Column("physical_memtype_description")]
    [MaxLength(500)]
    public string? PhysicalMemtypeDescription { get; set; }
}