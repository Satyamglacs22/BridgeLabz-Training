using System;
using Microsoft.Data.SqlClient;

public class AdminUtility : IAdmin
{
    // ================= UC-2.1 =================
    public void AddDoctor()
    {
        try
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Specialty ID: ");
            int spId = int.Parse(Console.ReadLine());

            Console.Write("Fee: ");
            decimal fee = decimal.Parse(Console.ReadLine());

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"INSERT INTO Doctors
                  (Name,Phone,SpecialtyId,Fee)
                  VALUES
                  (@Name,@Phone,@SpId,@Fee)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@SpId", spId);
                cmd.Parameters.AddWithValue("@Fee", fee);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Doctor Added");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-2.2 =================
    public void UpdateDoctorSpecialty()
    {
        try
        {
            Console.Write("Doctor ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("New Specialty ID: ");
            int spId = int.Parse(Console.ReadLine());

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"UPDATE Doctors
                  SET SpecialtyId=@SpId
                  WHERE DoctorId=@Id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SpId", spId);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("✅ Updated");
                else
                    Console.WriteLine("❌ Doctor Not Found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-2.3 =================
    public void ViewDoctors()
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT d.DoctorId,d.Name,d.Phone,
                     s.SpecialtyName,d.Fee
              FROM Doctors d
              JOIN Specialties s
              ON d.SpecialtyId = s.SpecialtyId
              WHERE d.IsActive=1";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Doctors List ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"ID:{dr["DoctorId"]} | " +
                    $"Name:{dr["Name"]} | " +
                    $"Specialty:{dr["SpecialtyName"]} | " +
                    $"Fee:{dr["Fee"]}"
                );
            }
        }
    }

    // ================= UC-2.4 =================
    public void DeactivateDoctor()
    {
        try
        {
            Console.Write("Doctor ID: ");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"UPDATE Doctors
                  SET IsActive=0
                  WHERE DoctorId=@Id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("✅ Doctor Deactivated");
                else
                    Console.WriteLine("❌ Doctor Not Found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }
}
