using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Config;

public class OsEditionConfiguration : IEntityTypeConfiguration<OsEdition>
{
    public void Configure(EntityTypeBuilder<OsEdition> builder)
    {
        builder.HasKey(e => e.OsEditionId);
        
        builder.HasIndex(e => e.OsEditionName)
            .IsUnique()
            .HasDatabaseName("UX_os_edition_name");

        // Seed data for OS editions
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var osEditions = new[]
        {
            new { OsEditionId = 1, OsEditionName = "Home", OsEditionDescription = "Consumer-focused edition with basic features for personal and household use", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 2, OsEditionName = "Professional", OsEditionDescription = "Business-oriented edition with advanced features for professionals and small businesses", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 3, OsEditionName = "Enterprise", OsEditionDescription = "Full-featured edition designed for large organizations with advanced management and security capabilities", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 4, OsEditionName = "Ultimate", OsEditionDescription = "Premium edition with all available features and capabilities; highest tier consumer offering", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 5, OsEditionName = "Starter", OsEditionDescription = "Entry-level edition with limited features for budget-conscious users or emerging markets", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 6, OsEditionName = "Standard", OsEditionDescription = "Mid-tier edition balancing features and cost for general business use", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 7, OsEditionName = "Datacenter", OsEditionDescription = "High-end server edition optimized for large-scale virtualization and cloud infrastructure", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 8, OsEditionName = "Workstation", OsEditionDescription = "High-performance edition optimized for content creation technical computing and advanced workloads", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 9, OsEditionName = "Education", OsEditionDescription = "Special edition for academic institutions students and educators with educational licensing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 10, OsEditionName = "Server", OsEditionDescription = "General server edition for hosting services applications and network infrastructure", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 11, OsEditionName = "Desktop", OsEditionDescription = "Standard desktop edition for workstation and personal computer use", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 12, OsEditionName = "Core", OsEditionDescription = "Minimal installation edition without GUI for reduced resource usage and attack surface", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 13, OsEditionName = "Community", OsEditionDescription = "Free community-supported edition typically for non-commercial use", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 14, OsEditionName = "Developer", OsEditionDescription = "Edition with development tools and features for software developers and programmers", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 15, OsEditionName = "LTS", OsEditionDescription = "Long Term Support edition with extended support lifecycle and stability focus", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 16, OsEditionName = "IoT", OsEditionDescription = "Internet of Things edition optimized for embedded devices and edge computing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 17, OsEditionName = "Embedded", OsEditionDescription = "Specialized edition for embedded systems industrial automation and dedicated appliances", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 18, OsEditionName = "Mobile", OsEditionDescription = "Edition designed for smartphones tablets and mobile computing devices", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 19, OsEditionName = "Server Core", OsEditionDescription = "Minimal server installation without graphical interface for improved security and performance", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 20, OsEditionName = "Web", OsEditionDescription = "Server edition optimized specifically for web hosting and internet-facing applications", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 21, OsEditionName = "Storage", OsEditionDescription = "Specialized edition optimized for file servers and storage area networks", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 22, OsEditionName = "HPC", OsEditionDescription = "High Performance Computing edition for scientific computing and computational clusters", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 23, OsEditionName = "Pro for Workstations", OsEditionDescription = "Enhanced professional edition with support for high-end hardware and advanced computing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 24, OsEditionName = "Small Business", OsEditionDescription = "Edition tailored for small business environments with simplified management features", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 25, OsEditionName = "Premium", OsEditionDescription = "Enhanced consumer edition with additional features beyond standard offering", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 26, OsEditionName = "Basic", OsEditionDescription = "Simplified edition with core functionality for basic computing needs", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 27, OsEditionName = "Evaluation", OsEditionDescription = "Time-limited trial edition for testing and evaluation purposes before purchase", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 28, OsEditionName = "OEM", OsEditionDescription = "Original Equipment Manufacturer edition pre-installed on hardware by manufacturers", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 29, OsEditionName = "Retail", OsEditionDescription = "Full retail edition sold through commercial channels with transferable licensing", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 30, OsEditionName = "Volume License", OsEditionDescription = "Edition for organizations purchasing multiple licenses with centralized management", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 31, OsEditionName = "Cloud", OsEditionDescription = "Edition optimized for cloud deployment and multi-tenant environments", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 32, OsEditionName = "Hyper-V", OsEditionDescription = "Server edition focused on virtualization and hypervisor functionality", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 33, OsEditionName = "Essentials", OsEditionDescription = "Small business server edition with user/device limitations and simplified management", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 34, OsEditionName = "Foundation", OsEditionDescription = "Entry-level server edition with hardware limitations for small businesses", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 35, OsEditionName = "ARM", OsEditionDescription = "Edition compiled for ARM processor architecture for mobile and embedded devices", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 36, OsEditionName = "Minimal", OsEditionDescription = "Stripped-down installation with only essential components for specialized deployments", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 37, OsEditionName = "Live", OsEditionDescription = "Bootable edition that runs from external media without installation for testing or recovery", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 38, OsEditionName = "Rescue", OsEditionDescription = "Specialized edition for system recovery troubleshooting and data rescue operations", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 39, OsEditionName = "Thin Client", OsEditionDescription = "Lightweight edition optimized for thin client devices and virtual desktop infrastructure", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 40, OsEditionName = "Container", OsEditionDescription = "Optimized edition for containerized applications and microservices architectures", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 41, OsEditionName = "Academic", OsEditionDescription = "Special licensing edition for educational institutions with volume discounts", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 42, OsEditionName = "NFR", OsEditionDescription = "Not For Resale edition provided to partners vendors or for demonstration purposes", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 43, OsEditionName = "Beta", OsEditionDescription = "Pre-release edition for testing new features before general availability", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 44, OsEditionName = "Preview", OsEditionDescription = "Early access edition showcasing upcoming features for feedback and evaluation", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 45, OsEditionName = "Insider", OsEditionDescription = "Continuous update edition for early adopters testing cutting-edge features", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 46, OsEditionName = "Stable", OsEditionDescription = "Production-ready edition with thoroughly tested features and long-term stability", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 47, OsEditionName = "Testing", OsEditionDescription = "Edition containing features undergoing validation before stable release", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 48, OsEditionName = "Unstable", OsEditionDescription = "Bleeding-edge edition with latest untested features for developers and testers", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 49, OsEditionName = "Rolling Release", OsEditionDescription = "Continuously updated edition without distinct version releases", CreatedAt = createdAt, CreatedBy = 1, Version = 1 },
            new { OsEditionId = 50, OsEditionName = "Extended Security", OsEditionDescription = "Edition receiving extended security updates beyond standard support lifecycle", CreatedAt = createdAt, CreatedBy = 1, Version = 1 }
        };

        builder.HasData(osEditions);
    }
}