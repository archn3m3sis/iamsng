# IAMSNG Seed Data Inventory

> **Version**: 1.1.0  
> **Last Updated**: 2025-09-29 (Session 004)  
> **Total Seed Records**: 898  
> **Database**: iamsdb (SQL Server 2022)

## Overview

This document provides a comprehensive inventory of all seed data pre-populated in the IAMSNG database. Seed data ensures the system has essential reference data for immediate operational readiness and testing.

## Summary Statistics

| Category | Tables | Total Records | Purpose |
|----------|--------|---------------|---------|
| Security & Access | 2 | 33 | User roles and permissions |
| Defense Programs | 1 | 18 | Program tracking |
| Locations | 4 | 97 | Physical asset locations |
| Vendors | 2 | 389 | Manufacturer registry |
| Hardware Components | 5 | 282 | Hardware categorization |
| System & OS Configuration | 3 | 118 | Platform and OS tracking |
| **TOTAL** | **17** | **898** | - |

## Detailed Seed Data Inventory

### 1. Role Table (5 Records)

System roles for role-based access control:

| ID | Role Name | Description | System Role |
|----|-----------|-------------|-------------|
| 1 | SuperAdmin | Full system access with all permissions | Yes |
| 2 | Admin | Administrative functions and user management | Yes |
| 3 | Manager | Team and asset management capabilities | Yes |
| 4 | User | Standard user access for asset operations | Yes |
| 5 | ReadOnly | View-only access for reporting and auditing | Yes |

**Purpose**: Core authorization framework  
**Growth**: Static - changes require security review

### 2. SME Role Table (28 Records)

Subject Matter Expert specializations:

| ID | Role Name | Category |
|----|-----------|----------|
| 1 | Network Engineer | Technical |
| 2 | Security Analyst | Security |
| 3 | Database Administrator | Technical |
| 4 | System Administrator | Technical |
| 5 | Software Developer | Development |
| 6 | Hardware Technician | Operations |
| 7 | Help Desk | Support |
| 8 | Project Manager | Management |
| 9 | Business Analyst | Analysis |
| 10 | Quality Assurance | Testing |
| 11 | Cloud Architect | Architecture |
| 12 | DevOps Engineer | Operations |
| 13 | Data Scientist | Analytics |
| 14 | Cybersecurity Specialist | Security |
| 15 | Infrastructure Engineer | Infrastructure |
| 16 | Application Support | Support |
| 17 | Technical Writer | Documentation |
| 18 | Compliance Officer | Compliance |
| 19 | Training Specialist | Training |
| 20 | Procurement Specialist | Acquisition |
| 21 | Asset Manager | Management |
| 22 | Field Technician | Operations |
| 23 | Integration Specialist | Technical |
| 24 | Data Analyst | Analytics |
| 25 | Supply Chain | Logistics |
| 26 | Logistics | Operations |
| 27 | Contract Management | Acquisition |
| 28 | Facilities Manager | Facilities |

**Purpose**: Specialized expertise tracking  
**Growth**: Minimal - new specializations added as needed

### 3. Program Table (18 Records)

Major defense acquisition programs:

| ID | Program Name | Code | Service Branch |
|----|--------------|------|----------------|
| 1 | F-35 Lightning II | F35 | Air Force |
| 2 | Virginia Class Submarine | VCS | Navy |
| 3 | B-21 Raider | B21 | Air Force |
| 4 | Gerald R. Ford Class Carrier | CVN78 | Navy |
| 5 | Apache Helicopter AH-64E | AH64E | Army |
| 6 | Patriot Missile System | PAT | Army |
| 7 | Aegis Combat System | AEGIS | Navy |
| 8 | F-22 Raptor | F22 | Air Force |
| 9 | Abrams Tank M1A2 | M1A2 | Army |
| 10 | Bradley Fighting Vehicle | BFV | Army |
| 11 | KC-46 Pegasus Tanker | KC46 | Air Force |
| 12 | Littoral Combat Ship | LCS | Navy |
| 13 | Joint Light Tactical Vehicle | JLTV | Army/Marines |
| 14 | MQ-9 Reaper Drone | MQ9 | Air Force |
| 15 | Stryker Combat Vehicle | STRK | Army |
| 16 | Zumwalt Class Destroyer | DDG1000 | Navy |
| 17 | Black Hawk Helicopter | UH60 | Army |
| 18 | Joint Strike Fighter Engine | F135 | Air Force |

