using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for Role entity.
/// Implements RBAC for DoD compliance.
/// </summary>
public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        // Table configuration
        builder.ToTable("role", t =>
        {
            t.HasComment("User roles for RBAC implementation - DoD compliant");
        });

        // Primary Key
        builder.HasKey(r => r.RoleId)
            .HasName("PK_role");

        // Properties
        builder.Property(r => r.RoleId)
            .HasColumnName("role_id")
            .UseIdentityColumn();

        builder.Property(r => r.RoleName)
            .HasColumnName("role_name")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("Unique role name for the system");

        // Audit fields are inherited from BaseEntity and already mapped

        // Indexes
        builder.HasIndex(r => r.RoleName)
            .IsUnique()
            .HasDatabaseName("UX_role_name");

        // Seed data for initial roles
        builder.HasData(
            new Role 
            { 
                RoleId = 1, 
                RoleName = "system",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1, // SYSTEM user
                Version = 1
            },
            new Role 
            { 
                RoleId = 2, 
                RoleName = "cyber_user",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            },
            new Role 
            { 
                RoleId = 3, 
                RoleName = "tem_user",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            },
            new Role 
            { 
                RoleId = 4, 
                RoleName = "dev_user",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            },
            new Role 
            { 
                RoleId = 5, 
                RoleName = "cyber_mgr",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            },
            new Role 
            { 
                RoleId = 6, 
                RoleName = "tem_mgr",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            },
            new Role 
            { 
                RoleId = 7, 
                RoleName = "org_mgr",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            },
            new Role 
            { 
                RoleId = 8, 
                RoleName = "sys_admin",
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = 1,
                Version = 1
            }
        );
    }
}