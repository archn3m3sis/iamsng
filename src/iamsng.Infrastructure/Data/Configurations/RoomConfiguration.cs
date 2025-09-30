using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Room entity.
/// Configures specific room locations within buildings and floors.
/// </summary>
public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        // Table configuration
        builder.ToTable("room", t =>
        {
            t.HasComment("Specific rooms within buildings, identified by building and floor");
        });

        // Primary Key
        builder.HasKey(r => r.RoomId)
            .HasName("PK_room");

        // Properties
        builder.Property(r => r.RoomId)
            .HasColumnName("room_id")
            .UseIdentityColumn();

        builder.Property(r => r.RoomName)
            .HasColumnName("room_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Room name or identifier");

        builder.Property(r => r.BuildingId)
            .HasColumnName("building_id")
            .IsRequired()
            .HasComment("Building where room is located");

        builder.Property(r => r.FloorId)
            .HasColumnName("floor_id")
            .IsRequired()
            .HasComment("Floor where room is located");

        // Relationships
        builder.HasOne(r => r.Building)
            .WithMany(b => b.Rooms)
            .HasForeignKey(r => r.BuildingId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_room_building");

        builder.HasOne(r => r.Floor)
            .WithMany(f => f.Rooms)
            .HasForeignKey(r => r.FloorId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_room_floor");

        // Indexes
        builder.HasIndex(r => r.BuildingId)
            .HasDatabaseName("IX_room_building");

        builder.HasIndex(r => r.FloorId)
            .HasDatabaseName("IX_room_floor");

        // Composite index for common queries
        builder.HasIndex(r => new { r.BuildingId, r.FloorId })
            .HasDatabaseName("IX_room_building_floor");

        // Index for room name searches
        builder.HasIndex(r => r.RoomName)
            .HasDatabaseName("IX_room_name");

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            new Room 
            { 
                RoomId = 1, 
                RoomName = "High Power Room",
                BuildingId = 1, // Building 370
                FloorId = 3, // Floor Ground
                CreatedAt = createdAt,
                CreatedBy = 1, // SYSTEM user
                Version = 1
            },
            new Room 
            { 
                RoomId = 2, 
                RoomName = "DLU Garage Oversight Bay",
                BuildingId = 1, // Building 370
                FloorId = 3, // Floor Ground
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            }
        );
    }
}