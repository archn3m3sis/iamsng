# IAMSNG System Configuration Catalog

> **Version**: 1.0.0  
> **Last Updated**: 2025-09-29 (Session 004)  
> **Purpose**: Comprehensive system architecture and operating system categorization  
> **Total Configuration Records**: 118 across 3 tables

## Executive Summary

The IAMSNG System Configuration Catalog provides a complete taxonomy for categorizing system architectures, operating system vendors, and platforms within the Department of Defense infrastructure. This catalog ensures standardized classification of computing platforms, enabling accurate compatibility assessment, security baseline management, and platform-specific configuration tracking.

## Architecture Overview

```
System Configuration
    ├── Hardware Layer
    │   └── System Architecture (sys_architecture)
    │       └── Instruction Set Architecture (ISA)
    │
    └── Software Layer
        ├── OS Vendor (os_vendor)
        │   └── Vendor/Maintainer Organization
        │
        └── OS Platform (os_platform)
            └── Operating System Family/Distribution
```

## Relationship Model

```
Future Asset Table
    ├── sys_architecture_id → sys_architecture
    ├── os_vendor_id → os_vendor
    ├── os_platform_id → os_platform
    └── [Hardware relationships from hardware catalog]
```

## Configuration Tables

### 1. System Architecture Table (`sys_architecture`)

**Purpose**: Hardware platform instruction set architecture categorization

**Key Features**:
- 28 comprehensive instruction set architectures
- Covers all major processor families
- Includes legacy and emerging architectures
- Critical for binary compatibility assessment

**Architecture Categories**:

#### x86 Family
- **x86**: Legacy 32-bit Intel/AMD architecture
- **x86_64**: 64-bit extension (AMD64/Intel 64)
- **Itanium**: Intel's IA-64 EPIC architecture

#### ARM Family
- **ARM**: 32-bit ARM architecture
- **ARM64**: 64-bit ARM (AArch64)
- **ARMv7**: Specific ARM version 7
- **ARMv8**: ARM version 8 with 64-bit support
- **ARMv9**: Latest ARM architecture with security extensions

#### RISC Architectures
- **PowerPC**: Classic IBM/Motorola/Apple architecture
- **POWER**: Modern IBM POWER ISA
- **SPARC/SPARCv9**: Oracle/Sun architecture
- **MIPS/MIPS64**: MIPS Technologies architecture
- **RISC-V**: Open-source RISC ISA
- **Alpha**: DEC Alpha 64-bit RISC
- **PA-RISC**: HP Precision Architecture
- **OpenRISC**: Open-source RISC implementation

#### Mainframe & Enterprise
- **z/Architecture**: IBM System z mainframe
- **s390x**: IBM System/390 64-bit

#### Embedded & Specialized
- **SuperH**: Hitachi/Renesas SH architecture
- **68k**: Motorola 68000 series
- **Hexagon**: Qualcomm DSP architecture
- **Xtensa**: Cadence configurable processor
- **AVR**: Atmel microcontroller architecture
- **LoongArch**: Loongson Chinese architecture

#### Legacy
- **VAX**: DEC VAX CISC architecture

#### Virtual
- **WASM**: WebAssembly virtual ISA

**Security Implications**:
- Architecture determines available security instructions
- Hardware encryption support varies by ISA
- Memory protection features differ across architectures
- Speculative execution vulnerabilities are architecture-specific

**Use Cases**:
- Binary compatibility verification
- Cross-compilation requirements
- Performance optimization strategies
- Security feature availability assessment
- Virtualization capability determination

### 2. Operating System Vendor Table (`os_vendor`)

**Purpose**: Operating system vendor and maintainer registry

**Key Features**:
- 40 OS vendors and maintainers
- Covers commercial, open-source, and specialty vendors
- Includes legacy vendors for historical systems
- Critical for support contract management

**Vendor Categories**:

