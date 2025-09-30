// This file contains the seed data for SoftwareManufacturerConfiguration
// Duplicates have been removed - each vendor appears only once

using iamsng.Core.Entities;

namespace iamsng.Infrastructure.Data.Configurations;

public static class SoftwareManufacturerSeedData
{
    public static List<SoftwareManufacturer> GetAllSeedData()
    {
        var createdAt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var seedData = new List<SoftwareManufacturer>();
        int id = 1;

        // All unique software manufacturers (duplicates removed)
        // OS, Enterprise, & Virtualization
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Microsoft", ProductionFocus = "OS Software & Productivity", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Apple", ProductionFocus = "OS Software & Hardware", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Google", ProductionFocus = "Cloud & Software Services", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Red Hat", ProductionFocus = "Enterprise Linux & Open Source", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "SUSE", ProductionFocus = "Enterprise Linux", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Canonical", ProductionFocus = "Ubuntu Linux", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "VMware", ProductionFocus = "Virtualization & Cloud", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Citrix", ProductionFocus = "Virtualization & Networking", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Oracle", ProductionFocus = "Database & Enterprise Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "IBM", ProductionFocus = "Enterprise & Cloud Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Wind River Systems", ProductionFocus = "Embedded OS", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Enterprise Software
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "SAP", ProductionFocus = "Enterprise Resource Planning", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Salesforce", ProductionFocus = "CRM & Cloud Services", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "ServiceNow", ProductionFocus = "IT Service Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Workday", ProductionFocus = "HR & Finance Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Infor", ProductionFocus = "Enterprise Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Epicor", ProductionFocus = "Enterprise Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "IFS", ProductionFocus = "Enterprise Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "QAD", ProductionFocus = "Enterprise Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Sage", ProductionFocus = "Business Management Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Financial & Accounting
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Intuit", ProductionFocus = "Financial Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Xero", ProductionFocus = "Accounting Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "FreshBooks", ProductionFocus = "Accounting Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Wave Accounting", ProductionFocus = "Financial Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Expensify", ProductionFocus = "Expense Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Bill.com", ProductionFocus = "Financial Automation", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "ADP", ProductionFocus = "Payroll & HR Services", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Paychex", ProductionFocus = "Payroll Services", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Communication & Collaboration
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Zoom", ProductionFocus = "Video Conferencing", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Cisco", ProductionFocus = "Networking & Communications", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "RingCentral", ProductionFocus = "Cloud Communications", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "8x8", ProductionFocus = "Cloud Communications", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Vonage", ProductionFocus = "Communications Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerName = "Twilio", ProductionFocus = "Communications APIs", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Constant Contact", ProductionFocus = "Email Marketing", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Campaign Monitor", ProductionFocus = "Email Marketing", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "AWeber", ProductionFocus = "Email Marketing", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Slack Technologies", ProductionFocus = "Team Collaboration", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Discord", ProductionFocus = "Communications Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // E-commerce & Retail
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Shopify", ProductionFocus = "E-commerce Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Automattic", ProductionFocus = "Web Publishing", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "BigCommerce", ProductionFocus = "E-commerce Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Squarespace", ProductionFocus = "Website Builder", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Wix", ProductionFocus = "Website Builder", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Etsy", ProductionFocus = "E-commerce Marketplace", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Amazon", ProductionFocus = "Cloud & E-commerce", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "eBay", ProductionFocus = "E-commerce Marketplace", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "PrestaShop", ProductionFocus = "E-commerce Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Healthcare Software
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "MEDITECH", ProductionFocus = "Healthcare IT", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Epic Systems", ProductionFocus = "Healthcare Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Cerner", ProductionFocus = "Healthcare IT", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Allscripts", ProductionFocus = "Healthcare Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "athenahealth", ProductionFocus = "Healthcare Services", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Industrial & Engineering Software
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Autodesk", ProductionFocus = "Design & Engineering Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Bentley Systems", ProductionFocus = "Infrastructure Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "AVEVA", ProductionFocus = "Industrial Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Rockwell Automation", ProductionFocus = "Industrial Automation", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Schneider Electric", ProductionFocus = "Energy Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Honeywell", ProductionFocus = "Industrial Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Emerson", ProductionFocus = "Automation Solutions", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Dassault Systèmes", ProductionFocus = "3D Design Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "PTC", ProductionFocus = "Product Lifecycle Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Siemens", ProductionFocus = "Digital Industries Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Ansys", ProductionFocus = "Simulation Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Trimble", ProductionFocus = "Positioning Technology", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Esri", ProductionFocus = "GIS Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Open Source Organizations
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Mozilla Foundation", ProductionFocus = "Open Source Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Linux Foundation", ProductionFocus = "Open Source Collaboration", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Apache Software Foundation", ProductionFocus = "Open Source Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "PostgreSQL Global Development", ProductionFocus = "Database Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "MariaDB Foundation", ProductionFocus = "Database Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Drupal Association", ProductionFocus = "Content Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "WordPress Foundation", ProductionFocus = "Content Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "OpenStack Foundation", ProductionFocus = "Cloud Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "LibreOffice Foundation", ProductionFocus = "Office Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // AI & Machine Learning
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "OpenAI", ProductionFocus = "Artificial Intelligence", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Anthropic", ProductionFocus = "AI Safety", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "DeepMind", ProductionFocus = "AI Research", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "NVIDIA", ProductionFocus = "AI Computing Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "DataRobot", ProductionFocus = "AutoML Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "H2O.ai", ProductionFocus = "Machine Learning Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Alteryx", ProductionFocus = "Data Analytics", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Dataiku", ProductionFocus = "Data Science Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Palantir", ProductionFocus = "Data Analytics Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "C3.ai", ProductionFocus = "Enterprise AI", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "UiPath", ProductionFocus = "Robotic Process Automation", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Automation Anywhere", ProductionFocus = "RPA Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Blue Prism", ProductionFocus = "Intelligent Automation", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Virtualization & Infrastructure
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Parallels", ProductionFocus = "Desktop Virtualization", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Nutanix", ProductionFocus = "Hybrid Cloud Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Docker", ProductionFocus = "Container Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Kubernetes", ProductionFocus = "Container Orchestration", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Backup & Recovery
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Veeam", ProductionFocus = "Data Protection", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Commvault", ProductionFocus = "Data Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Veritas", ProductionFocus = "Data Protection", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Acronis", ProductionFocus = "Cyber Protection", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Druva", ProductionFocus = "Cloud Data Protection", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Rubrik", ProductionFocus = "Cloud Data Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Cohesity", ProductionFocus = "Data Management Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Network Management
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "SolarWinds", ProductionFocus = "IT Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "ManageEngine", ProductionFocus = "IT Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Paessler", ProductionFocus = "Network Monitoring", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Nagios", ProductionFocus = "Infrastructure Monitoring", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Zabbix", ProductionFocus = "Monitoring Solution", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Progress", ProductionFocus = "Application Development", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Lansweeper", ProductionFocus = "IT Asset Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Mobile Development Platforms
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Ionic", ProductionFocus = "Mobile App Framework", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Appcelerator", ProductionFocus = "Mobile Development", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Content Management
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Joomla", ProductionFocus = "Content Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Sitecore", ProductionFocus = "Digital Experience Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Contentful", ProductionFocus = "Headless CMS", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Strapi", ProductionFocus = "Headless CMS", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Database Management
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "MongoDB", ProductionFocus = "NoSQL Database", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Snowflake", ProductionFocus = "Cloud Data Warehouse", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Databricks", ProductionFocus = "Data Lakehouse Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Tableau", ProductionFocus = "Data Visualization", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Qlik", ProductionFocus = "Business Intelligence", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "SAS Institute", ProductionFocus = "Analytics Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Teradata", ProductionFocus = "Data Analytics", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "MarkLogic", ProductionFocus = "NoSQL Database", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Neo4j", ProductionFocus = "Graph Database", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "DataStax", ProductionFocus = "Distributed Database", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "InfluxData", ProductionFocus = "Time Series Database", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Elastic", ProductionFocus = "Search & Analytics", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Cybersecurity Software
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "CrowdStrike", ProductionFocus = "Endpoint Protection", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "SentinelOne", ProductionFocus = "Endpoint Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Palo Alto Networks", ProductionFocus = "Network Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Fortinet", ProductionFocus = "Network Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Check Point", ProductionFocus = "Cyber Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Broadcom", ProductionFocus = "Enterprise Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "McAfee", ProductionFocus = "Security Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Trend Micro", ProductionFocus = "Cybersecurity", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Kaspersky", ProductionFocus = "Security Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Bitdefender", ProductionFocus = "Cybersecurity", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "ESET", ProductionFocus = "IT Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "F-Secure", ProductionFocus = "Cyber Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Sophos", ProductionFocus = "Cybersecurity", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Rapid7", ProductionFocus = "Security Analytics", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Qualys", ProductionFocus = "Cloud Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Tenable", ProductionFocus = "Vulnerability Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Veracode", ProductionFocus = "Application Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Okta", ProductionFocus = "Identity Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Ping Identity", ProductionFocus = "Identity Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "CyberArk", ProductionFocus = "Privileged Access Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "BeyondTrust", ProductionFocus = "Privileged Access Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Varonis", ProductionFocus = "Data Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Proofpoint", ProductionFocus = "Email Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Mimecast", ProductionFocus = "Email Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Zscaler", ProductionFocus = "Cloud Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Cloudflare", ProductionFocus = "Web Infrastructure & Security", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Development Tools & DevOps
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "JetBrains", ProductionFocus = "Development Tools", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Atlassian", ProductionFocus = "Collaboration Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "GitHub", ProductionFocus = "Development Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "GitLab", ProductionFocus = "DevOps Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Jenkins", ProductionFocus = "Automation Server", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "HashiCorp", ProductionFocus = "Infrastructure Automation", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Puppet", ProductionFocus = "Configuration Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Chef Software", ProductionFocus = "Infrastructure Automation", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Splunk", ProductionFocus = "Data Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "New Relic", ProductionFocus = "Observability Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Datadog", ProductionFocus = "Monitoring & Analytics", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "AppDynamics", ProductionFocus = "Application Performance", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Dynatrace", ProductionFocus = "Software Intelligence", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "PagerDuty", ProductionFocus = "Incident Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Unity Technologies", ProductionFocus = "Game Development Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Epic Games", ProductionFocus = "Game Engine & Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Cloud Providers
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Alibaba Cloud", ProductionFocus = "Cloud Computing", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "DigitalOcean", ProductionFocus = "Cloud Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Linode", ProductionFocus = "Cloud Hosting", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Vultr", ProductionFocus = "Cloud Infrastructure", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "OVHcloud", ProductionFocus = "Cloud Services", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Rackspace", ProductionFocus = "Managed Cloud", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Productivity & Collaboration
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Adobe", ProductionFocus = "Creative Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Corel", ProductionFocus = "Graphics Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Notion", ProductionFocus = "Productivity Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "LogMeIn", ProductionFocus = "Remote Access Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Dropbox", ProductionFocus = "Cloud Storage", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Box", ProductionFocus = "Cloud Content Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Media & Entertainment Software
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Maxon", ProductionFocus = "3D Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Foundry", ProductionFocus = "Visual Effects Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Blackmagic Design", ProductionFocus = "Video Production", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Avid Technology", ProductionFocus = "Media Production", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Gaming Companies
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Electronic Arts", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Activision Blizzard", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Ubisoft", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Valve Corporation", ProductionFocus = "Gaming Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Riot Games", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Take-Two Interactive", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Bethesda Game Studios", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "CD Projekt", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Square Enix", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Capcom", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Konami", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Bandai Namco", ProductionFocus = "Video Games", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Business Intelligence & Project Management
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "HubSpot", ProductionFocus = "Marketing Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Zendesk", ProductionFocus = "Customer Service", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Freshworks", ProductionFocus = "Customer Engagement", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Zoho", ProductionFocus = "Business Software", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Pipedrive", ProductionFocus = "Sales CRM", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Monday.com", ProductionFocus = "Work Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Asana", ProductionFocus = "Project Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Smartsheet", ProductionFocus = "Work Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Airtable", ProductionFocus = "Low-Code Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "ClickUp", ProductionFocus = "Productivity Platform", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });
        seedData.Add(new SoftwareManufacturer { SoftwareManufacturerId = id++, SoftwareManufacturerName = "Basecamp", ProductionFocus = "Project Management", IconFile = null, CreatedAt = createdAt, CreatedBy = 1, Version = 1 });

        // Fix the Twilio entry that was missing its ID
        var twilioEntry = seedData.FirstOrDefault(s => s.SoftwareManufacturerName == "Twilio");
        if (twilioEntry != null)
        {
            twilioEntry.SoftwareManufacturerId = 35;
        }

        // Renumber all IDs to be sequential
        for (int i = 0; i < seedData.Count; i++)
        {
            seedData[i].SoftwareManufacturerId = i + 1;
        }

        return seedData;
    }
}