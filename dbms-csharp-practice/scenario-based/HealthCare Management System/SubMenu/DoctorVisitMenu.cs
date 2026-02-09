using System;

public class DoctorVisitMenu
{
    private readonly IDoctor doctor =
        new DoctorUtility();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== Doctor Visit Menu ===");
            Console.WriteLine("1. Record Visit");
            Console.WriteLine("2. Add Prescription");
            Console.WriteLine("3. View Medical History");
            Console.WriteLine("4. Back");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    doctor.RecordVisit();
                    break;

                case 2:
                    doctor.AddPrescription();
                    break;

                case 3:
                    doctor.ViewMedicalHistory();
                    break;

                case 4:
                    return;
            }
        }
    }
}
