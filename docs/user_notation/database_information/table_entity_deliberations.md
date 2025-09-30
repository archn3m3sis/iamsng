  
  
  
##### **USER TABLE FIELD DETERMINATIONS:** 
  ---

  **Option A: Reference role_id (Recommended)**
  ✅ Benefits:
  - No data repetition - Role name stored once in role table
  - Easier updates - Change role name in one place, all users automatically see new name
  - Better performance - Integer comparisons faster than string comparisons
  - Smaller storage - Integer (4-8 bytes) vs string (potentially 50+ bytes per row)
  - Standard practice - Following normalized database design

  **❌ Drawbacks:**
  - Requires JOIN to see role name in queries
  - Less readable in raw database views

  **Option B: Reference role_name**
  ✅ Benefits:
  - Human readable - Can see role directly without JOIN
  - Simpler queries for basic selects

  **❌ Drawbacks:**
  - Data repetition - If you have 1000 users with "Administrator" role, that string is stored 1000 times
  - Update complexity - Changing a role name requires updating every user record
  - Risk of inconsistency - Typos or case differences ("Admin" vs "admin")
  - More storage - Significantly larger database size
  - Violates normalization - Goes against your requirement of minimal data repetition

>[!Quote] For the user table, we will be referencing the role.role_id field with our foreign key reference....

##### **USER TABLE FIELD CONSIDERATIONS WITH SECURITY IN MIND:**
  ---
  **Potentially Useful CAC Fields:**
  1. `user_piv_auth_cert_hash` - Hash of PIV authentication certificate (for certificate pinning) [add]
  2. `user_affiliation` - Military branch/civilian agency (ARMY, NAVY, USAF, etc.) [add]
  3. `user_person_designator` - Civilian/Military/Contractor status [add] 
  4. `user_cac_expiry` - Certificate expiration date (for proactive renewal) [add] 
  5. `user_alternate_token` - Backup authentication method if CAC unavailable [add] 

  My recommendation: Add at minimum user_affiliation and user_cac_expiry for better user management.

  **Audit Fields Explanation:**
  *What are audit fields?*
  Fields that automatically track WHO did WHAT and WHEN:
  - `created_at` - Timestamp when record was created
  - `created_by` - User ID who created the record
  - `modified_at` - Timestamp of last modification
  - `modified_by` - User ID who last modified it
  - `version` - Record version number (for optimistic locking)

  ***Are they REQUIRED for FIPS 140-3/DoD?***
  - **YES** - DoD RMF (Risk Management Framework) and *NIST 800-53 require audit trails*
  - **FIPS 140-3**: **Section 7.9 mandates** "*audit mechanism* for *security-relevant events*"
  - **STIG Requirements**: Application *must log user activities, especially privilege changes*


**Fields I want to add to the table:** 
- user_piv_auth_cert_hash
- user_affiliation 
- user_person_designator
- user_cac_expiry
- created_at
- created_by
- modified_at
- modified_by
- version

**Prior to pushing the addition of these fields, could you tell me:** 
- What is optimistic locking in the context of the verion field for the user table? 
- What is certificate pinning and how does the inclusion of the user_piv_auth_cert_hash facilitate this within a dataabase app authenticatijon? 


##### **OPTIMISTIC LOCKING & CERTIFICATE PINNING EXPLAINED**
---
**Optimistic Locking with Version Field:**
- What it is:
  *A strategy to ==prevent conflicts when multiple users edit the same record simultaneously WITHOUT locking the database row==.*

- How it works:
  -- User A loads record: SELECT * FROM user WHERE user_id = 1
  -- Record has version = 5

  -- User B loads same record simultaneously
  -- Also sees version = 5

  -- User A updates:
  
  ```
  UPDATE user
  SET user_email = 'new@email.com', version = 6
  WHERE user_id = 1 AND version = 5
  ```
  
  -- Success! 1 row affected

  -- User B tries to update:

 ```
  UPDATE user
  SET user_phone = '555-1234', version = 6
  WHERE user_id = 1 AND version = 5 
 ``` 
 
 -- FAILS! 0 rows affected (version is now 6, not 5)
  **-- ==Application detects failure and can reload/retry==**

  Benefits for DoD:
  - **Prevents data corruption** in high-concurrency environments
  - **No database locks** = ***better performance***
  - **Audit trail** shows all attempts
  - ***Required for many government systems***

##### **CERTIFICATE PINNING USING `USER_PIV_AUTH_CERT_HASH`**
---
**What it is:**
- ***Security technique that "pins" (associates) a specific certificate with a user, preventing man-in-the-middle attacks*** ==even if a Certificate Authority is compromised.==

**How it works in our app:**
// During CAC authentication:
  1. User presents CAC certificate
  2. Calculate hash: `SHA256(certificate)`
  3. Compare with stored `user_piv_auth_cert_hash`
  4. If match = trusted certificate
  5. If no match = potential security issue

