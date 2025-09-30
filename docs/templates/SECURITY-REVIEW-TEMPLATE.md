# Security Review: [FEATURE/COMPONENT_NAME]

> Review ID: SEC-[YYYY-MM-DD]-[NUMBER]  
> Date: [DATE]  
> Session: [SESSION_ID]  
> Reviewer: [Agent/Security Officer]  
> Classification: [UNCLASSIFIED/CUI/SECRET]  
> FIPS 140-3 Status: [COMPLIANT/NON-COMPLIANT/PENDING]

---

## Executive Summary

**Component**: [Name and version]  
**Risk Level**: [LOW/MEDIUM/HIGH/CRITICAL]  
**Compliance Status**: [PASS/FAIL/CONDITIONAL]  
**Recommendation**: [APPROVE/REJECT/APPROVE_WITH_CONDITIONS]  
**Required Actions**: [Number] critical, [Number] high, [Number] medium, [Number] low

---

## Scope of Review

### Components Reviewed
- [ ] Source code
- [ ] Configuration files
- [ ] Database schema
- [ ] API endpoints
- [ ] Authentication mechanisms
- [ ] Authorization logic
- [ ] Cryptographic implementations
- [ ] Third-party dependencies
- [ ] Network communications
- [ ] Logging and monitoring

### Review Methodology
- **Static Analysis Tools**: [Tools used]
- **Dynamic Testing**: [Methods applied]
- **Manual Code Review**: [Areas covered]
- **Penetration Testing**: [Scope and tools]

---

## Compliance Assessment

### FIPS 140-3 Compliance

| Requirement | Status | Evidence | Notes |
|-------------|--------|----------|-------|
| Approved algorithms only | [✅/🔴/🟡] | [Location] | [Details] |
| Proper key management | [✅/🔴/🟡] | [Location] | [Details] |
| Secure random generation | [✅/🔴/🟡] | [Location] | [Details] |
| Certificate validation | [✅/🔴/🟡] | [Location] | [Details] |
| TLS 1.2+ enforcement | [✅/🔴/🟡] | [Location] | [Details] |

### DoD Security Requirements

| STIG ID | Requirement | Status | Implementation |
|---------|-------------|--------|----------------|
| [ID] | [Description] | [✅/🔴/🟡] | [How implemented] |

### NIST 800-53 Controls

| Control | Family | Implementation | Status |
|---------|--------|----------------|--------|
| AC-2 | Access Control | [Description] | [✅/🔴/🟡] |
| AU-2 | Audit | [Description] | [✅/🔴/🟡] |
| IA-2 | Authentication | [Description] | [✅/🔴/🟡] |
| SC-8 | System Protection | [Description] | [✅/🔴/🟡] |

---

## Vulnerability Assessment

### Critical Findings (Must Fix)

#### Finding #1: [Title]
- **Severity**: CRITICAL
- **CVSS Score**: [0-10]
- **Location**: `[file:line]`
- **Description**: [Detailed description]
- **Impact**: [Business/Security impact]
- **Recommendation**: [Specific fix]
- **Code Example**:
```csharp
// Vulnerable code
[show vulnerable code]

// Recommended fix
[show fixed code]
```

### High Risk Findings

[List each finding with same structure as above]

### Medium Risk Findings

[List findings]

### Low Risk Findings

[List findings]

### Informational Findings

[List findings]

---

## OWASP Top 10 Assessment

| Risk | Category | Status | Findings | Mitigation |
|------|----------|--------|----------|------------|
| A01 | Broken Access Control | [✅/🔴/🟡] | [Details] | [Actions] |
| A02 | Cryptographic Failures | [✅/🔴/🟡] | [Details] | [Actions] |
| A03 | Injection | [✅/🔴/🟡] | [Details] | [Actions] |
| A04 | Insecure Design | [✅/🔴/🟡] | [Details] | [Actions] |
| A05 | Security Misconfiguration | [✅/🔴/🟡] | [Details] | [Actions] |
| A06 | Vulnerable Components | [✅/🔴/🟡] | [Details] | [Actions] |
| A07 | Authentication Failures | [✅/🔴/🟡] | [Details] | [Actions] |
| A08 | Data Integrity Failures | [✅/🔴/🟡] | [Details] | [Actions] |
| A09 | Logging Failures | [✅/🔴/🟡] | [Details] | [Actions] |
| A10 | SSRF | [✅/🔴/🟡] | [Details] | [Actions] |

---

## Authentication & Authorization

### Authentication Mechanisms
- **Method**: [CAC/JWT/Certificate/MFA]
- **Strength**: [WEAK/MODERATE/STRONG]
- **Issues Found**: [List]

### Authorization Model
- **Type**: [RBAC/ABAC/MAC]
- **Granularity**: [Coarse/Fine]
- **Issues Found**: [List]

### Session Management
- [ ] Secure session token generation
- [ ] Proper session timeout
- [ ] Session fixation prevention
- [ ] Concurrent session control

---

## Cryptography Review

