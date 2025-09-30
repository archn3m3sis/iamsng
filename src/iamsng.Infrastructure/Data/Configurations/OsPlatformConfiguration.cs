using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for OsPlatform entity.
/// Configures operating system platforms and families.
/// </summary>
public class OsPlatformConfiguration : IEntityTypeConfiguration<OsPlatform>
{
    public void Configure(EntityTypeBuilder<OsPlatform> builder)
    {
        // Table configuration
        builder.ToTable("os_platform", t =>
        {
            t.HasComment("Operating system platforms and families for software categorization");
        });

        // Primary Key
        builder.HasKey(o => o.OsPlatformId)
            .HasName("PK_os_platform");

        // Properties
        builder.Property(o => o.OsPlatformId)
            .HasColumnName("os_platform_id")
            .UseIdentityColumn();

        builder.Property(o => o.OsPlatformName)
            .HasColumnName("os_platform_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name of the operating system platform or family");

        builder.Property(o => o.OsPlatformDescription)
            .HasColumnName("os_platform_description")
            .HasMaxLength(500)
            .HasComment("Description of the platform and its primary use cases");

        // Indexes
        builder.HasIndex(o => o.OsPlatformName)
            .HasDatabaseName("IX_os_platform_name")
            .IsUnique();

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data - Use helper class to get all OS platforms
        builder.HasData(OsPlatformSeedData.GetAllSeedData());
    }
}