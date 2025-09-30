# Security and Compliance Documentation

## Executive Summary

This document outlines the comprehensive security requirements and compliance standards implemented in the IAMSNG (Industrial Asset Management System) to meet Department of Defense (DoD) security requirements. The system adheres to FIPS 140-3 cryptographic standards, implements defense-in-depth security principles, and maintains continuous compliance with federal security mandates.

## Table of Contents

1. [Security Overview](#security-overview)
2. [FIPS 140-3 Compliance](#fips-140-3-compliance)
3. [DoD Security Standards](#dod-security-standards)
4. [Encryption Requirements](#encryption-requirements)
5. [Authentication and Authorization](#authentication-and-authorization)
6. [Audit and Logging Requirements](#audit-and-logging-requirements)
7. [Data Protection](#data-protection)
8. [Network Security](#network-security)
9. [Application Security](#application-security)
10. [Security Testing and Validation](#security-testing-and-validation)
11. [Incident Response](#incident-response)
12. [Compliance Monitoring](#compliance-monitoring)

## Security Overview

### Security Architecture Principles

The IAMSNG system implements a multi-layered security architecture based on the following core principles:

1. **Defense in Depth**: Multiple layers of security controls at network, host, application, and data levels
2. **Least Privilege**: Users and services operate with minimal required permissions
3. **Zero Trust**: No implicit trust; continuous verification of all interactions
4. **Separation of Duties**: Critical functions require multiple authorized individuals
5. **Fail Secure**: System defaults to secure state upon failure

### Security Framework Alignment

| Framework | Version | Compliance Level | Validation Date |
|-----------|---------|------------------|-----------------|
| NIST Cybersecurity Framework | 2.0 | Full Implementation | Continuous |
| NIST 800-53 | Rev 5 | Moderate Baseline | Annual Assessment |
| DoD RMF | 2.0 | ATO Process | 3-Year Cycle |
| FIPS 140-3 | Level 1 | Validated Cryptography | Per Module Update |

## FIPS 140-3 Compliance

### Overview

Federal Information Processing Standard (FIPS) 140-3 defines security requirements for cryptographic modules protecting sensitive information. IAMSNG implements FIPS-validated cryptographic modules for all security functions.

### Implementation Requirements

#### Cryptographic Module Validation
```csharp
public class CryptographicService
{
    private readonly IConfiguration _configuration;
    
    public CryptographicService(IConfiguration configuration)
    {
        _configuration = configuration;
        ValidateFipsMode();
    }
    
    private void ValidateFipsMode()
    {
        // Check Windows FIPS policy
        using (var key = Registry.LocalMachine.OpenSubKey(
            @"System\CurrentControlSet\Control\Lsa\FipsAlgorithmPolicy"))
        {
            var fipsEnabled = (int)key?.GetValue("Enabled", 0) == 1;
            
            if (!fipsEnabled && _configuration.GetValue<bool>("Security:RequireFips"))
            {
                throw new SecurityException(
                    "FIPS 140-3 mode is required but not enabled on this system.");
            }
        }
        
        // Verify cryptographic provider compliance
        VerifyCryptographicProviders();
    }
    
    private void VerifyCryptographicProviders()
    {
        // Test FIPS-approved algorithms
        var algorithms = new Dictionary<string, Func<bool>>
        {
            ["AES"] = () => TestAlgorithm(() => Aes.Create()),
            ["SHA256"] = () => TestAlgorithm(() => SHA256.Create()),
            ["SHA384"] = () => TestAlgorithm(() => SHA384.Create()),
            ["SHA512"] = () => TestAlgorithm(() => SHA512.Create()),
            ["HMACSHA256"] = () => TestAlgorithm(() => new HMACSHA256()),
            ["RSA"] = () => TestAlgorithm(() => RSA.Create(2048))
        };
        
        foreach (var algorithm in algorithms)
        {
            if (!algorithm.Value())
            {
                throw new SecurityException(
                    $"FIPS-compliant {algorithm.Key} algorithm validation failed.");
            }
        }
    }
    
    private bool TestAlgorithm<T>(Func<T> createAlgorithm) where T : IDisposable
    {
        try
        {
            using (var algorithm = createAlgorithm())
            {
                return algorithm != null;
            }
        }
        catch (CryptographicException)
        {
            return false;
        }
    }
}
```

### Approved Cryptographic Algorithms

| Algorithm Type | Approved Algorithms | Key Size | Usage |
|---------------|-------------------|----------|--------|
| Symmetric Encryption | AES-128, AES-256 | 128/256 bits | Data encryption at rest and in transit |
| Asymmetric Encryption | RSA | 2048+ bits | Key exchange, digital signatures |
| Hash Functions | SHA-256, SHA-384, SHA-512 | N/A | Data integrity, password hashing |
| Message Authentication | HMAC-SHA256 | 256+ bits | API authentication, message integrity |
| Key Derivation | PBKDF2 | N/A | Password-based key derivation |
| Random Number Generation | DRBG (SP 800-90A) | N/A | Cryptographic key generation |

### Non-Compliant Algorithm Mitigation

```csharp
public class SecurityConfiguration
{
    public static void ConfigureCryptography(IServiceCollection services)
    {
        // Disable non-FIPS algorithms
        AppContext.SetSwitch("Switch.System.Security.Cryptography.UseLegacyFipsThrow", false);
        
        // Configure approved algorithms only
        services.Configure<SecurityOptions>(options =>
        {
            options.AllowedHashAlgorithms = new[] { "SHA256", "SHA384", "SHA512" };
            options.AllowedEncryptionAlgorithms = new[] { "AES128", "AES256" };
            options.MinimumRsaKeySize = 2048;
            options.RequireFipsCompliance = true;
        });
        
        // Register FIPS-compliant services
        services.AddSingleton<ICryptographyProvider, FipsCompliantCryptographyProvider>();
        services.AddSingleton<IHashingService, FipsHashingService>();
        services.AddSingleton<IEncryptionService, FipsEncryptionService>();
    }
}
```

## DoD Security Standards

### Defense Information Systems Agency (DISA) Requirements

#### Security Technical Implementation Guides (STIGs)
The system complies with relevant STIGs:

1. **Application Security and Development STIG V5R3**
   - Input validation on all user inputs
   - Output encoding for XSS prevention
   - Parameterized queries for SQL injection prevention
   - Secure session management
   - Error handling without information disclosure

2. **Database STIG (SQL Server 2022)**
   - Audit trail implementation
   - Access control lists
   - Encryption of sensitive data
   - Secure authentication mechanisms

3. **Web Server STIG (IIS 10.0 V2R10)**
   - TLS 1.2+ enforcement
   - Secure headers implementation
   - Directory browsing disabled
   - Custom error pages

### Risk Management Framework (RMF) Implementation

```yaml
RMF Process Steps:
  Step 1 - Categorize:
    System Category: "Moderate"
    Information Types:
      - Industrial Control Data: Moderate
      - Asset Management: Moderate
      - Operational Data: Low
    
  Step 2 - Select:
    Baseline: "NIST 800-53 Moderate"
    Tailoring: "DoD-specific overlays applied"
    
  Step 3 - Implement:
    Controls: "324 controls from Moderate baseline"
    Additional: "28 DoD-specific controls"
    
  Step 4 - Assess:
    Method: "Automated scanning + manual review"
    Frequency: "Continuous monitoring"
    
  Step 5 - Authorize:
    Authority: "Designated Authorizing Official"
    Duration: "3-year ATO"
    
  Step 6 - Monitor:
    Type: "Continuous"
    Tools: "SCAP-compliant scanners"
```

### Common Access Card (CAC) Integration

```csharp
public class CacAuthenticationHandler : AuthenticationHandler<CacAuthenticationOptions>
{
    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        // Retrieve client certificate
        var clientCertificate = await Context.Connection.GetClientCertificateAsync();
        
        if (clientCertificate == null)
        {
            return AuthenticateResult.Fail("No client certificate provided");
        }
        
        // Validate DoD PKI certificate
        var validationResult = ValidateDodCertificate(clientCertificate);
        
        if (!validationResult.IsValid)
        {
            Logger.LogWarning($"Certificate validation failed: {validationResult.Error}");
            return AuthenticateResult.Fail(validationResult.Error);
        }
        
        // Extract user information from certificate
        var claims = ExtractCacClaims(clientCertificate);
        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        
        // Log successful authentication
        await LogAuthenticationEvent(principal, clientCertificate);
        
        return AuthenticateResult.Success(new AuthenticationTicket(principal, Scheme.Name));
    }
    
    private CertificateValidationResult ValidateDodCertificate(X509Certificate2 certificate)
    {
        var chain = new X509Chain
        {
            ChainPolicy = new X509ChainPolicy
            {
                RevocationMode = X509RevocationMode.Online,
                RevocationFlag = X509RevocationFlag.EntireChain,
                UrlRetrievalTimeout = TimeSpan.FromSeconds(30),
                VerificationTime = DateTime.Now
            }
        };
        
        // Add DoD root certificates
        chain.ChainPolicy.ExtraStore.AddRange(GetDodRootCertificates());
        
        var isValid = chain.Build(certificate);
        
        return new CertificateValidationResult
        {
            IsValid = isValid,
            Error = isValid ? null : GetChainErrors(chain)
        };
    }
}
```

## Encryption Requirements

### Data Encryption Standards

#### Encryption at Rest
```csharp
public class DataEncryptionService
{
    private readonly byte[] _masterKey;
    private readonly IKeyManagementService _keyService;
    
    public async Task<byte[]> EncryptDataAsync(byte[] plaintext, string context)
    {
        // Generate unique key for this context
        var dataKey = await _keyService.GenerateDataKeyAsync(context);
        
        using (var aes = Aes.Create())
        {
            aes.Mode = CipherMode.GCM; // FIPS-approved mode
            aes.KeySize = 256;
            aes.Key = dataKey.PlaintextKey;
            
            var iv = new byte[aes.BlockSize / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(iv);
            }
            aes.IV = iv;
            
            using (var encryptor = aes.CreateEncryptor())
            using (var msEncrypt = new MemoryStream())
            {
                // Write IV to beginning of stream
                await msEncrypt.WriteAsync(iv, 0, iv.Length);
                
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    await csEncrypt.WriteAsync(plaintext, 0, plaintext.Length);
                }
                
                var encrypted = msEncrypt.ToArray();
                
                // Store encrypted data key with ciphertext
                return CombineWithEncryptedKey(encrypted, dataKey.EncryptedKey);
            }
        }
    }
}
```

#### Encryption in Transit

##### TLS Configuration
```csharp
public class TlsConfiguration
{
    public static void ConfigureKestrel(IWebHostBuilder webHostBuilder)
    {
        webHostBuilder.ConfigureKestrel((context, options) =>
        {
            options.ConfigureHttpsDefaults(httpsOptions =>
            {
                // Enforce TLS 1.2 minimum (TLS 1.3 preferred)
                httpsOptions.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls13;
                
                // Configure cipher suites (FIPS-approved only)
                httpsOptions.OnAuthenticate = (context, sslOptions) =>
                {
                    sslOptions.CipherSuitesPolicy = new CipherSuitesPolicy(
                        new[]
                        {
                            TlsCipherSuite.TLS_AES_256_GCM_SHA384,        // TLS 1.3
                            TlsCipherSuite.TLS_AES_128_GCM_SHA256,        // TLS 1.3
                            TlsCipherSuite.TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,  // TLS 1.2
                            TlsCipherSuite.TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256   // TLS 1.2
                        });
                };
                
                // Certificate validation
                httpsOptions.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
                httpsOptions.CheckCertificateRevocation = true;
            });
        });
    }
}
```

### Key Management

#### Key Hierarchy
```plaintext
Master Key (Hardware Security Module)
    ├── Key Encryption Keys (KEK)
    │   ├── Database Encryption Key
    │   ├── Application Encryption Key
    │   └── Backup Encryption Key
    └── Data Encryption Keys (DEK)
        ├── PII Encryption Key
        ├── Document Encryption Key
        └── Session Encryption Key
```

#### Key Rotation Policy
```csharp
public class KeyRotationService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var keysToRotate = await _keyRepository.GetKeysRequiringRotationAsync();
            
            foreach (var key in keysToRotate)
            {
                try
                {
                    // Generate new key version
                    var newKey = await _keyGenerator.GenerateKeyAsync(key.Algorithm, key.KeySize);
                    
                    // Re-encrypt data with new key
                    await ReencryptDataAsync(key, newKey);
                    
                    // Archive old key (for decryption only)
                    await _keyRepository.ArchiveKeyAsync(key);
                    
                    // Activate new key
                    await _keyRepository.ActivateKeyAsync(newKey);
                    
                    _logger.LogInformation($"Successfully rotated key {key.KeyId}");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Failed to rotate key {key.KeyId}");
                    await _alertService.SendKeyRotationFailureAlertAsync(key, ex);
                }
            }
            
            // Check daily
            await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
        }
    }
}
```

## Authentication and Authorization

### Multi-Factor Authentication (MFA)

```csharp
public class MfaService
{
    public async Task<MfaChallenge> InitiateMfaAsync(string userId, MfaMethod method)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        
        switch (method)
        {
            case MfaMethod.Totp:
                return await GenerateTotpChallengeAsync(user);
                
            case MfaMethod.Sms:
                return await SendSmsChallengeAsync(user);
                
            case MfaMethod.Email:
                return await SendEmailChallengeAsync(user);
                
            case MfaMethod.HardwareToken:
                return await ValidateHardwareTokenAsync(user);
                
            case MfaMethod.Biometric:
                return await InitiateBiometricChallengeAsync(user);
                
            default:
                throw new NotSupportedException($"MFA method {method} not supported");
        }
    }
    
    private async Task<MfaChallenge> GenerateTotpChallengeAsync(User user)
    {
        var secret = user.TotpSecret ?? GenerateTotpSecret();
        var code = GenerateTotpCode(secret);
        
        return new MfaChallenge
        {
            ChallengeId = Guid.NewGuid().ToString(),
            Method = MfaMethod.Totp,
            ExpiresAt = DateTime.UtcNow.AddSeconds(30),
            Data = new { QrCode = GenerateQrCode(user.Email, secret) }
        };
    }
}
```

### Role-Based Access Control (RBAC)

```csharp
public class RbacConfiguration
{
    public static void ConfigureAuthorization(IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            // System roles
            options.AddPolicy("SystemAdministrator", policy =>
                policy.RequireRole("SYSTEM_ADMIN")
                      .RequireClaim("SecurityClearance", "SECRET", "TOP_SECRET"));
            
            options.AddPolicy("SecurityOfficer", policy =>
                policy.RequireRole("SECURITY_OFFICER")
                      .RequireClaim("SecurityClearance", "SECRET", "TOP_SECRET"));
            
            options.AddPolicy("Auditor", policy =>
                policy.RequireRole("AUDITOR")
                      .RequireClaim("SecurityClearance", "SECRET", "TOP_SECRET"));
            
            // Operational roles
            options.AddPolicy("AssetManager", policy =>
                policy.RequireRole("ASSET_MANAGER", "SYSTEM_ADMIN"));
            
            options.AddPolicy("Operator", policy =>
                policy.RequireRole("OPERATOR", "ASSET_MANAGER", "SYSTEM_ADMIN"));
            
            options.AddPolicy("ReadOnly", policy =>
                policy.RequireRole("VIEWER", "OPERATOR", "ASSET_MANAGER", "AUDITOR", "SYSTEM_ADMIN"));
            
            // Attribute-based policies
            options.AddPolicy("DataClassification", policy =>
                policy.Requirements.Add(new DataClassificationRequirement()));
            
            options.AddPolicy("TimeOfDay", policy =>
                policy.Requirements.Add(new TimeOfDayRequirement(8, 18))); // 8 AM - 6 PM
        });
    }
}

public class DataClassificationRequirement : IAuthorizationRequirement
{
    public async Task<bool> HandleRequirementAsync(
        AuthorizationHandlerContext context,
        DataClassificationRequirement requirement)
    {
        var resource = context.Resource as DataResource;
        var userClearance = context.User.FindFirst("SecurityClearance")?.Value;
        
        return resource?.Classification switch
        {
            "UNCLASSIFIED" => true,
            "CONFIDENTIAL" => IsAuthorized(userClearance, "CONFIDENTIAL"),
            "SECRET" => IsAuthorized(userClearance, "SECRET"),
            "TOP_SECRET" => IsAuthorized(userClearance, "TOP_SECRET"),
            _ => false
        };
    }
}
```

### Attribute-Based Access Control (ABAC)

```csharp
public class AbacPolicyEngine
{
    private readonly List<PolicyRule> _rules = new();
    
    public AbacPolicyEngine()
    {
        InitializePolicyRules();
    }
    
    private void InitializePolicyRules()
    {
        // Define policy rules
        _rules.Add(new PolicyRule
        {
            Id = "RULE_001",
            Description = "Access to classified data requires appropriate clearance",
            Condition = (subject, resource, action, environment) =>
            {
                var clearanceLevel = subject.GetAttribute<string>("ClearanceLevel");
                var classification = resource.GetAttribute<string>("Classification");
                
                return CompareClassification(clearanceLevel, classification) >= 0;
            }
        });
        
        _rules.Add(new PolicyRule
        {
            Id = "RULE_002",
            Description = "Write operations require explicit write permission",
            Condition = (subject, resource, action, environment) =>
            {
                if (action.Name.Contains("Write") || action.Name.Contains("Update"))
                {
                    return subject.HasPermission($"{resource.Type}.Write");
                }
                return true;
            }
        });
        
        _rules.Add(new PolicyRule
        {
            Id = "RULE_003",
            Description = "Sensitive operations require MFA",
            Condition = (subject, resource, action, environment) =>
            {
                if (resource.GetAttribute<bool>("RequiresMfa") || 
                    action.GetAttribute<bool>("RequiresMfa"))
                {
                    return subject.GetAttribute<bool>("MfaVerified");
                }
                return true;
            }
        });
    }
    
    public AuthorizationDecision Evaluate(
        Subject subject,
        Resource resource,
        Action action,
        Environment environment)
    {
        var decision = new AuthorizationDecision();
        
        foreach (var rule in _rules)
        {
            var result = rule.Evaluate(subject, resource, action, environment);
            
            if (result == PolicyResult.Deny)
            {
                decision.Decision = AuthorizationResult.Deny;
                decision.DeniedByRule = rule.Id;
                decision.Reason = rule.Description;
                break;
            }
            
            if (result == PolicyResult.Permit)
            {
                decision.AppliedRules.Add(rule.Id);
            }
        }
        
        if (decision.Decision != AuthorizationResult.Deny)
        {
            decision.Decision = decision.AppliedRules.Any() 
                ? AuthorizationResult.Permit 
                : AuthorizationResult.NotApplicable;
        }
        
        // Audit authorization decision
        AuditAuthorizationDecision(subject, resource, action, decision);
        
        return decision;
    }
}
```

## Audit and Logging Requirements

### Audit Event Categories

| Category | Events | Retention | Protection |
|----------|--------|-----------|------------|
| Authentication | Login, Logout, Failed attempts, MFA events | 7 years | Encrypted, Tamper-proof |
| Authorization | Access granted/denied, Privilege changes | 7 years | Encrypted, Tamper-proof |
| Data Access | Read, Write, Delete operations on sensitive data | 7 years | Encrypted, Tamper-proof |
| Administrative | Configuration changes, User management | 7 years | Encrypted, Tamper-proof |
| Security | Security violations, Policy changes | 7 years | Encrypted, Tamper-proof |
| System | Service start/stop, Errors, Performance | 1 year | Encrypted |

### Audit Implementation

```csharp
public class AuditService : IAuditService
{
    private readonly ILogger<AuditService> _logger;
    private readonly IAuditRepository _repository;
    private readonly IEncryptionService _encryptionService;
    private readonly IHashingService _hashingService;
    
    public async Task LogAuditEventAsync(AuditEvent auditEvent)
    {
        // Ensure all required fields are present
        ValidateAuditEvent(auditEvent);
        
        // Add system context
        auditEvent.ServerName = Environment.MachineName;
        auditEvent.ProcessId = Process.GetCurrentProcess().Id;
        auditEvent.ThreadId = Thread.CurrentThread.ManagedThreadId;
        
        // Calculate hash for tamper detection
        auditEvent.Hash = CalculateEventHash(auditEvent);
        
        // Encrypt sensitive data
        if (auditEvent.SensitiveData != null)
        {
            auditEvent.EncryptedData = await _encryptionService.EncryptAsync(
                JsonSerializer.Serialize(auditEvent.SensitiveData));
            auditEvent.SensitiveData = null; // Clear unencrypted data
        }
        
        // Store in multiple locations for redundancy
        var tasks = new[]
        {
            _repository.SaveAsync(auditEvent),
            ForwardToSiemAsync(auditEvent),
            WriteToSecureLogAsync(auditEvent)
        };
        
        await Task.WhenAll(tasks);
        
        // Alert on critical events
        if (auditEvent.Severity == EventSeverity.Critical)
        {
            await _alertService.SendCriticalEventAlertAsync(auditEvent);
        }
    }
    
    private string CalculateEventHash(AuditEvent auditEvent)
    {
        var data = $"{auditEvent.EventId}|{auditEvent.Timestamp:O}|{auditEvent.EventType}|" +
                   $"{auditEvent.UserId}|{auditEvent.Action}|{auditEvent.ResourceId}|" +
                   $"{auditEvent.Result}|{auditEvent.IPAddress}";
        
        return _hashingService.ComputeHash(data);
    }
    
    private async Task ForwardToSiemAsync(AuditEvent auditEvent)
    {
        var syslogMessage = FormatAsSyslog(auditEvent);
        await _siemClient.SendAsync(syslogMessage);
    }
    
    private string FormatAsSyslog(AuditEvent auditEvent)
    {
        // Format as RFC 5424 syslog message
        var priority = CalculatePriority(auditEvent.Severity);
        var timestamp = auditEvent.Timestamp.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK");
        
        return $"<{priority}>1 {timestamp} {auditEvent.ServerName} IAMSNG " +
               $"{auditEvent.ProcessId} {auditEvent.EventId} " +
               $"[audit@32473 type=\"{auditEvent.EventType}\" " +
               $"user=\"{auditEvent.UserId}\" " +
               $"action=\"{auditEvent.Action}\" " +
               $"result=\"{auditEvent.Result}\"] " +
               $"{auditEvent.Message}";
    }
}
```

### Log Protection and Integrity

```csharp
public class SecureLogWriter
{
    private readonly string _logPath;
    private readonly IEncryptionService _encryptionService;
    private readonly object _lockObject = new object();
    
    public async Task WriteLogAsync(LogEntry entry)
    {
        // Create tamper-evident log entry
        var logData = new TamperEvidentLog
        {
            SequenceNumber = GetNextSequenceNumber(),
            Timestamp = DateTime.UtcNow,
            Entry = entry,
            PreviousHash = await GetPreviousHashAsync()
        };
        
        // Calculate hash including previous hash (blockchain-style)
        logData.Hash = CalculateHash(logData);
        
        // Sign the log entry
        logData.Signature = await SignLogEntryAsync(logData);
        
        // Encrypt the log entry
        var encryptedLog = await _encryptionService.EncryptAsync(
            JsonSerializer.Serialize(logData));
        
        // Write to append-only log file
        lock (_lockObject)
        {
            using (var stream = new FileStream(_logPath, 
                FileMode.Append, 
                FileAccess.Write, 
                FileShare.Read,
                4096,
                FileOptions.WriteThrough | FileOptions.SequentialScan))
            {
                stream.Write(encryptedLog, 0, encryptedLog.Length);
                stream.Flush(true); // Force write to disk
            }
        }
        
        // Update hash chain
        await UpdateHashChainAsync(logData.Hash);
    }
}
```

## Data Protection

### Data Classification

```csharp
public enum DataClassification
{
    [Description("Public release authorized")]
    Unclassified = 0,
    
    [Description("For official use only")]
    ControlledUnclassified = 1,
    
    [Description("Unauthorized disclosure could cause damage")]
    Confidential = 2,
    
    [Description("Unauthorized disclosure could cause serious damage")]
    Secret = 3,
    
    [Description("Unauthorized disclosure could cause exceptionally grave damage")]
    TopSecret = 4
}

public class DataClassificationService
{
    public DataClassification ClassifyData(object data)
    {
        // Automatic classification based on content
        var classifiers = new List<IDataClassifier>
        {
            new PiiClassifier(),
            new FinancialDataClassifier(),
            new OperationalDataClassifier(),
            new TechnicalDataClassifier()
        };
        
        var highestClassification = DataClassification.Unclassified;
        
        foreach (var classifier in classifiers)
        {
            var classification = classifier.Classify(data);
            if (classification > highestClassification)
            {
                highestClassification = classification;
            }
        }
        
        return highestClassification;
    }
}
```

### Data Loss Prevention (DLP)

```csharp
public class DlpService
{
    private readonly List<DlpRule> _rules = new();
    
    public async Task<DlpDecision> EvaluateDataTransferAsync(
        DataTransferRequest request)
    {
        var decision = new DlpDecision { Allow = true };
        
        foreach (var rule in _rules)
        {
            var result = await rule.EvaluateAsync(request);
            
            if (result.Block)
            {
                decision.Allow = false;
                decision.BlockedByRule = rule.Id;
                decision.Reason = result.Reason;
                
                await LogDlpViolationAsync(request, rule, result);
                break;
            }
            
            if (result.Warn)
            {
                decision.Warnings.Add(new DlpWarning
                {
                    RuleId = rule.Id,
                    Message = result.WarningMessage
                });
            }
        }
        
        return decision;
    }
}
```

## Network Security

### Network Segmentation

```yaml
Network Zones:
  DMZ:
    Purpose: "Public-facing services"
    VLAN: 100
    Subnet: "10.0.100.0/24"
    Firewall Rules:
      - Allow: "HTTPS (443) from Internet"
      - Allow: "HTTP (80) from Internet -> Redirect to HTTPS"
      - Deny: "All other inbound"
    
  Application:
    Purpose: "Application servers"
    VLAN: 200
    Subnet: "10.0.200.0/24"
    Firewall Rules:
      - Allow: "HTTPS from DMZ"
      - Allow: "SQL (1433) to Database Zone"
      - Deny: "Direct Internet access"
    
  Database:
    Purpose: "Database servers"
    VLAN: 300
    Subnet: "10.0.300.0/24"
    Firewall Rules:
      - Allow: "SQL (1433) from Application Zone"
      - Deny: "All Internet access"
    
  Management:
    Purpose: "Administrative access"
    VLAN: 400
    Subnet: "10.0.400.0/24"
    Firewall Rules:
      - Allow: "RDP/SSH from Jump Server"
      - Allow: "SNMP to all zones"
      - Require: "MFA for all connections"
```

### Intrusion Detection and Prevention

```csharp
public class IntrusionDetectionService
{
    private readonly Dictionary<string, AttackPattern> _attackPatterns;
    private readonly CircuitBreaker _circuitBreaker;
    
    public async Task<ThreatDetectionResult> AnalyzeRequestAsync(HttpContext context)
    {
        var result = new ThreatDetectionResult();
        
        // Check for common attack patterns
        var checks = new[]
        {
            CheckSqlInjection(context),
            CheckXssAttack(context),
            CheckPathTraversal(context),
            CheckCommandInjection(context),
            CheckDdosPattern(context),
            CheckBruteForce(context)
        };
        
        await Task.WhenAll(checks);
        
        foreach (var check in checks)
        {
            if (check.Result.ThreatDetected)
            {
                result.Threats.Add(check.Result);
                
                // Take defensive action
                if (check.Result.Severity >= ThreatSeverity.High)
                {
                    await BlockSourceAsync(context.Connection.RemoteIpAddress);
                    await AlertSecurityTeamAsync(check.Result);
                }
            }
        }
        
        return result;
    }
}
```

## Application Security

### Input Validation

```csharp
public class InputValidationService
{
    public ValidationResult ValidateInput<T>(T input) where T : class
    {
        var context = new ValidationContext(input);
        var results = new List<ValidationResult>();
        
        // Data annotations validation
        if (!Validator.TryValidateObject(input, context, results, true))
        {
            return new ValidationResult
            {
                IsValid = false,
                Errors = results.Select(r => r.ErrorMessage).ToList()
            };
        }
        
        // Custom security validation
        var securityResults = PerformSecurityValidation(input);
        if (!securityResults.IsValid)
        {
            return securityResults;
        }
        
        // Business rules validation
        var businessResults = PerformBusinessValidation(input);
        
        return businessResults;
    }
    
    private ValidationResult PerformSecurityValidation<T>(T input)
    {
        var properties = typeof(T).GetProperties();
        var errors = new List<string>();
        
        foreach (var property in properties)
        {
            var value = property.GetValue(input)?.ToString();
            if (string.IsNullOrEmpty(value)) continue;
            
            // Check for SQL injection patterns
            if (ContainsSqlInjectionPattern(value))
            {
                errors.Add($"{property.Name} contains potentially malicious SQL");
            }
            
            // Check for XSS patterns
            if (ContainsXssPattern(value))
            {
                errors.Add($"{property.Name} contains potentially malicious scripts");
            }
            
            // Check for path traversal
            if (ContainsPathTraversal(value))
            {
                errors.Add($"{property.Name} contains path traversal attempt");
            }
            
            // Check for command injection
            if (ContainsCommandInjection(value))
            {
                errors.Add($"{property.Name} contains command injection attempt");
            }
        }
        
        return new ValidationResult
        {
            IsValid = !errors.Any(),
            Errors = errors
        };
    }
}
```

### Secure Coding Practices

```csharp
// Secure data access layer example
public class SecureRepository<T> : IRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;
    private readonly IAuthorizationService _authorizationService;
    private readonly IAuditService _auditService;
    
    public async Task<T> GetByIdAsync(int id, ClaimsPrincipal user)
    {
        // Input validation
        if (id <= 0)
        {
            throw new ArgumentException("Invalid ID", nameof(id));
        }
        
        // Get entity
        var entity = await _context.Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id == id);
        
        if (entity == null)
        {
            return null;
        }
        
        // Authorization check
        var authResult = await _authorizationService.AuthorizeAsync(
            user, entity, "Read");
        
        if (!authResult.Succeeded)
        {
            await _auditService.LogUnauthorizedAccessAsync(user, entity);
            throw new UnauthorizedAccessException();
        }
        
        // Audit successful access
        await _auditService.LogDataAccessAsync(user, entity, "Read");
        
        return entity;
    }
    
    public async Task<T> CreateAsync(T entity, ClaimsPrincipal user)
    {
        // Validate entity
        ValidateEntity(entity);
        
        // Authorization check
        var authResult = await _authorizationService.AuthorizeAsync(
            user, entity, "Create");
        
        if (!authResult.Succeeded)
        {
            throw new UnauthorizedAccessException();
        }
        
        // Set audit fields
        entity.CreatedBy = user.Identity.Name;
        entity.CreatedAt = DateTime.UtcNow;
        
        // Begin transaction for consistency
        using var transaction = await _context.Database.BeginTransactionAsync();
        
        try
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            
            // Audit the creation
            await _auditService.LogDataModificationAsync(
                user, entity, "Create", null, entity);
            
            await transaction.CommitAsync();
            
            return entity;
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            await _auditService.LogErrorAsync(user, ex);
            throw;
        }
    }
}
```

## Security Testing and Validation

### Static Application Security Testing (SAST)

```yaml
SAST Configuration:
  Tools:
    - Name: "SonarQube"
      Rules: "OWASP Top 10 + CWE Top 25"
      Schedule: "Every commit"
      
    - Name: "Fortify Static Code Analyzer"
      Rules: "DoD Application Security"
      Schedule: "Nightly"
      
    - Name: "Roslyn Security Analyzers"
      Integration: "IDE + Build"
      RuleSet: "Microsoft Security Rules"
  
  Quality Gates:
    - No Critical vulnerabilities
    - No High vulnerabilities in new code
    - Security hotspot review completed
    - Code coverage > 80%
```

### Dynamic Application Security Testing (DAST)

```csharp
[TestClass]
public class SecurityTests
{
    [TestMethod]
    public async Task TestSqlInjectionProtection()
    {
        // Arrange
        var attackVectors = new[]
        {
            "'; DROP TABLE Users; --",
            "1' OR '1'='1",
            "admin'--",
            "' UNION SELECT * FROM Users--"
        };
        
        foreach (var vector in attackVectors)
        {
            // Act
            var response = await _client.PostAsync("/api/search", 
                new StringContent($"{{\"query\":\"{vector}\"}}"));
            
            // Assert
            Assert.AreNotEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsFalse(response.Content.ReadAsStringAsync().Result
                .Contains("syntax error"));
        }
    }
    
    [TestMethod]
    public async Task TestXssProtection()
    {
        // Arrange
        var xssVectors = new[]
        {
            "<script>alert('XSS')</script>",
            "<img src=x onerror=alert('XSS')>",
            "javascript:alert('XSS')",
            "<body onload=alert('XSS')>"
        };
        
        foreach (var vector in xssVectors)
        {
            // Act
            var response = await _client.PostAsync("/api/comment",
                new StringContent($"{{\"text\":\"{vector}\"}}"));
            
            var content = await response.Content.ReadAsStringAsync();
            
            // Assert
            Assert.IsFalse(content.Contains(vector));
            Assert.IsTrue(content.Contains(HttpUtility.HtmlEncode(vector)));
        }
    }
}
```

### Penetration Testing

```yaml
Penetration Testing Schedule:
  Quarterly:
    Type: "Automated Scanning"
    Tools:
      - OWASP ZAP
      - Burp Suite Professional
      - Nessus
    Coverage:
      - Web Application
      - API Endpoints
      - Network Services
  
  Annually:
    Type: "Manual Penetration Test"
    Performed By: "Certified Third Party"
    Scope:
      - Application Security
      - Network Security
      - Social Engineering
      - Physical Security
    
  Continuous:
    Type: "Bug Bounty Program"
    Platform: "DoD VDP"
    Scope: "Production Systems"
```

## Incident Response

### Incident Response Plan

```yaml
Incident Response Phases:
  1. Preparation:
    - Incident Response Team established
    - Communication channels defined
    - Tools and resources prepared
    - Training completed
  
  2. Detection and Analysis:
    - Monitoring systems active
    - Alert correlation
    - Incident classification
    - Impact assessment
  
  3. Containment:
    - Short-term containment
    - System isolation
    - Evidence preservation
    - Long-term containment
  
  4. Eradication:
    - Malware removal
    - Vulnerability patching
    - System hardening
    - Root cause analysis
  
  5. Recovery:
    - System restoration
    - Monitoring intensification
    - Verification testing
    - Return to operations
  
  6. Lessons Learned:
    - Incident documentation
    - Process improvement
    - Training updates
    - Policy updates
```

### Incident Detection and Response Implementation

```csharp
public class IncidentResponseService
{
    public async Task<IncidentResponse> HandleSecurityIncidentAsync(
        SecurityIncident incident)
    {
        var response = new IncidentResponse
        {
            IncidentId = Guid.NewGuid(),
            DetectedAt = DateTime.UtcNow,
            Severity = DetermineIncidentSeverity(incident)
        };
        
        // Phase 1: Initial Response
        await IsolateAffectedSystemsAsync(incident);
        await PreserveEvidenceAsync(incident);
        
        // Phase 2: Investigation
        var investigation = await InvestigateIncidentAsync(incident);
        response.RootCause = investigation.RootCause;
        response.AffectedSystems = investigation.AffectedSystems;
        
        // Phase 3: Containment
        await ContainThreatAsync(incident, investigation);
        
        // Phase 4: Eradication
        await EradicateThreatAsync(incident, investigation);
        
        // Phase 5: Recovery
        await RecoverSystemsAsync(incident.AffectedSystems);
        
        // Phase 6: Documentation
        await DocumentIncidentAsync(response);
        
        // Notification
        await NotifyStakeholdersAsync(response);
        
        return response;
    }
}
```

## Compliance Monitoring

### Continuous Compliance Monitoring

```csharp
public class ComplianceMonitoringService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var complianceChecks = new[]
            {
                CheckFipsCompliance(),
                CheckTlsConfiguration(),
                CheckPasswordPolicies(),
                CheckAuditingConfiguration(),
                CheckEncryptionStatus(),
                CheckAccessControls(),
                CheckPatchCompliance(),
                CheckConfigurationBaseline()
            };
            
            var results = await Task.WhenAll(complianceChecks);
            
            var report = new ComplianceReport
            {
                Timestamp = DateTime.UtcNow,
                Results = results.ToList(),
                OverallCompliance = CalculateOverallCompliance(results)
            };
            
            await SaveComplianceReportAsync(report);
            
            if (report.OverallCompliance < 95)
            {
                await AlertComplianceTeamAsync(report);
            }
            
            // Run every 6 hours
            await Task.Delay(TimeSpan.FromHours(6), stoppingToken);
        }
    }
}
```

### Security Metrics and KPIs

```yaml
Security Metrics:
  Vulnerability Management:
    - Mean Time to Detect (MTTD): < 24 hours
    - Mean Time to Respond (MTTR): < 72 hours
    - Critical Vulnerability Remediation: < 30 days
    - High Vulnerability Remediation: < 90 days
  
  Access Control:
    - Failed Authentication Rate: < 5%
    - Account Lockout Rate: < 1%
    - Privileged Account Usage: Monitored 100%
    - MFA Adoption: > 95%
  
  Incident Response:
    - Incident Detection Rate: > 95%
    - False Positive Rate: < 10%
    - Incident Containment Time: < 4 hours
    - Full Recovery Time: < 24 hours
  
  Compliance:
    - FIPS Compliance: 100%
    - Audit Log Availability: 99.99%
    - Security Training Completion: > 95%
    - Security Assessment Pass Rate: > 90%
```

## Security Controls Summary

| Control Family | Controls Implemented | Compliance Status |
|----------------|---------------------|-------------------|
| Access Control (AC) | 25 | Fully Compliant |
| Audit and Accountability (AU) | 16 | Fully Compliant |
| Security Assessment (CA) | 9 | Fully Compliant |
| Configuration Management (CM) | 11 | Fully Compliant |
| Contingency Planning (CP) | 13 | In Progress |
| Identification and Authentication (IA) | 11 | Fully Compliant |
| Incident Response (IR) | 10 | Fully Compliant |
| Maintenance (MA) | 6 | Fully Compliant |
| Media Protection (MP) | 8 | Fully Compliant |
| Physical Protection (PE) | N/A | Cloud Provider |
| Planning (PL) | 9 | Fully Compliant |
| Personnel Security (PS) | 8 | Fully Compliant |
| Risk Assessment (RA) | 6 | Fully Compliant |
| System and Services Acquisition (SA) | 22 | Fully Compliant |
| System and Communications Protection (SC) | 44 | Fully Compliant |
| System and Information Integrity (SI) | 17 | Fully Compliant |

## Appendices

### Appendix A: Cryptographic Algorithm Specifications
- FIPS 140-3 Approved Algorithm List
- Key Length Requirements
- Algorithm Deprecation Schedule

### Appendix B: Security Configuration Baselines
- Operating System Hardening
- Database Security Settings
- Application Security Configuration

### Appendix C: Incident Response Procedures
- Contact Information
- Escalation Procedures
- Evidence Collection Guidelines

### Appendix D: Compliance Checklists
- Daily Security Checks
- Weekly Audit Reviews
- Monthly Compliance Assessments
- Annual Security Audits