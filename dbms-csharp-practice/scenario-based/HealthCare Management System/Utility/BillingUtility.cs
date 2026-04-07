using System;
using Microsoft.Data.SqlClient;

public class BillingUtility : IBilling
{
    // ================= UC-5.1 =================
    public void GenerateBill()
    {
        try
        {
            Console.Write("Visit ID: ");
            int vid = int.Parse(Console.ReadLine());

            Console.Write("Patient ID: ");
            int pid = int.Parse(Console.ReadLine());

            Console.Write("Consultation Fee: ");
            decimal fee = decimal.Parse(Console.ReadLine());

            Console.Write("Other Charges: ");
            decimal other = decimal.Parse(Console.ReadLine());

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                @"INSERT INTO Bills
                  (VisitId,PatientId,ConsultationFee,OtherCharges)
                  VALUES
                  (@V,@P,@F,@O)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@V", vid);
                cmd.Parameters.AddWithValue("@P", pid);
                cmd.Parameters.AddWithValue("@F", fee);
                cmd.Parameters.AddWithValue("@O", other);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Bill Generated");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    // ================= UC-5.2 =================
    public void RecordPayment()
    {
        try
        {
            Console.Write("Bill ID: ");
            int bid = int.Parse(Console.ReadLine());

            Console.Write("Amount Paid: ");
            decimal amt = decimal.Parse(Console.ReadLine());

            Console.Write("Payment Mode (Cash/Card/UPI): ");
            string mode = Console.ReadLine();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    // Insert Payment
                    string payQuery =
                    @"INSERT INTO Payments
                      (BillId,AmountPaid,PaymentMode)
                      VALUES
                      (@B,@A,@M)";

                    SqlCommand cmd1 =
                        new SqlCommand(payQuery, con, tx);

                    cmd1.Parameters.AddWithValue("@B", bid);
                    cmd1.Parameters.AddWithValue("@A", amt);
                    cmd1.Parameters.AddWithValue("@M", mode);

                    cmd1.ExecuteNonQuery();

                    // Update Bill Status
                    string billQuery =
                    @"UPDATE Bills
                      SET PaymentStatus='PAID'
                      WHERE BillId=@Id";

                    SqlCommand cmd2 =
                        new SqlCommand(billQuery, con, tx);

                    cmd2.Parameters.AddWithValue("@Id", bid);

                    cmd2.ExecuteNonQuery();

                    tx.Commit();

                    Console.WriteLine("✅ Payment Recorded");
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

    // ================= UC-5.3 =================
    public void ViewPendingBills()
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT b.BillId,
                     p.Name,
                     b.TotalAmount,
                     b.BillDate
              FROM Bills b
              JOIN Patients p
              ON b.PatientId=p.PatientId
              WHERE b.PaymentStatus='UNPAID'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n--- Pending Bills ---");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"BillID:{dr["BillId"]} | " +
                    $"Patient:{dr["Name"]} | " +
                    $"Amount:{dr["TotalAmount"]} | " +
                    $"Date:{dr["BillDate"]}"
                );
            }
        }
    }

    // ================= UC-5.4 =================
    public void RevenueReport()
    {
        Console.Write("From Date (yyyy-mm-dd): ");
        DateTime from = DateTime.Parse(Console.ReadLine());

        Console.Write("To Date (yyyy-mm-dd): ");
        DateTime to = DateTime.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query =
            @"SELECT SUM(b.TotalAmount) AS TotalRevenue,
                     COUNT(b.BillId) AS TotalBills
              FROM Bills b
              WHERE b.BillDate
              BETWEEN @F AND @T
              AND b.PaymentStatus='PAID'";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@F", from);
            cmd.Parameters.AddWithValue("@T", to);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Console.WriteLine("\n--- Revenue Report ---");
                Console.WriteLine("Total Bills: " + dr["TotalBills"]);
                Console.WriteLine("Total Revenue: " + dr["TotalRevenue"]);
            }
        }
    }
}
