using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for HardwareManufacturer entity.
/// Configures hardware manufacturers with production focus for asset tracking.
/// </summary>
public class HardwareManufacturerConfiguration : IEntityTypeConfiguration<HardwareManufacturer>
{
    public void Configure(EntityTypeBuilder<HardwareManufacturer> builder)
    {
        // Table configuration
        builder.ToTable("hardware_manufacturer", t =>
        {
            t.HasComment("Hardware manufacturers and vendors with production focus for asset management");
        });

        // Primary Key
        builder.HasKey(h => h.HardwareManufacturerId)
            .HasName("PK_hardware_manufacturer");

        // Properties
        builder.Property(h => h.HardwareManufacturerId)
            .HasColumnName("hardware_manufacturer_id")
            .UseIdentityColumn();

        builder.Property(h => h.HardwareManufacturerName)
            .HasColumnName("hardware_manufacturer_name")
            .HasMaxLength(200)
            .IsRequired()
            .HasComment("Name of the hardware manufacturer or vendor");

        builder.Property(h => h.ProductionFocus)
            .HasColumnName("hwmanu_production_focus")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Primary production focus or specialization");

        builder.Property(h => h.IconFile)
            .HasColumnName("hwmanu_icon_file")
            .HasMaxLength(255)
            .HasComment("Filename of manufacturer icon/logo in wwwroot/images/hw_manufacturers/");

        // Indexes
        builder.HasIndex(h => h.HardwareManufacturerName)
            .HasDatabaseName("IX_hardware_manufacturer_name");

        builder.HasIndex(h => h.ProductionFocus)
            .HasDatabaseName("IX_hardware_manufacturer_focus");

        // Composite index for searching by name and focus
        builder.HasIndex(h => new { h.HardwareManufacturerName, h.ProductionFocus })
            .HasDatabaseName("IX_hardware_manufacturer_name_focus");

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data - 159 hardware manufacturers
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        builder.HasData(
            // Computing Hardware (1-15)
            new HardwareManufacturer { HardwareManufacturerId = 1, HardwareManufacturerName = "Dell Technologies (Dell, EMC)", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 2, HardwareManufacturerName = "Hewlett Packard Enterprise (HPE)", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 3, HardwareManufacturerName = "HP Inc.", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 4, HardwareManufacturerName = "Lenovo (ThinkPad, ThinkStation)", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 5, HardwareManufacturerName = "IBM", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 6, HardwareManufacturerName = "Supermicro", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 7, HardwareManufacturerName = "Fujitsu", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 8, HardwareManufacturerName = "NEC", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 9, HardwareManufacturerName = "Acer", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 10, HardwareManufacturerName = "ASUS", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 11, HardwareManufacturerName = "MSI", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 12, HardwareManufacturerName = "Gigabyte", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 13, HardwareManufacturerName = "Origin PC", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 14, HardwareManufacturerName = "System76", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 15, HardwareManufacturerName = "Puget Systems", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Networking Hardware (16-35)
            new HardwareManufacturer { HardwareManufacturerId = 16, HardwareManufacturerName = "Cisco Systems", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 17, HardwareManufacturerName = "Juniper Networks", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 18, HardwareManufacturerName = "Aruba Networks (HPE)", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 19, HardwareManufacturerName = "Fortinet", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 20, HardwareManufacturerName = "Palo Alto Networks", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 21, HardwareManufacturerName = "Check Point", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 22, HardwareManufacturerName = "Extreme Networks", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 23, HardwareManufacturerName = "Ruckus Networks", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 24, HardwareManufacturerName = "Ubiquiti", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 25, HardwareManufacturerName = "Netgear", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 26, HardwareManufacturerName = "D-Link", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 27, HardwareManufacturerName = "TP-Link", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 28, HardwareManufacturerName = "Linksys", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 29, HardwareManufacturerName = "Mikrotik", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 30, HardwareManufacturerName = "Cambium Networks", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 31, HardwareManufacturerName = "Huawei", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 32, HardwareManufacturerName = "ZTE", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 33, HardwareManufacturerName = "Nokia", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 34, HardwareManufacturerName = "Ericsson", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 35, HardwareManufacturerName = "F5 Networks", ProductionFocus = "Networking Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Storage Solutions (36-50)
            new HardwareManufacturer { HardwareManufacturerId = 36, HardwareManufacturerName = "NetApp", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 37, HardwareManufacturerName = "Pure Storage", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 38, HardwareManufacturerName = "Dell EMC", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 39, HardwareManufacturerName = "HPE (Nimble, 3PAR)", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 40, HardwareManufacturerName = "IBM (FlashSystem)", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 41, HardwareManufacturerName = "Hitachi Vantara", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 42, HardwareManufacturerName = "Western Digital", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 43, HardwareManufacturerName = "Seagate Technology", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 44, HardwareManufacturerName = "QNAP", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 45, HardwareManufacturerName = "Synology", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 46, HardwareManufacturerName = "Drobo", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 47, HardwareManufacturerName = "Promise Technology", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 48, HardwareManufacturerName = "Quantum Corporation", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 49, HardwareManufacturerName = "Spectra Logic", ProductionFocus = "Storage Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Processors & Components (50-62)
            new HardwareManufacturer { HardwareManufacturerId = 50, HardwareManufacturerName = "Intel", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 51, HardwareManufacturerName = "AMD", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 52, HardwareManufacturerName = "NVIDIA", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 53, HardwareManufacturerName = "Qualcomm", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 54, HardwareManufacturerName = "Broadcom", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 55, HardwareManufacturerName = "Marvell", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 56, HardwareManufacturerName = "MediaTek", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 57, HardwareManufacturerName = "ARM Holdings", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 58, HardwareManufacturerName = "Texas Instruments", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 59, HardwareManufacturerName = "Analog Devices", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 60, HardwareManufacturerName = "Microchip Technology", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 61, HardwareManufacturerName = "NXP Semiconductors", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 62, HardwareManufacturerName = "Infineon Technologies", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Memory & Flash Storage (63-72)
            new HardwareManufacturer { HardwareManufacturerId = 63, HardwareManufacturerName = "Samsung", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 64, HardwareManufacturerName = "SK Hynix", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 65, HardwareManufacturerName = "Micron Technology", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 66, HardwareManufacturerName = "Kingston Technology", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 67, HardwareManufacturerName = "Corsair", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 68, HardwareManufacturerName = "G.Skill", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 69, HardwareManufacturerName = "Crucial (Micron)", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 70, HardwareManufacturerName = "ADATA", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 71, HardwareManufacturerName = "SanDisk (Western Digital)", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 72, HardwareManufacturerName = "Toshiba Memory (Kioxia)", ProductionFocus = "Memory & Flash Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Mobile Hardware (73-84)
            new HardwareManufacturer { HardwareManufacturerId = 73, HardwareManufacturerName = "Apple", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 74, HardwareManufacturerName = "Samsung", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 75, HardwareManufacturerName = "Google (Pixel)", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 76, HardwareManufacturerName = "OnePlus", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 77, HardwareManufacturerName = "Xiaomi", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 78, HardwareManufacturerName = "Huawei", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 79, HardwareManufacturerName = "Oppo", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 80, HardwareManufacturerName = "Vivo", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 81, HardwareManufacturerName = "Motorola", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 82, HardwareManufacturerName = "LG (discontinued)", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 83, HardwareManufacturerName = "Sony", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 84, HardwareManufacturerName = "HTC", ProductionFocus = "Mobile Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Industrial/IoT Hardware (85-104)
            new HardwareManufacturer { HardwareManufacturerId = 85, HardwareManufacturerName = "Siemens", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 86, HardwareManufacturerName = "Schneider Electric", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 87, HardwareManufacturerName = "Rockwell Automation", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 88, HardwareManufacturerName = "Honeywell", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 89, HardwareManufacturerName = "General Electric (GE)", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 90, HardwareManufacturerName = "ABB", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 91, HardwareManufacturerName = "Emerson", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 92, HardwareManufacturerName = "Yokogawa", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 93, HardwareManufacturerName = "Omron", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 94, HardwareManufacturerName = "Mitsubishi Electric", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 95, HardwareManufacturerName = "Fanuc", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 96, HardwareManufacturerName = "Phoenix Contact", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 97, HardwareManufacturerName = "Wago", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 98, HardwareManufacturerName = "Beckhoff", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 99, HardwareManufacturerName = "B&R Automation", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 100, HardwareManufacturerName = "Advantech", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 101, HardwareManufacturerName = "Moxa", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 102, HardwareManufacturerName = "Digi International", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 103, HardwareManufacturerName = "Sierra Wireless", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 104, HardwareManufacturerName = "Telit", ProductionFocus = "Industrial/IoT Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Security Hardware (105-114)
            new HardwareManufacturer { HardwareManufacturerId = 105, HardwareManufacturerName = "RSA Security", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 106, HardwareManufacturerName = "Thales Group", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 107, HardwareManufacturerName = "Gemalto (Thales)", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 108, HardwareManufacturerName = "SafeNet (Thales)", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 109, HardwareManufacturerName = "Yubico", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 110, HardwareManufacturerName = "SonicWall", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 111, HardwareManufacturerName = "WatchGuard", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 112, HardwareManufacturerName = "Barracuda Networks", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 113, HardwareManufacturerName = "Imperva", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 114, HardwareManufacturerName = "A10 Networks", ProductionFocus = "Security Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Display Hardware (115-128)
            new HardwareManufacturer { HardwareManufacturerId = 115, HardwareManufacturerName = "Samsung Display", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 116, HardwareManufacturerName = "LG Display", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 117, HardwareManufacturerName = "Sony", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 118, HardwareManufacturerName = "Sharp", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 119, HardwareManufacturerName = "Panasonic", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 120, HardwareManufacturerName = "ViewSonic", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 121, HardwareManufacturerName = "BenQ", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 122, HardwareManufacturerName = "AOC", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 123, HardwareManufacturerName = "Acer", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 124, HardwareManufacturerName = "ASUS", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 125, HardwareManufacturerName = "Dell", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 126, HardwareManufacturerName = "HP", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 127, HardwareManufacturerName = "Eizo", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 128, HardwareManufacturerName = "NEC Display", ProductionFocus = "Display Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Power & Infrastructure (129-139)
            new HardwareManufacturer { HardwareManufacturerId = 129, HardwareManufacturerName = "APC (Schneider Electric)", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 130, HardwareManufacturerName = "Eaton", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 131, HardwareManufacturerName = "Vertiv (Liebert)", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 132, HardwareManufacturerName = "Tripp Lite", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 133, HardwareManufacturerName = "CyberPower", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 134, HardwareManufacturerName = "Rittal", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 135, HardwareManufacturerName = "Panduit", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 136, HardwareManufacturerName = "Legrand", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 137, HardwareManufacturerName = "Raritan", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 138, HardwareManufacturerName = "Server Technology", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 139, HardwareManufacturerName = "Chatsworth Products", ProductionFocus = "Power & Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Peripherals & Accessories (140-154)
            new HardwareManufacturer { HardwareManufacturerId = 140, HardwareManufacturerName = "Logitech", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 141, HardwareManufacturerName = "Microsoft", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 142, HardwareManufacturerName = "Razer", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 143, HardwareManufacturerName = "Corsair", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 144, HardwareManufacturerName = "SteelSeries", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 145, HardwareManufacturerName = "HyperX", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 146, HardwareManufacturerName = "Audio-Technica", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 147, HardwareManufacturerName = "Sennheiser", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 148, HardwareManufacturerName = "Plantronics (Poly)", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 149, HardwareManufacturerName = "Jabra", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 150, HardwareManufacturerName = "Wacom", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 151, HardwareManufacturerName = "Epson", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 152, HardwareManufacturerName = "Canon", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 153, HardwareManufacturerName = "Brother", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 154, HardwareManufacturerName = "Xerox", ProductionFocus = "Peripherals & Accessories", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Specialized & Emerging Tech (155-165)
            new HardwareManufacturer { HardwareManufacturerId = 155, HardwareManufacturerName = "Tesla (automotive tech)", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 156, HardwareManufacturerName = "SpaceX (aerospace)", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 157, HardwareManufacturerName = "Boston Dynamics (robotics)", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 158, HardwareManufacturerName = "Magic Leap (AR/VR)", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 159, HardwareManufacturerName = "Oculus (Meta)", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 160, HardwareManufacturerName = "HTC Vive", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 161, HardwareManufacturerName = "Varjo", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 162, HardwareManufacturerName = "3D Systems", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 163, HardwareManufacturerName = "Stratasys", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 164, HardwareManufacturerName = "Formlabs", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 165, HardwareManufacturerName = "MakerBot", ProductionFocus = "Specialized & Emerging Tech", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 166, HardwareManufacturerName = "Matrox", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 167, HardwareManufacturerName = "Oracle", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 168, HardwareManufacturerName = "Amazon (AWS)", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 169, HardwareManufacturerName = "Loongson", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 170, HardwareManufacturerName = "Zhaoxin", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 171, HardwareManufacturerName = "VIA Technologies", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 172, HardwareManufacturerName = "Phytium", ProductionFocus = "Processors & Components", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Additional motherboard manufacturers
            new HardwareManufacturer { HardwareManufacturerId = 173, HardwareManufacturerName = "ASRock", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 174, HardwareManufacturerName = "Tyan", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 175, HardwareManufacturerName = "Biostar", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new HardwareManufacturer { HardwareManufacturerId = 176, HardwareManufacturerName = "ECS", ProductionFocus = "Computing Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 }
        );
    }
}