**Purpose**: Asset program association  
**Growth**: ~5-10 programs annually

### 4. Building Table (8 Records)

Physical building identifiers:

| ID | Building Number | Type |
|----|----------------|------|
| 1 | Building 370 | Administrative |
| 2 | Building 010 | Operations |
| 3 | Building 012 | Technical |
| 4 | Building 001 | Headquarters |
| 5 | Building 014 | Research |
| 6 | Building 350 | Warehouse |
| 7 | Building 377 | Maintenance |
| 8 | Building 403 | Training |

**Purpose**: Physical asset location tracking  
**Growth**: Per installation expansion

### 5. Floor Table (4 Records)

Standard floor definitions:

| ID | Floor Number | Description |
|----|-------------|-------------|
| 1 | Floor 001 | Ground/First Floor |
| 2 | Floor 002 | Second Floor |
| 3 | Floor 003 | Third Floor |
| 4 | Floor 004 | Fourth Floor |

**Purpose**: Vertical location tracking  
**Growth**: Static - standard definitions

### 6. Room Table (33 Records)

Detailed room inventory:

#### By Room Type Distribution:
| Room Type | Count | Examples |
|-----------|-------|----------|
| Server Room | 7 | SRVR001-SRVR007 |
| Office | 6 | OFF101-OFF401 |
| Storage | 5 | STOR001-STOR005 |
| Lab | 5 | LAB001-LAB005 |
| Conference Room | 4 | CONF001-CONF004 |
| Workshop | 3 | WKSP001-WKSP003 |
| Training Room | 2 | TRNG001-TRNG002 |
| Network Closet | 1 | NETC001 |

#### Sample Room Details:
| Room Number | Name | Type | Building | Floor | Capacity |
|-------------|------|------|----------|-------|----------|
| 370-101 | Main Server Room | Server Room | 370 | 1 | - |
| 010-201 | Executive Office | Office | 010 | 2 | 4 |
| 012-301 | Development Lab | Lab | 012 | 3 | 20 |
| 001-101 | HQ Conference Room | Conference Room | 001 | 1 | 50 |

**Purpose**: Precise asset location  
**Growth**: 10-20 rooms per new building

### 7. Installation Table (52 Records)

Military installations worldwide:

#### By Service Branch:
| Service | Count | Notable Examples |
|---------|-------|------------------|
| Army | 15 | Fort Liberty, Fort Campbell, Fort Stewart |
| Air Force | 14 | Wright-Patterson, Edwards, Eglin |
| Navy | 11 | Norfolk, San Diego, Pearl Harbor |
| Marine Corps | 5 | Camp Pendleton, Camp Lejeune, Quantico |
| Joint Base | 4 | Lewis-McChord, San Antonio, Charleston |
| Space Force | 3 | Peterson SFB, Buckley SFB, Vandenberg SFB |

#### By Location:
| Location Type | Count | Examples |
|--------------|-------|----------|
| CONUS (Continental US) | 42 | Fort Hood (TX), Fort Carson (CO) |
| OCONUS (Outside US) | 10 | Ramstein (Germany), Yokota (Japan) |

#### International Installations:
| Country | Base Name | Code | Service |
|---------|-----------|------|---------|
| Germany | Ramstein Air Base | RMAB | Air Force |
| Japan | Yokota Air Base | YOKO | Air Force |
| Japan | Yokosuka Naval Base | YKNB | Navy |
| South Korea | Camp Humphreys | CMPH | Army |
| Italy | Aviano Air Base | AVIA | Air Force |
| United Kingdom | RAF Lakenheath | RAFH | Air Force |
| Bahrain | Naval Support Activity | NSAB | Navy |
| Qatar | Al Udeid Air Base | AUAB | Air Force |
| Djibouti | Camp Lemonnier | CLEM | Navy |
| Diego Garcia | Naval Support Facility | NSDG | Navy |

