using System;
using Microsoft.Data.SqlClient;

public class AppointmentUtility : IAppointment
{
    // ================= UC-3.1 =================
    public void BookAppointment()
    {
        try
        {
            Console.Write("Patient ID: ");
            int pid = int.Parse(Console.ReadLine());

            Console.Write("Doctor ID: ");
            int did = int.Parse(Console.ReadLine());

            Console.Write("Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Time (HH:mm): ");
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());

            using (SqlConnection con = DBConnection.GetConnection())
            {
                // Check slot
                string checkQuery =
                @"SELECT COUNT(*) FROM Appointments
                  WHERE DoctorId=@DId
                  AND AppointmentDate=@Date
                  AND AppointmentTime=@Time
                  AND Status='SCHEDULED'";

                SqlCommand checkCmd =
                    new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@DId", did);
                checkCmd.Parameters.AddWithValue("@Date", date);
                checkCmd.Parameters.AddWithValue("@Time", time);

                con.Open();

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    Console.WriteLine("❌ Slot Already Booked");
                    return;
                }

                // Insert
                string query =
                @"INSERT INTO Appointments
                  (PatientId,DoctorId,AppointmentDate,AppointmentTime)
                  VALUES
                  (@PId,@DId,@Date,@Time)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PId", pid);
                cmd.Parameters.AddWithValue("@DId", did);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Time", time);

                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Appointment Booked");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-3.2 =================
    public void CheckAvailability()
    {
        Console.Write("Doctor ID: ");
        int did = int.Parse(Console.ReadLine());

        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT AppointmentTime
              FROM Appointments
              WHERE DoctorId=@Id
              AND AppointmentDate=@Date
              AND Status='SCHEDULED'";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", did);
            cmd.Parameters.AddWithValue("@Date", date);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Booked Slots ---");

            while (dr.Read())
            {
                Console.WriteLine(dr["AppointmentTime"]);
            }
        }
    }

    // ================= UC-3.3 =================
    public void CancelAppointment()
    {
        Console.Write("Appointment ID: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"UPDATE Appointments
              SET Status='CANCELLED'
              WHERE AppointmentId=@Id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("✅ Appointment Cancelled");
            else
                Console.WriteLine("❌ Not Found");
        }
    }

    // ================= UC-3.4 =================
    public void RescheduleAppointment()
    {
        try
        {
            Console.Write("Appointment ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("New Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("New Time (HH:mm): ");
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"UPDATE Appointments
                  SET AppointmentDate=@Date,
                      AppointmentTime=@Time
                  WHERE AppointmentId=@Id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Time", time);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("✅ Rescheduled");
                else
                    Console.WriteLine("❌ Not Found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-3.5 =================
    public void ViewDailySchedule()
    {
        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT a.AppointmentId,
                     p.Name AS Patient,
                     d.Name AS Doctor,
                     a.AppointmentTime,
                     a.Status
              FROM Appointments a
              JOIN Patients p ON a.PatientId=p.PatientId
              JOIN Doctors d ON a.DoctorId=d.DoctorId
              WHERE a.AppointmentDate=@Date
              ORDER BY a.AppointmentTime";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Date", date);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Daily Schedule ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"ID:{dr["AppointmentId"]} | " +
                    $"Patient:{dr["Patient"]} | " +
                    $"Doctor:{dr["Doctor"]} | " +
                    $"Time:{dr["AppointmentTime"]} | " +
                    $"Status:{dr["Status"]}"
                );
            }
        }
    }
}
