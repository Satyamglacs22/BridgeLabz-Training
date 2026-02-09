using System;

public class AppointmentMenu
{
    private readonly IAppointment service =
        new AppointmentUtility();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== Appointment Management ===");
            Console.WriteLine("1. Book Appointment");
            Console.WriteLine("2. Check Availability");
            Console.WriteLine("3. Cancel Appointment");
            Console.WriteLine("4. Reschedule");
            Console.WriteLine("5. View Daily Schedule");
            Console.WriteLine("6. Back");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    service.BookAppointment();
                    break;

                case 2:
                    service.CheckAvailability();
                    break;

                case 3:
                    service.CancelAppointment();
                    break;

                case 4:
                    service.RescheduleAppointment();
                    break;

                case 5:
                    service.ViewDailySchedule();
                    break;

                case 6:
                    return;
            }
        }
    }
}