**Purpose**: Global asset distribution  
**Growth**: Minimal - follows DoD installations

### 8. Hardware Manufacturer Table (165 Records)

#### Top Categories:
| Category | Count | Major Companies |
|----------|-------|-----------------|
| Computer Systems | 25 | Dell, HP, IBM, Lenovo |
| Networking | 20 | Cisco, Juniper, Arista |
| Defense Contractors | 18 | Lockheed Martin, Boeing, Raytheon |
| Storage | 15 | NetApp, EMC, Pure Storage |
| Semiconductors | 12 | Intel, AMD, NVIDIA |
| Peripherals | 10 | Logitech, Kingston, Corsair |

#### Notable Defense Contractors:
1. Lockheed Martin Corporation
2. Boeing Defense, Space & Security
3. Raytheon Technologies
4. Northrop Grumman Corporation
5. General Dynamics
6. BAE Systems
7. L3Harris Technologies
8. Huntington Ingalls Industries
9. Textron Inc.
10. SAIC

**Purpose**: Hardware warranty and support tracking  
**Growth**: ~20-30 vendors annually

### 9. Software Manufacturer Table (217 Records)

#### Top Categories:
| Category | Count | Major Companies |
|----------|-------|-----------------|
| Operating Systems | 8 | Microsoft, Red Hat, Ubuntu |
| Databases | 15 | Oracle, Microsoft, PostgreSQL |
| Security | 25 | Symantec, McAfee, CrowdStrike |
| Development Tools | 20 | JetBrains, GitHub, Atlassian |
| Cloud Providers | 10 | AWS, Azure, Google Cloud |
| Enterprise Apps | 30 | SAP, Oracle, Salesforce |

#### Key Security Vendors:
1. CrowdStrike (FedRAMP High)
2. Palo Alto Networks
3. Symantec (Broadcom)
4. McAfee (Trellix)
5. Fortinet
6. Check Point Software
7. Rapid7
8. Qualys
9. Tenable
10. Splunk

#### Defense-Specific Software:
1. Palantir Technologies
2. CACI International
3. SAIC Software Division
4. General Dynamics IT
5. Booz Allen Hamilton
6. MITRE Corporation
7. Leidos
8. CSRA (General Dynamics)
9. ManTech International
10. GDIT

**Data Quality Notes**:
- 250 initial records processed
- 33 duplicates removed
- 217 unique vendors retained

**Purpose**: Software license compliance  
**Growth**: ~30-40 vendors annually

### 10. Condition Table (12 Records)

Asset condition states for lifecycle management:

| ID | Condition Name | Description |
|----|---------------|-------------|
| 1 | New | Brand new, unused equipment |
| 2 | Excellent | Like new condition with minimal wear |
| 3 | Good | Normal wear, fully functional |
| 4 | Fair | Moderate wear, functional with minor issues |
| 5 | Poor | Heavy wear, limited functionality |
| 6 | Non-Functional | Not operational, requires repair |
| 7 | Under Repair | Currently being serviced or repaired |
| 8 | Awaiting Disposal | Scheduled for disposal process |
| 9 | Disposed | Removed from inventory, disposed |
| 10 | Missing | Cannot be located in inventory |
| 11 | Damaged | Physical damage present |
| 12 | Obsolete | No longer supported or outdated |

**Purpose**: Asset lifecycle and accountability tracking  
**Growth**: Static - comprehensive condition states

### 11. Hardware Enclosure Table (16 Records)

Hardware form factor classifications:

| ID | Enclosure Name | Description |
|----|---------------|-------------|
| 1 | Server Rackmount | Standard rack-mounted server chassis |
| 2 | Server Tower | Tower form factor server |
| 3 | Server Blade | Blade server for blade chassis |
| 4 | Desktop Tower | Standard desktop PC tower |
| 5 | Desktop Small Form Factor | Compact desktop computer |
| 6 | All-in-One | Integrated display and computer |
| 7 | Laptop Portable | Standard laptop/notebook computer |
| 8 | Tablet | Tablet form factor device |
| 9 | Mini PC | Ultra-compact PC form factor |
| 10 | Network Appliance | Dedicated network device enclosure |
| 11 | Industrial PC | Ruggedized industrial computer |
| 12 | Embedded System | Integrated embedded computer |
| 13 | Mobile Device | Smartphone or handheld device |
| 14 | Workstation | High-performance workstation |
| 15 | Virtual Machine | Virtual server instance |
| 16 | Cloud Instance | Cloud-hosted compute instance |

