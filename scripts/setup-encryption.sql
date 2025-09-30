-- Setup Transparent Data Encryption (TDE) for FIPS 140-3 Compliance
-- Note: In production, use a proper certificate management system

USE master;
GO

-- Create a master key if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.symmetric_keys WHERE name = '##MS_DatabaseMasterKey##')
BEGIN
    CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'Str0ng!P@ssw0rd#2025_IAMSNG';
    PRINT 'Master key created'
END
GO

-- Create or retrieve certificate for TDE
IF NOT EXISTS (SELECT * FROM sys.certificates WHERE name = 'IAMSNG_TDE_Certificate')
BEGIN
    CREATE CERTIFICATE IAMSNG_TDE_Certificate
    WITH SUBJECT = 'IAMSNG Database Encryption Certificate',
    EXPIRY_DATE = '2030-12-31';
    PRINT 'TDE Certificate created'
END
GO

-- Switch to iamsdb
USE [iamsdb];
GO

-- Create database encryption key
IF NOT EXISTS (SELECT * FROM sys.dm_database_encryption_keys WHERE database_id = DB_ID())
BEGIN
    CREATE DATABASE ENCRYPTION KEY
    WITH ALGORITHM = AES_256
    ENCRYPTION BY SERVER CERTIFICATE IAMSNG_TDE_Certificate;
    PRINT 'Database encryption key created'
END
GO

-- Now enable encryption
ALTER DATABASE [iamsdb] SET ENCRYPTION ON;
GO

PRINT 'Transparent Data Encryption enabled successfully'

-- Verify encryption status
SELECT 
    db.name as database_name,
    db.is_encrypted,
    dm.encryption_state,
    dm.encryption_state_desc,
    dm.percent_complete
FROM sys.databases db
LEFT JOIN sys.dm_database_encryption_keys dm
    ON db.database_id = dm.database_id
WHERE db.name = 'iamsdb';
GO