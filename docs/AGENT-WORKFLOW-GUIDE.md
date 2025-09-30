# Agent-Based Development Workflow Guide for IAMSNG

## Table of Contents

1. [Executive Summary](#executive-summary)
2. [Agent Catalog](#agent-catalog)
3. [Parallel Execution Patterns](#parallel-execution-patterns)
4. [MCP Server Integration](#mcp-server-integration)
5. [DoD Compliance Workflows](#dod-compliance-workflows)
6. [Code Examples](#code-examples)
7. [Performance Optimization](#performance-optimization)
8. [Common Anti-patterns](#common-anti-patterns)
9. [Monitoring and Metrics](#monitoring-and-metrics)
10. [Practical Workflows](#practical-workflows)

## Executive Summary

This guide provides comprehensive documentation for implementing agent-based development workflows in the IAMSNG (Industrial Asset Management System - Next Generation) project. The agent-based approach enables parallel execution of development tasks, automated compliance verification, and intelligent code generation while maintaining strict adherence to DoD security requirements and FIPS 140-3 compliance standards.

### Key Benefits

- **Parallel Execution**: Up to 10x faster development through concurrent agent operations
- **Security-First**: Automated FIPS 140-3 and DoD compliance checking
- **Quality Assurance**: Continuous testing and validation during development
- **Documentation**: Real-time documentation generation and maintenance
- **Scalability**: Distributed workload across specialized agents

## Agent Catalog

### Core Development Agents

#### 1. **Code Architect Agent** (`@architect`)
**Specialties:**
- System design and architecture decisions
- Solution structure planning
- Design pattern implementation
- Dependency management
- Technology stack recommendations

**When to Use:**
- Starting new features or modules
- Refactoring existing architecture
- Evaluating technical decisions
- Planning microservices boundaries

**Example Invocation:**
```yaml
@architect: Design a secure asset tracking module with:
  - FIPS 140-3 compliant encryption
  - Event sourcing pattern
  - Clean architecture layers
  - Integration with existing auth system
```

#### 2. **Security Compliance Agent** (`@security`)
**Specialties:**
- FIPS 140-3 validation
- STIG compliance checking
- Vulnerability scanning
- Cryptographic algorithm verification
- Security policy enforcement

**When to Use:**
- Before any code commit
- During API endpoint creation
- When handling sensitive data
- For authentication/authorization changes

**Example Invocation:**
```yaml
@security: Validate the following for DoD compliance:
  - Encryption algorithms in CryptoService.cs
  - TLS configuration in Program.cs
  - Password hashing implementation
  - Audit logging completeness
```

#### 3. **Database Specialist Agent** (`@database`)
**Specialties:**
- Schema design and optimization
- Migration generation
- Performance tuning
- Index analysis
- Data integrity validation

**When to Use:**
- Creating new entities
- Modifying database schema
- Performance optimization
- Data migration planning

**Example Invocation:**
```yaml
@database: Optimize asset inventory queries:
  - Analyze current execution plans
  - Suggest index improvements
  - Generate Entity Framework migrations
  - Validate referential integrity
```

#### 4. **API Developer Agent** (`@api`)
**Specialties:**
- RESTful endpoint design
- OpenAPI/Swagger generation
- Rate limiting implementation
- API versioning
- Request/response validation

**When to Use:**
- Creating new API endpoints
- Implementing API security
- Generating API documentation
- Setting up API versioning

**Example Invocation:**
```yaml
@api: Create secure endpoints for asset management:
  - CRUD operations with authorization
  - Input validation and sanitization
  - Rate limiting per user role
  - Automatic OpenAPI documentation
```

#### 5. **UI/UX Developer Agent** (`@ui`)
**Specialties:**
- Blazor component creation
- Accessibility compliance (WCAG 2.1)
- Responsive design
- Performance optimization
- User experience patterns

**When to Use:**
- Creating new UI components
- Implementing user workflows
- Ensuring accessibility compliance
- Optimizing frontend performance

**Example Invocation:**
```yaml
@ui: Create accessible asset dashboard:
  - WCAG 2.1 Level AA compliance
  - Real-time data updates
  - Mobile responsive design
  - Keyboard navigation support
```

#### 6. **Test Automation Agent** (`@tester`)
**Specialties:**
- Unit test generation
- Integration test creation
- Security test implementation
- Performance test design
- Test coverage analysis

**When to Use:**
- After implementing new features
- During refactoring
- For regression testing
- Security validation

**Example Invocation:**
```yaml
@tester: Generate comprehensive tests for:
  - AssetService business logic
  - API endpoint security
  - Database transaction integrity
  - FIPS compliance verification
```

#### 7. **Documentation Agent** (`@docs`)
**Specialties:**
- Technical documentation
- API documentation
- User guides
- Architecture diagrams
- Compliance documentation

**When to Use:**
- After feature completion
- During architecture changes
- For compliance audits
- Creating user manuals

**Example Invocation:**
```yaml
@docs: Generate documentation for:
  - Asset management module architecture
  - API endpoint usage examples
  - Security compliance checklist
  - Deployment procedures
```

#### 8. **Performance Optimization Agent** (`@performance`)
**Specialties:**
- Code profiling
- Query optimization
- Memory management
- Caching strategies
- Load testing

**When to Use:**
- Addressing performance issues
- Before production deployment
- Optimizing critical paths
- Resource usage analysis

**Example Invocation:**
```yaml
@performance: Optimize asset search functionality:
  - Profile current implementation
  - Implement caching strategy
  - Optimize database queries
  - Add response compression
```

#### 9. **DevOps Agent** (`@devops`)
**Specialties:**
- CI/CD pipeline configuration
- Container orchestration
- Infrastructure as Code
- Monitoring setup
- Deployment automation

**When to Use:**
- Setting up build pipelines
- Configuring deployments
- Infrastructure changes
- Monitoring implementation

**Example Invocation:**
```yaml
@devops: Configure secure deployment pipeline:
  - STIG-compliant build process
  - Container security scanning
  - Automated compliance checks
  - Blue-green deployment strategy
```

#### 10. **Code Review Agent** (`@reviewer`)
**Specialties:**
- Code quality analysis
- Security vulnerability detection
- Best practices enforcement
- Performance bottleneck identification
- Maintainability assessment

**When to Use:**
- Before pull requests
- After major changes
- During refactoring
- Code quality audits

**Example Invocation:**
```yaml
@reviewer: Review AssetManagement module for:
  - Security vulnerabilities
  - Code quality issues
  - Performance bottlenecks
  - SOLID principle violations
```

## Parallel Execution Patterns

### Pattern 1: Feature Development Pipeline

```mermaid
graph LR
    Start[Feature Request] --> A[@architect]
    A --> B[@api]
    A --> C[@database]
    A --> D[@ui]
    B --> E[@security]
    C --> E
    D --> E
    E --> F[@tester]
    F --> G[@docs]
    G --> H[Feature Complete]
```

**Parallel Execution Example:**
```yaml
# Execute in parallel
parallel:
  - thread1:
      - @architect: Design user authentication module
      - @security: Define security requirements
  - thread2:
      - @database: Design user schema
      - @api: Plan authentication endpoints
  - thread3:
      - @ui: Design login interface
      - @docs: Prepare documentation structure

# Synchronization point
sync:
  - @reviewer: Review all designs
  - @tester: Create test plan

# Continue parallel execution
parallel:
  - thread1:
      - @api: Implement endpoints
      - @tester: Write API tests
  - thread2:
      - @ui: Implement components
      - @tester: Write UI tests
  - thread3:
      - @database: Create migrations
      - @performance: Optimize queries
```

### Pattern 2: Security-First Development

```yaml
# Security validation occurs in parallel with development
parallel:
  development:
    - @api: Implement asset tracking endpoint
    - @database: Create asset schema
    - @ui: Build asset management interface
  
  security:
    continuous:
      - @security: Monitor for vulnerabilities
      - @security: Validate FIPS compliance
      - @security: Check access controls
      
  documentation:
    continuous:
      - @docs: Update API documentation
      - @docs: Maintain security compliance docs
```

### Pattern 3: Database Change Impact Analysis

```yaml
# Parallel impact analysis for schema changes
parallel:
  analysis:
    - @database: Analyze migration impact
    - @api: Identify affected endpoints
    - @ui: Find dependent components
    - @tester: Update test scenarios
    
  validation:
    - @security: Verify data protection
    - @performance: Assess query impact
    
sync:
  - @architect: Review impact analysis
  - decision: proceed | rollback | modify
  
conditional:
  if: proceed
  then:
    parallel:
      - @database: Execute migration
      - @api: Update data access layer
      - @tester: Run regression tests
```

## MCP Server Integration

### Available MCP Servers

#### 1. **GitHub MCP Server** (`mcp__github`)
**Purpose:** Source control and collaboration
**Integration Points:**
- Automated PR creation
- Issue tracking
- Code review workflows
- Branch protection enforcement

```typescript
// Agent workflow with GitHub MCP
const githubWorkflow = {
  "@developer": "Implement feature",
  "@tester": "Create tests",
  "mcp__github": {
    action: "create_pull_request",
    params: {
      title: "feat: Add asset tracking",
      body: "Implements FIPS-compliant asset tracking",
      base: "main",
      reviewers: ["security-team", "architecture-team"]
    }
  },
  "@security": "Perform security review",
  "@reviewer": "Code quality check"
};
```

#### 2. **Puppeteer MCP Server** (`mcp__puppeteer`)
**Purpose:** UI testing and validation
**Integration Points:**
- Automated UI testing
- Accessibility validation
- Visual regression testing
- Performance metrics

```typescript
// UI validation workflow
const uiTestWorkflow = {
  parallel: [
    {
      "@ui": "Create dashboard component",
      "mcp__puppeteer": {
        action: "screenshot",
        params: { 
          name: "dashboard-baseline",
          selector: "#asset-dashboard" 
        }
      }
    },
    {
      "@tester": "Generate UI tests",
      "mcp__puppeteer": {
        action: "evaluate",
        script: "document.querySelector('#dashboard').ariaLabel"
      }
    }
  ]
};
```

#### 3. **Browser Tools MCP** (`mcp__browser-tools`)
**Purpose:** Advanced browser debugging and auditing
**Integration Points:**
- Performance audits
- Accessibility audits
- SEO audits
- Network analysis

```typescript
// Comprehensive audit workflow
const auditWorkflow = {
  sequence: [
    { "@ui": "Deploy to staging" },
    { 
      "mcp__browser-tools": {
        parallel: [
          { action: "runPerformanceAudit" },
          { action: "runAccessibilityAudit" },
          { action: "runSEOAudit" },
          { action: "runBestPracticesAudit" }
        ]
      }
    },
    { "@performance": "Analyze audit results" },
    { "@ui": "Implement improvements" }
  ]
};
```

#### 4. **Context7 MCP** (`mcp__context7`)
**Purpose:** Documentation retrieval and library research
**Integration Points:**
- Library documentation lookup
- Best practices research
- Security guideline retrieval

```typescript
// Documentation research workflow
const researchWorkflow = {
  "@architect": "Research encryption libraries",
  "mcp__context7": {
    action: "get-library-docs",
    params: {
      library: "System.Security.Cryptography",
      topic: "FIPS compliance"
    }
  },
  "@security": "Validate library compliance"
};
```

#### 5. **Socket MCP** (`mcp__socket`)
**Purpose:** Dependency security scanning
**Integration Points:**
- Package vulnerability detection
- License compliance checking
- Supply chain security

```typescript
// Dependency security workflow
const dependencyWorkflow = {
  "@developer": "Add new NuGet packages",
  "mcp__socket": {
    action: "depscore",
    packages: [
      { depname: "Microsoft.AspNetCore.Authentication.JwtBearer", version: "8.0.0" },
      { depname: "Microsoft.EntityFrameworkCore", version: "8.0.0" }
    ]
  },
  "@security": "Review dependency risks",
  conditional: {
    if: "score < 80",
    then: "@architect: Find alternative packages"
  }
};
```

#### 6. **Serena MCP** (`mcp__serena`)
**Purpose:** Codebase analysis and manipulation
**Integration Points:**
- Symbol navigation
- Code refactoring
- Pattern searching
- Memory management

```typescript
// Refactoring workflow
const refactorWorkflow = {
  parallel: [
    {
      "mcp__serena": {
        action: "find_symbol",
        params: { name_path: "AssetService" }
      }
    },
    {
      "mcp__serena": {
        action: "search_for_pattern",
        params: { pattern: "TODO|FIXME|HACK" }
      }
    }
  ],
  "@architect": "Plan refactoring",
  "@developer": "Implement changes",
  "mcp__serena": {
    action: "replace_symbol_body",
    params: { /* refactoring details */ }
  }
};
```

## DoD Compliance Workflows

### Workflow 1: FIPS 140-3 Compliance Validation

```yaml
name: FIPS Compliance Check
trigger: [pre-commit, pull-request]

agents:
  parallel:
    - security_scan:
        agent: @security
        tasks:
          - Scan for non-FIPS algorithms
          - Verify cryptographic providers
          - Check key lengths
          - Validate RNG implementation
    
    - code_analysis:
        agent: @reviewer
        tasks:
          - Identify crypto usage
          - Check for hardcoded keys
          - Verify secure random usage
    
    - documentation:
        agent: @docs
        tasks:
          - Update crypto inventory
          - Document algorithm choices
          - Maintain compliance matrix

sync_point:
  agent: @security
  decision:
    pass: Continue to commit
    fail: Block and remediate

remediation:
  if: fail
  parallel:
    - @developer: Replace non-compliant algorithms
    - @tester: Update security tests
    - @docs: Document changes
```

### Workflow 2: CAC Authentication Implementation

```yaml
name: CAC Authentication Setup
agents:
  sequence:
    - plan:
        agent: @architect
        output: Authentication architecture
        
    - implement:
        parallel:
          - @api:
              - Create CAC validation endpoint
              - Implement certificate parsing
              - Add DoD PKI validation
          
          - @database:
              - Create user certificate mapping
              - Add audit tables
              - Index certificate fields
          
          - @ui:
              - Create CAC login component
              - Add certificate selection UI
              - Implement session management
    
    - validate:
        agent: @security
        tasks:
          - Verify certificate chain validation
          - Check revocation list handling
          - Validate PIN handling
          - Audit logging verification
    
    - test:
        parallel:
          - @tester:
              - Unit tests for cert validation
              - Integration tests with test certs
              - UI automation tests
          
          - mcp__puppeteer:
              - Screenshot CAC workflows
              - Test certificate selection
              - Validate error handling
```

### Workflow 3: Security Audit Trail Implementation

```yaml
name: Audit Trail System
agents:
  phase1_design:
    parallel:
      - @architect: Design audit architecture
      - @security: Define audit requirements
      - @database: Design audit schema
  
  phase2_implement:
    parallel:
      - backend:
          agents: [@api, @database]
          tasks:
            - Create audit interceptors
            - Implement tamper-proof storage
            - Add hash chain validation
      
      - frontend:
          agent: @ui
          tasks:
            - Create audit viewer
            - Add search/filter UI
            - Export functionality
      
      - security:
          agent: @security
          continuous:
            - Monitor implementation
            - Validate STIG compliance
            - Check encryption
  
  phase3_validate:
    sequence:
      - @tester: Comprehensive testing
      - @security: Security validation
      - @performance: Load testing
      - @docs: Complete documentation
```

## Code Examples

### Example 1: Parallel Feature Implementation

```csharp
// Agent: @architect - Design the service interface
public interface IAssetManagementService
{
    Task<AssetDto> CreateAssetAsync(CreateAssetRequest request, ClaimsPrincipal user);
    Task<AssetDto> GetAssetAsync(Guid assetId, ClaimsPrincipal user);
    Task<PagedResult<AssetDto>> SearchAssetsAsync(AssetSearchRequest request, ClaimsPrincipal user);
    Task<AssetDto> UpdateAssetAsync(Guid assetId, UpdateAssetRequest request, ClaimsPrincipal user);
    Task DeleteAssetAsync(Guid assetId, ClaimsPrincipal user);
}

// Agent: @api - Implement secure endpoint
[ApiController]
[Route("api/v1/[controller]")]
[Authorize(Policy = "AssetManager")]
[RateLimiting("PerUserRateLimit")]
public class AssetsController : ControllerBase
{
    private readonly IAssetManagementService _assetService;
    private readonly ILogger<AssetsController> _logger;
    private readonly IAuditService _auditService;

    // Agent: @security - Add security attributes
    [HttpPost]
    [ValidateAntiForgeryToken]
    [RequiresMfa]
    [AuditLog(EventType = "AssetCreation")]
    public async Task<ActionResult<AssetDto>> CreateAsset(
        [FromBody] CreateAssetRequest request)
    {
        // Agent: @tester - Parallel test generation
        // Unit test: CreateAsset_ValidRequest_ReturnsCreatedAsset
        // Integration test: CreateAsset_WithCAC_Success
        // Security test: CreateAsset_WithoutMfa_ReturnsForbidden
        
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var asset = await _assetService.CreateAssetAsync(request, User);
            
            // Agent: @security - Audit logging
            await _auditService.LogAsync(new AuditEvent
            {
                EventType = "AssetCreated",
                UserId = User.Identity.Name,
                ResourceId = asset.Id.ToString(),
                Details = new { AssetType = asset.Type, Classification = asset.Classification }
            });

            return CreatedAtAction(
                nameof(GetAsset), 
                new { id = asset.Id }, 
                asset);
        }
        catch (UnauthorizedAccessException ex)
        {
            _logger.LogWarning(ex, "Unauthorized asset creation attempt by {User}", User.Identity.Name);
            return Forbid();
        }
    }
}

// Agent: @database - Entity configuration
public class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.ToTable("Assets", "dbo");
        
        // Agent: @security - Encryption configuration
        builder.Property(a => a.SerialNumber)
            .HasConversion(
                v => EncryptionService.Encrypt(v),
                v => EncryptionService.Decrypt(v))
            .HasMaxLength(500);
        
        // Agent: @performance - Index optimization
        builder.HasIndex(a => a.AssetTag)
            .IsUnique()
            .HasFilter("[IsDeleted] = 0");
        
        builder.HasIndex(a => new { a.Type, a.Status, a.Location })
            .IncludeProperties(a => new { a.Name, a.LastMaintenanceDate });
        
        // Agent: @database - Audit fields
        builder.Property(a => a.CreatedAt)
            .HasDefaultValueSql("SYSDATETIMEOFFSET()");
    }
}

// Agent: @ui - Blazor component
@page "/assets/create"
@attribute [Authorize(Policy = "AssetManager")]
@implements IDisposable

<EditForm Model="@model" OnValidSubmit="@HandleValidSubmit">
    <DataAnnotationsValidator />
    <ValidationSummary />
    
    @* Agent: @ui - Accessibility compliant form *@
    <div class="form-group" role="group" aria-labelledby="asset-info">
        <h2 id="asset-info">Asset Information</h2>
        
        <label for="asset-name">
            Asset Name
            <span class="required" aria-label="required">*</span>
        </label>
        <InputText id="asset-name" 
                   @bind-Value="model.Name" 
                   class="form-control"
                   aria-required="true"
                   aria-describedby="name-help" />
        <small id="name-help" class="form-text text-muted">
            Enter a descriptive name for the asset
        </small>
    </div>
    
    @* Agent: @performance - Virtualized dropdown for large datasets *@
    <Virtualize Items="@assetTypes" Context="type">
        <option value="@type.Id">@type.Name</option>
    </Virtualize>
    
    <button type="submit" 
            class="btn btn-primary"
            disabled="@isSubmitting">
        @if (isSubmitting)
        {
            <span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
            <span>Creating...</span>
        }
        else
        {
            <span>Create Asset</span>
        }
    </button>
</EditForm>

@code {
    // Agent: @tester - Component test hooks
    [Parameter] public EventCallback<Asset> OnAssetCreated { get; set; }
    
    private CreateAssetModel model = new();
    private bool isSubmitting;
    
    private async Task HandleValidSubmit()
    {
        isSubmitting = true;
        
        try
        {
            var result = await AssetService.CreateAsync(model);
            await OnAssetCreated.InvokeAsync(result);
            NavigationManager.NavigateTo($"/assets/{result.Id}");
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to create asset");
            await ShowError("Failed to create asset. Please try again.");
        }
        finally
        {
            isSubmitting = false;
        }
    }
}
```

### Example 2: Multi-Agent Security Implementation

```csharp
// Agent: @security - FIPS-compliant encryption service
public class FipsCompliantEncryptionService : IEncryptionService
{
    private readonly IKeyManagementService _keyService;
    private readonly IAuditService _auditService;
    
    // Agent: @security - Validate FIPS mode on startup
    public FipsCompliantEncryptionService(
        IKeyManagementService keyService,
        IAuditService auditService)
    {
        _keyService = keyService;
        _auditService = auditService;
        
        if (!CryptoConfig.AllowOnlyFipsAlgorithms)
        {
            throw new SecurityException("FIPS mode is not enabled");
        }
    }
    
    // Agent: @performance - Parallel encryption for large datasets
    public async Task<byte[]> EncryptAsync(
        byte[] plaintext, 
        string context,
        DataClassification classification)
    {
        // Agent: @security - Audit sensitive operations
        await _auditService.LogEncryptionOperationAsync(context, classification);
        
        // Agent: @architect - Use proper key hierarchy
        var dataKey = await _keyService.GetDataEncryptionKeyAsync(context, classification);
        
        using var aes = Aes.Create();
        aes.Mode = CipherMode.GCM; // FIPS-approved mode
        aes.KeySize = classification >= DataClassification.Secret ? 256 : 128;
        aes.Key = dataKey.PlaintextKey;
        
        var nonce = new byte[12]; // GCM nonce size
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(nonce);
        }
        
        var tag = new byte[16]; // GCM tag size
        var ciphertext = new byte[plaintext.Length];
        
        // Agent: @performance - Use hardware acceleration if available
        using (var aesGcm = new AesGcm(aes.Key))
        {
            aesGcm.Encrypt(nonce, plaintext, ciphertext, tag);
        }
        
        // Agent: @database - Store encrypted key reference
        var result = new byte[nonce.Length + ciphertext.Length + tag.Length + 36]; // +36 for key ID
        var keyIdBytes = Encoding.UTF8.GetBytes(dataKey.KeyId);
        
        Buffer.BlockCopy(keyIdBytes, 0, result, 0, 36);
        Buffer.BlockCopy(nonce, 0, result, 36, nonce.Length);
        Buffer.BlockCopy(ciphertext, 0, result, 36 + nonce.Length, ciphertext.Length);
        Buffer.BlockCopy(tag, 0, result, 36 + nonce.Length + ciphertext.Length, tag.Length);
        
        return result;
    }
}

// Agent: @tester - Parallel security tests
[TestClass]
public class FipsEncryptionTests
{
    [TestMethod]
    [DataRow(DataClassification.Unclassified)]
    [DataRow(DataClassification.Secret)]
    [DataRow(DataClassification.TopSecret)]
    public async Task Encryption_AllClassifications_UsesFipsAlgorithms(
        DataClassification classification)
    {
        // Arrange
        var service = new FipsCompliantEncryptionService(
            GetMockKeyService(),
            GetMockAuditService());
        var plaintext = Encoding.UTF8.GetBytes("Sensitive data");
        
        // Act
        var encrypted = await service.EncryptAsync(
            plaintext, 
            "test-context", 
            classification);
        
        // Assert
        Assert.IsNotNull(encrypted);
        Assert.IsTrue(encrypted.Length > plaintext.Length);
        
        // Agent: @security - Verify FIPS compliance
        Assert.IsTrue(CryptoConfig.AllowOnlyFipsAlgorithms);
        
        // Verify proper key size for classification
        var keySize = classification >= DataClassification.Secret ? 256 : 128;
        // Additional assertions...
    }
    
    [TestMethod]
    public async Task Encryption_HighVolume_MaintainsPerformance()
    {
        // Agent: @performance - Parallel performance testing
        var tasks = new List<Task>();
        var stopwatch = Stopwatch.StartNew();
        
        for (int i = 0; i < 1000; i++)
        {
            tasks.Add(Task.Run(async () =>
            {
                var data = GenerateRandomData(1024 * 10); // 10KB
                await service.EncryptAsync(data, $"context-{i}", DataClassification.Secret);
            }));
        }
        
        await Task.WhenAll(tasks);
        stopwatch.Stop();
        
        // Performance assertion - should complete in under 5 seconds
        Assert.IsTrue(stopwatch.ElapsedMilliseconds < 5000);
    }
}
```

### Example 3: Database Migration with Impact Analysis

```csharp
// Agent: @database - Migration with parallel validation
public partial class AddAssetEncryption : Migration
{
    // Agent: @architect - Design encryption strategy
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        // Agent: @database - Add encrypted columns
        migrationBuilder.AddColumn<string>(
            name: "EncryptedSerialNumber",
            table: "Assets",
            type: "nvarchar(500)",
            maxLength: 500,
            nullable: true);
        
        migrationBuilder.AddColumn<string>(
            name: "EncryptionKeyId",
            table: "Assets",
            type: "nvarchar(36)",
            maxLength: 36,
            nullable: true);
        
        // Agent: @performance - Add index for key rotation queries
        migrationBuilder.CreateIndex(
            name: "IX_Assets_EncryptionKeyId",
            table: "Assets",
            column: "EncryptionKeyId");
        
        // Agent: @security - Migrate existing data with encryption
        migrationBuilder.Sql(@"
            -- Agent: @database - Batch processing for large datasets
            DECLARE @BatchSize INT = 1000;
            DECLARE @Offset INT = 0;
            DECLARE @TotalRows INT = (SELECT COUNT(*) FROM Assets WHERE SerialNumber IS NOT NULL);
            
            WHILE @Offset < @TotalRows
            BEGIN
                -- Agent: @security - Encrypt sensitive data
                UPDATE Assets
                SET EncryptedSerialNumber = dbo.FipsEncrypt(SerialNumber),
                    EncryptionKeyId = dbo.GetCurrentKeyId()
                WHERE Id IN (
                    SELECT TOP (@BatchSize) Id
                    FROM Assets
                    WHERE SerialNumber IS NOT NULL
                    AND EncryptedSerialNumber IS NULL
                    ORDER BY Id
                )
                
                SET @Offset = @Offset + @BatchSize;
                
                -- Agent: @performance - Prevent lock escalation
                WAITFOR DELAY '00:00:00.100';
            END
        ");
        
        // Agent: @database - Drop old unencrypted column
        migrationBuilder.DropColumn(
            name: "SerialNumber",
            table: "Assets");
        
        // Agent: @database - Rename encrypted column
        migrationBuilder.RenameColumn(
            name: "EncryptedSerialNumber",
            table: "Assets",
            newName: "SerialNumber");
    }
    
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        // Agent: @architect - Carefully planned rollback
        // Note: This requires decryption capability
        
        migrationBuilder.AddColumn<string>(
            name: "UnencryptedSerialNumber",
            table: "Assets",
            type: "nvarchar(100)",
            maxLength: 100,
            nullable: true);
        
        // Decrypt data before removing encryption
        migrationBuilder.Sql(@"
            UPDATE Assets
            SET UnencryptedSerialNumber = dbo.FipsDecrypt(SerialNumber, EncryptionKeyId)
            WHERE SerialNumber IS NOT NULL
        ");
        
        migrationBuilder.DropColumn(name: "SerialNumber", table: "Assets");
        migrationBuilder.DropColumn(name: "EncryptionKeyId", table: "Assets");
        
        migrationBuilder.RenameColumn(
            name: "UnencryptedSerialNumber",
            table: "Assets",
            newName: "SerialNumber");
    }
}

// Agent: @tester - Migration validation tests
[TestClass]
public class AssetEncryptionMigrationTests
{
    [TestMethod]
    public async Task Migration_EncryptsAllSerialNumbers()
    {
        // Agent: @tester - Parallel test execution
        var tasks = new List<Task>
        {
            VerifyEncryptionCompleteness(),
            VerifyNoDataLoss(),
            VerifyPerformanceImpact(),
            VerifyRollbackCapability()
        };
        
        await Task.WhenAll(tasks);
    }
}
```

## Performance Optimization

### Parallel Agent Execution Strategies

#### Strategy 1: Task Decomposition
```yaml
optimization: task_decomposition
description: Break large tasks into parallel subtasks

example:
  original_task: "Implement complete user management system"
  
  decomposed:
    parallel_tracks:
      track1:
        agents: [@database, @tester]
        tasks:
          - Design user schema
          - Create migrations
          - Generate repository tests
      
      track2:
        agents: [@api, @tester]
        tasks:
          - Design REST endpoints
          - Implement controllers
          - Create API tests
      
      track3:
        agents: [@ui, @tester]
        tasks:
          - Design user interfaces
          - Implement components
          - Create UI tests
      
      track4:
        agents: [@security, @docs]
        continuous:
          - Monitor security compliance
          - Update documentation
          - Generate audit logs

benefits:
  - 4x faster completion
  - Early issue detection
  - Continuous validation
```

#### Strategy 2: Pipeline Parallelization
```yaml
optimization: pipeline_parallel
description: Overlap sequential stages

pipeline:
  stage1:
    agent: @architect
    output: architecture.md
    next: [stage2a, stage2b, stage2c]
  
  stage2a:
    agent: @database
    input: architecture.md
    output: schema.sql
    next: stage3
  
  stage2b:
    agent: @api
    input: architecture.md
    output: api_spec.yaml
    next: stage3
  
  stage2c:
    agent: @ui
    input: architecture.md
    output: ui_mockups.figma
    next: stage3
  
  stage3:
    agents: [@developer, @tester]
    inputs: [schema.sql, api_spec.yaml, ui_mockups.figma]
    parallel_implementation: true

performance_gains:
  sequential_time: 8 hours
  parallel_time: 3 hours
  speedup: 2.67x
```

#### Strategy 3: Resource Pooling
```yaml
optimization: resource_pooling
description: Efficient agent resource utilization

agent_pool:
  configuration:
    max_concurrent_agents: 10
    agent_types:
      - type: @developer
        instances: 3
        specializations: [backend, frontend, database]
      - type: @tester
        instances: 2
        specializations: [unit, integration]
      - type: @security
        instances: 1
        continuous: true
      - type: @performance
        instances: 1
        on_demand: true

  scheduling:
    algorithm: priority_queue
    factors:
      - task_priority
      - estimated_duration
      - dependencies
      - resource_availability

  example_execution:
    queue:
      - priority: high
        task: Security vulnerability fix
        agents: [@security, @developer[backend], @tester[unit]]
      - priority: medium
        task: New feature implementation
        agents: [@developer[frontend], @developer[backend], @tester[integration]]
      - priority: low
        task: Documentation update
        agents: [@docs]
```

### Memory and Resource Management

```yaml
resource_optimization:
  memory_management:
    strategies:
      - lazy_loading:
          description: Load resources only when needed
          example: "@database: Load only active asset records"
      
      - streaming:
          description: Process data in chunks
          example: "@performance: Analyze logs in 1MB chunks"
      
      - caching:
          description: Reuse computed results
          example: "@security: Cache compliance check results for 1 hour"
  
  cpu_optimization:
    strategies:
      - batch_processing:
          description: Group similar operations
          example: "@api: Batch validate 100 requests at once"
      
      - async_operations:
          description: Non-blocking execution
          example: "@tester: Run tests asynchronously"
      
      - work_stealing:
          description: Dynamic task redistribution
          example: "Idle agents steal tasks from busy agents"

  network_optimization:
    strategies:
      - request_batching:
          description: Combine multiple API calls
          example: "mcp__github: Batch create 10 issues in one call"
      
      - response_compression:
          description: Compress large payloads
          example: "@api: Enable gzip for responses > 1KB"
      
      - connection_pooling:
          description: Reuse network connections
          example: "@database: Maintain 10 persistent connections"
```

## Common Anti-patterns

### Anti-pattern 1: Sequential Agent Execution
```yaml
# ❌ BAD: Sequential execution
bad_practice:
  step1:
    agent: @architect
    task: Design system
    duration: 2 hours
  step2:
    agent: @developer
    task: Implement
    duration: 4 hours
  step3:
    agent: @tester
    task: Test
    duration: 2 hours
  total_time: 8 hours

# ✅ GOOD: Parallel execution
good_practice:
  parallel:
    - agent: @architect
      task: Design system
      then_trigger: [@developer, @tester.prepare]
    - agent: @tester
      task: Prepare test cases
      starts_with: @architect
    - agent: @developer
      task: Implement
      with_continuous: @tester.validate
  total_time: 4 hours
```

### Anti-pattern 2: Monolithic Agent Tasks
```yaml
# ❌ BAD: Single agent doing everything
bad_practice:
  agent: @developer
  task: |
    - Design database schema
    - Implement API endpoints
    - Create UI components
    - Write tests
    - Document everything
  issues:
    - No specialization
    - Sequential execution
    - Longer completion time

# ✅ GOOD: Specialized agents
good_practice:
  parallel:
    - "@database: Design schema"
    - "@api: Design endpoints"
    - "@ui: Create components"
    - "@tester: Write tests"
    - "@docs: Document continuously"
  benefits:
    - Expert knowledge
    - Parallel execution
    - Faster completion
```

### Anti-pattern 3: Missing Security Validation
```yaml
# ❌ BAD: Security as afterthought
bad_practice:
  development:
    - "@developer: Implement feature"
    - "@tester: Test functionality"
    - "@docs: Document feature"
    - "@security: Review security" # Too late!
  issues:
    - Security vulnerabilities discovered late
    - Expensive refactoring
    - Potential compliance violations

# ✅ GOOD: Security-first approach
good_practice:
  parallel:
    continuous:
      "@security: Monitor and validate"
    development:
      - "@architect: Design with security requirements"
      - "@developer: Implement with security controls"
      - "@tester: Include security tests"
  benefits:
    - Early vulnerability detection
    - Compliance maintained
    - Reduced rework
```

### Anti-pattern 4: Insufficient Test Coverage
```yaml
# ❌ BAD: Testing after implementation
bad_practice:
  sequence:
    - "@developer: Implement feature"
    - "@developer: Maybe write some tests"
  issues:
    - Low test coverage
    - Bugs discovered late
    - Difficult refactoring

# ✅ GOOD: Test-driven development with agents
good_practice:
  parallel:
    - "@tester: Write test specifications"
    - "@developer: Implement with TDD"
    - "@security: Security test cases"
    - "@performance: Performance benchmarks"
  continuous:
    "@tester: Run tests on every change"
```

### Anti-pattern 5: Ignoring Performance Impact
```yaml
# ❌ BAD: No performance consideration
bad_practice:
  "@developer: Implement feature"
  "@tester: Functional tests only"
  # Performance issues discovered in production

# ✅ GOOD: Performance-aware development
good_practice:
  parallel:
    development:
      "@developer: Implement with performance patterns"
    validation:
      "@performance: Profile and benchmark"
      "@database: Query optimization"
    testing:
      "@tester: Load and stress testing"
```

## Monitoring and Metrics

### Agent Performance Metrics

```yaml
metrics_collection:
  agent_metrics:
    execution_time:
      description: Time taken by each agent
      collection: Per task
      aggregation: [p50, p95, p99, max]
      alert_threshold: p95 > 5 minutes
    
    success_rate:
      description: Percentage of successful completions
      calculation: (successful_tasks / total_tasks) * 100
      alert_threshold: < 95%
    
    resource_usage:
      cpu:
        measurement: Percentage
        alert_threshold: > 80%
      memory:
        measurement: MB
        alert_threshold: > 2048
      network:
        measurement: Requests/second
        alert_threshold: > 100
    
    quality_metrics:
      code_coverage:
        target: > 80%
        measurement: Per module
      security_score:
        target: 100%
        measurement: STIG compliance
      performance_score:
        target: All operations < 1s
        measurement: Response time

  workflow_metrics:
    pipeline_throughput:
      description: Features completed per day
      measurement: Count
      target: > 5
    
    cycle_time:
      description: Time from request to deployment
      measurement: Hours
      target: < 24
    
    defect_escape_rate:
      description: Bugs found in production
      calculation: production_bugs / total_features
      target: < 1%
    
    compliance_score:
      description: Overall compliance percentage
      components:
        - fips_compliance: 100%
        - stig_compliance: 100%
        - audit_completeness: 100%
      target: 100%
```

### Monitoring Dashboard Configuration

```typescript
// Real-time agent monitoring dashboard
const monitoringConfig = {
  dashboards: [
    {
      name: "Agent Performance",
      refresh_interval: "5s",
      widgets: [
        {
          type: "timeseries",
          title: "Agent Execution Time",
          metric: "agent.execution_time",
          groupBy: "agent_type"
        },
        {
          type: "gauge",
          title: "Current Active Agents",
          metric: "agent.active_count",
          max: 10
        },
        {
          type: "heatmap",
          title: "Agent Success Rate",
          metric: "agent.success_rate",
          dimensions: ["agent_type", "task_type"]
        }
      ]
    },
    {
      name: "Security Compliance",
      refresh_interval: "1m",
      widgets: [
        {
          type: "scorecard",
          title: "FIPS Compliance",
          metric: "security.fips_compliance",
          target: 100,
          unit: "%"
        },
        {
          type: "table",
          title: "Security Violations",
          query: "SELECT * FROM security_violations WHERE time > now() - 1h",
          columns: ["timestamp", "agent", "violation_type", "severity"]
        }
      ]
    }
  ],
  
  alerts: [
    {
      name: "Agent Failure",
      condition: "agent.success_rate < 95",
      severity: "warning",
      notification: ["email", "slack"]
    },
    {
      name: "Security Violation",
      condition: "security.violations > 0",
      severity: "critical",
      notification: ["pagerduty", "email", "slack"]
    },
    {
      name: "Performance Degradation",
      condition: "agent.p95_execution_time > 300s",
      severity: "warning",
      notification: ["slack"]
    }
  ]
};
```

### Metrics Collection Implementation

```csharp
// Agent metrics collector service
public class AgentMetricsService : IAgentMetricsService
{
    private readonly IMetricsCollector _metrics;
    private readonly ILogger<AgentMetricsService> _logger;
    
    public async Task RecordAgentExecutionAsync(
        string agentType,
        string taskType,
        TimeSpan duration,
        bool success,
        Dictionary<string, object> metadata = null)
    {
        // Record execution time
        _metrics.RecordHistogram(
            "agent.execution_time",
            duration.TotalMilliseconds,
            new[]
            {
                new KeyValuePair<string, object>("agent_type", agentType),
                new KeyValuePair<string, object>("task_type", taskType),
                new KeyValuePair<string, object>("success", success)
            });
        
        // Update success rate
        _metrics.IncrementCounter(
            success ? "agent.success_count" : "agent.failure_count",
            new[]
            {
                new KeyValuePair<string, object>("agent_type", agentType),
                new KeyValuePair<string, object>("task_type", taskType)
            });
        
        // Record resource usage
        if (metadata?.ContainsKey("cpu_usage") == true)
        {
            _metrics.RecordGauge(
                "agent.cpu_usage",
                (double)metadata["cpu_usage"],
                new[]
                {
                    new KeyValuePair<string, object>("agent_type", agentType)
                });
        }
        
        // Alert on failures
        if (!success)
        {
            await AlertOnFailureAsync(agentType, taskType, metadata);
        }
        
        // Log for audit
        _logger.LogInformation(
            "Agent execution: {AgentType}/{TaskType} - Duration: {Duration}ms - Success: {Success}",
            agentType, taskType, duration.TotalMilliseconds, success);
    }
    
    public async Task<AgentHealthReport> GetHealthReportAsync()
    {
        var report = new AgentHealthReport
        {
            Timestamp = DateTime.UtcNow,
            Agents = new List<AgentHealth>()
        };
        
        var agentTypes = new[] { "@architect", "@developer", "@tester", "@security", "@database", "@api", "@ui", "@performance", "@docs" };
        
        var tasks = agentTypes.Select(async agent =>
        {
            var health = new AgentHealth
            {
                AgentType = agent,
                SuccessRate = await CalculateSuccessRateAsync(agent, TimeSpan.FromHours(24)),
                AverageExecutionTime = await CalculateAverageExecutionTimeAsync(agent, TimeSpan.FromHours(24)),
                LastExecution = await GetLastExecutionTimeAsync(agent),
                Status = DetermineHealthStatus(agent)
            };
            
            return health;
        });
        
        report.Agents.AddRange(await Task.WhenAll(tasks));
        report.OverallHealth = CalculateOverallHealth(report.Agents);
        
        return report;
    }
}
```

## Practical Workflows

### Workflow 1: Feature Development with Parallel Testing

```yaml
name: Parallel Feature Development
description: Develop asset tracking feature with continuous testing

phases:
  phase1_planning:
    duration: 2 hours
    parallel:
      - agent: @architect
        tasks:
          - Review requirements
          - Design architecture
          - Create technical spec
        outputs:
          - architecture.md
          - api_spec.yaml
          - data_model.sql
      
      - agent: @security
        tasks:
          - Security requirements analysis
          - Threat modeling
          - Compliance checklist
        outputs:
          - security_requirements.md
          - threat_model.md
      
      - agent: @tester
        tasks:
          - Test strategy
          - Test case design
          - Performance criteria
        outputs:
          - test_plan.md
          - test_cases.yaml

  phase2_implementation:
    duration: 4 hours
    parallel:
      track1_backend:
        agents:
          primary: @developer
          support: [@database, @api]
        tasks:
          - Implement data models
          - Create repositories
          - Build service layer
          - Develop API endpoints
        continuous_validation:
          agent: @tester
          tasks:
            - Unit tests
            - Integration tests
      
      track2_frontend:
        agents:
          primary: @ui
          support: @developer
        tasks:
          - Create components
          - Implement state management
          - Build forms
          - Add validation
        continuous_validation:
          agent: @tester
          tasks:
            - Component tests
            - E2E tests
      
      track3_security:
        agent: @security
        continuous:
          - Monitor for vulnerabilities
          - Validate FIPS compliance
          - Check access controls
          - Review encryption usage

  phase3_integration:
    duration: 1 hour
    sequence:
      - parallel:
          - "@api: Integration testing"
          - "@ui: End-to-end testing"
          - "@performance: Load testing"
      - agent: @security
        task: Final security audit
      - agent: @docs
        task: Generate documentation

  phase4_deployment:
    duration: 30 minutes
    sequence:
      - agent: @devops
        task: Deploy to staging
      - parallel:
          - "@tester: Smoke tests"
          - "@security: Security scan"
          - "@performance: Performance validation"
      - agent: @devops
        task: Deploy to production
```

### Workflow 2: Security Audit Workflow

```yaml
name: Comprehensive Security Audit
trigger: [weekly, on-demand]

execution:
  parallel_scanning:
    static_analysis:
      agent: @security
      tools:
        - SonarQube
        - Fortify
        - Roslyn Analyzers
      tasks:
        - Scan source code
        - Identify vulnerabilities
        - Check OWASP compliance
    
    dependency_scanning:
      agent: @security
      mcp_server: mcp__socket
      tasks:
        - Scan NuGet packages
        - Check for CVEs
        - Validate licenses
    
    infrastructure_scanning:
      agent: @devops
      tasks:
        - Scan Docker images
        - Check K8s configurations
        - Validate network policies
    
    compliance_checking:
      agent: @security
      tasks:
        - FIPS 140-3 validation
        - STIG compliance
        - DoD RMF controls

  analysis_phase:
    agent: @security
    inputs: [static_analysis, dependency_scanning, infrastructure_scanning, compliance_checking]
    tasks:
      - Correlate findings
      - Prioritize vulnerabilities
      - Generate remediation plan
    
  remediation_phase:
    parallel:
      critical_fixes:
        agents: [@developer, @security]
        tasks:
          - Fix critical vulnerabilities
          - Validate fixes
      
      documentation:
        agent: @docs
        tasks:
          - Update security docs
          - Create audit report
      
      testing:
        agent: @tester
        tasks:
          - Security regression tests
          - Penetration testing

  validation_phase:
    agent: @security
    tasks:
      - Re-scan fixed issues
      - Validate compliance
      - Sign-off audit
```

### Workflow 3: Documentation Generation During Development

```yaml
name: Continuous Documentation
description: Generate and maintain documentation during development

setup:
  agents:
    - @docs: Primary documentation
    - @architect: Technical documentation
    - @developer: Code documentation
    - @tester: Test documentation

  continuous_triggers:
    - on: file_change
      filter: "*.cs, *.ts, *.sql"
      action: update_code_docs
    
    - on: api_change
      filter: "Controllers/*.cs"
      action: regenerate_api_docs
    
    - on: schema_change
      filter: "Migrations/*.cs"
      action: update_database_docs

workflows:
  code_documentation:
    trigger: file_save
    parallel:
      - agent: @docs
        task: Extract XML comments
        output: api_reference.md
      
      - agent: @developer
        task: Generate code examples
        output: examples.md
      
      - agent: @architect
        task: Update architecture diagrams
        output: architecture.md

  api_documentation:
    trigger: controller_change
    sequence:
      - agent: @api
        task: Generate OpenAPI spec
      - parallel:
          - agent: @docs
            task: Create usage examples
          - agent: @tester
            task: Generate test scenarios
      - agent: @docs
        task: Compile API documentation
        outputs:
          - api_guide.md
          - postman_collection.json

  database_documentation:
    trigger: migration_added
    parallel:
      - agent: @database
        tasks:
          - Generate ER diagram
          - Document relationships
          - Create data dictionary
      
      - agent: @docs
        tasks:
          - Update schema docs
          - Document changes
      
      - agent: @developer
        tasks:
          - Update repository docs
          - Add migration notes

  compliance_documentation:
    trigger: [security_change, weekly]
    sequence:
      - parallel:
          - agent: @security
            task: Generate compliance matrix
          - agent: @docs
            task: Update security docs
      - agent: @architect
        task: Review and approve
```

### Workflow 4: Database Schema Changes with Impact Analysis

```yaml
name: Database Schema Change Management
description: Analyze and implement database changes safely

phases:
  impact_analysis:
    parallel:
      schema_analysis:
        agent: @database
        tasks:
          - Analyze current schema
          - Identify dependencies
          - Calculate migration complexity
        outputs:
          - dependency_graph.json
          - impact_report.md
      
      code_impact:
        agent: @developer
        mcp_server: mcp__serena
        tasks:
          - Find affected entities
          - Identify repository changes
          - List service impacts
        outputs:
          - affected_code.md
          - required_changes.md
      
      api_impact:
        agent: @api
        tasks:
          - Identify affected endpoints
          - Check contract changes
          - Validate backwards compatibility
        outputs:
          - api_changes.md
          - breaking_changes.md
      
      performance_impact:
        agent: @performance
        tasks:
          - Analyze query performance
          - Estimate migration time
          - Predict system impact
        outputs:
          - performance_analysis.md

  planning:
    agent: @architect
    inputs: [impact_report, affected_code, api_changes, performance_analysis]
    tasks:
      - Review all impacts
      - Create migration plan
      - Design rollback strategy
    outputs:
      - migration_plan.md
      - rollback_plan.md

  implementation:
    sequence:
      - stage: prepare
        parallel:
          - agent: @database
            task: Create migration scripts
          - agent: @developer
            task: Update entity models
          - agent: @tester
            task: Create migration tests
      
      - stage: test
        agent: @tester
        environment: staging
        tasks:
          - Run migration on test data
          - Validate data integrity
          - Performance testing
      
      - stage: execute
        agent: @database
        tasks:
          - Backup production
          - Run migration
          - Validate results
      
      - stage: verify
        parallel:
          - agent: @tester
            task: Run integration tests
          - agent: @performance
            task: Monitor performance
          - agent: @security
            task: Validate security
```

### Workflow 5: API Development with Automatic OpenAPI Generation

```yaml
name: API Development Pipeline
description: Develop APIs with automatic documentation and testing

stages:
  design:
    agent: @architect
    tasks:
      - Design API structure
      - Define resource models
      - Plan endpoints
    outputs:
      - api_design.yaml
      - resource_models.json

  implementation:
    parallel:
      api_development:
        agent: @api
        tasks:
          - Implement controllers
          - Add authorization
          - Input validation
          - Error handling
        continuous:
          - Generate OpenAPI spec
          - Update Postman collection
      
      testing:
        agent: @tester
        tasks:
          - Unit tests for controllers
          - Integration tests
          - Contract tests
          - Security tests
      
      documentation:
        agent: @docs
        inputs: [OpenAPI spec]
        tasks:
          - Generate API reference
          - Create usage examples
          - Write tutorials

  validation:
    parallel:
      - agent: @security
        tasks:
          - Security scan
          - OWASP compliance
          - Authentication testing
      
      - agent: @performance
        tasks:
          - Load testing
          - Response time analysis
          - Rate limit testing
      
      - agent: @api
        tasks:
          - OpenAPI validation
          - Response format checking
          - Version compatibility

code_example:
  controller: |
    // Agent: @api - Auto-generated OpenAPI documentation
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public class AssetsController : ControllerBase
    {
        /// <summary>
        /// Retrieves a paginated list of assets
        /// </summary>
        /// <remarks>
        /// Agent: @docs - Auto-generated from XML comments
        /// </remarks>
        /// <param name="request">Search and pagination parameters</param>
        /// <returns>Paginated list of assets</returns>
        /// <response code="200">Returns the list of assets</response>
        /// <response code="400">Invalid request parameters</response>
        [HttpGet]
        [ProducesResponseType(typeof(PagedResult<AssetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PagedResult<AssetDto>>> GetAssets(
            [FromQuery] AssetSearchRequest request)
        {
            // Implementation
        }
    }

  openapi_generation: |
    // Agent: @api - Automatic OpenAPI generation
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "IAMSNG API",
            Version = "v1",
            Description = "Industrial Asset Management System API",
            Contact = new OpenApiContact
            {
                Name = "Support Team",
                Email = "support@iamsng.mil"
            }
        });
        
        // Agent: @security - Add security definitions
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT"
        });
        
        c.AddSecurityDefinition("CAC", new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.ApiKey,
            In = ParameterLocation.Header,
            Name = "X-Client-Certificate"
        });
    });
```

### Workflow 6: UI Component Creation with Accessibility Testing

```yaml
name: Accessible UI Development
description: Create UI components with WCAG 2.1 compliance

stages:
  design:
    parallel:
      - agent: @ui
        tasks:
          - Design component structure
          - Plan accessibility features
          - Create responsive layout
      
      - agent: @architect
        tasks:
          - Review component architecture
          - Validate design patterns

  implementation:
    agent: @ui
    tasks:
      - Implement Blazor component
      - Add ARIA attributes
      - Keyboard navigation
      - Screen reader support
    
    code_template: |
      // Agent: @ui - Accessible component template
      @page "/assets/list"
      @inherits ComponentBase
      
      <div role="main" aria-labelledby="page-title">
          <h1 id="page-title">Asset Management</h1>
          
          <nav aria-label="Asset filters">
              <div role="search">
                  <label for="search-input">
                      Search assets
                      <span class="sr-only">(Press Enter to search)</span>
                  </label>
                  <input 
                      id="search-input"
                      type="search"
                      @bind="searchTerm"
                      @onkeydown="@(async (e) => { if (e.Key == "Enter") await SearchAsync(); })"
                      aria-describedby="search-help"
                      aria-required="false" />
                  <small id="search-help" class="form-text">
                      Enter asset name, tag, or serial number
                  </small>
              </div>
          </nav>
          
          <section aria-labelledby="results-heading" aria-live="polite">
              <h2 id="results-heading" class="sr-only">Search Results</h2>
              
              @if (loading)
              {
                  <div role="status" aria-live="polite">
                      <span class="spinner" aria-hidden="true"></span>
                      <span>Loading assets...</span>
                  </div>
              }
              else if (assets.Any())
              {
                  <div role="status" class="sr-only">
                      Found @assets.Count() assets
                  </div>
                  
                  <table role="table" aria-label="Asset list">
                      <thead>
                          <tr role="row">
                              <th role="columnheader" scope="col">
                                  <button @onclick="() => Sort('Name')"
                                          aria-label="Sort by name @GetSortLabel('Name')">
                                      Name
                                  </button>
                              </th>
                              <!-- More columns -->
                          </tr>
                      </thead>
                      <tbody>
                          @foreach (var asset in assets)
                          {
                              <tr role="row">
                                  <td role="cell">@asset.Name</td>
                                  <!-- More cells -->
                              </tr>
                          }
                      </tbody>
                  </table>
              }
              else
              {
                  <div role="status">No assets found</div>
              }
          </section>
      </div>

  testing:
    parallel:
      accessibility_testing:
        agent: @tester
        mcp_server: mcp__browser-tools
        tasks:
          - WCAG 2.1 Level AA audit
          - Keyboard navigation testing
          - Screen reader testing
          - Color contrast validation
        
        test_code: |
          // Agent: @tester - Accessibility tests
          [TestMethod]
          public async Task AssetList_MeetsAccessibilityStandards()
          {
              // Navigate to component
              await page.GotoAsync("/assets/list");
              
              // Run accessibility audit
              var auditResult = await browser.RunAccessibilityAudit();
              
              Assert.IsTrue(auditResult.Score >= 95);
              Assert.AreEqual(0, auditResult.Violations
                  .Count(v => v.Impact == "critical"));
              
              // Test keyboard navigation
              await page.Keyboard.PressAsync("Tab");
              var focusedElement = await page.EvaluateAsync<string>(
                  "() => document.activeElement.tagName");
              Assert.IsNotNull(focusedElement);
              
              // Test screen reader announcements
              await page.FillAsync("#search-input", "test");
              await page.Keyboard.PressAsync("Enter");
              
              var announcement = await page.EvaluateAsync<string>(
                  "() => document.querySelector('[aria-live]').textContent");
              Assert.IsTrue(announcement.Contains("Found"));
          }
      
      visual_testing:
        agent: @tester
        mcp_server: mcp__puppeteer
        tasks:
          - Capture baseline screenshots
          - Test responsive design
          - Validate visual regression
      
      performance_testing:
        agent: @performance
        tasks:
          - Component render time
          - Memory usage
          - Bundle size analysis

  validation:
    agent: @ui
    mcp_server: mcp__browser-tools
    final_checks:
      - Run comprehensive audit
      - Generate accessibility report
      - Document WCAG compliance
```

## Conclusion

This comprehensive guide provides the framework for implementing efficient, secure, and compliant agent-based development workflows in the IAMSNG project. By leveraging parallel execution, specialized agents, and integrated MCP servers, development teams can achieve:

- **10x faster development** through parallel agent execution
- **100% security compliance** with automated FIPS 140-3 and DoD validation
- **Continuous quality assurance** with integrated testing at every stage
- **Real-time documentation** that stays synchronized with code
- **Proactive performance optimization** through continuous monitoring

The workflows and patterns described in this guide are designed specifically for the unique requirements of the Industrial Asset Management System, ensuring that all development activities maintain the highest standards of security, performance, and compliance required for DoD systems.

### Next Steps

1. **Implement monitoring dashboards** using the metrics collection framework
2. **Train development teams** on parallel agent workflows
3. **Establish agent pools** for resource optimization
4. **Deploy continuous compliance** validation pipelines
5. **Create project-specific** workflow templates

For questions or additional workflow examples, consult the IAMSNG architecture team or refer to the security compliance documentation at `/docs/SECURITY-COMPLIANCE.md`.