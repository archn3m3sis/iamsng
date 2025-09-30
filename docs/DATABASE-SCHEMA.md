# IAMSNG Database Schema Documentation

> **Version**: 1.2.0  
> **Last Updated**: 2025-09-29 (Session 004)  
> **Database**: Microsoft SQL Server 2022  
> **Schema Version**: Migration AddOsPlatformTable

## Overview

The IAMSNG database implements a comprehensive Industrial Asset Management System designed for Department of Defense (DoD) deployment. The schema follows Clean Architecture principles with Entity Framework Core 8 Code-First approach, ensuring complete audit trail capabilities and FIPS 140-3 compliance.

## Database Configuration

- **Server Name**: `iamsdb`
- **Authentication**: Windows Authentication (Development) / CAC Authentication (Production)
- **Encryption**: TLS 1.2+ required for all connections
- **TDE**: Transparent Data Encryption enabled with AES-256
- **Connection Pooling**: Min=10, Max=100
- **Audit Level**: Full audit trail on all tables

## Base Entity Pattern

All tables inherit from `BaseEntity` which provides standard audit fields:

```sql
CreatedAt      DATETIMEOFFSET NOT NULL  -- Record creation timestamp
CreatedBy      INT NOT NULL             -- User ID who created record
ModifiedAt     DATETIMEOFFSET NULL      -- Last modification timestamp
ModifiedBy     INT NULL                 -- User ID who last modified
Version        INT NOT NULL             -- Optimistic concurrency control
```

## Table Definitions

### 1. User Table (`user`)
**Purpose**: System users with support for CAC/PIV authentication

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| user_id | INT | PK, IDENTITY | Primary key |
| username | NVARCHAR(50) | NOT NULL, UNIQUE | Unique username |
| email | NVARCHAR(100) | NOT NULL, UNIQUE | User email address |
| first_name | NVARCHAR(50) | NOT NULL | User first name |
| last_name | NVARCHAR(50) | NOT NULL | User last name |
| edipi | NVARCHAR(20) | NULL, UNIQUE | DoD ID number for CAC |
| role_id | INT | FK → role | User's primary role |
| sme_role_id | INT | FK → sme_role, NULL | Subject matter expertise |
| installation_id | INT | FK → installation, NULL | Assigned installation |
| building_id | INT | FK → building, NULL | Primary building location |
| room_id | INT | FK → room, NULL | Primary office location |
| is_active | BIT | NOT NULL, DEFAULT 1 | Account active status |
| last_login_at | DATETIMEOFFSET | NULL | Last successful login |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_user_username (UNIQUE)
- UX_user_email (UNIQUE)
- UX_user_edipi (UNIQUE, FILTERED WHERE edipi IS NOT NULL)
- IX_user_role (role_id)
- IX_user_sme_role (sme_role_id)

### 2. Role Table (`role`)
**Purpose**: Authorization roles for role-based access control (RBAC)

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| role_id | INT | PK, IDENTITY | Primary key |
| role_name | NVARCHAR(50) | NOT NULL, UNIQUE | Role identifier |
| description | NVARCHAR(200) | NULL | Role description |
| is_system_role | BIT | NOT NULL, DEFAULT 0 | Protected system role flag |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Roles**:
1. SuperAdmin - Full system access
2. Admin - Administrative functions
3. Manager - Team management
4. User - Standard user access
5. ReadOnly - View-only access

### 3. SME Role Table (`sme_role`)
**Purpose**: Subject Matter Expert specialization roles

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| sme_role_id | INT | PK, IDENTITY | Primary key |
| role_name | NVARCHAR(50) | NOT NULL, UNIQUE | SME role name |
| description | NVARCHAR(200) | NULL | Role description |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 28 specialization roles including:
- Network Engineer
- Security Analyst
- Database Administrator
- Software Developer
- Hardware Technician
- Quality Assurance
- Project Manager
- And 21 others...

