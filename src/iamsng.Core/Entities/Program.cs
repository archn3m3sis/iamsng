using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Program entity representing DoD programs that own/manage assets.
/// Each asset belongs to exactly one program (one-to-many relationship).
/// </summary>
[Table("program")]
public class Program : BaseEntity
{
    [Key]
    [Column("program_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProgramId { get; set; }

    [Required]
    [Column("program_name")]
    [MaxLength(50)]
    public string ProgramName { get; set; } = string.Empty;

    [Required]
    [Column("legacy_program_name")]
    [MaxLength(50)]
    public string LegacyProgramName { get; set; } = string.Empty;

    [Column("program_manager")]
    [ForeignKey(nameof(ProgramManager))]
    public int? ProgramManagerId { get; set; }

    // Navigation Properties
    public virtual User? ProgramManager { get; set; }
    
    // This will be added when Asset entity is created
    // public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();

    // Helper properties
    [NotMapped]
    public bool HasManager => ProgramManagerId.HasValue;

    [NotMapped]
    public string DisplayName => $"{ProgramName} (formerly {LegacyProgramName})";
}