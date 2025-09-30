using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for SysArchitecture entity.
/// Configures system architectures and instruction sets for hardware categorization.
/// </summary>
public class SysArchitectureConfiguration : IEntityTypeConfiguration<SysArchitecture>
{
    public void Configure(EntityTypeBuilder<SysArchitecture> builder)
    {
        // Table configuration
        builder.ToTable("sys_architecture", t =>
        {
            t.HasComment("System architectures and instruction sets for hardware platform categorization");
        });

        // Primary Key
        builder.HasKey(s => s.SysArchitectureId)
            .HasName("PK_sys_architecture");

        // Properties
        builder.Property(s => s.SysArchitectureId)
            .HasColumnName("sys_architecture_id")
            .UseIdentityColumn();

        builder.Property(s => s.SystemArchitecture)
            .HasColumnName("system_architecture")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("Architecture/instruction set name or designation");

        builder.Property(s => s.SysArchitectureDescription)
            .HasColumnName("sys_architecture_description")
            .HasMaxLength(500)
            .HasComment("Detailed description of the architecture and its use cases");

        // Indexes
        builder.HasIndex(s => s.SystemArchitecture)
            .HasDatabaseName("IX_sys_architecture_name")
            .IsUnique();

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var seedDate = DateTimeOffset.UtcNow;
        builder.HasData(
            new SysArchitecture 
            { 
                SysArchitectureId = 1, 
                SystemArchitecture = "x86", 
                SysArchitectureDescription = "32-bit Intel architecture based on 8086 processor family; also known as i386 or IA-32",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 2, 
                SystemArchitecture = "x86_64", 
                SysArchitectureDescription = "64-bit extension of x86 architecture; also known as x64 AMD64 or Intel 64",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 3, 
                SystemArchitecture = "ARM", 
                SysArchitectureDescription = "32-bit RISC architecture widely used in mobile devices and embedded systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 4, 
                SystemArchitecture = "ARM64", 
                SysArchitectureDescription = "64-bit ARM architecture; also known as AArch64 or ARMv8",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 5, 
                SystemArchitecture = "IA-64", 
                SysArchitectureDescription = "Intel Itanium 64-bit architecture designed for enterprise servers; now largely discontinued",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 6, 
                SystemArchitecture = "PowerPC", 
                SysArchitectureDescription = "RISC architecture developed by Apple IBM and Motorola; used in older Macs and gaming consoles",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 7, 
                SystemArchitecture = "SPARC", 
                SysArchitectureDescription = "Scalable Processor Architecture; RISC architecture used primarily in Oracle/Sun enterprise systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 8, 
                SystemArchitecture = "MIPS", 
                SysArchitectureDescription = "Microprocessor without Interlocked Pipeline Stages; RISC architecture used in embedded systems and routers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 9, 
                SystemArchitecture = "RISC-V", 
                SysArchitectureDescription = "Open-source RISC instruction set architecture gaining adoption in various applications",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 10, 
                SystemArchitecture = "Alpha", 
                SysArchitectureDescription = "64-bit RISC architecture developed by DEC; discontinued but historically significant",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 11, 
                SystemArchitecture = "PA-RISC", 
                SysArchitectureDescription = "Precision Architecture RISC developed by HP for Unix workstations and servers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 12, 
                SystemArchitecture = "s390x", 
                SysArchitectureDescription = "64-bit IBM System/390 mainframe architecture; also known as z/Architecture",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 13, 
                SystemArchitecture = "m68k", 
                SysArchitectureDescription = "Motorola 68000 series architecture; used in early Apple Macintosh and Amiga computers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 14, 
                SystemArchitecture = "MIPS64", 
                SysArchitectureDescription = "64-bit version of MIPS architecture used in high-performance embedded systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 15, 
                SystemArchitecture = "PowerPC64", 
                SysArchitectureDescription = "64-bit version of PowerPC architecture; used in IBM Power Systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 16, 
                SystemArchitecture = "ARMv7", 
                SysArchitectureDescription = "32-bit ARM architecture version 7; common in smartphones and tablets from 2010s",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 17, 
                SystemArchitecture = "ARMv8", 
                SysArchitectureDescription = "ARM architecture version 8; introduced 64-bit support and used in modern mobile devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 18, 
                SystemArchitecture = "i386", 
                SysArchitectureDescription = "Intel 80386 32-bit architecture; synonym for x86",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 19, 
                SystemArchitecture = "i686", 
                SysArchitectureDescription = "Intel Pentium Pro and later 32-bit x86 processors with enhanced instruction sets",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 20, 
                SystemArchitecture = "amd64", 
                SysArchitectureDescription = "AMD's implementation of 64-bit x86 architecture; synonym for x86_64",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 21, 
                SystemArchitecture = "RISC-V 32", 
                SysArchitectureDescription = "32-bit version of open-source RISC-V architecture",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 22, 
                SystemArchitecture = "RISC-V 64", 
                SysArchitectureDescription = "64-bit version of open-source RISC-V architecture",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 23, 
                SystemArchitecture = "ARMv6", 
                SysArchitectureDescription = "ARM architecture version 6; used in devices like Raspberry Pi 1 and earlier smartphones",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 24, 
                SystemArchitecture = "ARMv5", 
                SysArchitectureDescription = "ARM architecture version 5; used in older embedded systems and early smartphones",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 25, 
                SystemArchitecture = "SuperH", 
                SysArchitectureDescription = "RISC architecture developed by Hitachi; used in embedded systems and Sega gaming consoles",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 26, 
                SystemArchitecture = "Xtensa", 
                SysArchitectureDescription = "Configurable processor architecture by Tensilica; used in IoT and embedded devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 27, 
                SystemArchitecture = "OpenRISC", 
                SysArchitectureDescription = "Open-source RISC architecture for embedded systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new SysArchitecture 
            { 
                SysArchitectureId = 28, 
                SystemArchitecture = "ARC", 
                SysArchitectureDescription = "Argonaut RISC Core; synthesizable processor architecture for embedded applications",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            }
        );
    }
}