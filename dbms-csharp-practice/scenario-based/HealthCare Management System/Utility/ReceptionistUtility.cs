using System;
using Microsoft.Data.SqlClient;

public class ReceptionistUtility : IReceptionist
{
    // ================= UC-1.1 =================
    public void RegisterPatient()
    {
        try
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("DOB (yyyy-mm-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Blood Group: ");
            string blood = Console.ReadLine();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"INSERT INTO Patients
                  (Name,DOB,Phone,Email,Address,BloodGroup)
                  VALUES
                  (@Name,@DOB,@Phone,@Email,@Address,@Blood)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Blood", blood);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Patient Registered Successfully");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-1.2 =================
    public void UpdatePatient()
    {
        try
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("New Phone: ");
            string phone = Console.ReadLine();

            Console.Write("New Address: ");
            string address = Console.ReadLine();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"UPDATE Patients
                  SET Phone=@Phone, Address=@Address
                  WHERE PatientId=@Id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("✅ Patient Updated");
                else
                    Console.WriteLine("❌ Patient Not Found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-1.3 =================
    public void SearchPatient()
    {
        Console.Write("Search Name/Phone: ");
        string key = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT * FROM Patients
              WHERE Name LIKE @Key
              OR Phone LIKE @Key";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Key", "%" + key + "%");

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Search Results ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"ID: {dr["PatientId"]} | " +
                    $"Name: {dr["Name"]} | " +
                    $"Phone: {dr["Phone"]}"
                );
            }
        }
    }

    // ================= Extra =================
    public void ViewAllPatients()
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = "SELECT * FROM Patients";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- All Patients ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"ID: {dr["PatientId"]} | " +
                    $"Name: {dr["Name"]} | " +
                    $"Phone: {dr["Phone"]}"
                );
            }
        }
    }
}
