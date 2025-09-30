using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for SoftwareManufacturer entity.
/// Configures software manufacturers with production focus for software asset tracking.
/// </summary>
public class SoftwareManufacturerConfiguration : IEntityTypeConfiguration<SoftwareManufacturer>
{
    public void Configure(EntityTypeBuilder<SoftwareManufacturer> builder)
    {
        // Table configuration
        builder.ToTable("software_manufacturer", t =>
        {
            t.HasComment("Software manufacturers and vendors with production focus for software asset management");
        });

        // Primary Key
        builder.HasKey(s => s.SoftwareManufacturerId)
            .HasName("PK_software_manufacturer");

        // Properties
        builder.Property(s => s.SoftwareManufacturerId)
            .HasColumnName("software_manufacturer_id")
            .UseIdentityColumn();

        builder.Property(s => s.SoftwareManufacturerName)
            .HasColumnName("software_manufacturer_name")
            .HasMaxLength(200)
            .IsRequired()
            .HasComment("Name of the software manufacturer or vendor");

        builder.Property(s => s.ProductionFocus)
            .HasColumnName("swmanu_production_focus")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Primary production focus or specialization");

        builder.Property(s => s.IconFile)
            .HasColumnName("swmanu_icon_file")
            .HasMaxLength(255)
            .HasComment("Filename of manufacturer icon/logo in wwwroot/images/sw_manufacturers/");

        // Indexes
        builder.HasIndex(s => s.SoftwareManufacturerName)
            .HasDatabaseName("IX_software_manufacturer_name");

        builder.HasIndex(s => s.ProductionFocus)
            .HasDatabaseName("IX_software_manufacturer_focus");

        // Composite index for searching by name and focus
        builder.HasIndex(s => new { s.SoftwareManufacturerName, s.ProductionFocus })
            .HasDatabaseName("IX_software_manufacturer_name_focus");

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data - Use helper class to get all software manufacturers
        builder.HasData(SoftwareManufacturerSeedData.GetAllSeedData());
    }
}