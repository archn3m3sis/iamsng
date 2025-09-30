using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Installation entity.
/// Configures military installations with area of excellence for DoD asset tracking.
/// </summary>
public class InstallationConfiguration : IEntityTypeConfiguration<Installation>
{
    public void Configure(EntityTypeBuilder<Installation> builder)
    {
        // Table configuration
        builder.ToTable("installation", t =>
        {
            t.HasComment("Military installations/bases with area of excellence for asset management");
        });

        // Primary Key
        builder.HasKey(i => i.InstallationId)
            .HasName("PK_installation");

        // Properties
        builder.Property(i => i.InstallationId)
            .HasColumnName("installation_id")
            .UseIdentityColumn();

        builder.Property(i => i.InstallationName)
            .HasColumnName("installation_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name of the military installation");

        builder.Property(i => i.InstallationState)
            .HasColumnName("installation_state")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("State where installation is located");

        builder.Property(i => i.InstallationCity)
            .HasColumnName("installation_city")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("City where installation is located");

        builder.Property(i => i.InstallationAreaOfExcellence)
            .HasColumnName("installation_area_of_excellence")
            .HasMaxLength(200)
            .IsRequired()
            .HasComment("Primary area of excellence or specialization for this installation");

        // Indexes
        builder.HasIndex(i => i.InstallationName)
            .HasDatabaseName("IX_installation_name");

        builder.HasIndex(i => i.InstallationState)
            .HasDatabaseName("IX_installation_state");

        builder.HasIndex(i => i.InstallationAreaOfExcellence)
            .HasDatabaseName("IX_installation_area_excellence");

        // Composite index for location queries
        builder.HasIndex(i => new { i.InstallationState, i.InstallationCity })
            .HasDatabaseName("IX_installation_state_city");

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data - 52 military installations
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            new Installation { InstallationId = 1, InstallationName = "Anniston Army Depot", InstallationState = "Alabama", InstallationCity = "Anniston", InstallationAreaOfExcellence = "Ground Combat Vehicles", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 2, InstallationName = "Fort Campbell", InstallationState = "Kentucky", InstallationCity = "Fort Campbell", InstallationAreaOfExcellence = "Air Assault", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 3, InstallationName = "Fort Cavazos", InstallationState = "Texas", InstallationCity = "Killeen", InstallationAreaOfExcellence = "Armored Warfare", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 4, InstallationName = "Fort Eisenhower", InstallationState = "Georgia", InstallationCity = "Augusta", InstallationAreaOfExcellence = "Cyber Warfare", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 5, InstallationName = "Fort Liberty", InstallationState = "North Carolina", InstallationCity = "Fayetteville", InstallationAreaOfExcellence = "Special Operations", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 6, InstallationName = "Fort Moore", InstallationState = "Georgia", InstallationCity = "Columbus", InstallationAreaOfExcellence = "Maneuver Center of Excellence", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 7, InstallationName = "Joint Base Lewis-McChord", InstallationState = "Washington", InstallationCity = "Tacoma", InstallationAreaOfExcellence = "Power Projection Platform", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 8, InstallationName = "Letterkenny Army Depot", InstallationState = "Pennsylvania", InstallationCity = "Chambersburg", InstallationAreaOfExcellence = "Missile and Ammunition", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 9, InstallationName = "Red River Army Depot", InstallationState = "Texas", InstallationCity = "Texarkana", InstallationAreaOfExcellence = "Combat Vehicle Repair", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 10, InstallationName = "Rock Island Arsenal", InstallationState = "Illinois", InstallationCity = "Rock Island", InstallationAreaOfExcellence = "Manufacturing and Logistics", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 11, InstallationName = "Sierra Army Depot", InstallationState = "California", InstallationCity = "Herlong", InstallationAreaOfExcellence = "Ammunition Storage", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 12, InstallationName = "Tobyhanna Army Depot", InstallationState = "Pennsylvania", InstallationCity = "Tobyhanna", InstallationAreaOfExcellence = "Communications Electronics", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 13, InstallationName = "Watervliet Arsenal", InstallationState = "New York", InstallationCity = "Watervliet", InstallationAreaOfExcellence = "Cannon Manufacturing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 14, InstallationName = "Fort Bliss", InstallationState = "Texas", InstallationCity = "El Paso", InstallationAreaOfExcellence = "Air Defense Artillery", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 15, InstallationName = "Fort Carson", InstallationState = "Colorado", InstallationCity = "Colorado Springs", InstallationAreaOfExcellence = "Mountain Warfare", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 16, InstallationName = "Fort Drum", InstallationState = "New York", InstallationCity = "Watertown", InstallationAreaOfExcellence = "Cold Weather Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 17, InstallationName = "Fort Huachuca", InstallationState = "Arizona", InstallationCity = "Sierra Vista", InstallationAreaOfExcellence = "Intelligence Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 18, InstallationName = "Fort Irwin", InstallationState = "California", InstallationCity = "Barstow", InstallationAreaOfExcellence = "National Training Center", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 19, InstallationName = "Fort Johnson", InstallationState = "Louisiana", InstallationCity = "Leesville", InstallationAreaOfExcellence = "Joint Readiness Training Center", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 20, InstallationName = "Fort Knox", InstallationState = "Kentucky", InstallationCity = "Fort Knox", InstallationAreaOfExcellence = "Human Resources", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 21, InstallationName = "Fort Leavenworth", InstallationState = "Kansas", InstallationCity = "Leavenworth", InstallationAreaOfExcellence = "Combined Arms Center", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 22, InstallationName = "Fort Lee", InstallationState = "Virginia", InstallationCity = "Petersburg", InstallationAreaOfExcellence = "Sustainment", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 23, InstallationName = "Fort Leonard Wood", InstallationState = "Missouri", InstallationCity = "St. Robert", InstallationAreaOfExcellence = "Engineer Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 24, InstallationName = "Fort Novosel", InstallationState = "Alabama", InstallationCity = "Daleville", InstallationAreaOfExcellence = "Aviation Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 25, InstallationName = "Fort Riley", InstallationState = "Kansas", InstallationCity = "Junction City", InstallationAreaOfExcellence = "Division Headquarters", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 26, InstallationName = "Fort Sill", InstallationState = "Oklahoma", InstallationCity = "Lawton", InstallationAreaOfExcellence = "Field Artillery", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 27, InstallationName = "Fort Stewart", InstallationState = "Georgia", InstallationCity = "Hinesville", InstallationAreaOfExcellence = "Heavy Mechanized Infantry", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 28, InstallationName = "Fort Wainwright", InstallationState = "Alaska", InstallationCity = "Fairbanks", InstallationAreaOfExcellence = "Arctic Warfare", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 29, InstallationName = "Joint Base Elmendorf-Richardson", InstallationState = "Alaska", InstallationCity = "Anchorage", InstallationAreaOfExcellence = "Pacific Air Power", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 30, InstallationName = "Joint Base Langley-Eustis", InstallationState = "Virginia", InstallationCity = "Hampton", InstallationAreaOfExcellence = "Air Combat Command", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 31, InstallationName = "Joint Base San Antonio", InstallationState = "Texas", InstallationCity = "San Antonio", InstallationAreaOfExcellence = "Military Medical Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 32, InstallationName = "Picatinny Arsenal", InstallationState = "New Jersey", InstallationCity = "Dover", InstallationAreaOfExcellence = "Armaments Research", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 33, InstallationName = "Pine Bluff Arsenal", InstallationState = "Arkansas", InstallationCity = "Pine Bluff", InstallationAreaOfExcellence = "Chemical/Biological Defense", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 34, InstallationName = "Redstone Arsenal", InstallationState = "Alabama", InstallationCity = "Huntsville", InstallationAreaOfExcellence = "Missile and Space", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 35, InstallationName = "Aberdeen Proving Ground", InstallationState = "Maryland", InstallationCity = "Aberdeen", InstallationAreaOfExcellence = "Test and Evaluation", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 36, InstallationName = "Dugway Proving Ground", InstallationState = "Utah", InstallationCity = "Dugway", InstallationAreaOfExcellence = "Chemical/Biological Testing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 37, InstallationName = "White Sands Missile Range", InstallationState = "New Mexico", InstallationCity = "Las Cruces", InstallationAreaOfExcellence = "Missile Testing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 38, InstallationName = "Yuma Proving Ground", InstallationState = "Arizona", InstallationCity = "Yuma", InstallationAreaOfExcellence = "Desert Testing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 39, InstallationName = "Camp Atterbury", InstallationState = "Indiana", InstallationCity = "Edinburgh", InstallationAreaOfExcellence = "Mobilization Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 40, InstallationName = "Camp Dodge", InstallationState = "Iowa", InstallationCity = "Johnston", InstallationAreaOfExcellence = "National Guard Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 41, InstallationName = "Camp Grayling", InstallationState = "Michigan", InstallationCity = "Grayling", InstallationAreaOfExcellence = "Joint Maneuver Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 42, InstallationName = "Camp Ripley", InstallationState = "Minnesota", InstallationCity = "Little Falls", InstallationAreaOfExcellence = "Winter Operations", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 43, InstallationName = "Camp Shelby", InstallationState = "Mississippi", InstallationCity = "Hattiesburg", InstallationAreaOfExcellence = "Mobilization Site", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 44, InstallationName = "Fort Chaffee", InstallationState = "Arkansas", InstallationCity = "Fort Smith", InstallationAreaOfExcellence = "Joint Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 45, InstallationName = "Fort Hunter Liggett", InstallationState = "California", InstallationCity = "Jolon", InstallationAreaOfExcellence = "Combat Support Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 46, InstallationName = "Fort McCoy", InstallationState = "Wisconsin", InstallationCity = "Sparta", InstallationAreaOfExcellence = "Reserve Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 47, InstallationName = "Fort Pickett", InstallationState = "Virginia", InstallationCity = "Blackstone", InstallationAreaOfExcellence = "Foreign Military Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 48, InstallationName = "Fort William Henry Harrison", InstallationState = "Montana", InstallationCity = "Helena", InstallationAreaOfExcellence = "Regional Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 49, InstallationName = "Gowen Field", InstallationState = "Idaho", InstallationCity = "Boise", InstallationAreaOfExcellence = "Air National Guard", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 50, InstallationName = "Camp Navajo", InstallationState = "Arizona", InstallationCity = "Bellemont", InstallationAreaOfExcellence = "Munitions Storage", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 51, InstallationName = "Camp Parks", InstallationState = "California", InstallationCity = "Dublin", InstallationAreaOfExcellence = "Reserve Operations", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new Installation { InstallationId = 52, InstallationName = "Camp Swift", InstallationState = "Texas", InstallationCity = "Bastrop", InstallationAreaOfExcellence = "Maneuver Training", CreatedAt = createdAt, CreatedBy = 1, Version = 1 }
        );
    }
}