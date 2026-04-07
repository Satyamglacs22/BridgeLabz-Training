using System;

public class PatientMenu
{
    private readonly IReceptionist rec =
        new ReceptionistUtility();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== Patient Management ===");
            Console.WriteLine("1. Register Patient");
            Console.WriteLine("2. Update Patient");
            Console.WriteLine("3. Search Patient");
            Console.WriteLine("4. View All Patients");
            Console.WriteLine("5. Back");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    rec.RegisterPatient();
                    break;

                case 2:
                    rec.UpdatePatient();
                    break;

                case 3:
                    rec.SearchPatient();
                    break;

                case 4:
                    rec.ViewAllPatients();
                    break;

                case 5:
                    return;
            }
        }
    }
}
