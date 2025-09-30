using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Seeds the SYSTEM user required for audit trails and system operations.
/// This user cannot log in and is used only for database audit integrity.
/// </summary>
public static class SystemUserSeeder
{
    public static void SeedSystemUser(EntityTypeBuilder<User> builder)
    {
        var systemUserId = 1;
        var systemRoleId = 1; // "system" role
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero); // Fixed date for consistency

        builder.HasData(new User
        {
            UserId = systemUserId,
            FirstName = "SYSTEM",
            LastName = "ACCOUNT",
            Email = "system@iamsng.local",
            Phone = null,
            DodId = 0000000000, // Special value for system account
            CertificateDn = "CN=SYSTEM,OU=IAMSNG,O=DoD,C=US",
            CertificateSerial = "SYSTEM-ACCOUNT-NO-LOGIN",
            AccountStatus = AccountStatus.Active, // Always active for audit purposes
            LastCacAuth = null, // Never authenticates
            RequiresCac = false, // Cannot use CAC
            PivAuthCertHash = null, // No certificate
            Affiliation = "SYSTEM",
            PersonDesignator = "SYSTEM",
            CacExpiry = null, // Never expires
            RoleId = systemRoleId,
            SmeRoleId = null, // No SME role for system
            CreatedAt = createdAt,
            CreatedBy = systemUserId, // Self-created (bootstrap)
            ModifiedAt = null,
            ModifiedBy = null,
            Version = 1
        });
    }
}