**// First login:**
- if (user.user_piv_auth_cert_hash == null) {
      // Store the hash for future pinning
      user.user_piv_auth_cert_hash = CalculateHash(cacCertificate);
  }

**// Subsequent logins:**
  else if (user.user_piv_auth_cert_hash != CalculateHash(cacCertificate)) {
      // ALERT: Certificate changed unexpectedly!
      // Could be: reissued CAC, compromised cert, or attack
      LogSecurityEvent();
      RequireAdminApproval();
  }

**Benefits for DoD:**
  - **Prevents sophisticated attacks** - Even if attackers get a "valid" certificate from compromised CA
  - **Detects CAC cloning attempts** - Each physical CAC has unique certificate
  - **Compliance** - Meets "high assurance" authentication requirements
  - **Audit trail -** Logs when certificates change

> Important consideration: CACs get reissued (every 3 years, or if lost/damaged). When legitimate reissue happens, admin must update the hash.




  **Table: user**
  - user_id (PK, auto-increment)
  - user_first
  - user_last
  - user_email
  - user_phone
  - user_dodid
  - user_certificate_dn
  - user_certificate_serial
  - user_account_status
  - user_last_cac_auth
  - user_requires_cac
  - user_piv_auth_cert_hash
  - user_affiliation
  - user_person_designator
  - user_cac_expiry
  - user_role (FK to role.role_id, NOT NULL)
  - sme_role (FK to sme_role.smerole_id, NULLABLE)
  - created_at
  - created_by
  - modified_at
  - modified_by
  - version

  **Data Type Decisions for Scalability:**
  - *user_dodid: BIGINT (more efficient than VARCHAR, handles 10-digit numbers, indexed faster)*
  - *user_account_status: TINYINT with enum (more efficient than strings, prevents invalid values)*
  - *Timestamps: DATETIMEOFFSET (captures time-zone, crucial for global DoD operations)*


  **Table: role**
  - role_id (PK, auto-increment)
  - role_name
  - created_at
  - created_by
  - modified_at
  - modified_by
  - version
    
  **Table: sme_role**
  - smerole_id (PK, auto-increment)
  - smerole_name
  - created_at
  - created_by
  - modified_at
  - modified_by
  - version


##### **📚 ENTITY VERSUS CONFIGURATION EXPLANATION & SECURITY BEST PRACTICES**
---
  What I Mean by "Entities Created but Configurations Not":
```
  Entities (what we created):
  // User.cs - This is the C# class that represents the data
  public class User {
      public int UserId { get; set; }
      public string FirstName { get; set; }
      // etc...
  }

  Configuration Classes (what we need):
  // UserConfiguration.cs - This tells EF Core HOW to map the class to the database
  public class UserConfiguration : IEntityTypeConfiguration<User> {
      Configure() {
          // Maps UserId to "user_id" column
          // Sets up foreign keys
          // Creates indexes
          // Defines constraints
      }
  }
```

```
  Current Status:
  - ✅ Created: User.cs, Role.cs, SmeRole.cs (the entity classes)
  - ✅ Created: UserConfiguration.cs (tells EF how to create the user table)
  - ❌ Missing: RoleConfiguration.cs (needed to properly create role table)
  - ❌ Missing: SmeRoleConfiguration.cs (needed to properly create sme_role table)
```

  Without configurations, EF Core will use conventions (which might not match your exact requirements like column names role_id vs
  default RoleId).

##### **INDUSTRY STANDARD FOR AUDIT TRAIL (SYSTEM_USER)**
---
**DoD/NIST Best Practice** - *"Principle of Least Privilege with System Account":*