### Algorithms Used
| Purpose | Algorithm | Strength | FIPS Approved | Notes |
|---------|-----------|----------|---------------|-------|
| Hashing | [SHA256/SHA512] | [Bits] | [Yes/No] | |
| Encryption | [AES] | [Bits] | [Yes/No] | |
| Key Exchange | [ECDH] | [Bits] | [Yes/No] | |
| Digital Signatures | [RSA/ECDSA] | [Bits] | [Yes/No] | |

### Key Management
- **Key Storage**: [Method and security]
- **Key Rotation**: [Policy and implementation]
- **Key Recovery**: [Procedures]
- **Issues Found**: [List]

---

## Input Validation

### Validation Coverage
- [ ] All user inputs validated
- [ ] File upload restrictions
- [ ] API input validation
- [ ] Database query parameterization
- [ ] Command injection prevention

### Issues Found
[List validation gaps]

---

## Dependency Analysis

### Third-Party Libraries

| Package | Version | License | Vulnerabilities | Action Required |
|---------|---------|---------|-----------------|-----------------|
| [Package] | [Version] | [License] | [CVE count] | [Update/Replace/Accept] |

### Supply Chain Security
- [ ] All dependencies scanned
- [ ] License compliance verified
- [ ] Known vulnerabilities addressed
- [ ] SBOM (Software Bill of Materials) generated

---

## Security Testing Results

### Static Analysis (SAST)
- **Tool**: [SonarQube/Fortify/etc]
- **Critical Issues**: [Count]
- **High Issues**: [Count]
- **Medium Issues**: [Count]
- **Low Issues**: [Count]

### Dynamic Analysis (DAST)
- **Tool**: [OWASP ZAP/Burp/etc]
- **Findings**: [Summary]

### Penetration Testing
- **Scope**: [What was tested]
- **Findings**: [Summary]
- **Exploits Successful**: [List]

---

## Audit and Logging

### Audit Coverage
- [ ] Authentication events
- [ ] Authorization decisions
- [ ] Data access
- [ ] Configuration changes
- [ ] Errors and exceptions
- [ ] Security events

### Issues Found
- [List any gaps in audit logging]

---

## Network Security

### Communications
- [ ] TLS 1.2+ enforced
- [ ] Certificate validation
- [ ] Secure headers configured
- [ ] CORS properly configured

### Issues Found
[List network security issues]

---

## Data Protection

### Data at Rest
- **Encryption Method**: [TDE/Column-level]
- **Key Management**: [Description]
- **Issues**: [List]

### Data in Transit
- **Protocols**: [TLS 1.2/1.3]
- **Certificate Management**: [Description]
- **Issues**: [List]

### Data Classification
- [ ] PII identified and protected
- [ ] Classified data marked
- [ ] Access controls applied
- [ ] Retention policies defined

---

## Remediation Plan

### Priority Matrix

| Priority | Count | Timeline | Resources |
|----------|-------|----------|-----------|
| Critical | [#] | Immediate | [Team/Hours] |
| High | [#] | 1 week | [Team/Hours] |
| Medium | [#] | 2 weeks | [Team/Hours] |
| Low | [#] | 1 month | [Team/Hours] |

### Specific Actions

#### Immediate Actions (Critical)
1. [Action item with specific steps]
2. [Action item with specific steps]

#### Short-term Actions (High)
1. [Action item with timeline]
2. [Action item with timeline]

#### Long-term Actions (Medium/Low)
1. [Action item with timeline]
2. [Action item with timeline]

---

## Risk Acceptance

### Accepted Risks
| Risk | Justification | Compensating Controls | Expiry | Owner |
|------|---------------|----------------------|--------|--------|
| [Risk] | [Business reason] | [Controls] | [Date] | [Name] |

---

## Recommendations

### Security Enhancements
1. [Recommendation with justification]
2. [Recommendation with justification]

### Process Improvements
1. [Recommendation for development process]
2. [Recommendation for security process]

### Training Needs
1. [Identified knowledge gaps]
2. [Recommended training]

---

## Approval Chain

| Role | Name | Decision | Date | Notes |
|------|------|----------|------|-------|
| Security Lead | | [APPROVE/REJECT] | | |
| Development Lead | | [APPROVE/REJECT] | | |
| Project Manager | | [APPROVE/REJECT] | | |
| Risk Owner | | [ACCEPT/MITIGATE] | | |

---

## Follow-up Actions

- [ ] Schedule remediation review - [Date]
- [ ] Update security documentation
- [ ] Implement compensating controls
- [ ] Conduct security training
- [ ] Re-test after fixes - [Date]

---

## Appendices

### A. Tool Output Reports
[Links or references to detailed scan reports]

### B. Code Samples
[Additional vulnerable code examples]

### C. References
- [Security standards referenced]
- [Compliance guides used]
- [Best practices consulted]

---

*Generated by: Continuous Documentation Agent*  
*Template Version: 1.0.0*  
*Classification: Review document classification*  
*Retention: 7 years per DoD requirements*