### 4. Program Table (`program`)
**Purpose**: Defense acquisition programs for asset association

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| program_id | INT | PK, IDENTITY | Primary key |
| program_name | NVARCHAR(100) | NOT NULL, UNIQUE | Program name |
| program_code | NVARCHAR(20) | NOT NULL, UNIQUE | Short code |
| description | NVARCHAR(500) | NULL | Program description |
| service_branch | NVARCHAR(50) | NULL | Military branch |
| program_manager | NVARCHAR(100) | NULL | PM name |
| start_date | DATE | NULL | Program start |
| is_active | BIT | NOT NULL, DEFAULT 1 | Active status |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 18 major defense programs

### 5. Building Table (`building`)
**Purpose**: Physical building locations for asset tracking

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| building_id | INT | PK, IDENTITY | Primary key |
| building_number | NVARCHAR(20) | NOT NULL, UNIQUE | Building identifier |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 8 buildings

### 6. Floor Table (`floor`)
**Purpose**: Floor/level definitions across buildings

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| floor_id | INT | PK, IDENTITY | Primary key |
| floor_number | NVARCHAR(20) | NOT NULL, UNIQUE | Floor identifier |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 4 floors

### 7. Room Table (`room`)
**Purpose**: Specific room locations within buildings

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| room_id | INT | PK, IDENTITY | Primary key |
| room_number | NVARCHAR(20) | NOT NULL | Room number |
| room_name | NVARCHAR(100) | NULL | Descriptive name |
| room_type | NVARCHAR(50) | NULL | Room classification |
| building_id | INT | FK → building | Building location |
| floor_id | INT | FK → floor | Floor location |
| capacity | INT | NULL | Person capacity |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- IX_room_building_floor_number (building_id, floor_id, room_number)

**Seeded Count**: 33 rooms (various types)

### 8. Installation Table (`installation`)
**Purpose**: Military installations worldwide

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| installation_id | INT | PK, IDENTITY | Primary key |
| installation_name | NVARCHAR(100) | NOT NULL | Full name |
| installation_code | NVARCHAR(10) | NOT NULL, UNIQUE | Short code |
| service_branch | NVARCHAR(50) | NULL | Military branch |
| location | NVARCHAR(100) | NULL | Geographic location |
| state_country | NVARCHAR(50) | NULL | State or country |
| is_conus | BIT | NOT NULL, DEFAULT 1 | Continental US flag |
| is_active | BIT | NOT NULL, DEFAULT 1 | Active status |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_installation_code (UNIQUE)
- IX_installation_service_branch

**Seeded Count**: 52 military installations

### 9. Hardware Manufacturer Table (`hardware_manufacturer`)
**Purpose**: Hardware vendor registry for equipment tracking

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| hardware_manufacturer_id | INT | PK, IDENTITY | Primary key |
| manufacturer_name | NVARCHAR(100) | NOT NULL, UNIQUE | Company name |
| short_name | NVARCHAR(50) | NULL | Abbreviated name |
| website | NVARCHAR(200) | NULL | Company website |
| support_phone | NVARCHAR(50) | NULL | Support contact |
| support_email | NVARCHAR(100) | NULL | Support email |
| country | NVARCHAR(50) | NULL | Country of origin |
| is_doe_approved | BIT | NOT NULL, DEFAULT 0 | DoE approval status |
| cage_code | NVARCHAR(10) | NULL | CAGE code |
| icon_path | NVARCHAR(200) | NULL | Logo path |
| notes | NVARCHAR(MAX) | NULL | Additional notes |
| is_active | BIT | NOT NULL, DEFAULT 1 | Active vendor |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_hardware_manufacturer_name (UNIQUE)
- IX_hardware_manufacturer_cage_code

**Seeded Count**: 165 manufacturers

