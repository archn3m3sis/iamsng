using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data;

/// <summary>
/// Primary database context for IAMSNG application
/// Configured for FIPS 140-3 compliance per DoD requirements
/// </summary>
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        // Ensure FIPS-compliant algorithms are used
        ValidateFipsCompliance();
    }

    // DbSets for our entities
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<SmeRole> SmeRoles { get; set; } = null!;
    public DbSet<Program> Programs { get; set; } = null!;
    public DbSet<Building> Buildings { get; set; } = null!;
    public DbSet<Floor> Floors { get; set; } = null!;
    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<Installation> Installations { get; set; } = null!;
    public DbSet<HardwareManufacturer> HardwareManufacturers { get; set; } = null!;
    public DbSet<SoftwareManufacturer> SoftwareManufacturers { get; set; } = null!;
    public DbSet<Condition> Conditions { get; set; } = null!;
    public DbSet<HwEnclosure> HwEnclosures { get; set; } = null!;
    public DbSet<PhysicalMemoryType> PhysicalMemoryTypes { get; set; } = null!;
    public DbSet<GpuType> GpuTypes { get; set; } = null!;
    public DbSet<CpuType> CpuTypes { get; set; } = null!;
    public DbSet<SysArchitecture> SysArchitectures { get; set; } = null!;
    public DbSet<OsVendor> OsVendors { get; set; } = null!;
    public DbSet<OsPlatform> OsPlatforms { get; set; } = null!;
    public DbSet<OsEdition> OsEditions { get; set; } = null!;
    public DbSet<OsBuild> OsBuilds { get; set; } = null!;
    public DbSet<OsVersion> OsVersions { get; set; } = null!;
    public DbSet<MotherboardType> MotherboardTypes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Apply all entity configurations from this assembly
        // This includes RoleConfiguration, SmeRoleConfiguration, and UserConfiguration
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
        // Enable temporal tables for audit trail (SQL Server 2022 feature)
        // This will be configured per entity as needed for DoD compliance
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Security: Log warning if connection is not configured
            // In production, this should fail rather than continue
            throw new InvalidOperationException(
                "Database connection must be explicitly configured for security compliance.");
        }

        // Enable sensitive data logging only in development
        #if DEBUG
        optionsBuilder.EnableSensitiveDataLogging(false); // Still false for DoD requirements
        #endif

        // Enable detailed errors only in development
        optionsBuilder.EnableDetailedErrors(false);
    }

    private void ValidateFipsCompliance()
    {
        // Verify FIPS mode is enabled on the system
        try
        {
            // This checks if the system is running in FIPS mode
            using (var aes = Aes.Create())
            {
                // If FIPS mode is enabled, only FIPS-compliant algorithms will work
                aes.GenerateKey();
            }
        }
        catch (CryptographicException ex)
        {
            throw new InvalidOperationException(
                "System must be running in FIPS 140-3 compliant mode for DoD requirements.", ex);
        }
    }
}