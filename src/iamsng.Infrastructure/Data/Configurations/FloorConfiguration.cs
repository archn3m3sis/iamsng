using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Floor entity.
/// Configures floor/level definitions used across multiple buildings.
/// </summary>
public class FloorConfiguration : IEntityTypeConfiguration<Floor>
{
    public void Configure(EntityTypeBuilder<Floor> builder)
    {
        // Table configuration
        builder.ToTable("floor", t =>
        {
            t.HasComment("Floor/level definitions that exist across multiple buildings");
        });

        // Primary Key
        builder.HasKey(f => f.FloorId)
            .HasName("PK_floor");

        // Properties
        builder.Property(f => f.FloorId)
            .HasColumnName("floor_id")
            .UseIdentityColumn();

        builder.Property(f => f.FloorNumber)
            .HasColumnName("floor_number")
            .HasMaxLength(20)
            .IsRequired()
            .HasComment("Unique floor identifier/number");

        // Indexes
        builder.HasIndex(f => f.FloorNumber)
            .IsUnique()
            .HasDatabaseName("UX_floor_number"); // Unique constraint

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            new Floor 
            { 
                FloorId = 1, 
                FloorNumber = "Floor 001",
                CreatedAt = createdAt,
                CreatedBy = 1, // SYSTEM user
                Version = 1
            },
            new Floor 
            { 
                FloorId = 2, 
                FloorNumber = "Floor 002",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Floor 
            { 
                FloorId = 3, 
                FloorNumber = "Floor Ground",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            }
        );
    }
}