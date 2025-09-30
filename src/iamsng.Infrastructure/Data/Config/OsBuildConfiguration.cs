using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;
using iamsng.Infrastructure.Data.SeedData;
using System.Collections.Generic;
using System.Linq;

namespace iamsng.Infrastructure.Data.Config;

public class OsBuildConfiguration : IEntityTypeConfiguration<OsBuild>
{
    public void Configure(EntityTypeBuilder<OsBuild> builder)
    {
        builder.HasKey(e => e.OsBuildId);
        
        builder.HasIndex(e => e.OsBuildName)
            .IsUnique()
            .HasDatabaseName("UX_os_build_name");

        // Get all seed data parts
        var allSeeds = new List<object>();
        
        // Part 1 (1-50)
        allSeeds.AddRange(OsBuildSeedData.GetOsBuildSeeds());
        
        // Part 2 (51-100)
        allSeeds.AddRange(OsBuildSeedData.GetOsBuildSeedsPartTwo());
        
        // Part 3 (101-200)
        allSeeds.AddRange(OsBuildSeedData.GetOsBuildSeedsPartThree());
        
        // Add remaining builds directly here to complete the dataset
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        
        // Continue with remaining Windows 10 legacy builds and other OS builds
        var additionalSeeds = new[]
        {
            // Continue Windows 10 1809 and older builds (201-250)
            new { OsBuildId = 201, OsBuildName = "17763.678", OsBuildDescription = "Windows 10 1809 build from August 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 202, OsBuildName = "17763.615", OsBuildDescription = "Windows 10 1809 build from July 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 203, OsBuildName = "17763.557", OsBuildDescription = "Windows 10 1809 build from June 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 204, OsBuildName = "17763.529", OsBuildDescription = "Windows 10 1809 build from May 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 205, OsBuildName = "17763.475", OsBuildDescription = "Windows 10 1809 build from April 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 206, OsBuildName = "17763.437", OsBuildDescription = "Windows 10 1809 build from March 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 207, OsBuildName = "17763.379", OsBuildDescription = "Windows 10 1809 build from February 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 208, OsBuildName = "17763.316", OsBuildDescription = "Windows 10 1809 build from January 2019 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 209, OsBuildName = "17763.253", OsBuildDescription = "Windows 10 1809 build from December 2018 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 210, OsBuildName = "17763.168", OsBuildDescription = "Windows 10 1809 build from November 2018 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 211, OsBuildName = "17763.107", OsBuildDescription = "Windows 10 1809 initial release build from November 2018", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Windows 10 1803 and earlier builds (sampling key builds)
            new { OsBuildId = 212, OsBuildName = "17134.1", OsBuildDescription = "Windows 10 1803 initial release build from April 2018", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 213, OsBuildName = "16299.15", OsBuildDescription = "Windows 10 1709 initial release build from October 2017", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 214, OsBuildName = "15063", OsBuildDescription = "Windows 10 1703 initial release build from April 2017", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 215, OsBuildName = "14393.1", OsBuildDescription = "Windows 10 1607 initial release build from August 2016", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 216, OsBuildName = "10586", OsBuildDescription = "Windows 10 1511 initial release build from November 2015", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 217, OsBuildName = "10240.16384", OsBuildDescription = "Windows 10 1507 initial release build from July 2015", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Windows 8.1/8 builds
            new { OsBuildId = 218, OsBuildName = "9600.17415", OsBuildDescription = "Windows 8.1 Update initial build from April 2014", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 219, OsBuildName = "9200.16384", OsBuildDescription = "Windows 8 initial release build from October 2012", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Windows 7 builds
            new { OsBuildId = 220, OsBuildName = "7601.17514", OsBuildDescription = "Windows 7 SP1 initial release build from February 2011", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 221, OsBuildName = "7600.16385", OsBuildDescription = "Windows 7 RTM initial release build from October 2009", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Windows Vista/XP builds
            new { OsBuildId = 222, OsBuildName = "6002.18005", OsBuildDescription = "Windows Vista SP2 initial release build from April 2009", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 223, OsBuildName = "6001.18", OsBuildDescription = "Windows Vista SP1 initial release build from February 2008", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 224, OsBuildName = "6000.16386", OsBuildDescription = "Windows Vista RTM initial release build from November 2006", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 225, OsBuildName = "2600.5512", OsBuildDescription = "Windows XP SP3 initial release build from April 2008", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 226, OsBuildName = "2600", OsBuildDescription = "Windows XP RTM initial release build from August 2001", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Windows Server builds
            new { OsBuildId = 227, OsBuildName = "20348.2762", OsBuildDescription = "Windows Server 2022 build from December 2024 with latest updates", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 228, OsBuildName = "20348.169", OsBuildDescription = "Windows Server 2022 initial release build from August 2021", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 229, OsBuildName = "17763.6532", OsBuildDescription = "Windows Server 2019 build from November 2024 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 230, OsBuildName = "17763.1", OsBuildDescription = "Windows Server 2019 initial release build from October 2018", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 231, OsBuildName = "14393.7428", OsBuildDescription = "Windows Server 2016 build from October 2024 update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 232, OsBuildName = "14393", OsBuildDescription = "Windows Server 2016 initial release build from October 2016", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 233, OsBuildName = "9600.21758", OsBuildDescription = "Windows Server 2012 R2 build from July 2023 final update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 234, OsBuildName = "9200.23594", OsBuildDescription = "Windows Server 2012 build from January 2023 final update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 235, OsBuildName = "7601.26706", OsBuildDescription = "Windows Server 2008 R2 SP1 build from December 2023 final update", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 236, OsBuildName = "3790", OsBuildDescription = "Windows Server 2003 RTM initial release build from April 2003", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // macOS builds
            new { OsBuildId = 237, OsBuildName = "24B83", OsBuildDescription = "macOS Sequoia 15.1 build from October 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 238, OsBuildName = "24A335", OsBuildDescription = "macOS Sequoia 15.0 initial release build from September 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 239, OsBuildName = "23G93", OsBuildDescription = "macOS Sonoma 14.6.1 build from August 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 240, OsBuildName = "23A344", OsBuildDescription = "macOS Sonoma 14.0 initial release build from September 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 241, OsBuildName = "22G91", OsBuildDescription = "macOS Ventura 13.6 build from September 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 242, OsBuildName = "22A380", OsBuildDescription = "macOS Ventura 13.0 initial release build from October 2022", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 243, OsBuildName = "21G816", OsBuildDescription = "macOS Monterey 12.7.6 build from July 2024", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 244, OsBuildName = "21A559", OsBuildDescription = "macOS Monterey 12.0.1 initial release build from October 2021", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 245, OsBuildName = "20G918", OsBuildDescription = "macOS Big Sur 11.7.10 build from September 2023", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 246, OsBuildName = "20A2411", OsBuildDescription = "macOS Big Sur 11.0.1 initial release build from November 2020", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 247, OsBuildName = "19H2026", OsBuildDescription = "macOS Catalina 10.15.7 build from November 2021", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 248, OsBuildName = "19A583", OsBuildDescription = "macOS Catalina 10.15 initial release build from October 2019", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 249, OsBuildName = "18G9323", OsBuildDescription = "macOS Mojave 10.14.6 build from November 2021", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 250, OsBuildName = "18A391", OsBuildDescription = "macOS Mojave 10.14 initial release build from September 2018", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 251, OsBuildName = "17G14042", OsBuildDescription = "macOS High Sierra 10.13.6 build from November 2020", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 252, OsBuildName = "17A405", OsBuildDescription = "macOS High Sierra 10.13 initial release build from September 2017", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Linux kernel builds
            new { OsBuildId = 253, OsBuildName = "6.11.0-1", OsBuildDescription = "Debian 12 Bookworm stable kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 254, OsBuildName = "6.1.0-1", OsBuildDescription = "Debian 11 Bullseye stable kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 255, OsBuildName = "5.10.0-1", OsBuildDescription = "Debian 10 Buster stable kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 256, OsBuildName = "6.8.0-1", OsBuildDescription = "Ubuntu 24.04 LTS Noble Numbat kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 257, OsBuildName = "6.5.0-1", OsBuildDescription = "Ubuntu 22.04 LTS Jammy Jellyfish kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 258, OsBuildName = "5.15.0-1", OsBuildDescription = "Ubuntu 20.04 LTS Focal Fossa kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 259, OsBuildName = "5.4.0-1", OsBuildDescription = "Ubuntu 18.04 LTS Bionic Beaver kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 260, OsBuildName = "5.14.0-1", OsBuildDescription = "RHEL 9 initial release kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 261, OsBuildName = "4.18.0-1", OsBuildDescription = "RHEL 8 initial release kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 262, OsBuildName = "3.10.0-1", OsBuildDescription = "RHEL 7 initial release kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 263, OsBuildName = "6.9.0", OsBuildDescription = "Fedora 40 kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 264, OsBuildName = "6.8.0", OsBuildDescription = "Fedora 39 kernel build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // BSD builds
            new { OsBuildId = 265, OsBuildName = "14.0-0", OsBuildDescription = "FreeBSD 14.0-RELEASE build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 266, OsBuildName = "13.2-0", OsBuildDescription = "FreeBSD 13.2-RELEASE build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 267, OsBuildName = "7.4-0", OsBuildDescription = "OpenBSD 7.4-RELEASE build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 268, OsBuildName = "7.3-0", OsBuildDescription = "OpenBSD 7.3-RELEASE build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 269, OsBuildName = "10.0-0", OsBuildDescription = "NetBSD 10.0-RELEASE build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 270, OsBuildName = "9.3-0", OsBuildDescription = "NetBSD 9.3-RELEASE build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },

            // Android/iOS builds
            new { OsBuildId = 271, OsBuildName = "34", OsBuildDescription = "Android 14 API Level 34 build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 272, OsBuildName = "33", OsBuildDescription = "Android 13 API Level 33 build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 273, OsBuildName = "31", OsBuildDescription = "Android 12 API Level 31 build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 274, OsBuildName = "30", OsBuildDescription = "Android 11 API Level 30 build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 275, OsBuildName = "29", OsBuildDescription = "Android 10 API Level 29 build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 276, OsBuildName = "22A3354", OsBuildDescription = "iOS 18.0 initial release build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 277, OsBuildName = "21A331", OsBuildDescription = "iOS 17.0 initial release build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 278, OsBuildName = "20A362", OsBuildDescription = "iOS 16.0 initial release build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 279, OsBuildName = "19A346", OsBuildDescription = "iOS 15.0 initial release build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsBuildId = 280, OsBuildName = "18A373", OsBuildDescription = "iOS 14.0 initial release build", CreatedAt = createdAt, CreatedBy = 1, Version = 1 }
        };

        allSeeds.AddRange(additionalSeeds);
        
        builder.HasData(allSeeds.ToArray());
    }
}