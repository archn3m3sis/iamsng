# Database Patterns Decision Document for IAMSNG

> Document Version: 1.0.0  
> Date: 2025-09-28  
> Session: 2025-09-28-001  
> Status: RECOMMENDATION READY  
> Author: Continuous Documentation Agent

---

## Executive Summary

This document analyzes three critical database pattern decisions for the Industrial Asset Management System (IAMSNG):
1. **Repository Pattern** over direct DbContext usage
2. **Unit of Work Pattern** implementation
3. **Specification Pattern** for complex queries

**Key Recommendation**: Implement all three patterns with specific adaptations for DoD security requirements.

---

## Pattern Analysis for IAMSNG

### 1. Repository Pattern vs Direct DbContext

#### What This Choice Means

**Direct DbContext Approach**:
```csharp
// Controllers directly inject and use DbContext
public class AssetController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public async Task<Asset> GetAsset(int id)
    {
        return await _context.Assets
            .Include(a => a.MaintenanceRecords)
            .FirstOrDefaultAsync(a => a.Id == id);
    }
}
```

**Repository Pattern Approach**:
```csharp
// Controllers use abstracted repository interfaces
public class AssetController : ControllerBase
{
    private readonly IAssetRepository _assetRepository;
    
    public async Task<Asset> GetAsset(int id)
    {
        return await _assetRepository.GetByIdWithMaintenanceAsync(id);
    }
}
```

#### Why Repository Pattern is a CLEAR WIN for IAMSNG

✅ **Critical Benefits for DoD/Industrial Systems**:

1. **Security Isolation**
   - Centralized audit logging for all data access
   - Single point to enforce row-level security
   - Easier FIPS compliance validation
   - Prevents SQL injection through abstraction

2. **Testability**
   - Mock repositories for unit testing without database
   - Faster test execution (crucial for CI/CD)
   - Predictable test data scenarios

3. **Maintainability**
   - Complex industrial asset queries in one place
   - Easier to optimize database access patterns
   - Swap data sources if needed (SQL Server to Oracle for DoD)

4. **Domain-Specific Operations**
   ```csharp
   public interface IAssetRepository
   {
       // Industrial-specific queries
       Task<IEnumerable<Asset>> GetAssetsRequiringMaintenanceAsync();
       Task<IEnumerable<Asset>> GetAssetsByLocationAndStatusAsync(int locationId, AssetStatus status);
       Task<AssetHealth> CalculateAssetHealthScoreAsync(int assetId);
       Task<IEnumerable<Asset>> GetAssetsWithExpiredCertificationsAsync();
   }
   ```

#### Implementation Recommendation

```csharp
// Base repository for common operations
public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<bool> ExistsAsync(int id);
}

// Generic implementation with audit logging
public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDbContext Context;
    protected readonly IAuditService AuditService;
    protected readonly IUserContext UserContext;

    public async Task<T> AddAsync(T entity)
    {
        // Audit logging for DoD compliance
        await AuditService.LogDataAccessAsync(
            UserContext.CurrentUser,
            "CREATE",
            typeof(T).Name,
            entity.Id
        );
        
        entity.CreatedBy = UserContext.CurrentUser.Username;
        entity.CreatedDate = DateTime.UtcNow;
        
        await Context.Set<T>().AddAsync(entity);
        return entity;
    }
}
```

---

### 2. Unit of Work Pattern

#### What This Pattern Does

The Unit of Work pattern manages database transactions and coordinates changes across multiple repositories.

#### Why Unit of Work is a CLEAR WIN for IAMSNG

✅ **Critical Benefits**:

1. **Transaction Management**
   - Atomic operations for complex industrial workflows
   - Rollback capability for failed asset transfers
   - Consistent state during maintenance operations

2. **Performance Optimization**
   - Batch database operations
   - Single SaveChanges() call
   - Reduced database round trips

3. **Audit Trail Consistency**
   ```csharp
   public class UnitOfWork : IUnitOfWork
   {
       private readonly ApplicationDbContext _context;
       private readonly IAuditService _auditService;
       
       public async Task<int> SaveChangesAsync()
       {
           // Capture all changes for audit
           var auditEntries = GetAuditEntries();
           
           // Save main changes
           var result = await _context.SaveChangesAsync();
           
           // Save audit logs (required for DoD)
           await _auditService.LogChangesAsync(auditEntries);
           
           return result;
       }
   }
   ```

#### Implementation for Industrial Asset Management

```csharp
public interface IUnitOfWork : IDisposable
{
    // Repository access
    IAssetRepository Assets { get; }
    IMaintenanceRepository MaintenanceRecords { get; }
    ILocationRepository Locations { get; }
    IUserRepository Users { get; }
    ICertificationRepository Certifications { get; }
    
    // Transaction management
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}

// Usage in service layer
public class AssetTransferService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public async Task TransferAssetAsync(int assetId, int newLocationId)
    {
        await _unitOfWork.BeginTransactionAsync();
        try
        {
            var asset = await _unitOfWork.Assets.GetByIdAsync(assetId);
            var oldLocation = asset.LocationId;
            
            // Update asset
            asset.LocationId = newLocationId;
            await _unitOfWork.Assets.UpdateAsync(asset);
            
            // Create transfer record
            var transfer = new AssetTransfer
            {
                AssetId = assetId,
                FromLocationId = oldLocation,
                ToLocationId = newLocationId,
                TransferDate = DateTime.UtcNow
            };
            await _unitOfWork.Transfers.AddAsync(transfer);
            
            // Save all changes atomically
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync();
            throw;
        }
    }
}
```

---

### 3. Specification Pattern for Complex Queries

#### What This Pattern Solves

The Specification pattern encapsulates query logic into reusable, testable, and composable objects.

