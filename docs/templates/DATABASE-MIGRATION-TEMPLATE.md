# Database Migration: [MIGRATION_NAME]

> Migration ID: [YYYYMMDDHHMMSS_MigrationName]  
> Date Created: [DATE]  
> Session: [SESSION_ID]  
> Author: [Agent/Developer]  
> FIPS Compliance: [VERIFIED/PENDING]  
> Rollback Tested: [YES/NO]

---

## Migration Overview

**Purpose**: [Describe why this migration is needed]  
**Impact Level**: [LOW/MEDIUM/HIGH/CRITICAL]  
**Affects Tables**: [List of tables affected]  
**Breaking Changes**: [YES/NO - describe if yes]  
**Downtime Required**: [YES/NO - estimated duration if yes]  
**Data Loss Risk**: [NONE/LOW/MEDIUM/HIGH]

---

## Pre-Migration Checklist

### Prerequisites
- [ ] Database backup completed
- [ ] Migration tested in development
- [ ] Migration tested in staging
- [ ] Rollback script tested
- [ ] Performance impact assessed
- [ ] Security review completed
- [ ] FIPS compliance verified
- [ ] Audit logging verified

### Validation Queries
```sql
-- Pre-migration data validation
SELECT COUNT(*) FROM [table_name];
-- Add specific validation queries
```

---

## Migration Script

### Up Migration

```csharp
public partial class [MigrationName] : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        // Add migration code here
        migrationBuilder.CreateTable(
            name: "[TableName]",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                // Additional columns
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_[TableName]", x => x.Id);
                // Foreign keys
            });
        
        // Indexes
        migrationBuilder.CreateIndex(
            name: "IX_[TableName]_[Column]",
            table: "[TableName]",
            column: "[Column]");
    }
}
```

### SQL Equivalent
```sql
-- Direct SQL for reference/manual execution
CREATE TABLE [dbo].[TableName] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    -- Additional columns
    CONSTRAINT [PK_TableName] PRIMARY KEY CLUSTERED ([Id])
);

-- Indexes
CREATE INDEX [IX_TableName_Column] ON [dbo].[TableName] ([Column]);

-- Audit columns (required for DoD compliance)
ALTER TABLE [dbo].[TableName] ADD
    [CreatedBy] NVARCHAR(100) NOT NULL DEFAULT SYSTEM_USER,
    [CreatedDate] DATETIME2 NOT NULL DEFAULT GETUTCDATE(),
    [ModifiedBy] NVARCHAR(100) NULL,
    [ModifiedDate] DATETIME2 NULL;
```

---

## Rollback Script

### Down Migration

```csharp
protected override void Down(MigrationBuilder migrationBuilder)
{
    // Rollback code
    migrationBuilder.DropTable(
        name: "[TableName]");
}
```

### SQL Rollback
```sql
-- Manual rollback script
DROP TABLE IF EXISTS [dbo].[TableName];
-- Additional rollback steps
```

---

## Data Migration (if applicable)

### Data Transformation Script
```sql
-- Data migration/transformation
INSERT INTO [NewTable] ([Columns])
SELECT [Columns]
FROM [OldTable]
WHERE [Conditions];
```

### Data Validation
```sql
-- Post-migration data validation
SELECT COUNT(*) FROM [NewTable];
-- Verify data integrity
```

---

## Schema Changes Detail

### New Tables
| Table Name | Purpose | Columns | Indexes | Relationships |
|------------|---------|---------|---------|---------------|
| [TableName] | [Purpose] | [Count] | [Count] | [FK details] |

### Modified Tables
| Table Name | Change Type | Column | Old Type | New Type | Impact |
|------------|-------------|--------|----------|----------|---------|
| [Table] | [ADD/ALTER/DROP] | [Column] | [Type] | [Type] | [Impact] |

### New Indexes
| Index Name | Table | Columns | Type | Purpose |
|------------|-------|---------|------|----------|
| IX_[Name] | [Table] | [Columns] | [CLUSTERED/NONCLUSTERED] | [Purpose] |

### New Constraints
| Constraint | Type | Table | Definition | Purpose |
|------------|------|-------|------------|----------|
| [Name] | [CHECK/UNIQUE/FK] | [Table] | [Definition] | [Purpose] |

---

## Security Considerations

### Data Classification
- **Tables with PII**: [List tables containing personal information]
- **Tables with Classified Data**: [List tables with sensitive data]
- **Encryption Requirements**: [Specify which columns need encryption]

### Access Control Changes
- **New Permissions Required**: [List any new database permissions]
- **Role Changes**: [Document any role modifications]