The industry standard, especially for government systems, is:
  1. ***Create a SYSTEM user (ID = 1) that:***
    - Cannot log in (no CAC, no password)
    - Is used ONLY for system operations
    - Has account_status = SYSTEM (we'd add this status)
    - Shows clear audit trail (not NULL, not ambiguous)
  2. ***Benefits of SYSTEM user approach:***
    - ✅ Clear accountability - Shows "SYSTEM" did it, **not unknown**
    - ✅ STIG compliant - **Satisfies V-222430** (all actions must be attributable)
    - ✅ No nulls - Maintains **referential integrity**
    - ✅ Auditable - Can **track all system operations**
    - ✅ Standard practice - **Used by SQL Server, Oracle, Windows, etc.**
  3. ***Implementation:***
  -- First record in database
  
```sql
INSERT INTO user (user_id, user_first, user_last, user_email, user_dodid, ...)
VALUES (1, 'SYSTEM', 'ACCOUNT', 'system@iamsng.local', 0, ...);
```

  Final Decisions: 
  4. Yes, create the configuration classes for `Role` and `SmeRole` (ensures proper column names and relationships)
  5. Use `SYSTEM user approach` (ID = 1) for audit trail - this is DoD best practice
  6. Add **seed data for**:
    - SYSTEM user (ID = 1)
    - Initial roles (Administrator, Technician, etc.)

	- Maybe one admin user for first login


###### DATABASE TABLE SUMMARIES:
---
  1. **user table**
  - Purpose: Stores system users with CAC authentication support
  - Key Fields: user_id, user_dodid, user_edipi, user_firstname, user_lastname, user_email, user_piv_auth_cert_hash, user_affiliation, user_person_designator, user_cac_expiry, role_id, sme_role_id
  - Relationships: References role and sme_role tables
  - Seed Data: 1 SYSTEM user (ID=1)

  2. **role table**
  - Purpose: Defines user roles for access control
  - Key Fields: role_id, role_name
  - Seed Data: 8 roles
      1. system (ID=1)
	  2. cyber_user (ID=2)
	  3. tem_user (ID=3)
	  4. dev_user (ID=4)
	  5. cyber_mgr (ID=5)
	  6. tem_mgr (ID=6)
	  7. org_mgr (ID=7)
	  8. sys_admin (ID=8)

  2. **sme_role table**
  - Purpose: Defines Subject Matter Expert specializations
  - Key Fields: sme_role_id, sme_role_name
  - Seed Data: 6 SME roles


  3. **program table**
  - Purpose: Tracks DoD programs that own assets
  - Key Fields: program_id, program_name
  - Relationships: Will have one-to-many with assets
  - Seed Data: 7 programs
      1. IFMC (Legacy: Patriot)
	  2. STORM (Legacy: Himars)
	  3. TAGM (Legacy: TOW)
	  4. SHIELD (Legacy: Avenger)
	  5. MULTI (Legacy: MULTI)
	  6. STARE (Legacy: Sentinel)

  4. **building table**
  - Purpose: Physical buildings where assets are located
  - Key Fields: building_id, building_number (unique)
  - Relationships: One-to-many with rooms
  - Seed Data: 8 buildings
    - Buildings: 370, 010, 012, 001, 014, 350, 377, 403

  6. **floor table**
  - Purpose: Floor/level definitions used across buildings
  - Key Fields: floor_id, floor_number (unique)
  - Relationships: One-to-many with rooms
  - Seed Data: 3 floors
    - Floor 001, Floor 002, Floor Ground

  7. **room table**
  - Purpose: Specific rooms within buildings
  - Key Fields: room_id, room_name, building_id, floor_id
  - Relationships: Many-to-one with building and floor
  - Seed Data: 2 rooms
    - High Power Room (Building 370, Floor Ground)
    - DLU Garage Oversight Bay (Building 370, Floor Ground)

  8. **installation table**
  - Purpose: Military installations/bases with areas of excellence
  - Key Fields: installation_id, installation_name, installation_state, installation_city, installation_area_of_excellence
  - Relationships: Will have one-to-many with assets
  - Seed Data: 52 military installations including:
    - Army Depots (Anniston, Letterkenny, Red River, Sierra, Tobyhanna)
    - Major Forts (Campbell, Cavazos, Liberty, Bliss, Carson, etc.)
    - Arsenals (Rock Island, Watervliet, Picatinny, Pine Bluff, Redstone)
    - Proving Grounds (Aberdeen, Dugway, White Sands, Yuma)
    - Training Centers (Camp Atterbury, Camp Shelby, Fort McCoy, etc.)

==Common Audit Fields (ALL tables)==
Every table includes these audit fields from `BaseEntity`:
  - `created_at`: `DateTimeOffset` - When record was created
  - `created_by`: int - User ID who created the record
  - `modified_at`: DateTimeOffset (nullable) - Last modification timestamp
  - `modified_by`: int (nullable) - User ID who last modified
  - `version`: int - For optimistic locking/concurrency control

**Key Design Features:**
  - FIPS 140-3 Compliant: All security fields support DoD requirements
  - Minimal Data Repetition: Normalized design with proper foreign keys
  - Hierarchical Location: Building → Floor → Room structure
  - DoD-Specific: CAC authentication, military installations, defense programs
  - Audit Trail: Complete audit fields for compliance
  - Ready for Asset Table: All supporting tables in place for main asset tracking

The database is well-structured for the next phase: creating the main Asset table that will reference Program, Installation, Building/Floor/Room, and User tables.












```hardware_manu_icons
/wwwroot/images/manufacturers/
```



#### COMPONENT IDEAS FOR APPLICATION USE: 

`COMPARISON_GRID:`
Comparison before and after idea for asset scap scans, acas scans, and ISPR [industrial security posture rating]
![[Pasted image 20250928192737.png]]


Pair the `COMPARISON_GRID` with a drop down `PROGRAM` selector and a drop down `ASSET` selector, as well as a full text search bar with optimized functionality and `PROGRAM` selector based filtering in combination with it's own optimized text parsing and filtering functionality... 


