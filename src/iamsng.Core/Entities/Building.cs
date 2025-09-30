using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Building entity representing physical buildings where assets are located.
/// Part of the hierarchical location structure: Building -> Floor -> Room.
/// </summary>
[Table("building")]
public class Building : BaseEntity
{
    [Key]
    [Column("building_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BuildingId { get; set; }

    [Required]
    [Column("building_number")]
    [MaxLength(20)]
    public string BuildingNumber { get; set; } = string.Empty;

    // Navigation Properties
    public virtual ICollection<Room> Rooms { get; set; } = new HashSet<Room>();

    // Helper properties
    [NotMapped]
    public int RoomCount => Rooms?.Count ?? 0;
}