-- IAMSNG Database Setup Script
-- SQL Server 2022 Developer Edition
-- FIPS 140-3 Compliant Configuration

-- Check if database exists, create if not
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'iamsdb')
BEGIN
    CREATE DATABASE [iamsdb]
    PRINT 'Database iamsdb created successfully'
END
ELSE
BEGIN
    PRINT 'Database iamsdb already exists'
END
GO

-- Switch to the database
USE [iamsdb]
GO

-- Enable encryption for FIPS compliance
ALTER DATABASE [iamsdb] SET ENCRYPTION ON
GO

-- Set database options for DoD compliance
ALTER DATABASE [iamsdb] SET RECOVERY FULL
GO

ALTER DATABASE [iamsdb] SET ALLOW_SNAPSHOT_ISOLATION ON
GO

ALTER DATABASE [iamsdb] SET READ_COMMITTED_SNAPSHOT ON
GO

-- Enable Query Store for performance monitoring
ALTER DATABASE [iamsdb] SET QUERY_STORE = ON
GO

ALTER DATABASE [iamsdb] SET QUERY_STORE 
(
    OPERATION_MODE = READ_WRITE,
    CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30),
    DATA_FLUSH_INTERVAL_SECONDS = 900,
    MAX_STORAGE_SIZE_MB = 1000,
    INTERVAL_LENGTH_MINUTES = 60,
    SIZE_BASED_CLEANUP_MODE = AUTO,
    QUERY_CAPTURE_MODE = AUTO,
    MAX_PLANS_PER_QUERY = 200
)
GO

-- Create audit schema for DoD compliance
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'audit')
BEGIN
    EXEC('CREATE SCHEMA [audit] AUTHORIZATION [dbo]')
    PRINT 'Audit schema created'
END
GO

-- Create security schema for access control
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'security')
BEGIN
    EXEC('CREATE SCHEMA [security] AUTHORIZATION [dbo]')
    PRINT 'Security schema created'
END
GO

PRINT 'Database setup completed successfully'
PRINT 'Connection String: Server=(local);Database=iamsdb;Trusted_Connection=True;TrustServerCertificate=False;Encrypt=True'