**Purpose**: Physical security and space planning  
**Growth**: Minimal - new form factors emerge slowly

### 12. Physical Memory Type Table (33 Records)

RAM/Memory specification categories:

#### DDR Memory Types (8):
- DDR, DDR2, DDR3, DDR3L, DDR4, DDR4 ECC, DDR5, DDR5 ECC

#### SODIMM Memory (6):
- DDR3 SODIMM, DDR3L SODIMM, DDR4 SODIMM, DDR4 ECC SODIMM, DDR5 SODIMM, DDR5 ECC SODIMM

#### Server Memory (5):
- DDR4 RDIMM, DDR4 LRDIMM, DDR5 RDIMM, DDR5 LRDIMM, FB-DIMM

#### Graphics Memory (6):
- GDDR3, GDDR4, GDDR5, GDDR6, GDDR6X, HBM2

#### Mobile Memory (5):
- LPDDR2, LPDDR3, LPDDR4, LPDDR5, LPDDR5X

#### Legacy Memory (3):
- SDRAM, RDRAM, EDO RAM

**Purpose**: Hardware compatibility and upgrade planning  
**Growth**: New standards every 2-3 years

### 13. GPU Types Table (41 Records)

Graphics processors by manufacturer:

#### NVIDIA GPUs (20):
| Series | Models |
|--------|--------|
| RTX 40 Series | RTX 4090, RTX 4080, RTX 4070 Ti, RTX 4070, RTX 4060 Ti, RTX 4060 |
| RTX 30 Series | RTX 3090, RTX 3080, RTX 3070, RTX 3060, RTX 3050 |
| Professional | Quadro RTX 6000, Quadro P5000, Tesla V100, A100 |
| Data Center | H100, A40, T4 |

#### AMD GPUs (16):
| Series | Models |
|--------|--------|
| RX 7000 Series | RX 7900 XTX, RX 7900 XT, RX 7800 XT, RX 7700 XT, RX 7600 |
| RX 6000 Series | RX 6900 XT, RX 6800 XT, RX 6700 XT, RX 6600 XT, RX 6500 XT, RX 6400 |
| Legacy | RX 580, RX 570 |
| Professional | Radeon Pro W6800, Radeon Pro VII, FirePro W9100 |

#### Intel GPUs (5):
- Arc A770, Arc A750, Arc A380, Arc A310, Iris Xe Graphics

**Purpose**: Graphics capability inventory and AI/ML workload planning  
**Growth**: ~10-15 new models annually

### 14. CPU Type Table (180 Records)

Comprehensive processor catalog:

#### Distribution by Manufacturer:
| Manufacturer | Count | Key Series |
|-------------|-------|------------|
| Intel | 58 | Core i3/i5/i7/i9, Xeon, Pentium, Celeron, Atom |
| AMD | 55 | Ryzen 3/5/7/9, Threadripper, EPYC, Athlon |
| Apple | 17 | M1/M2/M3 (Pro/Max/Ultra), A12-A17 Bionic |
| Qualcomm | 9 | Snapdragon 8 Gen series |
| ARM Holdings | 14 | Cortex-A/X, Neoverse |
| IBM | 4 | POWER9, POWER10 |
| Oracle | 3 | SPARC M8, S7, T4 |
| Amazon | 3 | Graviton2, Graviton3 |
| MediaTek | 6 | Dimensity series |
| Samsung | 3 | Exynos series |
| Others | 8 | Huawei, Loongson, Zhaoxin, VIA, Phytium |

#### Intel CPU Breakdown:
- Core i9: 12th/13th Gen variants
- Core i7: 12th/13th Gen variants  
- Core i5: 12th/13th Gen variants
- Core i3: 12th/13th Gen variants
- Xeon: E-series, W-series, Gold, Platinum, Silver, Bronze
- Entry: Pentium Gold, Celeron
- Mobile: Atom series

