using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

/// <summary>
/// Entity Framework Core configuration for User entity.
/// Implements DoD security requirements and FIPS 140-3 compliance.
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Table configuration
        builder.ToTable("user", t =>
        {
            t.HasComment("System users with CAC authentication support for DoD compliance");
        });

        // Primary Key
        builder.HasKey(u => u.UserId)
            .HasName("PK_user");

        // Properties
        builder.Property(u => u.UserId)
            .HasColumnName("user_id")
            .UseIdentityColumn();

        builder.Property(u => u.FirstName)
            .HasColumnName("user_first")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("User's first name");

        builder.Property(u => u.LastName)
            .HasColumnName("user_last")
            .HasMaxLength(50)
            .IsRequired()
            .HasComment("User's last name");

        builder.Property(u => u.Email)
            .HasColumnName("user_email")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("User's email address - must be unique");

        builder.Property(u => u.Phone)
            .HasColumnName("user_phone")
            .HasMaxLength(20)
            .HasComment("User's phone number - optional");

        builder.Property(u => u.DodId)
            .HasColumnName("user_dodid")
            .IsRequired()
            .HasComment("10-digit DoD ID number (EDIPI) for CAC authentication");

        builder.Property(u => u.CertificateDn)
            .HasColumnName("user_certificate_dn")
            .HasMaxLength(500)
            .IsRequired()
            .HasComment("Distinguished Name from CAC certificate");

        builder.Property(u => u.CertificateSerial)
            .HasColumnName("user_certificate_serial")
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("Certificate serial number for tracking");

        builder.Property(u => u.AccountStatus)
            .HasColumnName("user_account_status")
            .HasConversion<byte>()
            .IsRequired()
            .HasDefaultValue(AccountStatus.Inactive)
            .HasComment("Account status: 0=Inactive, 1=Active, 2=Suspended, 3=Locked");

        builder.Property(u => u.LastCacAuth)
            .HasColumnName("user_last_cac_auth")
            .HasComment("Timestamp of last successful CAC authentication");

        builder.Property(u => u.RequiresCac)
            .HasColumnName("user_requires_cac")
            .IsRequired()
            .HasDefaultValue(true)
            .HasComment("Whether CAC authentication is mandatory for this user");

        builder.Property(u => u.PivAuthCertHash)
            .HasColumnName("user_piv_auth_cert_hash")
            .HasMaxLength(64)
            .HasComment("SHA-256 hash of PIV certificate for pinning (MITM protection)");

        builder.Property(u => u.Affiliation)
            .HasColumnName("user_affiliation")
            .HasMaxLength(20)
            .HasComment("Military branch or civilian agency");

        builder.Property(u => u.PersonDesignator)
            .HasColumnName("user_person_designator")
            .HasMaxLength(20)
            .HasComment("Personnel type: MILITARY, CIVILIAN, CONTRACTOR");

        builder.Property(u => u.CacExpiry)
            .HasColumnName("user_cac_expiry")
            .HasComment("CAC certificate expiration date");

        // Foreign Keys
        builder.Property(u => u.RoleId)
            .HasColumnName("user_role")
            .IsRequired()
            .HasComment("Primary role assignment (required)");

        builder.Property(u => u.SmeRoleId)
            .HasColumnName("sme_role")
            .HasComment("Subject Matter Expert role (optional)");

        // Relationships
        builder.HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_user_role");

        builder.HasOne(u => u.SmeRole)
            .WithMany(s => s.Users)
            .HasForeignKey(u => u.SmeRoleId)
            .OnDelete(DeleteBehavior.SetNull)
            .HasConstraintName("FK_user_smerole");

        // Indexes for performance
        builder.HasIndex(u => u.Email)
            .IsUnique()
            .HasDatabaseName("UX_user_email");

        builder.HasIndex(u => u.DodId)
            .IsUnique()
            .HasDatabaseName("UX_user_dodid");

        builder.HasIndex(u => u.CertificateDn)
            .HasDatabaseName("IX_user_certificate_dn");

        builder.HasIndex(u => u.AccountStatus)
            .HasDatabaseName("IX_user_account_status")
            .HasFilter("[user_account_status] = 1"); // Filtered index for active users

        builder.HasIndex(u => new { u.RoleId, u.AccountStatus })
            .HasDatabaseName("IX_user_role_status");

        builder.HasIndex(u => u.SmeRoleId)
            .HasDatabaseName("IX_user_smerole")
            .HasFilter("[sme_role] IS NOT NULL"); // Filtered index for SMEs only

        // Check constraints for data integrity
        // Check constraints moved to ToTable configuration

        // Audit fields are inherited from BaseEntity and already mapped

        // Seed the SYSTEM user
        SystemUserSeeder.SeedSystemUser(builder);
    }
}