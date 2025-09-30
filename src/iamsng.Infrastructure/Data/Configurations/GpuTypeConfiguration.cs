using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for GpuType entity.
/// Configures GPU types from various manufacturers for hardware asset specifications.
/// </summary>
public class GpuTypeConfiguration : IEntityTypeConfiguration<GpuType>
{
    public void Configure(EntityTypeBuilder<GpuType> builder)
    {
        // Table configuration
        builder.ToTable("gpu_types", t =>
        {
            t.HasComment("GPU types and models from various manufacturers");
        });

        // Primary Key
        builder.HasKey(g => g.GpuTypeId)
            .HasName("PK_gpu_types");

        // Properties
        builder.Property(g => g.GpuTypeId)
            .HasColumnName("gpu_type_id")
            .UseIdentityColumn();

        builder.Property(g => g.GpuTypeName)
            .HasColumnName("gpu_type_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name or designation of the GPU model/series");

        builder.Property(g => g.HardwareManufacturerId)
            .HasColumnName("hardware_manufacturer_id")
            .IsRequired()
            .HasComment("Foreign key to hardware_manufacturer table");

        // Relationships
        builder.HasOne(g => g.HardwareManufacturer)
            .WithMany()
            .HasForeignKey(g => g.HardwareManufacturerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_gpu_types_hardware_manufacturer");

        // Indexes
        builder.HasIndex(g => g.GpuTypeName)
            .HasDatabaseName("IX_gpu_types_name");

        builder.HasIndex(g => g.HardwareManufacturerId)
            .HasDatabaseName("IX_gpu_types_manufacturer");

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var seedDate = DateTimeOffset.UtcNow;
        // Hardware Manufacturer IDs from existing seed data:
        // Intel: 50, AMD: 51, NVIDIA: 52
        builder.HasData(
            // NVIDIA GPUs (ID: 52)
            new GpuType { GpuTypeId = 1, GpuTypeName = "GeForce RTX 40 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 2, GpuTypeName = "GeForce RTX 30 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 3, GpuTypeName = "GeForce RTX 20 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 4, GpuTypeName = "GeForce GTX 16 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 5, GpuTypeName = "GeForce GTX 10 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 6, GpuTypeName = "GeForce GTX 900 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 7, GpuTypeName = "GeForce GTX 700 Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 8, GpuTypeName = "Quadro RTX Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 9, GpuTypeName = "Quadro P Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 10, GpuTypeName = "Quadro M Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 11, GpuTypeName = "Quadro K Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 12, GpuTypeName = "RTX A Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 13, GpuTypeName = "Tesla V100", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 14, GpuTypeName = "Tesla P100", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 15, GpuTypeName = "Tesla K80", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 16, GpuTypeName = "Tesla M Series", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 17, GpuTypeName = "A100 Tensor Core", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 18, GpuTypeName = "H100 Tensor Core", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 19, GpuTypeName = "L40S", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 20, GpuTypeName = "T4 Tensor Core", HardwareManufacturerId = 52, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // AMD GPUs (ID: 51)
            new GpuType { GpuTypeId = 21, GpuTypeName = "Radeon RX 7000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 22, GpuTypeName = "Radeon RX 6000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 23, GpuTypeName = "Radeon RX 5000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 24, GpuTypeName = "Radeon RX Vega Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 25, GpuTypeName = "Radeon RX 500 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 26, GpuTypeName = "Radeon RX 400 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 27, GpuTypeName = "Radeon Pro W7000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 28, GpuTypeName = "Radeon Pro W6000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 29, GpuTypeName = "Radeon Pro W5000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 30, GpuTypeName = "Radeon Pro WX Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 31, GpuTypeName = "Radeon Pro Vega Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 32, GpuTypeName = "FirePro W Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 33, GpuTypeName = "FirePro S Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 34, GpuTypeName = "Instinct MI300 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 35, GpuTypeName = "Instinct MI200 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 36, GpuTypeName = "Instinct MI100 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Intel GPUs (ID: 50)
            new GpuType { GpuTypeId = 37, GpuTypeName = "Arc A Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 38, GpuTypeName = "Iris Xe Graphics", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 39, GpuTypeName = "UHD Graphics 700 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 40, GpuTypeName = "UHD Graphics 600 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new GpuType { GpuTypeId = 41, GpuTypeName = "HD Graphics 500 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 }
        );
    }
}