using System;

public class DoctorMenu
{
    private readonly IAdmin admin =
        new AdminUtility();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== Doctor Management ===");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Specialty");
            Console.WriteLine("3. View Doctors");
            Console.WriteLine("4. Deactivate Doctor");
            Console.WriteLine("5. Back");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    admin.AddDoctor();
                    break;

                case 2:
                    admin.UpdateDoctorSpecialty();
                    break;

                case 3:
                    admin.ViewDoctors();
                    break;

                case 4:
                    admin.DeactivateDoctor();
                    break;

                case 5:
                    return;
            }
        }
    }
}
