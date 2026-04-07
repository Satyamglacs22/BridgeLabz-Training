using System;
using Microsoft.Data.SqlClient;
using System.IO;

public class SystemAdminUtility : IAdminService
{
    // ================= UC-6.1 =================
    public void AddSpecialty()
    {
        Console.Write("Specialty Name: ");
        string name = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            "INSERT INTO Specialties VALUES(@N)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@N", name);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("✅ Specialty Added");
        }
    }

    public void DeleteSpecialty()
    {
        Console.Write("Specialty ID: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            "DELETE FROM Specialties WHERE SpecialtyId=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("✅ Deleted");
            else
                Console.WriteLine("❌ Cannot Delete (In Use)");
        }
    }

    // ================= UC-6.3 =================
    public void ViewAuditLogs()
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            "SELECT * FROM AuditLogs ORDER BY LogDate DESC";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Audit Logs ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"[{dr["LogDate"]}] " +
                    $"{dr["ActionType"]} - " +
                    $"{dr["TableName"]} - " +
                    $"ID:{dr["RecordId"]}"
                );
            }
        }
    }

    // ================= UC-6.2 =================
    public void BackupDatabase()
    {
        try
        {
            string path =
                @"D:\HealthCareBackup_" +
                DateTime.Now.ToString("yyyyMMdd_HHmm") +
                ".bak";

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                $"BACKUP DATABASE HealthCare TO DISK='{path}'";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Backup Created:");
                Console.WriteLine(path);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Backup Failed: " + ex.Message);
        }
    }
}
