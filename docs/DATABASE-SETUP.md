# Database Setup and Configuration Guide

## Executive Summary

This document provides comprehensive guidance for configuring Microsoft SQL Server 2022 Developer Edition for the IAMSNG (Industrial Asset Management System) project, with specific emphasis on meeting DoD security requirements including FIPS 140-3 compliance. The configuration supports both local development and enterprise deployment scenarios while maintaining strict security standards throughout the application lifecycle.

## Table of Contents

1. [Overview](#overview)
2. [Prerequisites](#prerequisites)
3. [SQL Server 2022 Installation](#sql-server-2022-installation)
4. [FIPS 140-3 Compliance Configuration](#fips-140-3-compliance-configuration)
5. [Database Instance Configuration](#database-instance-configuration)
6. [Connection String Configuration](#connection-string-configuration)
7. [Security Settings](#security-settings)
8. [Windows Authentication Setup](#windows-authentication-setup)
9. [Migration Path to Enterprise Authentication](#migration-path-to-enterprise-authentication)
10. [Entity Framework Core Configuration](#entity-framework-core-configuration)
11. [Audit and Compliance Features](#audit-and-compliance-features)
12. [Troubleshooting](#troubleshooting)

## Overview

The IAMSNG system utilizes SQL Server 2022 Developer Edition as its primary data store, configured to meet stringent DoD security requirements. The database architecture implements defense-in-depth principles with multiple layers of security controls.

### Key Requirements
- **FIPS 140-3 Level 1** compliance for cryptographic operations
- **DoD STIG** compliance for database security
- **Audit trail** requirements per NIST 800-53
- **Data encryption** at rest and in transit
- **Windows Authentication** as primary authentication mechanism

## Prerequisites

### System Requirements
```yaml
Operating System: Windows Server 2019/2022 or Windows 10/11 Pro
Memory: Minimum 8GB RAM (16GB recommended)
Storage: 50GB available space for database files
.NET Runtime: .NET 8.0 Runtime installed
SQL Server: SQL Server 2022 Developer Edition
```

### Required Windows Features
```powershell
# Enable required Windows features
Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServerRole
Enable-WindowsOptionalFeature -Online -FeatureName IIS-WindowsAuthentication
```

## SQL Server 2022 Installation

### Download and Installation Steps

1. **Download SQL Server 2022 Developer Edition**
   ```
   URL: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
   Edition: Developer (free for development/testing)
   ```

2. **Installation Configuration**
   ```sql
   Instance Name: IAMSDB
   Authentication Mode: Windows Authentication
   Collation: SQL_Latin1_General_CP1_CI_AS
   TempDB Files: 4 (minimum)
   Max Memory: 80% of available RAM
   ```

3. **Feature Selection**
   - Database Engine Services
   - SQL Server Replication
   - Full-Text and Semantic Extractions
   - Data Quality Services
   - SQL Server Management Tools

### Post-Installation Configuration Script
```sql
-- Enable advanced options
EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;

-- Configure for FIPS compliance
EXEC sp_configure 'common criteria compliance enabled', 1;
RECONFIGURE WITH OVERRIDE;

-- Enable encryption
EXEC sp_configure 'remote query timeout', 600;
EXEC sp_configure 'cost threshold for parallelism', 50;
RECONFIGURE;

-- Configure audit specifications
CREATE SERVER AUDIT [DOD_Compliance_Audit]
TO FILE 
(
    FILEPATH = 'C:\SQLAudit\',
    MAXSIZE = 100 MB,
    MAX_ROLLOVER_FILES = 10,
    RESERVE_DISK_SPACE = ON
)
WITH (QUEUE_DELAY = 1000, ON_FAILURE = SHUTDOWN);

ALTER SERVER AUDIT [DOD_Compliance_Audit] WITH (STATE = ON);
```

## FIPS 140-3 Compliance Configuration

### Windows FIPS Mode Configuration
```powershell
# Enable FIPS Algorithm Policy
# Run as Administrator
New-ItemProperty -Path "HKLM:\SYSTEM\CurrentControlSet\Control\Lsa\FipsAlgorithmPolicy" `
    -Name "Enabled" -Value 1 -PropertyType DWORD -Force

# Verify FIPS mode is enabled
Get-ItemProperty -Path "HKLM:\SYSTEM\CurrentControlSet\Control\Lsa\FipsAlgorithmPolicy" `
    -Name "Enabled"
```

### SQL Server FIPS Configuration
```sql
-- Configure SQL Server for FIPS-compliant encryption
USE master;
GO

-- Create master key for encryption
CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'StrongP@ssw0rd123!';
GO

-- Create certificate for TDE
CREATE CERTIFICATE TDE_Certificate
WITH SUBJECT = 'IAMSNG TDE Certificate',
EXPIRY_DATE = '2034-12-31';
GO

-- Backup certificate (CRITICAL - Store securely)
BACKUP CERTIFICATE TDE_Certificate
TO FILE = 'C:\SQLBackup\TDE_Certificate.cer'
WITH PRIVATE KEY (
    FILE = 'C:\SQLBackup\TDE_Certificate_Key.pvk',
    ENCRYPTION BY PASSWORD = 'CertP@ssw0rd456!'
);
GO
```

### Application-Level FIPS Validation
```csharp
// ApplicationDbContext.cs validation method
private void ValidateFipsCompliance()
{
    try
    {
        using (var aes = Aes.Create())
        {
            aes.GenerateKey(); // Will fail if FIPS is not enabled
        }
    }
    catch (CryptographicException ex)
    {
        throw new InvalidOperationException(
            "System must be running in FIPS 140-3 compliant mode for DoD requirements.", ex);
    }
}
```

## Database Instance Configuration

### Create IAMSNG Database
```sql
-- Create database with specific file configurations
CREATE DATABASE [IAMSNG]
ON PRIMARY
(
    NAME = N'IAMSNG',
    FILENAME = N'C:\SQLData\IAMSNG.mdf',
    SIZE = 100MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 64MB
)
LOG ON
(
    NAME = N'IAMSNG_log',
    FILENAME = N'C:\SQLData\IAMSNG_log.ldf',
    SIZE = 50MB,
    MAXSIZE = 2048GB,
    FILEGROWTH = 64MB
);
GO

-- Enable Transparent Data Encryption
USE [IAMSNG];
GO

CREATE DATABASE ENCRYPTION KEY
WITH ALGORITHM = AES_256
ENCRYPTION BY SERVER CERTIFICATE TDE_Certificate;
GO

ALTER DATABASE [IAMSNG] SET ENCRYPTION ON;
GO

-- Configure database options
ALTER DATABASE [IAMSNG] SET RECOVERY FULL;
ALTER DATABASE [IAMSNG] SET PAGE_VERIFY CHECKSUM;
ALTER DATABASE [IAMSNG] SET AUTO_UPDATE_STATISTICS ON;
ALTER DATABASE [IAMSNG] SET AUTO_UPDATE_STATISTICS_ASYNC ON;
GO
```

### Temporal Tables Configuration
```sql
-- Example temporal table for audit trail
CREATE TABLE dbo.Assets
(
    AssetId INT NOT NULL PRIMARY KEY CLUSTERED,
    AssetName NVARCHAR(100) NOT NULL,
    AssetType NVARCHAR(50) NOT NULL,
    SerialNumber NVARCHAR(100) NOT NULL,
    AcquisitionDate DATE NOT NULL,
    LastModifiedBy NVARCHAR(100) NOT NULL,
    -- Temporal table columns
    ValidFrom DATETIME2 GENERATED ALWAYS AS ROW START NOT NULL,
    ValidTo DATETIME2 GENERATED ALWAYS AS ROW END NOT NULL,
    PERIOD FOR SYSTEM_TIME (ValidFrom, ValidTo)
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = dbo.AssetsHistory));
```

## Connection String Configuration

### Development Environment (Windows Authentication)
```json
// appsettings.Development.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\IAMSDB;Database=IAMSNG;Trusted_Connection=True;TrustServerCertificate=False;Encrypt=True;MultipleActiveResultSets=true;Application Name=IAMSNG_Dev"
  },
  "Security": {
    "RequireFips": true,
    "MinTlsVersion": "1.2",
    "EnableAudit": true
  }
}
```

### Production Environment (Integrated Security)
```json
// appsettings.Production.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=PROD-SQL-01\\IAMSDB;Initial Catalog=IAMSNG;Integrated Security=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Application Name=IAMSNG_Prod"
  },
  "Security": {
    "RequireFips": true,
    "MinTlsVersion": "1.3",
    "EnableAudit": true,
    "AuditLevel": "Detailed"
  }
}
```

### Connection String Security Parameters
| Parameter | Description | DoD Requirement |
|-----------|-------------|-----------------|
| `Encrypt=True` | Forces TLS encryption | REQUIRED |
| `TrustServerCertificate=False` | Validates server certificate | REQUIRED |
| `Integrated Security=True` | Uses Windows Authentication | RECOMMENDED |
| `Connection Timeout=30` | Limits connection attempts | RECOMMENDED |
| `MultipleActiveResultSets=true` | Enables MARS for performance | OPTIONAL |

## Security Settings

### Database-Level Security Configuration
```sql
-- Create application role for least privilege
CREATE ROLE [IAMSNG_AppRole];
GO

-- Grant minimum required permissions
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO [IAMSNG_AppRole];
GRANT EXECUTE ON SCHEMA::dbo TO [IAMSNG_AppRole];
GO

-- Deny unnecessary permissions
DENY CREATE TABLE TO [IAMSNG_AppRole];
DENY ALTER ANY SCHEMA TO [IAMSNG_AppRole];
DENY CREATE PROCEDURE TO [IAMSNG_AppRole];
GO

-- Create login for application service account
CREATE LOGIN [DOMAIN\IAMSNG_Service] FROM WINDOWS;
GO

-- Map login to database user
USE [IAMSNG];
CREATE USER [IAMSNG_Service] FOR LOGIN [DOMAIN\IAMSNG_Service];
ALTER ROLE [IAMSNG_AppRole] ADD MEMBER [IAMSNG_Service];
GO
```

### Row-Level Security Implementation
```sql
-- Create security policy for row-level security
CREATE SCHEMA Security;
GO

CREATE FUNCTION Security.fn_SecurityPredicate(@UserId INT)
RETURNS TABLE
WITH SCHEMABINDING
AS
RETURN SELECT 1 AS fn_SecurityPredicate_result
WHERE @UserId = CONVERT(INT, SESSION_CONTEXT(N'UserId'));
GO

CREATE SECURITY POLICY AssetFilter
ADD FILTER PREDICATE Security.fn_SecurityPredicate(UserId)
ON dbo.UserAssets
WITH (STATE = ON);
GO
```

### Column-Level Encryption
```sql
-- Create column master key
CREATE COLUMN MASTER KEY CMK_IAMSNG
WITH (
    KEY_STORE_PROVIDER_NAME = 'MSSQL_CERTIFICATE_STORE',
    KEY_PATH = 'CurrentUser/My/A6B5C4D3E2F1G0H9I8J7K6L5M4N3O2P1'
);

-- Create column encryption key
CREATE COLUMN ENCRYPTION KEY CEK_IAMSNG
WITH VALUES (
    COLUMN_MASTER_KEY = CMK_IAMSNG,
    ALGORITHM = 'RSA_OAEP',
    ENCRYPTED_VALUE = 0x... -- Generated value
);

-- Apply to sensitive columns
ALTER TABLE dbo.Users
ALTER COLUMN SSN NVARCHAR(11)
ENCRYPTED WITH (
    COLUMN_ENCRYPTION_KEY = CEK_IAMSNG,
    ENCRYPTION_TYPE = Deterministic,
    ALGORITHM = 'AEAD_AES_256_CBC_HMAC_SHA_256'
);
```

## Windows Authentication Setup

### Local Development Configuration

1. **Create Local Windows Account**
```powershell
# Create local development account
New-LocalUser -Name "IAMSNG_Dev" -Password (ConvertTo-SecureString "Dev@Pass123!" -AsPlainText -Force)
Add-LocalGroupMember -Group "Users" -Member "IAMSNG_Dev"
```

2. **SQL Server Login Creation**
```sql
-- Create Windows authentication login
CREATE LOGIN [COMPUTERNAME\IAMSNG_Dev] FROM WINDOWS;
GO

USE [IAMSNG];
CREATE USER [IAMSNG_Dev] FOR LOGIN [COMPUTERNAME\IAMSNG_Dev];
ALTER ROLE [db_datareader] ADD MEMBER [IAMSNG_Dev];
ALTER ROLE [db_datawriter] ADD MEMBER [IAMSNG_Dev];
GO
```

3. **Application Pool Configuration (IIS)**
```xml
<!-- applicationHost.config -->
<add name="IAMSNG_AppPool" managedRuntimeVersion="v4.0">
    <processModel identityType="SpecificUser" 
                   userName="COMPUTERNAME\IAMSNG_Dev" 
                   password="[encrypted]" />
</add>
```

### Service Account Best Practices
- Use separate accounts for each environment
- Implement password rotation policy (90 days)
- Enable account lockout after 3 failed attempts
- Log all authentication attempts

## Migration Path to Enterprise Authentication

### Phase 1: Development Environment
```csharp
// Startup.cs - Development configuration
public void ConfigureDevelopmentServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection"),
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
            }));
    
    services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
        .AddNegotiate();
}
```

### Phase 2: Staging Environment with AD Integration
```csharp
// Startup.cs - Staging configuration
public void ConfigureStagingServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("StagingConnection")));
    
    services.AddAuthentication(IISDefaults.AuthenticationScheme);
    
    services.AddAuthorization(options =>
    {
        options.AddPolicy("DomainUsers", policy =>
            policy.RequireAuthenticatedUser()
                  .RequireClaim(ClaimTypes.GroupSid, "S-1-5-21-domain-513"));
    });
}
```

### Phase 3: Production Environment with PKI
```csharp
// Startup.cs - Production configuration
public void ConfigureProductionServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(
            Configuration.GetConnectionString("ProductionConnection"),
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure();
                sqlOptions.CommandTimeout(30);
            });
    });
    
    // Certificate-based authentication
    services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
        .AddCertificate(options =>
        {
            options.AllowedCertificateTypes = CertificateTypes.Chained;
            options.ValidateCertificateUse = true;
            options.ValidateValidityPeriod = true;
            options.RevocationMode = X509RevocationMode.Online;
            options.Events = new CertificateAuthenticationEvents
            {
                OnCertificateValidated = context =>
                {
                    // Custom validation logic for DoD PKI certificates
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, 
                            context.ClientCertificate.Subject, 
                            ClaimValueTypes.String, context.Options.ClaimsIssuer),
                        new Claim(ClaimTypes.Name, 
                            context.ClientCertificate.Subject, 
                            ClaimValueTypes.String, context.Options.ClaimsIssuer)
                    };
                    
                    context.Principal = new ClaimsPrincipal(
                        new ClaimsIdentity(claims, context.Scheme.Name));
                    context.Success();
                    
                    return Task.CompletedTask;
                }
            };
        });
}
```

## Entity Framework Core Configuration

### DbContext Configuration
```csharp
// ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<ApplicationDbContext> _logger;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IConfiguration configuration,
        ILogger<ApplicationDbContext> logger)
        : base(options)
    {
        _configuration = configuration;
        _logger = logger;
        ValidateFipsCompliance();
        ConfigureAudit();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            throw new InvalidOperationException(
                "Database connection must be explicitly configured for security compliance.");
        }

        // Apply security configurations
        optionsBuilder.AddInterceptors(new AuditingInterceptor(_logger));
        
        #if DEBUG
        optionsBuilder.EnableSensitiveDataLogging(false); // Never log sensitive data
        #endif
        
        optionsBuilder.EnableDetailedErrors(false);
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Apply configurations
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
        // Configure temporal tables for all entities
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.GetInterface(nameof(IAuditable)) != null)
            {
                modelBuilder.Entity(entityType.ClrType)
                    .ToTable(tb => tb.IsTemporal());
            }
        }
        
        // Apply global query filters for soft delete
        modelBuilder.Entity<BaseEntity>()
            .HasQueryFilter(e => !e.IsDeleted);
    }
}
```

### Migration Commands
```bash
# Add migration
dotnet ef migrations add InitialCreate -c ApplicationDbContext -p src/iamsng.Infrastructure -s src/iamsng.Web

# Update database
dotnet ef database update -c ApplicationDbContext -p src/iamsng.Infrastructure -s src/iamsng.Web

# Generate SQL script for review
dotnet ef migrations script -c ApplicationDbContext -p src/iamsng.Infrastructure -s src/iamsng.Web -o migration.sql
```

## Audit and Compliance Features

### Database Audit Specification
```sql
-- Create database audit specification
CREATE DATABASE AUDIT SPECIFICATION [IAMSNG_Database_Audit]
FOR SERVER AUDIT [DOD_Compliance_Audit]
ADD (SELECT, INSERT, UPDATE, DELETE, EXECUTE ON SCHEMA::dbo BY [public]),
ADD (DATABASE_ROLE_MEMBER_CHANGE_GROUP),
ADD (DATABASE_PERMISSION_CHANGE_GROUP),
ADD (SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP),
ADD (DATABASE_PRINCIPAL_CHANGE_GROUP)
WITH (STATE = ON);
GO

-- Create audit table for application-level auditing
CREATE TABLE dbo.AuditLog
(
    AuditId BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    EventTime DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    UserName NVARCHAR(100) NOT NULL,
    IPAddress NVARCHAR(50),
    Action NVARCHAR(50) NOT NULL,
    EntityType NVARCHAR(100),
    EntityId NVARCHAR(100),
    OldValues NVARCHAR(MAX),
    NewValues NVARCHAR(MAX),
    Success BIT NOT NULL DEFAULT 1,
    ErrorMessage NVARCHAR(MAX)
);

-- Create index for audit queries
CREATE NONCLUSTERED INDEX IX_AuditLog_EventTime 
ON dbo.AuditLog(EventTime DESC) 
INCLUDE (UserName, Action, EntityType);
```

### Application-Level Audit Implementation
```csharp
public class AuditingInterceptor : SaveChangesInterceptor
{
    private readonly ILogger _logger;
    
    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        var context = eventData.Context;
        var auditEntries = new List<AuditEntry>();
        
        foreach (var entry in context.ChangeTracker.Entries())
        {
            if (entry.Entity is IAuditable || 
                entry.State == EntityState.Added || 
                entry.State == EntityState.Modified || 
                entry.State == EntityState.Deleted)
            {
                var auditEntry = new AuditEntry
                {
                    TableName = entry.Metadata.GetTableName(),
                    Action = entry.State.ToString(),
                    DateTime = DateTime.UtcNow,
                    Username = context.GetService<IHttpContextAccessor>()?.HttpContext?.User?.Identity?.Name ?? "System",
                    Changes = GetChanges(entry)
                };
                
                auditEntries.Add(auditEntry);
            }
        }
        
        // Save audit entries to audit table
        if (auditEntries.Any())
        {
            await SaveAuditEntries(context, auditEntries);
        }
        
        return result;
    }
}
```

## Troubleshooting

### Common Issues and Solutions

#### FIPS Compliance Errors
```plaintext
Error: "System.Security.Cryptography.CryptographicException: This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms."

Solution:
1. Enable FIPS in Windows Group Policy
2. Restart SQL Server service
3. Verify all cryptographic operations use FIPS-compliant algorithms
```

#### Connection Timeout Issues
```csharp
// Add retry logic to connection string
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: new[] { 
                49918, 49919, 49920, 4060, 18456 
            });
    }));
```

#### Windows Authentication Failures
```powershell
# Verify SPN registration
setspn -L DOMAIN\IAMSNG_Service

# Register SPN if missing
setspn -A MSSQLSvc/servername.domain.com:1433 DOMAIN\IAMSNG_Service
setspn -A MSSQLSvc/servername:1433 DOMAIN\IAMSNG_Service
```

#### TDE Performance Impact
```sql
-- Monitor TDE encryption progress
SELECT 
    DB_NAME(database_id) AS DatabaseName,
    encryption_state,
    encryption_state_desc,
    percent_complete,
    key_algorithm,
    key_length
FROM sys.dm_database_encryption_keys;

-- Check TDE performance impact
SELECT 
    wait_type,
    waiting_tasks_count,
    wait_time_ms,
    max_wait_time_ms
FROM sys.dm_os_wait_stats
WHERE wait_type LIKE '%ENCRYPTION%'
ORDER BY wait_time_ms DESC;
```

### Performance Monitoring Queries
```sql
-- Monitor database performance
SELECT 
    database_name = DB_NAME(database_id),
    [Database Size (MB)] = CAST(SUM(size) * 8. / 1024 AS DECIMAL(10,2)),
    [Unallocated Space (MB)] = SUM(CASE WHEN type_desc = 'ROWS' 
        THEN size - CAST(FILEPROPERTY(name, 'SpaceUsed') AS INT) 
        ELSE 0 END) * 8. / 1024
FROM sys.master_files
WHERE database_id = DB_ID('IAMSNG')
GROUP BY database_id;

-- Check for blocking queries
SELECT 
    blocking_session_id,
    session_id,
    wait_type,
    wait_time,
    wait_resource,
    transaction_id
FROM sys.dm_exec_requests
WHERE blocking_session_id > 0;
```

## Security Checklist

- [ ] FIPS 140-3 mode enabled at OS level
- [ ] SQL Server configured for encrypted connections
- [ ] TDE enabled on database
- [ ] Audit specifications created and enabled
- [ ] Windows Authentication configured
- [ ] Service accounts created with minimal privileges
- [ ] Row-level security implemented where applicable
- [ ] Column encryption applied to sensitive data
- [ ] Regular backup schedule configured
- [ ] Disaster recovery plan tested
- [ ] Security patches applied monthly
- [ ] Audit logs reviewed weekly
- [ ] Certificate backups stored securely
- [ ] Connection strings encrypted in configuration
- [ ] Temporal tables enabled for audit trail

## References

- [SQL Server 2022 Security Documentation](https://docs.microsoft.com/en-us/sql/relational-databases/security/)
- [FIPS 140-3 Compliance Guide](https://csrc.nist.gov/projects/cryptographic-module-validation-program)
- [DoD Database STIG](https://public.cyber.mil/stigs/downloads/)
- [Entity Framework Core Security](https://docs.microsoft.com/en-us/ef/core/security/)
- [NIST 800-53 Security Controls](https://nvlpubs.nist.gov/nistpubs/SpecialPublications/NIST.SP.800-53r5.pdf)