# IAMSNG Entity Relationship Documentation

> **Version**: 1.0.0  
> **Last Updated**: 2025-09-29  
> **Database**: Microsoft SQL Server 2022  
> **ORM**: Entity Framework Core 8

## Overview

This document describes the relationships between entities in the IAMSNG database. The system implements a normalized relational model with foreign key constraints ensuring referential integrity across all tables.

## Entity Relationship Diagram (ERD) Overview

```
┌──────────────┐     ┌──────────────┐     ┌──────────────┐
│     User     │────→│     Role     │     │   SmeRole    │
│              │────→│              │     │              │
│              │────→└──────────────┘     └──────────────┘
│              │     
│              │────→┌──────────────┐
│              │     │ Installation │
│              │     └──────────────┘
│              │
│              │────→┌──────────────┐     ┌──────────────┐
│              │     │   Building   │←────│     Room     │
│              │     └──────────────┘     │              │
│              │                          │              │
│              │────→┌──────────────┐     │              │
│              │     │     Room     │────→│    Floor     │
└──────────────┘     └──────────────┘     └──────────────┘

┌──────────────────┐     ┌──────────────────┐     ┌──────────────┐
│ HardwareManufac. │     │ SoftwareManufac. │     │   Program    │
└──────────────────┘     └──────────────────┘     └──────────────┘
```

## Primary Entity Relationships

### 1. User Entity Relationships

The User entity is the central entity with multiple relationships:

#### User → Role (Many-to-One)
- **Relationship Type**: Many-to-One (Required)
- **Foreign Key**: `user.role_id` → `role.role_id`
- **Description**: Every user must have exactly one role
- **Cascade Behavior**: RESTRICT (cannot delete role with users)
- **Business Rule**: Users inherit all permissions from their assigned role

#### User → SmeRole (Many-to-One)
- **Relationship Type**: Many-to-One (Optional)
- **Foreign Key**: `user.sme_role_id` → `sme_role.sme_role_id`
- **Description**: Users may have a subject matter expert specialization
- **Cascade Behavior**: SET NULL (removes specialization if role deleted)
- **Business Rule**: SME role provides additional context, not permissions

#### User → Installation (Many-to-One)
- **Relationship Type**: Many-to-One (Optional)
- **Foreign Key**: `user.installation_id` → `installation.installation_id`
- **Description**: User's primary assigned military installation
- **Cascade Behavior**: SET NULL
- **Business Rule**: Used for location-based asset visibility

#### User → Building (Many-to-One)
- **Relationship Type**: Many-to-One (Optional)
- **Foreign Key**: `user.building_id` → `building.building_id`
- **Description**: User's primary building location
- **Cascade Behavior**: SET NULL
- **Business Rule**: Facilitates physical asset proximity

#### User → Room (Many-to-One)
- **Relationship Type**: Many-to-One (Optional)
- **Foreign Key**: `user.room_id` → `room.room_id`
- **Description**: User's specific office/workspace
- **Cascade Behavior**: SET NULL
- **Business Rule**: Enables precise asset assignment

### 2. Location Entity Relationships

#### Room → Building (Many-to-One)
- **Relationship Type**: Many-to-One (Required)
- **Foreign Key**: `room.building_id` → `building.building_id`
- **Description**: Every room must belong to a building
- **Cascade Behavior**: CASCADE (delete rooms when building deleted)
- **Business Rule**: Rooms cannot exist without a parent building

#### Room → Floor (Many-to-One)
- **Relationship Type**: Many-to-One (Required)
- **Foreign Key**: `room.floor_id` → `floor.floor_id`
- **Description**: Every room must be on a specific floor
- **Cascade Behavior**: RESTRICT (cannot delete floor with rooms)
- **Business Rule**: Floor assignment required for navigation

### 3. Standalone Reference Entities

The following entities currently have no foreign key relationships but will connect to future asset tables:

#### Program
- **Future Relationships**: Assets will reference programs
- **Purpose**: Track equipment by defense acquisition program
- **Cardinality**: One program to many assets

#### Installation
- **Current Relationships**: Referenced by User entity
- **Future Relationships**: Assets, Buildings, Transfers
- **Purpose**: Geographic distribution of resources
- **Cardinality**: One installation to many entities

#### HardwareManufacturer
- **Future Relationships**: HardwareAssets will reference manufacturers
- **Purpose**: Warranty, support, and procurement tracking
- **Cardinality**: One manufacturer to many assets

#### SoftwareManufacturer
- **Future Relationships**: SoftwareAssets will reference manufacturers
- **Purpose**: License management and compliance
- **Cardinality**: One manufacturer to many licenses

## Relationship Cardinality Summary

| Parent Entity | Child Entity | Relationship Type | Cardinality | Required |
|--------------|--------------|-------------------|-------------|----------|
| Role | User | One-to-Many | 1:N | Yes |
| SmeRole | User | One-to-Many | 1:N | No |
| Installation | User | One-to-Many | 1:N | No |
| Building | User | One-to-Many | 1:N | No |
| Building | Room | One-to-Many | 1:N | Yes |
| Floor | Room | One-to-Many | 1:N | Yes |
| Room | User | One-to-Many | 1:N | No |

## Referential Integrity Rules

### Delete Cascades
- **Building → Room**: CASCADE (rooms deleted with building)
- **None others**: Prefer soft delete pattern