#### Why Specification Pattern is a STRONG WIN for IAMSNG

✅ **Critical Benefits for Complex Industrial Queries**:

1. **Complex Query Composition**
   ```csharp
   // Combine specifications for complex industrial scenarios
   var criticalAssetsNeedingMaintenance = 
       new CriticalAssetSpecification()
       .And(new MaintenanceDueSpecification())
       .And(new LocationSpecification(locationId));
   
   var assets = await _repository.FindAsync(criticalAssetsNeedingMaintenance);
   ```

2. **Reusable Business Rules**
   ```csharp
   public class HighValueAssetSpecification : Specification<Asset>
   {
       public override Expression<Func<Asset, bool>> ToExpression()
       {
           return asset => asset.Value > 100000 || asset.Criticality == Criticality.Critical;
       }
   }
   ```

3. **Testable Query Logic**
   - Unit test specifications without database
   - Validate business rules independently
   - Document query intent clearly

#### Implementation for IAMSNG

```csharp
// Base specification
public abstract class Specification<T>
{
    public abstract Expression<Func<T, bool>> ToExpression();
    
    public Specification<T> And(Specification<T> specification)
    {
        return new AndSpecification<T>(this, specification);
    }
    
    public Specification<T> Or(Specification<T> specification)
    {
        return new OrSpecification<T>(this, specification);
    }
}

// Industrial-specific specifications
public class AssetsDueForMaintenanceSpecification : Specification<Asset>
{
    private readonly int _daysTolerance;
    
    public override Expression<Func<Asset, bool>> ToExpression()
    {
        var dueDate = DateTime.UtcNow.AddDays(_daysTolerance);
        return asset => asset.NextMaintenanceDate <= dueDate;
    }
}

public class AssetsInComplianceSpecification : Specification<Asset>
{
    public override Expression<Func<Asset, bool>> ToExpression()
    {
        return asset => 
            asset.Certifications.All(c => c.ExpiryDate > DateTime.UtcNow) &&
            asset.LastInspectionDate > DateTime.UtcNow.AddMonths(-12);
    }
}

// Repository using specifications
public class AssetRepository : Repository<Asset>, IAssetRepository
{
    public async Task<IEnumerable<Asset>> FindAsync(Specification<Asset> spec)
    {
        return await Context.Assets
            .Where(spec.ToExpression())
            .ToListAsync();
    }
}
```

---

## Recommended Architecture for IAMSNG

### Complete Pattern Integration

```csharp
// Service layer using all three patterns
public class AssetManagementService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public async Task<IEnumerable<AssetMaintenanceDto>> GetCriticalMaintenanceAsync()
    {
        // Use specification pattern for complex query
        var specification = new CriticalAssetSpecification()
            .And(new MaintenanceDueWithin30DaysSpecification())
            .And(new ActiveAssetSpecification());
        
        // Repository pattern provides abstraction
        var assets = await _unitOfWork.Assets.FindAsync(specification);
        
        // Process with business logic
        foreach (var asset in assets)
        {
            // Create maintenance tasks
            var task = new MaintenanceTask
            {
                AssetId = asset.Id,
                Priority = Priority.High,
                DueDate = asset.NextMaintenanceDate
            };
            await _unitOfWork.MaintenanceTasks.AddAsync(task);
        }
        
        // Unit of Work ensures atomic transaction
        await _unitOfWork.SaveChangesAsync();
        
        return assets.Select(a => MapToDto(a));
    }
}
```

---

## Implementation Priority

### Phase 1: Repository Pattern (Week 1)
- Implement generic repository base
- Create asset-specific repositories
- Add audit logging integration

### Phase 2: Unit of Work (Week 2)
- Implement transaction management
- Integrate with repositories
- Add rollback capabilities

### Phase 3: Specification Pattern (Week 3)
- Create base specification classes
- Implement common specifications
- Integrate with repositories

---

## Security Considerations

### Audit Requirements
- All data access through repositories must be logged
- User context must be captured
- Timestamp and operation type required

### Row-Level Security
```csharp
public class SecureAssetRepository : AssetRepository
{
    public override async Task<IEnumerable<Asset>> GetAllAsync()
    {
        var userClearance = _userContext.GetClearanceLevel();
        return await Context.Assets
            .Where(a => a.ClassificationLevel <= userClearance)
            .ToListAsync();
    }
}
```

---

## Performance Impact

| Pattern | Performance Impact | Mitigation |
|---------|-------------------|------------|
| Repository | Minimal overhead | Use async/await throughout |
| Unit of Work | Improved (batching) | Proper scope management |
| Specification | Neutral | Compile expressions once |

---

## Conclusion

**All three patterns are CLEAR WINS for IAMSNG** because:

1. **Repository Pattern**: Essential for security, testing, and maintaining complex industrial queries
2. **Unit of Work**: Critical for transaction integrity in asset management workflows
3. **Specification Pattern**: Valuable for complex, reusable query logic in industrial scenarios

These patterns work together to create a maintainable, testable, and secure data access layer suitable for DoD deployment.

---

## Alternative Considerations

### Why NOT Direct DbContext?
- Harder to test
- Security logging scattered
- Business logic leaks into controllers
- Difficult to swap data providers

### Why NOT CQRS Instead?
- CQRS could be added later if needed
- Current complexity doesn't warrant it
- These patterns don't prevent CQRS adoption

### Why NOT Dapper for Queries?
- EF Core performance is sufficient
- Losing LINQ benefits
- Additional complexity for marginal gains
- Harder to maintain type safety

---

*Generated by: Continuous Documentation Agent*  
*Decision Status: RECOMMENDED FOR IMPLEMENTATION*  
*Review Required By: Lead Architect, Security Officer*