### 10. Software Manufacturer Table (`software_manufacturer`)
**Purpose**: Software vendor registry for license management

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| software_manufacturer_id | INT | PK, IDENTITY | Primary key |
| manufacturer_name | NVARCHAR(100) | NOT NULL, UNIQUE | Company name |
| short_name | NVARCHAR(50) | NULL | Abbreviated name |
| website | NVARCHAR(200) | NULL | Company website |
| support_phone | NVARCHAR(50) | NULL | Support contact |
| support_email | NVARCHAR(100) | NULL | Support email |
| country | NVARCHAR(50) | NULL | Country of origin |
| is_doe_approved | BIT | NOT NULL, DEFAULT 0 | DoE approval status |
| is_fedRAMP_certified | BIT | NOT NULL, DEFAULT 0 | FedRAMP status |
| icon_path | NVARCHAR(200) | NULL | Logo path |
| notes | NVARCHAR(MAX) | NULL | Additional notes |
| is_active | BIT | NOT NULL, DEFAULT 1 | Active vendor |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_software_manufacturer_name (UNIQUE)
- IX_software_manufacturer_fedramp

**Seeded Count**: 217 unique manufacturers

### 11. Condition Table (`condition`)
**Purpose**: Asset condition states for lifecycle management

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| condition_id | INT | PK, IDENTITY | Primary key |
| condition_name | NVARCHAR(50) | NOT NULL, UNIQUE | Condition state |
| condition_description | NVARCHAR(200) | NULL | Detailed description |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 12 condition states (New, Excellent, Good, Fair, Poor, Non-Functional, Under Repair, Awaiting Disposal, Disposed, Missing, Damaged, Obsolete)

### 12. Hardware Enclosure Table (`hw_enclosure`)
**Purpose**: Hardware form factor classifications

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| hw_enclosure_id | INT | PK, IDENTITY | Primary key |
| enclosure_name | NVARCHAR(50) | NOT NULL, UNIQUE | Form factor name |
| enclosure_description | NVARCHAR(200) | NULL | Detailed description |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 16 enclosure types (Server Rackmount, Tower, Blade, Desktop, Laptop, Tablet, Mobile Device, Workstation, etc.)

### 13. Physical Memory Type Table (`physical_memory_type`)
**Purpose**: RAM/Memory specifications catalog

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| physical_memtype_id | INT | PK, IDENTITY | Primary key |
| physical_memtype_name | NVARCHAR(50) | NOT NULL, UNIQUE | Memory type name |
| physical_memtype_description | NVARCHAR(200) | NULL | Technical specifications |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Seeded Count**: 33 memory types (DDR, DDR2-5, SODIMM variants, ECC, GDDR3-6, LPDDR2-5, legacy types)

### 14. GPU Types Table (`gpu_types`)
**Purpose**: Graphics processor catalog with manufacturer relationships

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| gpu_type_id | INT | PK, IDENTITY | Primary key |
| gpu_type_name | NVARCHAR(100) | NOT NULL, UNIQUE | GPU model name |
| hardware_manufacturer_id | INT | FK → hardware_manufacturer | GPU manufacturer |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- IX_gpu_types_manufacturer (hardware_manufacturer_id)

**Seeded Count**: 41 GPU models (20 NVIDIA, 16 AMD, 5 Intel)

### 15. CPU Type Table (`cpu_type`)
**Purpose**: Processor catalog with manufacturer relationships

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| cpu_type_id | INT | PK, IDENTITY | Primary key |
| cpu_type_name | NVARCHAR(100) | NOT NULL, UNIQUE | CPU model name |
| hardware_manufacturer_id | INT | FK → hardware_manufacturer | CPU manufacturer |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- IX_cpu_type_manufacturer (hardware_manufacturer_id)

**Seeded Count**: 180 CPU models (58 Intel, 55 AMD, 17 Apple, 9 Qualcomm, 14 ARM, and others)