#### Major Commercial (8)
1. **Microsoft Corporation** - Windows ecosystem
2. **Apple Inc.** - macOS, iOS, tvOS, watchOS
3. **Oracle Corporation** - Solaris, Oracle Linux
4. **IBM** - AIX, z/OS, IBM i
5. **VMware (Broadcom)** - ESXi, Photon OS
6. **HPE** - HP-UX, NonStop
7. **Dell Technologies** - Dell EMC solutions
8. **Amazon Web Services** - Amazon Linux

#### Linux Distributions (10)
1. **Red Hat (IBM)** - RHEL, Fedora, CentOS Stream
2. **Canonical Ltd.** - Ubuntu, Ubuntu Core
3. **SUSE** - SUSE Linux Enterprise, openSUSE
4. **Debian Project** - Debian GNU/Linux
5. **Oracle** - Oracle Linux
6. **CentOS Project** - CentOS Linux (EOL)
7. **Rocky Enterprise** - Rocky Linux
8. **AlmaLinux Foundation** - AlmaLinux
9. **Arch Linux** - Rolling release
10. **Gentoo Foundation** - Source-based distribution

#### BSD Projects (4)
1. **FreeBSD Foundation** - FreeBSD
2. **OpenBSD Project** - Security-focused BSD
3. **NetBSD Foundation** - Portable BSD
4. **DragonFly BSD** - Performance-focused BSD

#### Security-Focused (4)
1. **Offensive Security** - Kali Linux
2. **Parrot Security** - Parrot OS
3. **BlackArch** - Penetration testing
4. **Security Onion** - Network security monitoring

#### Embedded/RTOS (5)
1. **Wind River Systems** - VxWorks
2. **BlackBerry QNX** - QNX Neutrino RTOS
3. **Green Hills Software** - INTEGRITY RTOS
4. **FreeRTOS (Amazon)** - Open-source RTOS
5. **Zephyr Project** - Scalable RTOS

#### Network/Firewall (3)
1. **Netgate** - pfSense
2. **Deciso** - OPNsense
3. **MikroTik** - RouterOS

#### Container/Cloud (3)
1. **Docker Inc.** - Docker, Moby
2. **CoreOS (Red Hat)** - Container Linux
3. **Rancher Labs (SUSE)** - RancherOS

#### Defense/Government (2)
1. **Astra Linux** - Russian certified OS
2. **Kylin** - Chinese national OS

#### Legacy (3)
1. **Sun Microsystems** - Historical Solaris
2. **Digital Equipment Corp** - VMS, Tru64
3. **Silicon Graphics** - IRIX

**FIPS Compliance Notes**:
- Microsoft, Red Hat, Canonical have FIPS-validated modules
- Oracle Solaris includes FIPS 140-2 certified crypto
- VMware ESXi supports FIPS mode
- Some vendors provide Common Criteria certification

**Use Cases**:
- Vendor support contract tracking
- Security update management
- License compliance monitoring
- Vendor risk assessment
- Supply chain security evaluation

### 3. Operating System Platform Table (`os_platform`)

**Purpose**: Operating system platform families and distributions

**Key Features**:
- 50 OS platforms covering all major categories
- Hierarchical classification by family
- Includes virtualization and container platforms
- Critical for software compatibility management

**Platform Families**:

#### Windows Family (4)
1. **Windows Server** - Enterprise server OS
2. **Windows Desktop** - Client workstation OS
3. **Windows IoT** - Embedded/IoT variants
4. **Windows Mobile** - Mobile device OS (legacy)

#### Apple Platforms (3)
1. **macOS** - Desktop/laptop OS
2. **OS X** - Legacy macOS naming
3. **iOS** - Mobile device OS