### Update Cascades
- **All Foreign Keys**: RESTRICT (prevent orphaned records)
- **Audit Fields**: Automatic via triggers/interceptors

### Null Handling
- **Required Relationships**: NOT NULL constraint enforced
- **Optional Relationships**: NULL allowed with SET NULL on delete

## Business Rules and Constraints

### Unique Constraints
1. **User**: username, email, edipi (when not null)
2. **Role**: role_name
3. **SmeRole**: role_name
4. **Program**: program_name, program_code
5. **Building**: building_number
6. **Floor**: floor_number
7. **Installation**: installation_code
8. **HardwareManufacturer**: manufacturer_name
9. **SoftwareManufacturer**: manufacturer_name

### Composite Constraints
1. **Room Location**: Unique(building_id, floor_id, room_number)
2. **Future Asset Assignment**: Unique(user_id, asset_id, active_flag)

### Check Constraints (Planned)
1. **Email Format**: Valid email pattern for user.email
2. **EDIPI Format**: 10-digit number for user.edipi
3. **Date Ranges**: start_date < end_date where applicable
4. **Capacity Limits**: room.capacity > 0

## Data Integrity Patterns

### Soft Delete Pattern
- All entities maintain `is_active` flag where applicable
- Relationships maintained for historical reporting
- Deleted records excluded from active queries

### Audit Trail Pattern
- Every entity tracks created_by and modified_by
- Foreign keys to user table for accountability
- Timestamps in DATETIMEOFFSET for timezone accuracy

### Concurrency Control
- Version column on all tables for optimistic locking
- Prevents lost updates in multi-user environment
- Automatic increment on each update

## Query Patterns and Performance

### Common Join Patterns
```sql
-- User with full location hierarchy
User → Role
User → SmeRole  
User → Installation
User → Building
User → Room → Floor

-- Room with complete details
Room → Building
Room → Floor
Room → Users (reverse)
```

### Index Coverage
- All foreign keys have supporting indexes
- Covering indexes for common query patterns
- Filtered indexes for soft-delete queries

### N+1 Query Prevention
- Use Include() for eager loading in EF Core
- Projection queries for read-only operations
- Compiled queries for hot paths

## Future Relationship Enhancements

### Phase 2 Relationships (Asset Management)
```
User ←→ Asset (Many-to-Many via Assignment)
Asset → Program (Many-to-One)
Asset → Installation (Many-to-One)  
Asset → Building → Room (Location hierarchy)
HardwareAsset → HardwareManufacturer
SoftwareAsset → SoftwareManufacturer
```

### Phase 3 Relationships (Advanced Features)
```
Asset ←→ MaintenanceSchedule (One-to-Many)
Asset ←→ Ticket (One-to-Many)
Asset ←→ Warranty (One-to-One)
User ←→ Team (Many-to-Many)
Installation ←→ Installation (Transfer routes)
```

## Migration Considerations

### Adding New Relationships
1. Create foreign key with initial NULL allowed
2. Populate data ensuring referential integrity
3. Add NOT NULL constraint if required
4. Create supporting indexes
5. Update documentation

### Modifying Existing Relationships
1. Create new relationship alongside old
2. Migrate data with verification
3. Update application code
4. Remove old relationship
5. Clean up orphaned records

### Breaking Relationships
1. Assess impact on existing queries
2. Archive dependent data if needed
3. Remove foreign key constraint
4. Update cascade rules
5. Document business rule changes

## Security Considerations

### Row-Level Security
- Filter by user.installation_id for multi-tenant isolation
- Restrict access based on user.role_id permissions
- Audit all relationship modifications

### Data Classification
- PII fields: user.edipi requires encryption
- Location data: building/room may be classified
- Manufacturer data: CAGE codes are FOUO

## Validation Rules

### Entity Framework Validations
```csharp
// User entity validations
- Username: Required, MaxLength(50), Unique
- Email: Required, EmailAddress, MaxLength(100)
- EDIPI: RegularExpression(@"^\d{10}$")
- Role: Required, ForeignKey

// Room entity validations  
- RoomNumber: Required, MaxLength(20)
- Building: Required, ForeignKey
- Floor: Required, ForeignKey
- Capacity: Range(0, 1000)
```

### Database-Level Validations
- Foreign key constraints prevent orphaned records
- Unique constraints prevent duplicates
- Check constraints enforce business rules
- Triggers validate complex rules

## Relationship Monitoring

### Key Metrics
1. **Orphaned Records**: Monitor for referential integrity violations
2. **Cascade Impact**: Track records affected by cascading deletes
3. **Join Performance**: Monitor slow queries involving multiple joins
4. **Cardinality Violations**: Detect unexpected one-to-many explosions

### Health Checks
```sql
-- Check for orphaned users
SELECT * FROM [user] u
WHERE NOT EXISTS (SELECT 1 FROM role r WHERE r.role_id = u.role_id)

-- Check for rooms without valid building/floor
SELECT * FROM room r
WHERE NOT EXISTS (SELECT 1 FROM building b WHERE b.building_id = r.building_id)
   OR NOT EXISTS (SELECT 1 FROM floor f WHERE f.floor_id = r.floor_id)

-- Check for duplicate relationships (future asset assignments)
-- Will be implemented when asset tables are created
```

---

*Document maintained by: Continuous Documentation Agent*  
*For questions contact: IAMSNG Database Team*  
*Classification: UNCLASSIFIED // FOUO*