### 16. System Architecture Table (`sys_architecture`)
**Purpose**: Hardware platform instruction set architecture categorization

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| sys_architecture_id | INT | PK, IDENTITY | Primary key |
| system_architecture | NVARCHAR(50) | NOT NULL, UNIQUE | Architecture name |
| sys_architecture_description | NVARCHAR(200) | NULL | Detailed description |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_sys_architecture_name (UNIQUE)

**Seeded Count**: 28 instruction set architectures (x86, x86_64, ARM variants, PowerPC, SPARC, MIPS, RISC-V, etc.)

### 17. Operating System Vendor Table (`os_vendor`)
**Purpose**: Operating system vendor and maintainer registry

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| os_vendor_id | INT | PK, IDENTITY | Primary key |
| os_vendor_name | NVARCHAR(100) | NOT NULL, UNIQUE | Vendor/maintainer name |
| os_vendor_description | NVARCHAR(200) | NULL | Vendor description |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_os_vendor_name (UNIQUE)

**Seeded Count**: 40 OS vendors (Microsoft, Apple, Red Hat, Canonical, Oracle, IBM, Google, etc.)

### 18. Operating System Platform Table (`os_platform`)
**Purpose**: Operating system platform families and categories

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| os_platform_id | INT | PK, IDENTITY | Primary key |
| os_platform_name | NVARCHAR(100) | NOT NULL, UNIQUE | Platform name |
| os_platform_description | NVARCHAR(200) | NULL | Platform description |
| created_at | DATETIMEOFFSET | NOT NULL | Audit field |
| created_by | INT | NOT NULL | Audit field |
| modified_at | DATETIMEOFFSET | NULL | Audit field |
| modified_by | INT | NULL | Audit field |
| version | INT | NOT NULL | Concurrency token |

**Indexes**:
- UX_os_platform_name (UNIQUE)

**Seeded Count**: 50 OS platforms (Windows, macOS, Linux distributions, Unix, BSD, Mobile, Embedded, etc.)

**Note**: Cisco IOS renamed to "Cisco IOS" to avoid conflict with Apple iOS

### 19. Audit Entry Table (`audit_entry`) [Planned]
**Purpose**: Comprehensive audit trail for all database operations

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| audit_id | BIGINT | PK, IDENTITY | Primary key |
| table_name | NVARCHAR(100) | NOT NULL | Affected table |
| entity_id | NVARCHAR(50) | NOT NULL | Primary key value |
| action | NVARCHAR(10) | NOT NULL | INSERT/UPDATE/DELETE |
| user_id | INT | NOT NULL | User performing action |
| timestamp | DATETIMEOFFSET | NOT NULL | Action timestamp |
| old_values | NVARCHAR(MAX) | NULL | JSON of previous values |
| new_values | NVARCHAR(MAX) | NULL | JSON of new values |
| ip_address | NVARCHAR(45) | NULL | Client IP address |
| user_agent | NVARCHAR(500) | NULL | Browser/client info |

## Security Features

### Encryption
- **At Rest**: Transparent Data Encryption (TDE) with AES-256
- **In Transit**: TLS 1.2+ mandatory for all connections
- **Column Encryption**: Planned for PII fields (EDIPI, etc.)

### Access Control
- Row-Level Security (RLS) policies per installation
- Role-Based Access Control (RBAC) via role table
- Audit logging on all data modifications
- Soft delete pattern for data retention

### Compliance
- FIPS 140-3 compliant encryption algorithms
- DoD STIG compliance for database configuration
- CMMC Level 2 audit trail requirements
- Support for CAC/PIV authentication

## Performance Optimizations

### Indexing Strategy
- Primary key clustered indexes on all tables
- Unique constraints with supporting indexes
- Foreign key indexes for join optimization
- Filtered indexes for nullable unique fields

### Query Optimization
- Entity Framework Core 8 with compiled queries
- Dapper for complex reporting queries
- Redis caching layer for reference data
- Connection pooling for scalability

## Migration History

