using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for OsVendor entity.
/// Configures operating system vendors and maintainers.
/// </summary>
public class OsVendorConfiguration : IEntityTypeConfiguration<OsVendor>
{
    public void Configure(EntityTypeBuilder<OsVendor> builder)
    {
        // Table configuration
        builder.ToTable("os_vendor", t =>
        {
            t.HasComment("Operating system vendors and maintainers for software asset categorization");
        });

        // Primary Key
        builder.HasKey(o => o.OsVendorId)
            .HasName("PK_os_vendor");

        // Properties
        builder.Property(o => o.OsVendorId)
            .HasColumnName("os_vendor_id")
            .UseIdentityColumn();

        builder.Property(o => o.OsVendorName)
            .HasColumnName("os_vendor_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Name of the operating system vendor or maintainer");

        builder.Property(o => o.OsVendorDescription)
            .HasColumnName("os_vendor_description")
            .HasMaxLength(500)
            .HasComment("Description of vendor's primary operating systems and focus areas");

        // Indexes
        builder.HasIndex(o => o.OsVendorName)
            .HasDatabaseName("IX_os_vendor_name")
            .IsUnique();

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed data
        var seedDate = DateTimeOffset.UtcNow;
        builder.HasData(
            new OsVendor 
            { 
                OsVendorId = 1, 
                OsVendorName = "Microsoft", 
                OsVendorDescription = "Develops Windows operating systems for desktops servers and enterprise environments",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 2, 
                OsVendorName = "Apple", 
                OsVendorDescription = "Develops macOS iOS iPadOS watchOS and tvOS for consumer and enterprise devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 3, 
                OsVendorName = "Google", 
                OsVendorDescription = "Develops Android mobile OS and Chrome OS for Chromebooks and cloud-based computing",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 4, 
                OsVendorName = "Canonical", 
                OsVendorDescription = "Commercial sponsor of Ubuntu Linux distribution and provider of enterprise support services",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 5, 
                OsVendorName = "Red Hat", 
                OsVendorDescription = "Enterprise Linux vendor providing RHEL and related open-source solutions; owned by IBM",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 6, 
                OsVendorName = "SUSE", 
                OsVendorDescription = "European enterprise Linux vendor providing SUSE Linux Enterprise Server and Desktop",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 7, 
                OsVendorName = "Oracle", 
                OsVendorDescription = "Develops Oracle Linux Oracle Solaris and enterprise database systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 8, 
                OsVendorName = "IBM", 
                OsVendorDescription = "Develops AIX for Power Systems and z/OS for mainframe systems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 9, 
                OsVendorName = "Hewlett Packard Enterprise", 
                OsVendorDescription = "Develops HP-UX Unix operating system for Integrity and PA-RISC servers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 10, 
                OsVendorName = "Debian Project", 
                OsVendorDescription = "Community-driven organization maintaining Debian GNU/Linux distribution",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 11, 
                OsVendorName = "Fedora Project", 
                OsVendorDescription = "Community-driven Linux distribution sponsored by Red Hat",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 12, 
                OsVendorName = "Linux Foundation", 
                OsVendorDescription = "Non-profit organization supporting Linux kernel development and related open-source projects",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 13, 
                OsVendorName = "FreeBSD Foundation", 
                OsVendorDescription = "Non-profit supporting FreeBSD Unix-like operating system development",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 14, 
                OsVendorName = "OpenBSD Project", 
                OsVendorDescription = "Develops OpenBSD focused on security and code correctness",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 15, 
                OsVendorName = "NetBSD Foundation", 
                OsVendorDescription = "Develops NetBSD emphasizing portability across hardware platforms",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 16, 
                OsVendorName = "Arch Linux", 
                OsVendorDescription = "Community-maintained rolling-release Linux distribution",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 17, 
                OsVendorName = "Gentoo Foundation", 
                OsVendorDescription = "Maintains Gentoo Linux source-based distribution",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 18, 
                OsVendorName = "Slackware Linux", 
                OsVendorDescription = "One of oldest Linux distributions maintained by Patrick Volkerding",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 19, 
                OsVendorName = "Kali Linux", 
                OsVendorDescription = "Offensive Security maintains Kali Linux for penetration testing and security auditing",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 20, 
                OsVendorName = "CentOS Project", 
                OsVendorDescription = "Community Enterprise OS based on RHEL sources; now CentOS Stream maintained by Red Hat",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 21, 
                OsVendorName = "Rocky Linux", 
                OsVendorDescription = "Community enterprise Linux distribution created as CentOS replacement",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 22, 
                OsVendorName = "AlmaLinux", 
                OsVendorDescription = "Community-owned enterprise Linux distribution forked from RHEL",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 23, 
                OsVendorName = "VMware", 
                OsVendorDescription = "Develops ESXi hypervisor and related virtualization operating systems; owned by Broadcom",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 24, 
                OsVendorName = "Citrix", 
                OsVendorDescription = "Develops XenServer hypervisor and virtualization platforms",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 25, 
                OsVendorName = "Amazon Web Services", 
                OsVendorDescription = "Develops Amazon Linux optimized for AWS cloud infrastructure",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 26, 
                OsVendorName = "Huawei", 
                OsVendorDescription = "Develops HarmonyOS for mobile devices and IoT ecosystems",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 27, 
                OsVendorName = "Samsung", 
                OsVendorDescription = "Develops Tizen OS for smart TVs wearables and IoT devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 28, 
                OsVendorName = "Wind River", 
                OsVendorDescription = "Develops VxWorks real-time operating system for embedded systems; owned by Aptiv",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 29, 
                OsVendorName = "QNX Software Systems", 
                OsVendorDescription = "Develops QNX real-time operating system for automotive and embedded systems; owned by BlackBerry",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 30, 
                OsVendorName = "Juniper Networks", 
                OsVendorDescription = "Develops Junos OS for networking equipment and routers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 31, 
                OsVendorName = "Cisco Systems", 
                OsVendorDescription = "Develops IOS and IOS-XE operating systems for networking infrastructure",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 32, 
                OsVendorName = "Arista Networks", 
                OsVendorDescription = "Develops EOS network operating system for data center switches",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 33, 
                OsVendorName = "MikroTik", 
                OsVendorDescription = "Develops RouterOS for networking equipment and routers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 34, 
                OsVendorName = "Ubiquiti", 
                OsVendorDescription = "Develops UniFi OS and EdgeOS for networking and IoT devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 35, 
                OsVendorName = "Proxmox Server Solutions", 
                OsVendorDescription = "Develops Proxmox VE virtualization platform based on Debian",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 36, 
                OsVendorName = "TrueNAS", 
                OsVendorDescription = "iXsystems develops TrueNAS storage operating system based on FreeBSD",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 37, 
                OsVendorName = "pfSense", 
                OsVendorDescription = "Netgate develops pfSense firewall and router operating system based on FreeBSD",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 38, 
                OsVendorName = "OpenWrt Project", 
                OsVendorDescription = "Community-developed Linux-based OS for embedded devices and routers",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 39, 
                OsVendorName = "Synology", 
                OsVendorDescription = "Develops DiskStation Manager (DSM) for NAS devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            },
            new OsVendor 
            { 
                OsVendorId = 40, 
                OsVendorName = "QNAP", 
                OsVendorDescription = "Develops QTS and QuTS operating systems for NAS and storage devices",
                CreatedAt = seedDate,
                CreatedBy = 1,
                ModifiedAt = seedDate,
                ModifiedBy = 1,
                Version = 1
            }
        );
    }
}