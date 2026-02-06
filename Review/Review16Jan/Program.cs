
using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    public class Program
    {
        public static void Main()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Enter Doctor's Details");
            Console.WriteLine("Enter Name");
            doctor.name = Console.ReadLine();
            Console.WriteLine("Enter Id");
            doctor.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Specilization");
            doctor.specilization = Console.ReadLine();
          

            Console.WriteLine("------------------------------- Details of the Patient----------------------------");

            OutPatient patient = new OutPatient();
            Console.WriteLine("Enter OutPatient Details");
            Console.WriteLine("Enter Patient Name");
            patient.name = Console.ReadLine();
            Console.WriteLine("Enter Patient Age");
            patient.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient Id");
            patient.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doctor Assigned to that Patient");
            patient.doctorAssigned = Console.ReadLine();
            Console.WriteLine("Enter Consultation Fee ");
            patient.ConsultationFee = int.Parse(Console.ReadLine());

            
            patient.Doctor = doctor;

            patient.DisplayInfo();


            InPatient patient1 = new InPatient();
            Console.WriteLine("Enter Details of the InPatient");
            Console.WriteLine("Enter Name of the InPatient");
            patient1.name = Console.ReadLine();
            Console.WriteLine("Enter Age of the Patient ");
            patient1.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id of the Patient");
            patient1.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name of The Doctor assigned to that Patient");

            patient1.doctorAssigned = Console.ReadLine();
            Console.WriteLine("Enter the Consultation fee");
            patient1.ConsultationFee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the No of Days he Stayed in the Hospital");
            patient1.NoOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Per Day Charges");
            patient1.PerDayCharge = int.Parse(Console.ReadLine());

            patient1.Doctor = doctor;

            patient1.DisplayInfo();

            Console.WriteLine("_______________________________________________________Bill Details _____________________________________________________");
            Bill bill = new Bill();
            //bill.GenerateBill(patient1);

            //bill.GenerateBill(patient);
            bool found = false;
            while (!found)
            {
                Console.WriteLine("Enter 1 For InPatient");
                Console.WriteLine("Enter 2 For OutPatient");
                Console.WriteLine("Enter 0 For Exit");
                Console.WriteLine("Enter Choice");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        bill.GenerateBill(patient1);
                        break;

                    case 2:
                        bill.GenerateBill(patient);
                        break;
                    case 0:
                        found = true;
                        break;
                }
            }




        }
    }
}