#### Linux Distributions (15)
1. **Ubuntu** - Debian-based, wide adoption
2. **Red Hat Enterprise Linux** - Enterprise standard
3. **CentOS** - RHEL rebuild (transitioning)
4. **Debian** - Community distribution
5. **SUSE Linux Enterprise** - Enterprise focus
6. **Fedora** - Red Hat community
7. **Oracle Linux** - RHEL-compatible
8. **Amazon Linux** - AWS-optimized
9. **Alpine Linux** - Security-oriented, minimal
10. **Arch Linux** - Rolling release
11. **Rocky Linux** - CentOS replacement
12. **AlmaLinux** - RHEL compatible
13. **openSUSE** - SUSE community
14. **Mint** - Desktop-focused
15. **Manjaro** - Arch-based, user-friendly

#### Unix Variants (4)
1. **AIX** - IBM enterprise Unix
2. **HP-UX** - HPE enterprise Unix
3. **Solaris** - Oracle/Sun Unix
4. **UnixWare** - SCO Unix

#### BSD Family (5)
1. **FreeBSD** - General-purpose BSD
2. **OpenBSD** - Security-focused BSD
3. **NetBSD** - Portable BSD
4. **DragonFlyBSD** - Performance BSD
5. **TrueNAS** - Storage-focused BSD

#### Mobile Platforms (3)
1. **Android** - Linux-based mobile OS
2. **iOS** - Apple mobile OS
3. **Windows Mobile** - Microsoft mobile (discontinued)

#### Embedded Systems (6)
1. **VxWorks** - Real-time OS
2. **QNX** - Microkernel RTOS
3. **FreeRTOS** - Open-source RTOS
4. **Embedded Linux** - Custom Linux builds
5. **INTEGRITY** - Safety-critical RTOS
6. **Zephyr** - Scalable RTOS

#### Mainframe (3)
1. **z/OS** - IBM mainframe OS
2. **z/VM** - IBM virtualization
3. **z/VSE** - IBM batch processing

#### Hypervisors (4)
1. **VMware ESXi** - Type 1 hypervisor
2. **Microsoft Hyper-V** - Windows hypervisor
3. **Xen** - Open-source hypervisor
4. **KVM** - Kernel-based VM

#### Container Platforms (3)
1. **Docker** - Container runtime
2. **Kubernetes** - Container orchestration
3. **OpenShift** - Enterprise Kubernetes

#### Network OS (3)
1. **Cisco IOS** - Network device OS (renamed for clarity)
2. **JunOS** - Juniper Networks OS
3. **RouterOS** - MikroTik router OS

#### Security Platforms (2)
1. **Kali Linux** - Penetration testing
2. **Security Onion** - Network security

#### Firewall OS (2)
1. **pfSense** - Open-source firewall
2. **OPNsense** - pfSense fork

#### Legacy (3)
1. **DOS** - Disk Operating System
2. **OS/2** - IBM/Microsoft OS
3. **VMS** - DEC Virtual Memory System

**Important Notes**:
- **Cisco IOS Naming**: Explicitly named "Cisco IOS" to differentiate from Apple iOS
- **FIPS Support**: Windows Server, RHEL, Ubuntu Server have FIPS modes
- **DoD Standards**: Primary platforms are Windows, RHEL, VMware ESXi

**Use Cases**:
- Software compatibility verification
- Security baseline selection
- Update management strategies
- Platform-specific configuration
- License requirement tracking

## Integration Patterns

### Asset Configuration Workflow

```
1. Hardware Assessment
   └── Determine sys_architecture (x86_64, ARM64, etc.)
   
2. OS Identification  
   ├── Identify os_vendor (Microsoft, Red Hat, etc.)
   └── Specify os_platform (Windows Server, RHEL, etc.)
   
3. Compatibility Verification
   ├── Check architecture support for OS
   ├── Verify vendor certification
   └── Confirm platform security features
   
4. Configuration Management
   ├── Apply platform-specific baselines
   ├── Set security configurations
   └── Enable compliance monitoring
```

### Security Configuration Matrix

