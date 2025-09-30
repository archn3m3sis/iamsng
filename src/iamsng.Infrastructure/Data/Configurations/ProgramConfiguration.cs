using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Program entity.
/// Configures DoD program management structure with optimized Asset queries.
/// </summary>
public class ProgramConfiguration : IEntityTypeConfiguration<Program>
{
    public void Configure(EntityTypeBuilder<Program> builder)
    {
        // Table configuration
        builder.ToTable("program", t =>
        {
            t.HasComment("DoD programs that own/manage industrial assets");
        });

        // Primary Key
        builder.HasKey(p => p.ProgramId)
            .HasName("PK_program");

        // Properties
        builder.Property(p => p.ProgramId)
            .HasColumnName("program_id")
            .UseIdentityColumn();

        builder.Property(p => p.ProgramName)
            .HasColumnName("program_name")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("Current program name");

        builder.Property(p => p.LegacyProgramName)
            .HasColumnName("legacy_program_name")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("Historical/legacy program name");

        builder.Property(p => p.ProgramManagerId)
            .HasColumnName("program_manager")
            .HasComment("User ID of program manager (nullable until data available)");

        // Relationships
        builder.HasOne(p => p.ProgramManager)
            .WithMany()
            .HasForeignKey(p => p.ProgramManagerId)
            .OnDelete(DeleteBehavior.SetNull)
            .HasConstraintName("FK_program_manager_user");

        // Indexes
        builder.HasIndex(p => p.ProgramName)
            .IsUnique()
            .HasDatabaseName("UX_program_name"); // Unique index on program name

        builder.HasIndex(p => p.LegacyProgramName)
            .HasDatabaseName("IX_program_legacy_name"); // Index for searching by legacy name

        // Optimized index for Asset queries (will be used when Asset.ProgramId is queried)
        builder.HasIndex(p => p.ProgramId)
            .IncludeProperties(p => new { p.ProgramName, p.LegacyProgramName })
            .HasDatabaseName("IX_program_asset_lookup"); // Covering index for efficient Asset->Program lookups

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            new Program 
            { 
                ProgramId = 1, 
                ProgramName = "IFMC",
                LegacyProgramName = "Patriot",
                ProgramManagerId = null,
                CreatedAt = createdAt,
                CreatedBy = 1, // SYSTEM user
                Version = 1
            },
            new Program 
            { 
                ProgramId = 2, 
                ProgramName = "STORM",
                LegacyProgramName = "Himars",
                ProgramManagerId = null,
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Program 
            { 
                ProgramId = 3, 
                ProgramName = "TAGM",
                LegacyProgramName = "TOW", // Uppercase per requirement
                ProgramManagerId = null,
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Program 
            { 
                ProgramId = 4, 
                ProgramName = "SHIELD",
                LegacyProgramName = "Avenger",
                ProgramManagerId = null,
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Program 
            { 
                ProgramId = 5, 
                ProgramName = "MULTI",
                LegacyProgramName = "MULTI", // Uppercase per requirement
                ProgramManagerId = null,
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new Program 
            { 
                ProgramId = 6, 
                ProgramName = "STARE",
                LegacyProgramName = "Sentinel",
                ProgramManagerId = null,
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            }
        );
    }
}