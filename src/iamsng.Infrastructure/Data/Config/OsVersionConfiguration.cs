using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Config;

public class OsVersionConfiguration : IEntityTypeConfiguration<OsVersion>
{
    public void Configure(EntityTypeBuilder<OsVersion> builder)
    {
        builder.HasKey(e => e.OsVersionId);
        
        builder.HasIndex(e => e.OsVersionName)
            .IsUnique()
            .HasDatabaseName("UX_os_version_name");

        // Seed data for OS versions
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var osVersions = new[]
        {
            // Windows Consumer/Business versions (1-15)
            new { OsVersionId = 1, OsVersionName = "Windows 11", OsVersionDescription = "Latest consumer and business Windows version released in 2021 with redesigned interface", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 2, OsVersionName = "Windows 10", OsVersionDescription = "Long-term Windows version released in 2015 with continuous updates and widespread adoption", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 3, OsVersionName = "Windows 8.1", OsVersionDescription = "Updated version of Windows 8 released in 2013 with improved Start menu functionality", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 4, OsVersionName = "Windows 8", OsVersionDescription = "Windows version released in 2012 featuring Metro UI and touch-focused design", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 5, OsVersionName = "Windows 7", OsVersionDescription = "Popular Windows version released in 2009 known for stability and performance", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 6, OsVersionName = "Windows Vista", OsVersionDescription = "Windows version released in 2006 introducing Aero interface and enhanced security", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 7, OsVersionName = "Windows XP", OsVersionDescription = "Highly successful Windows version released in 2001 with extended support lifecycle", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 8, OsVersionName = "Windows 2000", OsVersionDescription = "Business-focused Windows NT version released in 2000 for professional workstations", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 9, OsVersionName = "Windows ME", OsVersionDescription = "Consumer Windows version released in 2000 as successor to Windows 98", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 10, OsVersionName = "Windows 98", OsVersionDescription = "Consumer Windows version released in 1998 with improved USB and internet support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 11, OsVersionName = "Windows 95", OsVersionDescription = "Revolutionary Windows version released in 1995 introducing Start menu and taskbar", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 12, OsVersionName = "Windows NT 4.0", OsVersionDescription = "Business Windows version released in 1996 based on NT kernel architecture", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 13, OsVersionName = "Windows 3.1", OsVersionDescription = "Early graphical Windows version released in 1992 running on MS-DOS", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Windows Server versions (14-21)
            new { OsVersionId = 14, OsVersionName = "Windows Server 2022", OsVersionDescription = "Latest Windows Server version released in 2021 for datacenter and hybrid cloud", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 15, OsVersionName = "Windows Server 2019", OsVersionDescription = "Windows Server version released in 2018 with enhanced hybrid cloud capabilities", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 16, OsVersionName = "Windows Server 2016", OsVersionDescription = "Windows Server version released in 2016 introducing containers and nano server", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 17, OsVersionName = "Windows Server 2012 R2", OsVersionDescription = "Updated server version released in 2013 with cloud and virtualization enhancements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 18, OsVersionName = "Windows Server 2012", OsVersionDescription = "Windows Server version released in 2012 with Hyper-V improvements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 19, OsVersionName = "Windows Server 2008 R2", OsVersionDescription = "Server version released in 2009 exclusively for 64-bit systems", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 20, OsVersionName = "Windows Server 2008", OsVersionDescription = "Server version released in 2008 based on Windows Vista codebase", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 21, OsVersionName = "Windows Server 2003", OsVersionDescription = "Server version released in 2003 replacing Windows 2000 Server", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // macOS/OS X versions (22-37)
            new { OsVersionId = 22, OsVersionName = "macOS Sequoia 15", OsVersionDescription = "macOS version 15 released in 2024 with AI and continuity features", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 23, OsVersionName = "macOS Sonoma 14", OsVersionDescription = "macOS version 14 released in 2023 with widget enhancements and video conferencing features", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 24, OsVersionName = "macOS Ventura 13", OsVersionDescription = "macOS version 13 released in 2022 with Stage Manager and Continuity Camera", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 25, OsVersionName = "macOS Monterey 12", OsVersionDescription = "macOS version 12 released in 2021 with Universal Control and SharePlay", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 26, OsVersionName = "macOS Big Sur 11", OsVersionDescription = "macOS version 11 released in 2020 with redesigned interface and Apple Silicon support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 27, OsVersionName = "macOS Catalina 10.15", OsVersionDescription = "macOS version released in 2019 replacing iTunes with separate apps", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 28, OsVersionName = "macOS Mojave 10.14", OsVersionDescription = "macOS version released in 2018 introducing Dark Mode and Stacks", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 29, OsVersionName = "macOS High Sierra 10.13", OsVersionDescription = "macOS version released in 2017 with APFS file system", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 30, OsVersionName = "macOS Sierra 10.12", OsVersionDescription = "macOS version released in 2016 introducing Siri to Mac", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 31, OsVersionName = "OS X El Capitan 10.11", OsVersionDescription = "OS X version released in 2015 focused on performance improvements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 32, OsVersionName = "OS X Yosemite 10.10", OsVersionDescription = "OS X version released in 2014 with iOS-inspired flat design", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 33, OsVersionName = "OS X Mavericks 10.9", OsVersionDescription = "OS X version released in 2013 introducing Maps and iBooks", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 34, OsVersionName = "OS X Mountain Lion 10.8", OsVersionDescription = "OS X version released in 2012 with iCloud integration", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 35, OsVersionName = "Mac OS X Lion 10.7", OsVersionDescription = "OS X version released in 2011 introducing Mission Control and Launchpad", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 36, OsVersionName = "Mac OS X Snow Leopard 10.6", OsVersionDescription = "OS X version released in 2009 focused on refinement and performance", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 37, OsVersionName = "Mac OS X Leopard 10.5", OsVersionDescription = "OS X version released in 2007 with Time Machine backup feature", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Ubuntu LTS versions (38-42)
            new { OsVersionId = 38, OsVersionName = "Ubuntu 24.04 LTS", OsVersionDescription = "Ubuntu Long Term Support release from April 2024 with 5-year support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 39, OsVersionName = "Ubuntu 22.04 LTS", OsVersionDescription = "Ubuntu Long Term Support release from April 2022 codenamed Jammy Jellyfish", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 40, OsVersionName = "Ubuntu 20.04 LTS", OsVersionDescription = "Ubuntu Long Term Support release from April 2020 codenamed Focal Fossa", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 41, OsVersionName = "Ubuntu 18.04 LTS", OsVersionDescription = "Ubuntu Long Term Support release from April 2018 codenamed Bionic Beaver", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 42, OsVersionName = "Ubuntu 16.04 LTS", OsVersionDescription = "Ubuntu Long Term Support release from April 2016 codenamed Xenial Xerus", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Debian versions (43-46)
            new { OsVersionId = 43, OsVersionName = "Debian 12", OsVersionDescription = "Debian stable release codenamed Bookworm released in 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 44, OsVersionName = "Debian 11", OsVersionDescription = "Debian stable release codenamed Bullseye released in 2021", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 45, OsVersionName = "Debian 10", OsVersionDescription = "Debian stable release codenamed Buster released in 2019", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 46, OsVersionName = "Debian 9", OsVersionDescription = "Debian stable release codenamed Stretch released in 2017", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // RHEL versions (47-50)
            new { OsVersionId = 47, OsVersionName = "RHEL 9", OsVersionDescription = "Red Hat Enterprise Linux 9 released in 2022 with 10-year lifecycle", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 48, OsVersionName = "RHEL 8", OsVersionDescription = "Red Hat Enterprise Linux 8 released in 2019 with modular repository support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 49, OsVersionName = "RHEL 7", OsVersionDescription = "Red Hat Enterprise Linux 7 released in 2014 with systemd and Docker support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 50, OsVersionName = "RHEL 6", OsVersionDescription = "Red Hat Enterprise Linux 6 released in 2010 with KVM virtualization", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // CentOS versions (51-54)
            new { OsVersionId = 51, OsVersionName = "CentOS Stream 9", OsVersionDescription = "Rolling preview of next RHEL 9 minor release", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 52, OsVersionName = "CentOS Stream 8", OsVersionDescription = "Rolling preview of next RHEL 8 minor release", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 53, OsVersionName = "CentOS 7", OsVersionDescription = "Community rebuild of RHEL 7 released in 2014", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 54, OsVersionName = "CentOS 6", OsVersionDescription = "Community rebuild of RHEL 6 released in 2010", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Rocky Linux versions (55-56)
            new { OsVersionId = 55, OsVersionName = "Rocky Linux 9", OsVersionDescription = "Enterprise Linux 9 compatible with RHEL 9", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 56, OsVersionName = "Rocky Linux 8", OsVersionDescription = "Enterprise Linux 8 compatible with RHEL 8", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // AlmaLinux versions (57-58)
            new { OsVersionId = 57, OsVersionName = "AlmaLinux 9", OsVersionDescription = "Community-owned enterprise Linux 9 compatible with RHEL 9", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 58, OsVersionName = "AlmaLinux 8", OsVersionDescription = "Community-owned enterprise Linux 8 compatible with RHEL 8", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Fedora versions (59-60)
            new { OsVersionId = 59, OsVersionName = "Fedora 40", OsVersionDescription = "Community Linux distribution released in 2024 with cutting-edge features", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 60, OsVersionName = "Fedora 39", OsVersionDescription = "Community Linux distribution released in 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // SUSE versions (61-64)
            new { OsVersionId = 61, OsVersionName = "SUSE Linux Enterprise 15", OsVersionDescription = "Enterprise Linux version 15 with extended lifecycle support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 62, OsVersionName = "SUSE Linux Enterprise 12", OsVersionDescription = "Enterprise Linux version 12 for mission-critical workloads", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 63, OsVersionName = "openSUSE Leap 15", OsVersionDescription = "Stable openSUSE version aligned with SUSE Linux Enterprise", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 64, OsVersionName = "openSUSE Tumbleweed", OsVersionDescription = "Rolling release openSUSE distribution with latest packages", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Oracle Linux versions (65-66)
            new { OsVersionId = 65, OsVersionName = "Oracle Linux 9", OsVersionDescription = "Enterprise Linux 9 compatible with RHEL and optimized for Oracle products", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 66, OsVersionName = "Oracle Linux 8", OsVersionDescription = "Enterprise Linux 8 with Unbreakable Enterprise Kernel", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Other Linux distributions (67-74)
            new { OsVersionId = 67, OsVersionName = "Arch Linux", OsVersionDescription = "Rolling release distribution with latest software versions", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 68, OsVersionName = "Manjaro", OsVersionDescription = "User-friendly Arch-based distribution with curated rolling releases", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 69, OsVersionName = "Linux Mint 21", OsVersionDescription = "Ubuntu-based distribution with Cinnamon desktop released in 2022", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 70, OsVersionName = "Linux Mint 20", OsVersionDescription = "Ubuntu-based distribution released in 2020", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 71, OsVersionName = "Kali Linux 2024", OsVersionDescription = "Penetration testing distribution updated in 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 72, OsVersionName = "Kali Linux 2023", OsVersionDescription = "Penetration testing distribution updated in 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 73, OsVersionName = "Gentoo", OsVersionDescription = "Source-based rolling release distribution", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 74, OsVersionName = "Slackware 15", OsVersionDescription = "Stable release of one of oldest Linux distributions", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Android versions (75-79)
            new { OsVersionId = 75, OsVersionName = "Android 14", OsVersionDescription = "Android mobile OS version released in 2023 with privacy enhancements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 76, OsVersionName = "Android 13", OsVersionDescription = "Android mobile OS version released in 2022", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 77, OsVersionName = "Android 12", OsVersionDescription = "Android mobile OS version released in 2021 with Material You design", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 78, OsVersionName = "Android 11", OsVersionDescription = "Android mobile OS version released in 2020", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 79, OsVersionName = "Android 10", OsVersionDescription = "Android mobile OS version released in 2019", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // iOS versions (80-84)
            new { OsVersionId = 80, OsVersionName = "iOS 18", OsVersionDescription = "Apple mobile OS version released in 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 81, OsVersionName = "iOS 17", OsVersionDescription = "Apple mobile OS version released in 2023 with Contact Poster and StandBy", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 82, OsVersionName = "iOS 16", OsVersionDescription = "Apple mobile OS version released in 2022 with customizable Lock Screen", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 83, OsVersionName = "iOS 15", OsVersionDescription = "Apple mobile OS version released in 2021 with Focus modes", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 84, OsVersionName = "iOS 14", OsVersionDescription = "Apple mobile OS version released in 2020 with widgets and App Library", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // iPadOS versions (85-86)
            new { OsVersionId = 85, OsVersionName = "iPadOS 18", OsVersionDescription = "iPad-specific OS version released in 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 86, OsVersionName = "iPadOS 17", OsVersionDescription = "iPad-specific OS version released in 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // BSD versions (87-93)
            new { OsVersionId = 87, OsVersionName = "FreeBSD 14", OsVersionDescription = "FreeBSD version 14 released in 2023 with performance improvements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 88, OsVersionName = "FreeBSD 13", OsVersionDescription = "FreeBSD version 13 released in 2021 with ZFS enhancements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 89, OsVersionName = "FreeBSD 12", OsVersionDescription = "FreeBSD version 12 released in 2018", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 90, OsVersionName = "OpenBSD 7.4", OsVersionDescription = "OpenBSD version 7.4 released in 2023 with security enhancements", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 91, OsVersionName = "OpenBSD 7.3", OsVersionDescription = "OpenBSD version 7.3 released in 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 92, OsVersionName = "NetBSD 10", OsVersionDescription = "NetBSD version 10 with improved hardware support", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 93, OsVersionName = "NetBSD 9", OsVersionDescription = "NetBSD version 9 released in 2020", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Unix versions (94-99)
            new { OsVersionId = 94, OsVersionName = "Solaris 11", OsVersionDescription = "Oracle Solaris 11 with ZFS and DTrace integration", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 95, OsVersionName = "Solaris 10", OsVersionDescription = "Oracle Solaris 10 with Zones virtualization", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 96, OsVersionName = "AIX 7.3", OsVersionDescription = "IBM AIX version 7.3 for Power Systems", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 97, OsVersionName = "AIX 7.2", OsVersionDescription = "IBM AIX version 7.2 released in 2015", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 98, OsVersionName = "HP-UX 11i v3", OsVersionDescription = "HP-UX version 11i v3 for Integrity servers", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Chrome OS versions (99-100)
            new { OsVersionId = 99, OsVersionName = "Chrome OS 120", OsVersionDescription = "Chrome OS version 120 released in 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsVersionId = 100, OsVersionName = "Chrome OS 119", OsVersionDescription = "Chrome OS version 119 released in 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 }
        };

        builder.HasData(osVersions);
    }
}