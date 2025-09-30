# IAMSNG Hardware Components Catalog

> **Version**: 1.0.0  
> **Last Updated**: 2025-09-29 (Session 003)  
> **Purpose**: Comprehensive hardware component categorization for asset management  
> **Total Component Records**: 282 across 5 tables

## Executive Summary

The IAMSNG hardware component catalog provides a comprehensive taxonomy for categorizing and tracking all hardware assets within the Department of Defense infrastructure. This catalog ensures standardized hardware classification, enabling accurate inventory management, compatibility assessment, and lifecycle tracking.

## Architecture Overview

```
Hardware Asset
    ├── Physical Properties
    │   ├── Condition (condition table)
    │   └── Form Factor (hw_enclosure table)
    │
    └── Technical Components
        ├── Processing Units
        │   ├── CPU (cpu_type → hardware_manufacturer)
        │   └── GPU (gpu_types → hardware_manufacturer)
        │
        └── Memory
            └── RAM Type (physical_memory_type)
```

## Component Tables

### 1. Condition Table
**Purpose**: Lifecycle state tracking for all hardware assets

**Key Features**:
- 12 comprehensive condition states
- Supports full asset lifecycle from acquisition to disposal
- Critical for DoD property accountability
- Enables predictive maintenance scheduling

**Use Cases**:
- Asset valuation and depreciation
- Maintenance prioritization
- Disposal workflow management
- Audit compliance reporting
- Insurance claim documentation

**Integration Points**:
- Links to future Asset table via condition_id
- Triggers maintenance workflows based on state
- Feeds into reporting dashboards

### 2. Hardware Enclosure Table
**Purpose**: Physical form factor classification

**Key Features**:
- 16 form factor types covering all compute platforms
- Includes virtual and cloud instances
- Supports space planning and rack management
- Physical security assessment criteria

**Categories Covered**:
- **Server**: Rackmount, Tower, Blade
- **Desktop**: Tower, SFF, All-in-One
- **Mobile**: Laptop, Tablet, Mobile Device
- **Specialized**: Industrial PC, Embedded, Network Appliance
- **Virtual**: VM, Cloud Instance

**Use Cases**:
- Data center space planning
- Physical security requirements
- Cooling and power calculations
- Shipping and logistics planning
- Virtualization capacity management

### 3. Physical Memory Type Table
**Purpose**: RAM specification and compatibility tracking

**Key Features**:
- 33 memory types across 6 categories
- Covers consumer, server, and specialty memory
- Technical specifications for compatibility
- Performance tier classification

**Technology Coverage**:
- **DDR Generations**: DDR through DDR5
- **Form Factors**: DIMM, SODIMM, RDIMM, LRDIMM
- **Error Correction**: ECC and non-ECC variants
- **Specialty**: Graphics (GDDR), Mobile (LPDDR), High Bandwidth (HBM)
- **Legacy Support**: SDRAM, RDRAM, EDO

**Use Cases**:
- Upgrade compatibility verification
- Performance optimization planning
- Bulk procurement specifications
- Warranty claim processing
- Technology refresh planning

### 4. GPU Types Table
**Purpose**: Graphics processor inventory and capability tracking

**Key Features**:
- 41 GPU models from 3 major vendors
- Foreign key relationship to hardware_manufacturer
- Covers consumer, professional, and data center GPUs
- AI/ML capability classification

**Vendor Distribution**:
- **NVIDIA** (20 models): Consumer RTX, Professional Quadro, Data Center Tesla/A100/H100
- **AMD** (16 models): Consumer Radeon, Professional Radeon Pro, Legacy models
- **Intel** (5 models): Arc discrete graphics, Integrated Iris Xe

**Use Cases**:
- AI/ML workload allocation
- Graphics workstation configuration
- Virtual desktop infrastructure planning
- Cryptocurrency mining detection
- Power consumption modeling

### 5. CPU Type Table
**Purpose**: Comprehensive processor catalog with manufacturer relationships

**Key Features**:
- 180 CPU models from 15+ manufacturers
- Foreign key relationship to hardware_manufacturer
- Architecture diversity (x86, ARM, RISC, SPARC)
- Performance tier classification

**Architecture Coverage**:
- **x86/x64**: Intel, AMD, VIA, Zhaoxin
- **ARM**: Apple Silicon, Qualcomm, ARM Holdings, MediaTek
- **RISC**: IBM POWER, Oracle SPARC
- **Specialty**: Amazon Graviton, Chinese domestic (Loongson, Phytium)

**Major Manufacturers**:
1. **Intel** (58 models): Full range from Atom to Xeon Platinum
2. **AMD** (55 models): Consumer Ryzen to datacenter EPYC
3. **Apple** (17 models): M-series and A-series Bionic
4. **ARM Ecosystem** (32 models): Various ARM-based designs
5. **Enterprise** (10 models): IBM POWER, Oracle SPARC
6. **Emerging** (8 models): Chinese and specialty processors

**Use Cases**:
- Performance benchmarking baselines
- Security feature availability (SGX, SEV, etc.)
- Power efficiency optimization
- License compliance (per-core licensing)
- Architecture-specific software compatibility

## Relationships and Dependencies

### Primary Relationships

