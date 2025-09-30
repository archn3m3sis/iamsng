using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for HwEnclosure entity.
/// Configures hardware enclosure types for asset categorization.
/// </summary>
public class HwEnclosureConfiguration : IEntityTypeConfiguration<HwEnclosure>
{
    public void Configure(EntityTypeBuilder<HwEnclosure> builder)
    {
        // Table configuration
        builder.ToTable("hw_enclosure", t =>
        {
            t.HasComment("Hardware enclosure types defining form factors and mounting styles");
        });

        // Primary Key
        builder.HasKey(h => h.HwEnclosureId)
            .HasName("PK_hw_enclosure");

        // Properties
        builder.Property(h => h.HwEnclosureId)
            .HasColumnName("hw_enclosure_id")
            .UseIdentityColumn();

        builder.Property(h => h.EnclosureName)
            .HasColumnName("enclosure_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name or type of the hardware enclosure");

        builder.Property(h => h.EnclosureDescription)
            .HasColumnName("enclosure_description")
            .HasMaxLength(500)
            .HasComment("Detailed description of the enclosure type and use case");

        // Indexes
        builder.HasIndex(h => h.EnclosureName)
            .HasDatabaseName("IX_hw_enclosure_name")
            .IsUnique();

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var seedDate = DateTimeOffset.UtcNow;
        builder.HasData(
            new HwEnclosure 
            { 
                HwEnclosureId = 1, 
                EnclosureName = "Server Rackmount Enclosure", 
                EnclosureDescription = "Standard 19-inch server rack mountable enclosure",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 2, 
                EnclosureName = "Tower", 
                EnclosureDescription = "Vertical tower case design for standalone server or workstation",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 3, 
                EnclosureName = "Blade", 
                EnclosureDescription = "Modular blade server enclosure housing multiple blade servers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 4, 
                EnclosureName = "Desktop", 
                EnclosureDescription = "Standard desktop computer case",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 5, 
                EnclosureName = "Small Form Factor", 
                EnclosureDescription = "Compact desktop enclosure with reduced footprint",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 6, 
                EnclosureName = "All-in-One", 
                EnclosureDescription = "Integrated enclosure with display and computer components",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 7, 
                EnclosureName = "Portable", 
                EnclosureDescription = "Laptop or notebook form factor enclosure",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 8, 
                EnclosureName = "Tablet", 
                EnclosureDescription = "Slate-style touchscreen mobile device enclosure",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 9, 
                EnclosureName = "Rackmount Chassis", 
                EnclosureDescription = "Multi-node chassis for rack-mounted server systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 10, 
                EnclosureName = "Network Appliance", 
                EnclosureDescription = "Purpose-built enclosure for network devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 11, 
                EnclosureName = "Industrial PC", 
                EnclosureDescription = "Ruggedized enclosure for harsh industrial environments",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 12, 
                EnclosureName = "DIN Rail Mount", 
                EnclosureDescription = "Enclosure designed for DIN rail mounting in control panels",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 13, 
                EnclosureName = "Wall Mount", 
                EnclosureDescription = "Enclosure designed for wall-mounted installation",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 14, 
                EnclosureName = "Outdoor Rated", 
                EnclosureDescription = "Weather-resistant enclosure for outdoor deployment",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 15, 
                EnclosureName = "NEMA Rated", 
                EnclosureDescription = "Enclosure meeting NEMA environmental protection standards",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new HwEnclosure 
            { 
                HwEnclosureId = 16, 
                EnclosureName = "Embedded", 
                EnclosureDescription = "Compact embedded system enclosure",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            }
        );
    }
}