| Migration | Date | Description |
|-----------|------|-------------|
| InitialUserRoleStructure | 2025-09-28 19:43:48 | User, Role, SmeRole tables |
| AddProgramTable | 2025-09-28 20:31:40 | Program table with seed data |
| AddLocationTables | 2025-09-28 21:09:12 | Building, Floor, Room tables |
| AddInstallationTable | 2025-09-28 22:33:40 | Installation table with 52 bases |
| UpdateSmeRoleSeeds | 2025-09-28 23:07:33 | Expanded SME roles to 28 |
| AddHardwareManufacturerTable | 2025-09-28 23:19:22 | Hardware vendors (165) |
| AddSoftwareManufacturerTable | 2025-09-29 12:52:40 | Software vendors (217) |
| AddConditionTable | 2025-09-29 14:15:00 | Condition states (12) |
| AddHwEnclosureTable | 2025-09-29 14:30:00 | Hardware enclosure types (16) |
| AddPhysicalMemoryTypeTable | 2025-09-29 14:45:00 | Memory specifications (33) |
| AddMatroxAndGpuTypesTable | 2025-09-29 15:00:00 | GPU types (41), Matrox added |
| AddCpuTypeAndNewManufacturers | 2025-09-29 15:30:00 | CPU types (180), 6 new manufacturers |
| AddSysArchitectureTable | 2025-09-29 16:00:00 | System architectures (28) |
| AddOsVendorTable | 2025-09-29 16:15:00 | OS vendors (40) |
| AddOsPlatformTable | 2025-09-29 16:30:00 | OS platforms (50) |

## Data Volume Summary

| Table | Seeded Records | Expected Growth |
|-------|---------------|-----------------|
| user | 0 | 1,000-5,000 users |
| role | 5 | Static |
| sme_role | 28 | Minimal growth |
| program | 18 | 50-100 programs |
| building | 8 | Per installation |
| floor | 4 | Static |
| room | 33 | 100-500 per site |
| installation | 52 | Minimal growth |
| hardware_manufacturer | 172 | 500-1,000 vendors |
| software_manufacturer | 217 | 500-1,000 vendors |
| condition | 12 | Static |
| hw_enclosure | 16 | Minimal growth |
| physical_memory_type | 33 | Technology updates |
| gpu_types | 41 | New models quarterly |
| cpu_type | 180 | New models quarterly |
| sys_architecture | 28 | Static/minimal growth |
| os_vendor | 40 | Occasional additions |
| os_platform | 50 | Technology updates |
| **Total Seed Data** | **898** | - |

## Backup and Recovery

- **Backup Schedule**: Daily full, hourly differential
- **Retention**: 30 days local, 1 year archive
- **Recovery Time Objective (RTO)**: 4 hours
- **Recovery Point Objective (RPO)**: 1 hour
- **Disaster Recovery**: Geo-redundant Azure SQL replica

## Maintenance Procedures

### Regular Tasks
1. Index rebuild: Weekly during maintenance window
2. Statistics update: Daily automatic
3. Transaction log backup: Every 15 minutes
4. Integrity check: Weekly DBCC CHECKDB
5. Audit log rotation: Monthly archive

### Monitoring
- Query performance via SQL Profiler
- Deadlock detection and alerting
- Storage growth trending
- Connection pool utilization
- Failed login attempts

## Future Enhancements

### Phase 2 Tables (Planned)
- Asset (hardware and software inventory)
- AssetAssignment (user-asset relationships)
- MaintenanceSchedule (preventive maintenance)
- TicketSystem (issue tracking)
- Warranty (warranty tracking)

### Phase 3 Features
- Temporal tables for complete history
- Graph database for complex relationships
- Partitioning for large tables
- Column-store indexes for analytics
- Always Encrypted for PII fields

---

*Document maintained by: Continuous Documentation Agent*  
*For questions contact: IAMSNG Database Team*  
*Classification: UNCLASSIFIED // FOUO*