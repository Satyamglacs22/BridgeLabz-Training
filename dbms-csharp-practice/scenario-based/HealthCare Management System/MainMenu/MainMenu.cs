using System;

public class MainMenu
{
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== HealthCare System ===");
            Console.WriteLine("1. Patient (UC-1)");
            Console.WriteLine("2. Doctor (UC-2)");
            Console.WriteLine("3. Appointment (UC-3)");
            Console.WriteLine("4. Medical (UC-4)");
            Console.WriteLine("5. Billing (UC-5)");
            Console.WriteLine("6. Admin (UC-6)");
            Console.WriteLine("7. Exit");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    new PatientMenu().Show();
                    break;

                case 2:
                    new DoctorMenu().Show();
                    break;

                case 3:
                    new AppointmentMenu().Show();
                    break;

                case 4:
                    new DoctorVisitMenu().Show();
                    break;

                case 5:
                    new BillingMenu().Show();
                    break;

                case 6:
                    new AdminMenu().Show();
                    break;

                case 7:
                    return;
            }
        }
    }
}
