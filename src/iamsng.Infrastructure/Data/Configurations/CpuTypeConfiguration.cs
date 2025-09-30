using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for CpuType entity.
/// Configures CPU types from various manufacturers for hardware asset specifications.
/// </summary>
public class CpuTypeConfiguration : IEntityTypeConfiguration<CpuType>
{
    public void Configure(EntityTypeBuilder<CpuType> builder)
    {
        // Table configuration
        builder.ToTable("cpu_type", t =>
        {
            t.HasComment("CPU types and models from various manufacturers");
        });

        // Primary Key
        builder.HasKey(c => c.CpuTypeId)
            .HasName("PK_cpu_type");

        // Properties
        builder.Property(c => c.CpuTypeId)
            .HasColumnName("cpu_type_id")
            .UseIdentityColumn();

        builder.Property(c => c.CpuTypeName)
            .HasColumnName("cpu_type_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name or designation of the CPU model/series");

        builder.Property(c => c.HardwareManufacturerId)
            .HasColumnName("hardware_manufacturer_id")
            .IsRequired()
            .HasComment("Foreign key to hardware_manufacturer table");

        // Relationships
        builder.HasOne(c => c.HardwareManufacturer)
            .WithMany()
            .HasForeignKey(c => c.HardwareManufacturerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_cpu_type_hardware_manufacturer");

        // Indexes
        builder.HasIndex(c => c.CpuTypeName)
            .HasDatabaseName("IX_cpu_type_name");

        builder.HasIndex(c => c.HardwareManufacturerId)
            .HasDatabaseName("IX_cpu_type_manufacturer");

        // Composite index for searching by name and manufacturer
        builder.HasIndex(c => new { c.CpuTypeName, c.HardwareManufacturerId })
            .HasDatabaseName("IX_cpu_type_name_manufacturer");

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data - Use helper class to get all CPU types
        builder.HasData(CpuTypeSeedData.GetAllSeedData());
    }
}