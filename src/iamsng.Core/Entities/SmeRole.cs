using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Subject Matter Expert (SME) Role entity for specialized expertise designation.
/// Allows users to have additional specialized roles beyond their primary role.
/// </summary>
[Table("sme_role")]
public class SmeRole : BaseEntity
{
    [Key]
    [Column("smerole_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SmeRoleId { get; set; }

    [Required]
    [Column("smerole_name")]
    [MaxLength(100)]
    public string SmeRoleName { get; set; } = string.Empty;

    // Navigation Properties
    public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

    // Predefined SME roles for industrial asset management
    public static class SystemSmeRoles
    {
        // Equipment Specializations
        public const string PumpSpecialist = "Pump Specialist";
        public const string ValveSpecialist = "Valve Specialist";
        public const string CompressorSpecialist = "Compressor Specialist";
        public const string ElectricalSystemsExpert = "Electrical Systems Expert";
        public const string InstrumentationExpert = "Instrumentation Expert";
        public const string HVACSpecialist = "HVAC Specialist";
        
        // Maintenance Specializations
        public const string PredictiveMaintenanceExpert = "Predictive Maintenance Expert";
        public const string ReliabilityEngineer = "Reliability Engineer";
        public const string VibrationAnalyst = "Vibration Analyst";
        public const string ThermographySpecialist = "Thermography Specialist";
        public const string LubricationSpecialist = "Lubrication Specialist";
        
        // Compliance & Safety Specializations
        public const string SafetyExpert = "Safety Expert";
        public const string EnvironmentalComplianceExpert = "Environmental Compliance Expert";
        public const string CyberSecurityExpert = "Cyber Security Expert";
        public const string QualityAssuranceExpert = "Quality Assurance Expert";
        
        // Operational Specializations
        public const string ProcessOptimizationExpert = "Process Optimization Expert";
        public const string EnergyManagementExpert = "Energy Management Expert";
        public const string AutomationSpecialist = "Automation Specialist";
        public const string DataAnalyticsExpert = "Data Analytics Expert";
    }

    // Helper method to determine expertise category
    [NotMapped]
    public string ExpertiseCategory
    {
        get
        {
            if (SmeRoleName.Contains("Specialist") && 
                (SmeRoleName.Contains("Pump") || SmeRoleName.Contains("Valve") || 
                 SmeRoleName.Contains("Compressor") || SmeRoleName.Contains("Electrical") ||
                 SmeRoleName.Contains("Instrumentation") || SmeRoleName.Contains("HVAC")))
                return "Equipment";
            
            if (SmeRoleName.Contains("Maintenance") || SmeRoleName.Contains("Reliability") ||
                SmeRoleName.Contains("Vibration") || SmeRoleName.Contains("Thermography") ||
                SmeRoleName.Contains("Lubrication"))
                return "Maintenance";
            
            if (SmeRoleName.Contains("Safety") || SmeRoleName.Contains("Compliance") ||
                SmeRoleName.Contains("Security") || SmeRoleName.Contains("Quality"))
                return "Compliance";
            
            if (SmeRoleName.Contains("Process") || SmeRoleName.Contains("Energy") ||
                SmeRoleName.Contains("Automation") || SmeRoleName.Contains("Analytics"))
                return "Operations";
            
            return "General";
        }
    }
}