#### AMD CPU Breakdown:
- Ryzen 9: 7950X, 5950X, 7900X, 5900X
- Ryzen 7: 7700X, 5800X3D, 5700X
- Ryzen 5: 7600X, 5600X, 5500
- Ryzen 3: 5300G, 4100
- Threadripper: PRO 5995WX, 5975WX, 5965WX
- EPYC: 9654, 7763, 7543
- Legacy: FX-9590, FX-8350, Athlon series

**Purpose**: Performance capability assessment and compatibility tracking  
**Growth**: ~20-30 new models quarterly

### 15. System Architecture Table (28 Records)

Hardware platform instruction set architectures:

| ID | Architecture Name | Description |
|----|------------------|-------------|
| 1 | x86 | Legacy Intel/AMD 32-bit architecture |
| 2 | x86_64 | 64-bit extension of x86 (AMD64) |
| 3 | ARM | ARM 32-bit architecture |
| 4 | ARM64 | ARM 64-bit architecture (AArch64) |
| 5 | ARMv7 | ARM version 7 architecture |
| 6 | ARMv8 | ARM version 8 architecture |
| 7 | ARMv9 | ARM version 9 architecture |
| 8 | PowerPC | IBM POWER architecture |
| 9 | POWER | IBM POWER ISA |
| 10 | SPARC | Oracle/Sun SPARC architecture |
| 11 | SPARCv9 | SPARC Version 9 64-bit |
| 12 | MIPS | MIPS processor architecture |
| 13 | MIPS64 | 64-bit MIPS architecture |
| 14 | RISC-V | Open-source RISC architecture |
| 15 | Itanium | Intel IA-64 architecture |
| 16 | Alpha | DEC Alpha architecture |
| 17 | PA-RISC | HP Precision Architecture |
| 18 | z/Architecture | IBM System z mainframe |
| 19 | s390x | IBM System/390 64-bit |
| 20 | VAX | DEC VAX architecture |
| 21 | 68k | Motorola 68000 series |
| 22 | SuperH | Hitachi/Renesas SH architecture |
| 23 | LoongArch | Loongson architecture |
| 24 | OpenRISC | Open source RISC |
| 25 | Hexagon | Qualcomm Hexagon DSP |
| 26 | Xtensa | Cadence/Tensilica architecture |
| 27 | AVR | Atmel AVR microcontroller |
| 28 | WASM | WebAssembly virtual ISA |

**Purpose**: Platform compatibility and security capability tracking  
**Growth**: Static - new architectures emerge rarely

### 16. Operating System Vendor Table (40 Records)

OS vendor and maintainer organizations:

#### By Category:
| Category | Count | Notable Vendors |
|----------|-------|----------------|
| Commercial | 8 | Microsoft, Apple, Oracle, IBM, VMware |
| Linux Distributions | 10 | Red Hat, Canonical, SUSE, Debian |
| BSD Projects | 4 | FreeBSD, OpenBSD, NetBSD, DragonFly |
| Embedded/RTOS | 5 | Wind River, QNX, Green Hills |
| Security-Focused | 4 | Kali, Parrot, BlackArch, Security Onion |
| Cloud/Container | 3 | Docker, CoreOS, Rancher |
| Network/Firewall | 3 | pfSense, OPNsense, MikroTik |
| Legacy | 3 | Sun Microsystems, DEC, Silicon Graphics |

#### Key Enterprise Vendors:
1. Microsoft Corporation - Windows family
2. Red Hat (IBM) - RHEL, Fedora
3. Canonical Ltd. - Ubuntu
4. SUSE - SUSE Linux Enterprise
5. Oracle Corporation - Oracle Linux, Solaris
6. VMware (Broadcom) - ESXi, Photon OS
7. Apple Inc. - macOS, iOS
8. Google - Android, Chrome OS
9. IBM - AIX, z/OS
10. Amazon - Amazon Linux

**Purpose**: Vendor support and security update tracking  
**Growth**: ~2-3 new vendors annually

### 17. Operating System Platform Table (50 Records)

OS platform families and distributions:

