using System;

public class BillingMenu
{
    private readonly IBilling billing =
        new BillingUtility();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== Billing System ===");
            Console.WriteLine("1. Generate Bill");
            Console.WriteLine("2. Record Payment");
            Console.WriteLine("3. View Pending Bills");
            Console.WriteLine("4. Revenue Report");
            Console.WriteLine("5. Back");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    billing.GenerateBill();
                    break;

                case 2:
                    billing.RecordPayment();
                    break;

                case 3:
                    billing.ViewPendingBills();
                    break;

                case 4:
                    billing.RevenueReport();
                    break;

                case 5:
                    return;
            }
        }
    }
}