```sql
gpu_types.hardware_manufacturer_id → hardware_manufacturer.hardware_manufacturer_id
cpu_type.hardware_manufacturer_id → hardware_manufacturer.hardware_manufacturer_id
```

### Future Asset Table Integration

```sql
-- Planned relationships for Phase 2
asset.condition_id → condition.condition_id
asset.hw_enclosure_id → hw_enclosure.hw_enclosure_id
asset.cpu_type_id → cpu_type.cpu_type_id
asset.gpu_type_id → gpu_types.gpu_type_id
asset.memory_type_id → physical_memory_type.physical_memtype_id
```

## Data Quality and Governance

### Seed Data Standards
- **Completeness**: All required fields populated
- **Accuracy**: Verified against manufacturer specifications
- **Consistency**: Standardized naming conventions
- **Currency**: Updated quarterly for new models

### Update Procedures
1. **New Hardware Releases**: Quarterly review and addition
2. **End-of-Life**: Mark as obsolete, retain for historical assets
3. **Manufacturer Changes**: Update via migration with audit trail
4. **Category Expansion**: Requires architecture review

## Security Considerations

### FIPS 140-3 Compliance
- Hardware selection impacts cryptographic capabilities
- CPU instruction sets affect encryption performance
- ECC memory recommended for cryptographic operations
- GPU acceleration for approved algorithms only

### DoD Requirements
- STIG compliance for hardware selection
- Supply chain verification via manufacturer tracking
- Technology Control Plan (TCP) compliance
- Export control classification

## Performance Optimization

### Query Optimization
```sql
-- Indexed lookups for common queries
CREATE INDEX IX_cpu_performance ON cpu_type(hardware_manufacturer_id, cpu_type_name)
CREATE INDEX IX_gpu_capability ON gpu_types(hardware_manufacturer_id, gpu_type_name)
CREATE INDEX IX_memory_compatibility ON physical_memory_type(physical_memtype_name)
```

### Caching Strategy
- Cache all component tables in Redis (static data)
- 24-hour TTL with manual invalidation on updates
- Reduces database load for frequent lookups

## Use Case Scenarios

### Scenario 1: Hardware Refresh Planning
1. Query assets by CPU generation (cpu_type)
2. Filter by condition state (condition)
3. Check form factor constraints (hw_enclosure)
4. Verify memory upgrade paths (physical_memory_type)
5. Generate procurement specifications

### Scenario 2: Data Center Consolidation
1. Inventory by enclosure type (rackmount vs tower)
2. Group by CPU architecture for virtualization
3. Assess GPU resources for VDI deployment
4. Plan memory upgrades for VM density

### Scenario 3: Security Audit
1. Identify CPUs without hardware security features
2. Find systems with non-ECC memory
3. Locate legacy hardware (obsolete condition)
4. Verify supply chain (manufacturer origin)

## Integration with Asset Management

### Asset Creation Workflow
```
1. Select hardware_manufacturer
2. Choose cpu_type (filtered by manufacturer)
3. Select gpu_type (if applicable)
4. Specify memory_type and capacity
5. Set hw_enclosure form factor
6. Assign initial condition (typically "New")
```

### Lifecycle Transitions
```
New → Excellent → Good → Fair → Poor → Non-Functional
                    ↓
            Under Repair → Good
                    ↓
            Awaiting Disposal → Disposed
```

## Reporting Capabilities

### Standard Reports
1. **Hardware Inventory by Type**: CPU/GPU/Memory distribution
2. **Condition Assessment**: Asset health dashboard
3. **Technology Currency**: Obsolescence tracking
4. **Vendor Concentration**: Supply chain risk analysis
5. **Form Factor Distribution**: Space utilization

### Compliance Reports
1. **FIPS Capability**: Hardware crypto support
2. **End-of-Life**: Unsupported hardware
3. **Performance Tiers**: Capability assessment
4. **Physical Security**: Enclosure type analysis

## Future Enhancements

### Phase 2 Additions
- Storage device types (SSD, HDD, NVMe)
- Network interface types (Ethernet, Fiber, Wireless)
- Peripheral device catalog
- Power supply specifications

### Phase 3 Expansions
- Firmware version tracking
- Hardware vulnerability database
- Performance benchmark scores
- Thermal design power (TDP) specs

## Maintenance Guidelines

### Quarterly Review Tasks
1. Add new CPU/GPU models from manufacturers
2. Update obsolete status for EOL products
3. Verify manufacturer active status
4. Review and update descriptions

### Annual Tasks
1. Comprehensive vendor audit
2. Technology trend analysis
3. Seed data optimization
4. Performance impact assessment

## Conclusion

The hardware components catalog provides the foundational taxonomy for comprehensive asset management within the IAMSNG system. By maintaining detailed categorization across conditions, form factors, processors, and memory types, the system enables:

- Accurate inventory tracking
- Informed procurement decisions
- Effective lifecycle management
- Security compliance verification
- Performance optimization planning

This catalog serves as the authoritative reference for all hardware classification decisions within the Department of Defense asset management framework.

---

*Document maintained by: Continuous Documentation Agent*  
*Technical Owner: IAMSNG Database Team*  
*Classification: UNCLASSIFIED // FOUO*  
*Review Cycle: Quarterly*