#### By Platform Family:
| Family | Count | Examples |
|--------|-------|----------|
| Windows | 4 | Server, Desktop, IoT, Mobile |
| macOS/iOS | 3 | macOS, OS X, iOS |
| Linux | 15 | Ubuntu, RHEL, CentOS, Debian, SUSE |
| Unix | 4 | AIX, HP-UX, Solaris, UnixWare |
| BSD | 5 | FreeBSD, OpenBSD, NetBSD, DragonFlyBSD |
| Mobile | 3 | Android, iOS, Windows Mobile |
| Embedded | 6 | VxWorks, QNX, FreeRTOS, Embedded Linux |
| Mainframe | 3 | z/OS, z/VM, z/VSE |
| Hypervisor | 4 | ESXi, Hyper-V, Xen, KVM |
| Container | 3 | Docker, Kubernetes, OpenShift |
| Network | 3 | Cisco IOS, JunOS, RouterOS |
| Legacy | 3 | DOS, OS/2, VMS |

#### Special Notes:
- **Naming Fix**: "Cisco IOS" used to differentiate from Apple iOS
- **FIPS Support**: Windows Server, RHEL, Ubuntu have FIPS-validated versions
- **DoD Approved**: Windows, RHEL, VMware ESXi primary platforms

**Purpose**: Software compatibility and security baseline management  
**Growth**: ~5-10 new platforms annually with technology evolution

## Seed Data Characteristics

### Data Quality Metrics
- **Completeness**: 100% required fields populated
- **Uniqueness**: All unique constraints satisfied
- **Referential Integrity**: All foreign keys valid
- **Consistency**: Standardized naming conventions
- **Accuracy**: Verified against DoD sources

### Audit Fields (All Tables)
- **CreatedAt**: 2024-01-01 (standardized for seed data)
- **CreatedBy**: 1 (System user)
- **ModifiedAt**: NULL (never modified)
- **ModifiedBy**: NULL
- **Version**: 1 (initial version)

### Standardization Rules Applied
1. **Naming Conventions**:
   - PascalCase for proper names
   - Consistent abbreviations (Inc., Corp., LLC)
   - No trailing spaces or special characters

2. **Code Fields**:
   - Uppercase alphanumeric only
   - 3-10 characters length
   - Unique within table

3. **Boolean Flags**:
   - is_active: Default TRUE for all seed data
   - is_conus: Set based on geographic location
   - is_doe_approved: Default FALSE (requires verification)
   - is_fedRAMP_certified: Default FALSE (requires verification)

## Seed Data Management

### Update Procedures
1. **Adding New Seed Data**:
   - Create new migration with HasData()
   - Document in this inventory
   - Update timeline with rationale

2. **Modifying Existing Seed Data**:
   - Create migration with UpdateData()
   - Maintain audit trail
   - Document business justification

3. **Removing Seed Data**:
   - Soft delete preferred (is_active = false)
   - Hard delete requires approval
   - Archive historical data

### Validation Rules
- No NULL values in required fields
- Unique constraints enforced
- Foreign key relationships valid
- Business rules satisfied

## Usage Guidelines

### For Developers
- Seed data is read-only in production
- Use for testing and development
- Do not modify via application code
- Reference by ID for consistency

### For Testers
- Provides consistent baseline
- Covers common scenarios
- Enables reproducible tests
- Supports integration testing

### For Operations
- Included in all deployments
- Verified during migration
- Backed up with database
- Audited for compliance

## Compliance Notes

### FIPS 140-3 Considerations
- No cryptographic material in seed data
- No sensitive/classified information
- Vendor data is public information
- Installation data is unclassified

### DoD Requirements
- CAGE codes for applicable vendors
- Service branch associations
- CONUS/OCONUS designations
- Program classifications pending

## Future Seed Data Plans

### Phase 2 Additions
- Asset type definitions
- Maintenance schedules
- Warranty types
- Ticket categories

### Phase 3 Additions
- Compliance frameworks
- Audit templates
- Report definitions
- Dashboard configurations

---

*Document maintained by: Continuous Documentation Agent*  
*Data Source: EF Core Migrations*  
*Classification: UNCLASSIFIED // FOUO*