using System;
using Microsoft.Data.SqlClient;

public class DoctorUtility : IDoctor
{
    // ================= UC-4.1 =================
    public void RecordVisit()
    {
        try
        {
            Console.Write("Appointment ID: ");
            int appId = int.Parse(Console.ReadLine());

            Console.Write("Patient ID: ");
            int pid = int.Parse(Console.ReadLine());

            Console.Write("Doctor ID: ");
            int did = int.Parse(Console.ReadLine());

            Console.Write("Diagnosis: ");
            string diagnosis = Console.ReadLine();

            Console.Write("Notes: ");
            string notes = Console.ReadLine();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    // Insert Visit
                    string visitQuery =
                    @"INSERT INTO Visits
                      (AppointmentId,PatientId,DoctorId,Diagnosis,Notes)
                      VALUES
                      (@A,@P,@D,@Diag,@Note)";

                    SqlCommand cmd =
                        new SqlCommand(visitQuery, con, tx);

                    cmd.Parameters.AddWithValue("@A", appId);
                    cmd.Parameters.AddWithValue("@P", pid);
                    cmd.Parameters.AddWithValue("@D", did);
                    cmd.Parameters.AddWithValue("@Diag", diagnosis);
                    cmd.Parameters.AddWithValue("@Note", notes);

                    cmd.ExecuteNonQuery();

                    // Update Appointment Status
                    string updateQuery =
                    @"UPDATE Appointments
                      SET Status='COMPLETED'
                      WHERE AppointmentId=@Id";

                    SqlCommand cmd2 =
                        new SqlCommand(updateQuery, con, tx);

                    cmd2.Parameters.AddWithValue("@Id", appId);

                    cmd2.ExecuteNonQuery();

                    tx.Commit();

                    Console.WriteLine("✅ Visit Recorded");
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-4.3 =================
    public void AddPrescription()
    {
        try
        {
            Console.Write("Visit ID: ");
            int vid = int.Parse(Console.ReadLine());

            Console.Write("Medicine Name: ");
            string med = Console.ReadLine();

            Console.Write("Dosage: ");
            string dose = Console.ReadLine();

            Console.Write("Duration: ");
            string duration = Console.ReadLine();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"INSERT INTO Prescriptions
                  (VisitId,MedicineName,Dosage,Duration)
                  VALUES
                  (@V,@M,@D,@Du)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@V", vid);
                cmd.Parameters.AddWithValue("@M", med);
                cmd.Parameters.AddWithValue("@D", dose);
                cmd.Parameters.AddWithValue("@Du", duration);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Prescription Added");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-4.2 =================
    public void ViewMedicalHistory()
    {
        Console.Write("Patient ID: ");
        int pid = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT v.VisitDate,
                     v.Diagnosis,
                     v.Notes,
                     p.MedicineName,
                     p.Dosage,
                     p.Duration
              FROM Visits v
              LEFT JOIN Prescriptions p
              ON v.VisitId = p.VisitId
              WHERE v.PatientId=@Id
              ORDER BY v.VisitDate DESC";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", pid);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Medical History ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"Date: {dr["VisitDate"]}\n" +
                    $"Diagnosis: {dr["Diagnosis"]}\n" +
                    $"Medicine: {dr["MedicineName"]}\n" +
                    $"Dosage: {dr["Dosage"]}\n" +
                    $"Duration: {dr["Duration"]}\n"
                );
            }
        }
    }
}
