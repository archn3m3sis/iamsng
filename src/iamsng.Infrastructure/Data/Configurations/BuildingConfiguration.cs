using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Building entity.
/// Configures physical building locations for asset management.
/// </summary>
public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        // Table configuration
        builder.ToTable("building", t =>
        {
            t.HasComment("Physical buildings where assets and equipment are located");
        });

        // Primary Key
        builder.HasKey(b => b.BuildingId)
            .HasName("PK_building");

        // Properties
        builder.Property(b => b.BuildingId)
            .HasColumnName("building_id")
            .UseIdentityColumn();

        builder.Property(b => b.BuildingNumber)
            .HasColumnName("building_number")
            .HasMaxLength(20)
            .IsRequired()
            .HasComment("Unique building identifier/number");

        // Indexes
        builder.HasIndex(b => b.BuildingNumber)
            .IsUnique()
            .HasDatabaseName("UX_building_number"); // Unique constraint

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            new Building 
            { 
                BuildingId = 1, 
                BuildingNumber = "Building 370",
                CreatedAt = createdAt,
                CreatedBy = 1, // SYSTEM user
                Version = 1
            },
            new Building 
            { 
                BuildingId = 2, 
                BuildingNumber = "Building 010",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Building 
            { 
                BuildingId = 3, 
                BuildingNumber = "Building 012",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Building 
            { 
                BuildingId = 4, 
                BuildingNumber = "Building 001",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Building 
            { 
                BuildingId = 5, 
                BuildingNumber = "Building 014",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Building 
            { 
                BuildingId = 6, 
                BuildingNumber = "Building 350",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Building 
            { 
                BuildingId = 7, 
                BuildingNumber = "Building 377",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Building 
            { 
                BuildingId = 8, 
                BuildingNumber = "Building 403",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            }
        );
    }
}