using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for SmeRole entity.
/// Defines Subject Matter Expert specializations for DoD operations.
/// </summary>
public class SmeRoleConfiguration : IEntityTypeConfiguration<SmeRole>
{
    public void Configure(EntityTypeBuilder<SmeRole> builder)
    {
        // Table configuration
        builder.ToTable("sme_role", t =>
        {
            t.HasComment("Subject Matter Expert roles for specialized expertise designation");
        });

        // Primary Key
        builder.HasKey(s => s.SmeRoleId)
            .HasName("PK_sme_role");

        // Properties
        builder.Property(s => s.SmeRoleId)
            .HasColumnName("smerole_id")
            .UseIdentityColumn();

        builder.Property(s => s.SmeRoleName)
            .HasColumnName("smerole_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Unique SME role/specialization name");

        // Audit fields are inherited from BaseEntity and already mapped

        // Indexes
        builder.HasIndex(s => s.SmeRoleName)
            .IsUnique()
            .HasDatabaseName("UX_sme_role_name");

        // Seed data for initial SME roles
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            new SmeRole 
            { 
                SmeRoleId = 1, 
                SmeRoleName = "Change Management Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1, // SYSTEM user
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 2, 
                SmeRoleName = "Vulnerability Management Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 3, 
                SmeRoleName = "Access Control Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 4, 
                SmeRoleName = "Risk Management Framework Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 5, 
                SmeRoleName = "Database Management Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 6, 
                SmeRoleName = "SAN Environment & Virtualization Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 7, 
                SmeRoleName = "Linux Environment Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 8, 
                SmeRoleName = "Windows Environment Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            },
            new SmeRole 
            { 
                SmeRoleId = 9, 
                SmeRoleName = "Legacy Environment Specialist",
                CreatedAt = createdAt,
                CreatedBy = 1,
                Version = 1
            }
        );
    }
}