| Platform | Architecture | FIPS Support | DoD Approved | Common Criteria |
|----------|-------------|--------------|--------------|-----------------|
| Windows Server | x86_64, ARM64 | Yes | Yes | EAL4+ |
| RHEL | x86_64, ARM64, POWER | Yes | Yes | EAL4+ |
| VMware ESXi | x86_64 | Yes | Yes | EAL4+ |
| Ubuntu Server | x86_64, ARM64 | Yes | Limited | No |
| Solaris | SPARC, x86_64 | Yes | Legacy | EAL4+ |

## Compliance Considerations

### FIPS 140-3 Requirements
- Platform must support FIPS-validated cryptographic modules
- Architecture must provide hardware crypto acceleration
- Vendor must maintain FIPS certification status
- Configuration must enable FIPS mode where available

### DoD STIG Compliance
- Platform-specific Security Technical Implementation Guides
- Architecture-specific hardening requirements
- Vendor-provided security updates and patches
- Regular compliance scanning and remediation

### Common Criteria
- Evaluation Assurance Level (EAL) certification
- Protection profiles for specific use cases
- Target of Evaluation (TOE) boundaries
- Certification maintenance requirements

## Performance Optimization

### Query Patterns

```sql
-- Find all Windows servers on x86_64
SELECT a.* FROM assets a
JOIN sys_architecture sa ON a.sys_architecture_id = sa.sys_architecture_id
JOIN os_platform op ON a.os_platform_id = op.os_platform_id
WHERE sa.system_architecture = 'x86_64'
  AND op.os_platform_name = 'Windows Server'

-- Identify systems needing FIPS compliance
SELECT a.*, op.os_platform_name, ov.os_vendor_name
FROM assets a
JOIN os_platform op ON a.os_platform_id = op.os_platform_id
JOIN os_vendor ov ON a.os_vendor_id = ov.os_vendor_id
WHERE a.requires_fips = 1
  AND op.supports_fips = 1

-- Architecture distribution analysis
SELECT sa.system_architecture, COUNT(*) as asset_count
FROM assets a
JOIN sys_architecture sa ON a.sys_architecture_id = sa.sys_architecture_id
GROUP BY sa.system_architecture
ORDER BY asset_count DESC
```

### Caching Strategy
- Cache all three tables in Redis (static reference data)
- 24-hour TTL with manual invalidation
- Minimal memory footprint (~10KB total)
- Instant lookups for UI dropdowns

## Reporting Capabilities

### Standard Reports

1. **Platform Distribution**
   - OS platform usage across installations
   - Vendor concentration analysis
   - Architecture diversity metrics

2. **Compatibility Matrix**
   - Software-to-platform compatibility
   - Architecture support coverage
   - Cross-platform application inventory

3. **Security Posture**
   - FIPS-compliant system percentage
   - Platform patch level status
   - Architecture vulnerability exposure

4. **Vendor Analysis**
   - Support contract coverage
   - End-of-life platform tracking
   - Vendor diversity metrics

### Compliance Reports

1. **FIPS Compliance**
   - Platform FIPS capability assessment
   - Configuration compliance status
   - Non-compliant system identification

2. **STIG Compliance**
   - Platform-specific STIG coverage
   - Hardening status by architecture
   - Remediation priority listing

3. **License Compliance**
   - Platform license utilization
   - Vendor agreement compliance
   - Overcapacity/undercapacity analysis

## Use Case Scenarios

### Scenario 1: New System Deployment
1. Select target architecture based on workload
2. Choose approved OS vendor for support
3. Select specific platform version
4. Apply architecture-specific optimizations
5. Configure platform security baselines

### Scenario 2: Platform Migration
1. Inventory current architecture/platform combinations
2. Identify compatibility constraints
3. Map migration paths (e.g., x86 to ARM)
4. Assess vendor change impacts
5. Plan phased migration approach

### Scenario 3: Security Audit
1. List all non-FIPS platforms
2. Identify unsupported OS versions
3. Find architecture-specific vulnerabilities
4. Assess vendor security posture
5. Generate remediation priorities

