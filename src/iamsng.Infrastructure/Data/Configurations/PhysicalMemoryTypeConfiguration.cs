using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for PhysicalMemoryType entity.
/// Configures physical memory types and technologies for hardware asset specifications.
/// </summary>
public class PhysicalMemoryTypeConfiguration : IEntityTypeConfiguration<PhysicalMemoryType>
{
    public void Configure(EntityTypeBuilder<PhysicalMemoryType> builder)
    {
        // Table configuration
        builder.ToTable("physical_memory_type", t =>
        {
            t.HasComment("Physical memory types and technologies for hardware specifications");
        });

        // Primary Key
        builder.HasKey(p => p.PhysicalMemtypeId)
            .HasName("PK_physical_memory_type");

        // Properties
        builder.Property(p => p.PhysicalMemtypeId)
            .HasColumnName("physical_memtype_id")
            .UseIdentityColumn();

        builder.Property(p => p.PhysicalMemtypeName)
            .HasColumnName("physical_memtype_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name or designation of the memory type");

        builder.Property(p => p.PhysicalMemtypeDescription)
            .HasColumnName("physical_memtype_description")
            .HasMaxLength(500)
            .HasComment("Technical description and specifications of the memory type");

        // Indexes
        builder.HasIndex(p => p.PhysicalMemtypeName)
            .HasDatabaseName("IX_physical_memory_type_name")
            .IsUnique();

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var seedDate = DateTimeOffset.UtcNow;
        builder.HasData(
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 1, 
                PhysicalMemtypeName = "DDR", 
                PhysicalMemtypeDescription = "Double Data Rate SDRAM - First generation DDR memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 2, 
                PhysicalMemtypeName = "DDR2", 
                PhysicalMemtypeDescription = "Double Data Rate 2 SDRAM - Improved speed and efficiency over DDR",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 3, 
                PhysicalMemtypeName = "DDR3", 
                PhysicalMemtypeDescription = "Double Data Rate 3 SDRAM - Standard desktop/server RAM 2007-2015",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 4, 
                PhysicalMemtypeName = "DDR4", 
                PhysicalMemtypeDescription = "Double Data Rate 4 SDRAM - Current standard desktop/server RAM",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 5, 
                PhysicalMemtypeName = "DDR5", 
                PhysicalMemtypeDescription = "Double Data Rate 5 SDRAM - Latest generation high-speed RAM",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 6, 
                PhysicalMemtypeName = "DDR3 SODIMM", 
                PhysicalMemtypeDescription = "Small Outline DDR3 module for laptops and compact systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 7, 
                PhysicalMemtypeName = "DDR4 SODIMM", 
                PhysicalMemtypeDescription = "Small Outline DDR4 module for laptops and compact systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 8, 
                PhysicalMemtypeName = "DDR5 SODIMM", 
                PhysicalMemtypeDescription = "Small Outline DDR5 module for laptops and compact systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 9, 
                PhysicalMemtypeName = "DDR3L", 
                PhysicalMemtypeDescription = "Low voltage DDR3 SDRAM (1.35V) for energy efficiency",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 10, 
                PhysicalMemtypeName = "DDR3L SODIMM", 
                PhysicalMemtypeDescription = "Low voltage DDR3 SODIMM for mobile devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 11, 
                PhysicalMemtypeName = "DDR4L", 
                PhysicalMemtypeDescription = "Low voltage DDR4 SDRAM (1.2V) for energy efficiency",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 12, 
                PhysicalMemtypeName = "ECC DDR3", 
                PhysicalMemtypeDescription = "Error-Correcting Code DDR3 for servers and workstations",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 13, 
                PhysicalMemtypeName = "ECC DDR4", 
                PhysicalMemtypeDescription = "Error-Correcting Code DDR4 for servers and workstations",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 14, 
                PhysicalMemtypeName = "ECC DDR5", 
                PhysicalMemtypeDescription = "Error-Correcting Code DDR5 for servers and workstations",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 15, 
                PhysicalMemtypeName = "Registered DDR3", 
                PhysicalMemtypeDescription = "Buffered DDR3 for high-capacity server configurations",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 16, 
                PhysicalMemtypeName = "Registered DDR4", 
                PhysicalMemtypeDescription = "Buffered DDR4 for high-capacity server configurations",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 17, 
                PhysicalMemtypeName = "Registered DDR5", 
                PhysicalMemtypeDescription = "Buffered DDR5 for high-capacity server configurations",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 18, 
                PhysicalMemtypeName = "Load-Reduced DDR4", 
                PhysicalMemtypeDescription = "LR-DIMM DDR4 for maximum density server memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 19, 
                PhysicalMemtypeName = "Load-Reduced DDR5", 
                PhysicalMemtypeDescription = "LR-DIMM DDR5 for maximum density server memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 20, 
                PhysicalMemtypeName = "SDRAM", 
                PhysicalMemtypeDescription = "Synchronous Dynamic RAM - Legacy memory type",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 21, 
                PhysicalMemtypeName = "EDO RAM", 
                PhysicalMemtypeDescription = "Extended Data Out RAM - Obsolete legacy memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 22, 
                PhysicalMemtypeName = "FPM RAM", 
                PhysicalMemtypeDescription = "Fast Page Mode RAM - Obsolete legacy memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 23, 
                PhysicalMemtypeName = "GDDR5", 
                PhysicalMemtypeDescription = "Graphics DDR5 - Specialized memory for graphics cards",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 24, 
                PhysicalMemtypeName = "GDDR6", 
                PhysicalMemtypeDescription = "Graphics DDR6 - High-speed graphics card memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 25, 
                PhysicalMemtypeName = "GDDR6X", 
                PhysicalMemtypeDescription = "Graphics DDR6X - Enhanced graphics memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 26, 
                PhysicalMemtypeName = "HBM2", 
                PhysicalMemtypeDescription = "High Bandwidth Memory 2 - Stacked memory for GPUs",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 27, 
                PhysicalMemtypeName = "HBM2e", 
                PhysicalMemtypeDescription = "High Bandwidth Memory 2e - Enhanced HBM2",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 28, 
                PhysicalMemtypeName = "HBM3", 
                PhysicalMemtypeDescription = "High Bandwidth Memory 3 - Latest high-performance stacked memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 29, 
                PhysicalMemtypeName = "LPDDR3", 
                PhysicalMemtypeDescription = "Low Power DDR3 - Mobile device optimized memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 30, 
                PhysicalMemtypeName = "LPDDR4", 
                PhysicalMemtypeDescription = "Low Power DDR4 - Smartphone and tablet memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 31, 
                PhysicalMemtypeName = "LPDDR4X", 
                PhysicalMemtypeDescription = "Low Power DDR4X - Enhanced efficiency mobile memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 32, 
                PhysicalMemtypeName = "LPDDR5", 
                PhysicalMemtypeDescription = "Low Power DDR5 - Latest generation mobile memory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new PhysicalMemoryType 
            { 
                PhysicalMemtypeId = 33, 
                PhysicalMemtypeName = "LPDDR5X", 
                PhysicalMemtypeDescription = "Low Power DDR5X - Enhanced LPDDR5 for flagship devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            }
        );
    }
}