### Audit Requirements
- [ ] All tables have audit columns (CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
- [ ] Audit triggers configured for sensitive tables
- [ ] Change tracking enabled where required
- [ ] Temporal tables configured for history tracking

### FIPS 140-3 Compliance
- [ ] No hardcoded sensitive data
- [ ] Encryption keys properly managed
- [ ] TDE (Transparent Data Encryption) configured
- [ ] Column-level encryption for PII/classified data
- [ ] Secure connection strings (Encrypt=true)

---

## Performance Impact

### Estimated Impact
| Metric | Before | After | Change | Acceptable |
|--------|--------|-------|--------|------------|
| Table Size | [size] | [size] | [+/-]% | [Y/N] |
| Index Size | [size] | [size] | [+/-]% | [Y/N] |
| Query Time | [ms] | [ms] | [+/-]% | [Y/N] |
| Lock Duration | [ms] | [ms] | [+/-]% | [Y/N] |

### Performance Testing Results
```sql
-- Key queries to test
-- Query 1: [Description]
SELECT /* test query */

-- Execution plan analysis
-- Before: [metrics]
-- After: [metrics]
```

---

## Deployment Instructions

### Development Environment
```bash
# EF Core migration command
dotnet ef database update [MigrationName] --project iamsng.Infrastructure --startup-project iamsng.API

# Or using Package Manager Console
Update-Database -Migration [MigrationName]
```

### Production Deployment

1. **Pre-Deployment** (T-24 hours)
   - [ ] Notify stakeholders
   - [ ] Schedule maintenance window
   - [ ] Prepare rollback plan

2. **Deployment Steps** (T-0)
   - [ ] Create database backup
   - [ ] Set application to maintenance mode
   - [ ] Execute migration script
   - [ ] Verify migration success
   - [ ] Run validation queries
   - [ ] Update application configuration
   - [ ] Deploy application updates
   - [ ] Remove maintenance mode

3. **Post-Deployment** (T+1 hour)
   - [ ] Monitor application logs
   - [ ] Check performance metrics
   - [ ] Verify audit logging
   - [ ] Confirm no data loss
   - [ ] Document any issues

---

## Testing Verification

### Unit Tests
- [ ] Repository tests updated
- [ ] DbContext tests passing
- [ ] Migration tests created

### Integration Tests
- [ ] Database connection tests
- [ ] CRUD operations verified
- [ ] Transaction tests passing
- [ ] Concurrent access tested

### Security Tests
- [ ] SQL injection prevention verified
- [ ] Access control tested
- [ ] Audit logging confirmed
- [ ] Encryption verified

---

## Rollback Plan

### Rollback Triggers
- [ ] Data corruption detected
- [ ] Performance degradation >50%
- [ ] Application errors >1%
- [ ] Security vulnerability discovered

### Rollback Procedure
1. Set application to maintenance mode
2. Execute rollback script
3. Restore from backup if necessary
4. Verify data integrity
5. Deploy previous application version
6. Remove maintenance mode
7. Document incident

### Recovery Time Objective (RTO)
- **Target**: [time]
- **Maximum Acceptable**: [time]

### Recovery Point Objective (RPO)
- **Target**: [time]
- **Maximum Acceptable**: [time]

---

## Related Documentation

- **Entity Documentation**: `docs/entities/[EntityName].md`
- **API Changes**: `docs/api/[endpoints].md`
- **Application Impact**: `docs/features/[feature].md`
- **Previous Migrations**: [List related migrations]

---

## Approval and Sign-off

| Role | Name | Date | Signature |
|------|------|------|-----------|
| Database Administrator | | | |
| Security Officer | | | |
| Lead Developer | | | |
| Project Manager | | | |

---

## Post-Migration Notes

[Document any issues encountered, workarounds applied, or lessons learned]

---

## Monitoring Queries

```sql
-- Monitor table growth
SELECT 
    t.name AS TableName,
    p.rows AS RowCount,
    SUM(a.total_pages) * 8 AS TotalSpaceKB
FROM sys.tables t
INNER JOIN sys.indexes i ON t.object_id = i.object_id
INNER JOIN sys.partitions p ON i.object_id = p.object_id AND i.index_id = p.index_id
INNER JOIN sys.allocation_units a ON p.partition_id = a.container_id
WHERE t.name = '[TableName]'
GROUP BY t.name, p.rows;

-- Check for blocking
SELECT * FROM sys.dm_exec_requests WHERE blocking_session_id <> 0;

-- Audit log verification
SELECT TOP 100 * FROM [AuditLog] ORDER BY CreatedDate DESC;
```

---

*Generated by: Continuous Documentation Agent*  
*Template Version: 1.0.0*  
*Compliance Level: DoD IL4 / FIPS 140-3*