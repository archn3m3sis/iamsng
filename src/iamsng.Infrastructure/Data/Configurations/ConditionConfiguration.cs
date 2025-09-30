using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Condition entity.
/// Configures asset condition states for lifecycle tracking.
/// </summary>
public class ConditionConfiguration : IEntityTypeConfiguration<Condition>
{
    public void Configure(EntityTypeBuilder<Condition> builder)
    {
        // Table configuration
        builder.ToTable("condition", t =>
        {
            t.HasComment("Asset condition states for lifecycle and maintenance tracking");
        });

        // Primary Key
        builder.HasKey(c => c.ConditionId)
            .HasName("PK_condition");

        // Properties
        builder.Property(c => c.ConditionId)
            .HasColumnName("condition_id")
            .UseIdentityColumn();

        builder.Property(c => c.ConditionName)
            .HasColumnName("condition_name")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("Name or label of the condition state");

        builder.Property(c => c.ConditionDescription)
            .HasColumnName("condition_description")
            .HasMaxLength(500)
            .HasComment("Detailed description of what this condition means");

        // Indexes
        builder.HasIndex(c => c.ConditionName)
            .HasDatabaseName("IX_condition_name")
            .IsUnique();

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var seedDate = DateTimeOffset.UtcNow;
        builder.HasData(
            new Condition 
            { 
                ConditionId = 1, 
                ConditionName = "New", 
                ConditionDescription = "Device is brand new, unused, and in original packaging",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 2, 
                ConditionName = "Excellent", 
                ConditionDescription = "Device is in like-new condition with no visible wear or defects",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 3, 
                ConditionName = "Good", 
                ConditionDescription = "Device is fully functional with minor cosmetic wear but no operational issues",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 4, 
                ConditionName = "Fair", 
                ConditionDescription = "Device is functional but shows moderate wear or has minor non-critical issues",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 5, 
                ConditionName = "Poor", 
                ConditionDescription = "Device has significant wear or operational issues but remains usable",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 6, 
                ConditionName = "Non-Functional", 
                ConditionDescription = "Device is not operational and requires repair or replacement",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 7, 
                ConditionName = "Under Repair", 
                ConditionDescription = "Device is currently being serviced or repaired",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 8, 
                ConditionName = "Awaiting Disposal", 
                ConditionDescription = "Device has been marked for disposal or decommissioning",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 9, 
                ConditionName = "Disposed", 
                ConditionDescription = "Device has been properly disposed of or decommissioned",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 10, 
                ConditionName = "Missing", 
                ConditionDescription = "Device cannot be located and is considered missing from inventory",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 11, 
                ConditionName = "Damaged", 
                ConditionDescription = "Device has physical damage affecting functionality or safety",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new Condition 
            { 
                ConditionId = 12, 
                ConditionName = "Obsolete", 
                ConditionDescription = "Device is outdated and no longer supported for operational use",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            }
        );
    }
}