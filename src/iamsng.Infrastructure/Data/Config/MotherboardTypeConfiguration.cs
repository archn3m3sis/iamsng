using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Config;

public class MotherboardTypeConfiguration : IEntityTypeConfiguration<MotherboardType>
{
    public void Configure(EntityTypeBuilder<MotherboardType> builder)
    {
        builder.HasKey(e => e.MoboTypeId);
        
        builder.HasIndex(e => e.MoboTypeName)
            .IsUnique()
            .HasDatabaseName("UX_motherboard_type_name");

        builder.HasOne(e => e.HardwareManufacturer)
            .WithMany()
            .HasForeignKey(e => e.HardwareManufacturerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed data for motherboard types
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        
        // Manufacturer IDs based on existing HardwareManufacturer table:
        // ASUS = 10, MSI = 11, Gigabyte = 12, ASRock = 173 (to be added)
        // Supermicro = 6, Dell = 1, HPE = 2, Lenovo = 4
        // Intel = 50, AMD = 51, Tyan = 174 (to be added), Biostar = 175 (to be added)
        // ECS = 176 (to be added), Fujitsu = 7, Cisco = 16
        
        var motherboards = new[]
        {
            // ASUS Motherboards (ID: 10)
            new { MoboTypeId = 1, MoboTypeName = "Z790 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 2, MoboTypeName = "Z690 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 3, MoboTypeName = "B760 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 4, MoboTypeName = "B660 Chipset Micro-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 5, MoboTypeName = "H770 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 6, MoboTypeName = "H610 Chipset Micro-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 7, MoboTypeName = "X670E Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 8, MoboTypeName = "X670 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 9, MoboTypeName = "B650E Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 10, MoboTypeName = "B650 Chipset Micro-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 11, MoboTypeName = "A620 Chipset Micro-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 12, MoboTypeName = "TRX50 Chipset E-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 13, MoboTypeName = "WRX90 Chipset E-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 14, MoboTypeName = "W680 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 15, MoboTypeName = "C621 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 16, MoboTypeName = "C246 Chipset Micro-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // MSI Motherboards (ID: 11) - using different names to avoid duplicates
            new { MoboTypeId = 17, MoboTypeName = "MSI Z790 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 18, MoboTypeName = "MSI Z690 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 19, MoboTypeName = "MSI B760 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 20, MoboTypeName = "MSI B660 Chipset Micro-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 21, MoboTypeName = "MSI H770 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 22, MoboTypeName = "MSI X670E Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 23, MoboTypeName = "MSI X670 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 24, MoboTypeName = "MSI B650E Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 25, MoboTypeName = "MSI B650 Chipset Micro-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 26, MoboTypeName = "MSI A620 Chipset Micro-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 27, MoboTypeName = "MSI TRX50 Chipset E-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 28, MoboTypeName = "MSI WRX90 Chipset E-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 29, MoboTypeName = "MSI C621 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Gigabyte Motherboards (ID: 12) - using different names to avoid duplicates
            new { MoboTypeId = 30, MoboTypeName = "Gigabyte Z790 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 31, MoboTypeName = "Gigabyte Z690 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 32, MoboTypeName = "Gigabyte B760 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 33, MoboTypeName = "Gigabyte B660 Chipset Micro-ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 34, MoboTypeName = "Gigabyte H770 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 35, MoboTypeName = "Gigabyte X670E Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 36, MoboTypeName = "Gigabyte X670 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 37, MoboTypeName = "Gigabyte B650E Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 38, MoboTypeName = "Gigabyte B650 Chipset Micro-ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 39, MoboTypeName = "Gigabyte A620 Chipset Micro-ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 40, MoboTypeName = "Gigabyte TRX50 Chipset E-ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 41, MoboTypeName = "Gigabyte WRX90 Chipset E-ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // ASRock Motherboards (ID: 173 - to be added) - temporarily using 10
            new { MoboTypeId = 42, MoboTypeName = "ASRock Z790 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 43, MoboTypeName = "ASRock Z690 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 44, MoboTypeName = "ASRock B760 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 45, MoboTypeName = "ASRock B660 Chipset Micro-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 46, MoboTypeName = "ASRock H770 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 47, MoboTypeName = "ASRock X670E Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 48, MoboTypeName = "ASRock X670 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 49, MoboTypeName = "ASRock B650E Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 50, MoboTypeName = "ASRock B650 Chipset Micro-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 51, MoboTypeName = "ASRock A620 Chipset Micro-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 52, MoboTypeName = "ASRock TRX50 Chipset E-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 53, MoboTypeName = "ASRock WRX90 Chipset E-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Supermicro Motherboards (ID: 6)
            new { MoboTypeId = 54, MoboTypeName = "X11 Series LGA3647 ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 55, MoboTypeName = "X12 Series LGA4189 ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 56, MoboTypeName = "X13 Series LGA4677 ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 57, MoboTypeName = "H11 Series SP3 ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 58, MoboTypeName = "H12 Series SP3 ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 59, MoboTypeName = "H13 Series SP5 ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 60, MoboTypeName = "A2 Series ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 61, MoboTypeName = "M11 Series Micro-ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 62, MoboTypeName = "M12 Series Micro-ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 63, MoboTypeName = "X11DPi-N Dual Socket", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 64, MoboTypeName = "X12DPi-N6 Dual Socket", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 65, MoboTypeName = "H11DSi Dual Socket EPYC", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 66, MoboTypeName = "H12DSi Dual Socket EPYC", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Dell Motherboards (ID: 1)
            new { MoboTypeId = 67, MoboTypeName = "PowerEdge R740 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 68, MoboTypeName = "PowerEdge R750 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 69, MoboTypeName = "PowerEdge R760 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 70, MoboTypeName = "PowerEdge R640 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 71, MoboTypeName = "PowerEdge R650 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 72, MoboTypeName = "PowerEdge T550 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 73, MoboTypeName = "Precision 7920 Workstation Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 74, MoboTypeName = "Precision 7960 Workstation Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 75, MoboTypeName = "OptiPlex 7010 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 76, MoboTypeName = "OptiPlex 7090 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 77, MoboTypeName = "Latitude 5430 System Board", HardwareManufacturerId = 1, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // HPE Motherboards (ID: 2)
            new { MoboTypeId = 78, MoboTypeName = "ProLiant DL380 Gen10 System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 79, MoboTypeName = "ProLiant DL380 Gen10 Plus System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 80, MoboTypeName = "ProLiant DL360 Gen10 System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 81, MoboTypeName = "ProLiant DL360 Gen10 Plus System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 82, MoboTypeName = "ProLiant ML350 Gen10 System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 83, MoboTypeName = "ProLiant DL580 Gen10 System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 84, MoboTypeName = "Z8 G4 Workstation Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 85, MoboTypeName = "Z6 G5 Workstation Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 86, MoboTypeName = "EliteDesk 800 G9 System Board", HardwareManufacturerId = 2, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Lenovo Motherboards (ID: 4)
            new { MoboTypeId = 87, MoboTypeName = "ThinkSystem SR650 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 88, MoboTypeName = "ThinkSystem SR850 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 89, MoboTypeName = "ThinkSystem SR950 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 90, MoboTypeName = "ThinkSystem ST650 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 91, MoboTypeName = "ThinkStation P620 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 92, MoboTypeName = "ThinkStation P920 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 93, MoboTypeName = "ThinkStation P360 System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 94, MoboTypeName = "ThinkCentre M90a System Board", HardwareManufacturerId = 4, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Additional ASUS boards from bottom of list
            new { MoboTypeId = 95, MoboTypeName = "Z590 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 96, MoboTypeName = "Z490 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 97, MoboTypeName = "X570 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 98, MoboTypeName = "X470 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 99, MoboTypeName = "B550 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 100, MoboTypeName = "B450 Chipset Micro-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Additional MSI boards
            new { MoboTypeId = 101, MoboTypeName = "MSI Z590 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 102, MoboTypeName = "MSI Z490 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 103, MoboTypeName = "MSI X570 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 104, MoboTypeName = "MSI X470 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 105, MoboTypeName = "MSI B550 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 106, MoboTypeName = "MSI B450 Chipset Micro-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Additional Gigabyte boards
            new { MoboTypeId = 107, MoboTypeName = "Gigabyte Z590 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 108, MoboTypeName = "Gigabyte Z490 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 109, MoboTypeName = "Gigabyte X570 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 110, MoboTypeName = "Gigabyte B550 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Additional ASRock boards
            new { MoboTypeId = 111, MoboTypeName = "ASRock Z590 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 112, MoboTypeName = "ASRock Z490 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 113, MoboTypeName = "ASRock X570 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 114, MoboTypeName = "ASRock B550 Chipset ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Mini-ITX boards
            new { MoboTypeId = 115, MoboTypeName = "Mini-ITX Z790", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 116, MoboTypeName = "Mini-ITX Z690", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 117, MoboTypeName = "Mini-ITX B650", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 118, MoboTypeName = "Mini-ITX X670", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 119, MoboTypeName = "MSI Mini-ITX Z790", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 120, MoboTypeName = "MSI Mini-ITX B650", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 121, MoboTypeName = "Gigabyte Mini-ITX Z790", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 122, MoboTypeName = "Gigabyte Mini-ITX B650", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 123, MoboTypeName = "ASRock Mini-ITX Z790", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 124, MoboTypeName = "ASRock Mini-ITX B650", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // E-ATX boards
            new { MoboTypeId = 125, MoboTypeName = "E-ATX Z790", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 126, MoboTypeName = "E-ATX X670E", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 127, MoboTypeName = "MSI E-ATX Z790", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 128, MoboTypeName = "MSI E-ATX X670E", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 129, MoboTypeName = "Gigabyte E-ATX Z790", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 130, MoboTypeName = "Gigabyte E-ATX X670E", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Additional Supermicro boards
            new { MoboTypeId = 131, MoboTypeName = "C621E Chipset SSI-EEB", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 132, MoboTypeName = "C627 Chipset E-ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 133, MoboTypeName = "C621A Chipset ATX", HardwareManufacturerId = 6, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // X299 boards
            new { MoboTypeId = 134, MoboTypeName = "X299 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 135, MoboTypeName = "MSI X299 Chipset ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 136, MoboTypeName = "Gigabyte X299 Chipset ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // X399/TRX40 boards
            new { MoboTypeId = 137, MoboTypeName = "X399 Chipset ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 138, MoboTypeName = "MSI X399 Chipset E-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 139, MoboTypeName = "TRX40 Chipset E-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 140, MoboTypeName = "MSI TRX40 Chipset E-ATX", HardwareManufacturerId = 11, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 141, MoboTypeName = "Gigabyte TRX40 Chipset E-ATX", HardwareManufacturerId = 12, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 142, MoboTypeName = "ASRock TRX40 Chipset E-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // WRX80 boards
            new { MoboTypeId = 143, MoboTypeName = "WRX80 Chipset E-ATX", HardwareManufacturerId = 10, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 144, MoboTypeName = "ASRock WRX80 Chipset E-ATX", HardwareManufacturerId = 173, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Intel boards (ID: 50)
            new { MoboTypeId = 145, MoboTypeName = "Intel S2600 Series", HardwareManufacturerId = 50, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 146, MoboTypeName = "Intel S1200 Series", HardwareManufacturerId = 50, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 147, MoboTypeName = "Intel C236 Chipset", HardwareManufacturerId = 50, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // AMD boards (ID: 51)
            new { MoboTypeId = 148, MoboTypeName = "AMD EPYC Rome Platform", HardwareManufacturerId = 51, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 149, MoboTypeName = "AMD EPYC Milan Platform", HardwareManufacturerId = 51, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Tyan boards (ID: 174 - to be added)
            new { MoboTypeId = 150, MoboTypeName = "Tyan S8030 Series", HardwareManufacturerId = 174, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { MoboTypeId = 151, MoboTypeName = "Tyan Thunder Series", HardwareManufacturerId = 174, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Biostar boards (ID: 175 - to be added)
            new { MoboTypeId = 152, MoboTypeName = "Biostar Racing Series", HardwareManufacturerId = 175, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // ECS boards (ID: 176 - to be added)
            new { MoboTypeId = 153, MoboTypeName = "ECS Server Board", HardwareManufacturerId = 176, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Fujitsu boards (ID: 7)
            new { MoboTypeId = 154, MoboTypeName = "Fujitsu Primergy Board", HardwareManufacturerId = 7, CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            
            // Cisco boards (ID: 16)
            new { MoboTypeId = 155, MoboTypeName = "Cisco UCS C-Series Board", HardwareManufacturerId = 16, CreatedAt = createdAt, CreatedBy = 1, Version = 1 }
        };

        builder.HasData(motherboards);
    }
}