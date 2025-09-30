using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Room entity representing specific rooms within buildings.
/// Requires both building and floor to uniquely identify location.
/// Part of the hierarchical location structure: Building -> Floor -> Room.
/// </summary>
[Table("room")]
public class Room : BaseEntity
{
    [Key]
    [Column("room_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RoomId { get; set; }

    [Required]
    [Column("room_name")]
    [MaxLength(100)]
    public string RoomName { get; set; } = string.Empty;

    [Required]
    [Column("building_id")]
    [ForeignKey(nameof(Building))]
    public int BuildingId { get; set; }

    [Required]
    [Column("floor_id")]
    [ForeignKey(nameof(Floor))]
    public int FloorId { get; set; }

    // Navigation Properties
    public virtual Building Building { get; set; } = null!;
    public virtual Floor Floor { get; set; } = null!;

    // This will be added when Asset entity is created
    // public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();

    // Helper properties
    [NotMapped]
    public string FullLocation => $"{RoomName}, {Building?.BuildingNumber}, {Floor?.FloorNumber}";
}