using iamsng.Core.Entities;
using System;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Seed data for CpuType table
/// </summary>
public static class CpuTypeSeedData
{
    public static CpuType[] GetAllSeedData()
    {
        var seedDate = DateTimeOffset.UtcNow;
        
        // Hardware Manufacturer IDs:
        // Intel: 50, AMD: 51, IBM: 5, Apple: 73, Qualcomm: 53, 
        // ARM Holdings: 57, Oracle: 167, Amazon (AWS): 168, MediaTek: 56,
        // Samsung: 63, Huawei: 31, Loongson: 169, Zhaoxin: 170, 
        // VIA Technologies: 171, Phytium: 172
        
        return new CpuType[]
        {
            // Intel CPUs (ID: 50)
            new CpuType { CpuTypeId = 1, CpuTypeName = "Core i9 14th Gen (Raptor Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 2, CpuTypeName = "Core i7 14th Gen (Raptor Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 3, CpuTypeName = "Core i5 14th Gen (Raptor Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 4, CpuTypeName = "Core i3 14th Gen (Raptor Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 5, CpuTypeName = "Core i9 13th Gen (Raptor Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 6, CpuTypeName = "Core i7 13th Gen (Raptor Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 7, CpuTypeName = "Core i5 13th Gen (Raptor Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 8, CpuTypeName = "Core i3 13th Gen (Raptor Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 9, CpuTypeName = "Core i9 12th Gen (Alder Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 10, CpuTypeName = "Core i7 12th Gen (Alder Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 11, CpuTypeName = "Core i5 12th Gen (Alder Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 12, CpuTypeName = "Core i3 12th Gen (Alder Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 13, CpuTypeName = "Core i9 11th Gen (Rocket Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 14, CpuTypeName = "Core i7 11th Gen (Rocket Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 15, CpuTypeName = "Core i5 11th Gen (Rocket Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 16, CpuTypeName = "Core i3 11th Gen (Rocket Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 17, CpuTypeName = "Core i9 10th Gen (Comet Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 18, CpuTypeName = "Core i7 10th Gen (Comet Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 19, CpuTypeName = "Core i5 10th Gen (Comet Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 20, CpuTypeName = "Core i3 10th Gen (Comet Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 21, CpuTypeName = "Core i9 9th Gen (Coffee Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 22, CpuTypeName = "Core i7 9th Gen (Coffee Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 23, CpuTypeName = "Core i5 9th Gen (Coffee Lake Refresh)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 24, CpuTypeName = "Core i7 8th Gen (Coffee Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 25, CpuTypeName = "Core i5 8th Gen (Coffee Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 26, CpuTypeName = "Core i7 7th Gen (Kaby Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 27, CpuTypeName = "Core i5 7th Gen (Kaby Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 28, CpuTypeName = "Core i7 6th Gen (Skylake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 29, CpuTypeName = "Core i5 6th Gen (Skylake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 30, CpuTypeName = "Core i7 4th Gen (Haswell)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 31, CpuTypeName = "Core i5 4th Gen (Haswell)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 32, CpuTypeName = "Core i7 3rd Gen (Ivy Bridge)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 33, CpuTypeName = "Core i5 3rd Gen (Ivy Bridge)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 34, CpuTypeName = "Core i7 2nd Gen (Sandy Bridge)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 35, CpuTypeName = "Core i5 2nd Gen (Sandy Bridge)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 36, CpuTypeName = "Core 2 Quad", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 37, CpuTypeName = "Core 2 Duo", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 38, CpuTypeName = "Xeon Scalable 5th Gen (Emerald Rapids)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 39, CpuTypeName = "Xeon Scalable 4th Gen (Sapphire Rapids)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 40, CpuTypeName = "Xeon Scalable 3rd Gen (Ice Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 41, CpuTypeName = "Xeon Scalable 2nd Gen (Cascade Lake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 42, CpuTypeName = "Xeon Scalable 1st Gen (Skylake)", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 43, CpuTypeName = "Xeon E7 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 44, CpuTypeName = "Xeon E5 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 45, CpuTypeName = "Xeon E3 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 46, CpuTypeName = "Xeon W-3400 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 47, CpuTypeName = "Xeon W-2400 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 48, CpuTypeName = "Xeon W Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 49, CpuTypeName = "Xeon D Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 50, CpuTypeName = "Xeon Phi", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 51, CpuTypeName = "Pentium Gold Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 52, CpuTypeName = "Pentium Silver Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 53, CpuTypeName = "Pentium 4", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 54, CpuTypeName = "Pentium III", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 55, CpuTypeName = "Celeron Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 56, CpuTypeName = "Atom x7 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 57, CpuTypeName = "Atom x5 Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 58, CpuTypeName = "Atom C Series", HardwareManufacturerId = 50, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // AMD CPUs (ID: 51)
            new CpuType { CpuTypeId = 59, CpuTypeName = "Ryzen 9 7950X3D", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 60, CpuTypeName = "Ryzen 9 7950X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 61, CpuTypeName = "Ryzen 9 7900X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 62, CpuTypeName = "Ryzen 7 7800X3D", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 63, CpuTypeName = "Ryzen 7 7700X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 64, CpuTypeName = "Ryzen 5 7600X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 65, CpuTypeName = "Ryzen 9 5950X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 66, CpuTypeName = "Ryzen 9 5900X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 67, CpuTypeName = "Ryzen 7 5800X3D", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 68, CpuTypeName = "Ryzen 7 5800X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 69, CpuTypeName = "Ryzen 7 5700X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 70, CpuTypeName = "Ryzen 5 5600X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 71, CpuTypeName = "Ryzen 5 5600", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 72, CpuTypeName = "Ryzen 3 5300G", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 73, CpuTypeName = "Ryzen 9 3950X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 74, CpuTypeName = "Ryzen 9 3900X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 75, CpuTypeName = "Ryzen 7 3800X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 76, CpuTypeName = "Ryzen 7 3700X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 77, CpuTypeName = "Ryzen 5 3600X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 78, CpuTypeName = "Ryzen 5 3600", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 79, CpuTypeName = "Ryzen 7 2700X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 80, CpuTypeName = "Ryzen 5 2600X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 81, CpuTypeName = "Ryzen 7 1800X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 82, CpuTypeName = "Ryzen 5 1600X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 83, CpuTypeName = "Ryzen Threadripper 7980X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 84, CpuTypeName = "Ryzen Threadripper 7970X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 85, CpuTypeName = "Ryzen Threadripper PRO 7995WX", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 86, CpuTypeName = "Ryzen Threadripper PRO 7985WX", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 87, CpuTypeName = "Ryzen Threadripper PRO 5995WX", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 88, CpuTypeName = "Ryzen Threadripper PRO 5975WX", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 89, CpuTypeName = "Ryzen Threadripper 3990X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 90, CpuTypeName = "Ryzen Threadripper 3970X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 91, CpuTypeName = "Ryzen Threadripper 2990WX", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 92, CpuTypeName = "Ryzen Threadripper 1950X", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 93, CpuTypeName = "EPYC 9754 (Genoa)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 94, CpuTypeName = "EPYC 9654 (Genoa)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 95, CpuTypeName = "EPYC 9554 (Genoa)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 96, CpuTypeName = "EPYC 9374F (Genoa-X)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 97, CpuTypeName = "EPYC 7773X (Milan-X)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 98, CpuTypeName = "EPYC 7763 (Milan)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 99, CpuTypeName = "EPYC 7713 (Milan)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 100, CpuTypeName = "EPYC 7H12 (Rome)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 101, CpuTypeName = "EPYC 7742 (Rome)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 102, CpuTypeName = "EPYC 7601 (Naples)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 103, CpuTypeName = "EPYC 7551 (Naples)", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 104, CpuTypeName = "Athlon 3000G", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 105, CpuTypeName = "Athlon 200GE", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 106, CpuTypeName = "Athlon 64 X2", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 107, CpuTypeName = "Athlon 64", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 108, CpuTypeName = "Opteron 6000 Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 109, CpuTypeName = "FX-8350", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 110, CpuTypeName = "FX-8150", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 111, CpuTypeName = "A10 APU Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 112, CpuTypeName = "A8 APU Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 113, CpuTypeName = "A6 APU Series", HardwareManufacturerId = 51, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Apple CPUs (ID: 73)
            new CpuType { CpuTypeId = 114, CpuTypeName = "M3 Max", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 115, CpuTypeName = "M3 Pro", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 116, CpuTypeName = "M3", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 117, CpuTypeName = "M2 Ultra", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 118, CpuTypeName = "M2 Max", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 119, CpuTypeName = "M2 Pro", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 120, CpuTypeName = "M2", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 121, CpuTypeName = "M1 Ultra", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 122, CpuTypeName = "M1 Max", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 123, CpuTypeName = "M1 Pro", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 124, CpuTypeName = "M1", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 125, CpuTypeName = "A17 Pro", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 126, CpuTypeName = "A16 Bionic", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 127, CpuTypeName = "A15 Bionic", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 128, CpuTypeName = "A14 Bionic", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 129, CpuTypeName = "A13 Bionic", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 130, CpuTypeName = "A12 Bionic", HardwareManufacturerId = 73, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Qualcomm CPUs (ID: 53)
            new CpuType { CpuTypeId = 131, CpuTypeName = "Snapdragon 8 Gen 3", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 132, CpuTypeName = "Snapdragon 8 Gen 2", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 133, CpuTypeName = "Snapdragon 8 Gen 1", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 134, CpuTypeName = "Snapdragon 888", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 135, CpuTypeName = "Snapdragon 865", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 136, CpuTypeName = "Snapdragon 7+ Gen 2", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 137, CpuTypeName = "Snapdragon 7 Gen 1", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 138, CpuTypeName = "Snapdragon 6 Gen 1", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 139, CpuTypeName = "Snapdragon 4 Gen 1", HardwareManufacturerId = 53, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // ARM Holdings CPUs (ID: 57)
            new CpuType { CpuTypeId = 140, CpuTypeName = "Cortex-A78", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 141, CpuTypeName = "Cortex-A77", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 142, CpuTypeName = "Cortex-A76", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 143, CpuTypeName = "Cortex-A75", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 144, CpuTypeName = "Cortex-A73", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 145, CpuTypeName = "Cortex-A72", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 146, CpuTypeName = "Cortex-R82", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 147, CpuTypeName = "Cortex-R52", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 148, CpuTypeName = "Cortex-M85", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 149, CpuTypeName = "Cortex-M55", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 150, CpuTypeName = "Cortex-M33", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 151, CpuTypeName = "Neoverse V2", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 152, CpuTypeName = "Neoverse N2", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 153, CpuTypeName = "Neoverse N1", HardwareManufacturerId = 57, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // IBM CPUs (ID: 5)
            new CpuType { CpuTypeId = 154, CpuTypeName = "POWER10", HardwareManufacturerId = 5, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 155, CpuTypeName = "POWER9", HardwareManufacturerId = 5, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 156, CpuTypeName = "POWER8", HardwareManufacturerId = 5, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 157, CpuTypeName = "POWER7", HardwareManufacturerId = 5, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Oracle CPUs (ID: 167)
            new CpuType { CpuTypeId = 158, CpuTypeName = "SPARC M8", HardwareManufacturerId = 167, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 159, CpuTypeName = "SPARC M7", HardwareManufacturerId = 167, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 160, CpuTypeName = "SPARC T5", HardwareManufacturerId = 167, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Amazon (AWS) CPUs (ID: 168)
            new CpuType { CpuTypeId = 161, CpuTypeName = "Graviton3", HardwareManufacturerId = 168, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 162, CpuTypeName = "Graviton2", HardwareManufacturerId = 168, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 163, CpuTypeName = "Graviton", HardwareManufacturerId = 168, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // MediaTek CPUs (ID: 56)
            new CpuType { CpuTypeId = 164, CpuTypeName = "Dimensity 9300", HardwareManufacturerId = 56, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 165, CpuTypeName = "Dimensity 9200", HardwareManufacturerId = 56, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 166, CpuTypeName = "Dimensity 9000", HardwareManufacturerId = 56, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 167, CpuTypeName = "Dimensity 8300", HardwareManufacturerId = 56, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 168, CpuTypeName = "Dimensity 8200", HardwareManufacturerId = 56, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 169, CpuTypeName = "Dimensity 7200", HardwareManufacturerId = 56, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Samsung CPUs (ID: 63)
            new CpuType { CpuTypeId = 170, CpuTypeName = "Exynos 2400", HardwareManufacturerId = 63, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 171, CpuTypeName = "Exynos 2200", HardwareManufacturerId = 63, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 172, CpuTypeName = "Exynos 2100", HardwareManufacturerId = 63, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Huawei CPUs (ID: 31)
            new CpuType { CpuTypeId = 173, CpuTypeName = "Kirin 9000", HardwareManufacturerId = 31, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 174, CpuTypeName = "Kirin 990", HardwareManufacturerId = 31, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Loongson CPUs (ID: 169)
            new CpuType { CpuTypeId = 175, CpuTypeName = "Loongson 3A6000", HardwareManufacturerId = 169, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 176, CpuTypeName = "Loongson 3A5000", HardwareManufacturerId = 169, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            new CpuType { CpuTypeId = 177, CpuTypeName = "Godson (龙芯)", HardwareManufacturerId = 169, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Zhaoxin CPUs (ID: 170)
            new CpuType { CpuTypeId = 178, CpuTypeName = "Zhaoxin KX-6000", HardwareManufacturerId = 170, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // VIA Technologies CPUs (ID: 171)
            new CpuType { CpuTypeId = 179, CpuTypeName = "VIA C7", HardwareManufacturerId = 171, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 },
            
            // Phytium CPUs (ID: 172)
            new CpuType { CpuTypeId = 180, CpuTypeName = "Phytium FT-2000", HardwareManufacturerId = 172, CreatedAt = seedDate, CreatedBy = 1, ModifiedAt = seedDate, ModifiedBy = 1, Version = 1 }
        };
    }
}