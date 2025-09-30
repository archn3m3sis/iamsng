using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Floor entity representing floors/levels that exist across multiple buildings.
/// Part of the hierarchical location structure: Building -> Floor -> Room.
/// </summary>
[Table("floor")]
public class Floor : BaseEntity
{
    [Key]
    [Column("floor_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FloorId { get; set; }

    [Required]
    [Column("floor_number")]
    [MaxLength(20)]
    public string FloorNumber { get; set; } = string.Empty;

    // Navigation Properties
    public virtual ICollection<Room> Rooms { get; set; } = new HashSet<Room>();

    // Helper properties
    [NotMapped]
    public bool IsGroundFloor => FloorNumber.Contains("Ground", StringComparison.OrdinalIgnoreCase);
}