### Scenario 4: Capacity Planning
1. Analyze architecture utilization
2. Project platform growth trends
3. Identify consolidation opportunities
4. Plan architecture refreshes
5. Optimize license allocations

## Data Governance

### Update Procedures

1. **New Architectures**
   - Rare additions (1-2 per decade)
   - Requires architecture review board approval
   - Full compatibility assessment required

2. **New OS Vendors**
   - Quarterly review for additions
   - Vendor vetting process required
   - Security certification verification

3. **New OS Platforms**
   - Monthly review for new releases
   - Version tracking and EOL dates
   - Compatibility testing required

### Data Quality Standards
- Unique names enforced via constraints
- Standardized naming conventions
- No duplicate entries across tables
- Regular validation audits

### Change Management
- All changes via EF Core migrations
- Audit trail for modifications
- Rollback procedures documented
- Testing in development environment

## Integration with Hardware Catalog

### Complete Asset Profile

```
Asset Configuration
├── Hardware Layer
│   ├── CPU Type → Hardware Manufacturer
│   ├── GPU Type → Hardware Manufacturer  
│   ├── Memory Type
│   ├── Enclosure Type
│   └── System Architecture ← NEW
│
└── Software Layer
    ├── OS Vendor ← NEW
    ├── OS Platform ← NEW
    └── [Future: Installed Software]
```

### Compatibility Rules

1. **Architecture-Platform Compatibility**
   - Windows Server: x86_64, ARM64
   - macOS: x86_64, ARM64 (Apple Silicon)
   - Linux: Supports most architectures
   - VMware ESXi: x86_64 only

2. **Vendor-Platform Relationships**
   - Microsoft → Windows family
   - Apple → macOS, iOS
   - Red Hat → RHEL, Fedora
   - Canonical → Ubuntu

3. **Hardware-Software Constraints**
   - ARM platforms limited OS choices
   - Mainframe architectures require specific OS
   - Embedded systems have RTOS requirements
   - Virtual platforms need hypervisor support

## Future Enhancements

### Phase 2 Additions
- OS Version tracking (specific builds/releases)
- OS Edition differentiation (Enterprise, Standard, etc.)
- Driver/firmware version catalog
- Kernel version tracking for Linux

### Phase 3 Expansions
- Container runtime versions
- Kubernetes distribution tracking
- Cloud platform variants
- Edge computing platforms

### Phase 4 Advanced Features
- Automated compatibility checking
- Architecture migration planning tools
- Platform optimization recommendations
- Security baseline automation

## Maintenance Guidelines

### Monthly Tasks
1. Review new OS platform releases
2. Update EOL status for platforms
3. Verify vendor active status
4. Check for security bulletins

### Quarterly Tasks
1. Add new OS vendors if any
2. Review architecture landscape
3. Update platform descriptions
4. Audit data quality

### Annual Tasks
1. Comprehensive platform review
2. Architecture trend analysis
3. Vendor relationship audit
4. Compliance framework updates

## Conclusion

The System Configuration Catalog provides essential categorization for system architectures and operating system platforms within the IAMSNG system. This comprehensive taxonomy enables:

- **Accurate Configuration Management**: Precise tracking of system configurations
- **Compatibility Assessment**: Verification of hardware-software compatibility
- **Security Baseline Management**: Platform-specific security configurations
- **Compliance Tracking**: FIPS, STIG, and certification status monitoring
- **Vendor Management**: Support contract and lifecycle tracking
- **Migration Planning**: Architecture and platform transition strategies

Together with the Hardware Components Catalog, these configuration tables provide complete foundational reference data for comprehensive asset management in Department of Defense environments.

---

*Document maintained by: Continuous Documentation Agent*  
*Technical Owner: IAMSNG Database Team*  
*Classification: UNCLASSIFIED // FOUO*  
*Review Cycle: Monthly*