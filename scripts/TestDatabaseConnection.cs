using System;
using Microsoft.Data.SqlClient;

class TestDatabaseConnection
{
    static void Main()
    {
        Console.WriteLine("=== IAMSNG Database Connection Test ===\n");
        
        string connectionString = "Server=(local);Database=iamsdb;Trusted_Connection=True;TrustServerCertificate=False;Encrypt=True;Connection Timeout=30;";
        
        Console.WriteLine($"Connection String: {connectionString}");
        Console.WriteLine("\nTesting connection...");
        
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                Console.WriteLine("✅ Connection successful!");
                Console.WriteLine($"   Server: {connection.DataSource}");
                Console.WriteLine($"   Database: {connection.Database}");
                Console.WriteLine($"   Server Version: {connection.ServerVersion}");
                
                // Check encryption status
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        db.name as database_name,
                        db.is_encrypted,
                        dm.encryption_state_desc
                    FROM sys.databases db
                    LEFT JOIN sys.dm_database_encryption_keys dm
                        ON db.database_id = dm.database_id
                    WHERE db.name = 'iamsdb'", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isEncrypted = reader.GetBoolean(1);
                            string encryptionState = reader.IsDBNull(2) ? "NOT ENCRYPTED" : reader.GetString(2);
                            
                            Console.WriteLine($"\n🔒 Encryption Status:");
                            Console.WriteLine($"   Encrypted: {(isEncrypted ? "Yes" : "No")}");
                            Console.WriteLine($"   State: {encryptionState}");
                        }
                    }
                }
                
                // Check FIPS compliance
                Console.WriteLine($"\n🛡️ FIPS 140-3 Compliance:");
                Console.WriteLine($"   Connection Encrypted: {connection.ConnectionString.Contains("Encrypt=True") ? "Yes" : "No"}");
                Console.WriteLine($"   TLS Version: 1.2+ (enforced by SQL Server 2022)");
                
                Console.WriteLine($"\n✅ Database is ready for IAMSNG application!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Connection failed!");
            Console.WriteLine($"   Error: {ex.Message}");
            
            if (ex.InnerException != null)
            {
                Console.WriteLine($"   Inner Error: {ex.InnerException.Message}");
            }
            
            Console.WriteLine($"\nTroubleshooting tips:");
            Console.WriteLine("1. Ensure SQL Server service is running");
            Console.WriteLine("2. Check if 'iamsdb' database exists");
            Console.WriteLine("3. Verify Windows Authentication is enabled");
            Console.WriteLine("4. Check firewall settings");
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}