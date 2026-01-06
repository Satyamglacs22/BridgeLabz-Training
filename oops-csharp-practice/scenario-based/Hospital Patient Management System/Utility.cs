using System;

namespace Hospital_Patient_Management_System
{
    public class Utility
    {
        public static void Main()
        {
            Doctor doctor = new Doctor();
            doctor.name = "Satyam Singh";
            doctor.id = 101;
            doctor.specilization = "Surgeon";
            //doctor.DisplayDoctorInfo();

            Console.WriteLine("________________________________________________Patient Details __________________________________________________");

            OutPatient patient = new OutPatient();
            patient.name = "Prateek";
            patient.age = 22;
            patient.id = 202;
            patient.doctorAssigned = "Satyam Singh";
            patient.consultationFee = 500;

            // IMPORTANT LINE
            patient.Doctor = doctor;

            patient.DisplayInfo();


            InPatient patient1 = new InPatient();
            patient1.name = "Kailash";
            patient1.age = 26;
            patient1.id = 203;

            patient1.doctorAssigned = "Satyam Singh";
            patient1.ConsultationFee = 500;
            patient1.noOfDays = 3;
            patient1.perDayCharge = 200;

            patient1.Doctor = doctor;

            patient1.DisplayInfo();

            Console.WriteLine("_______________________________________________________Bill Details _____________________________________________________");
            Bill bill = new Bill();
            bill.GenerateBill(patient1);

            bill.GenerateBill(patient);


            Console.WriteLine("____________________________________________________________Nurse Details________________________________________________________");
            Nurse nurse = new Nurse();
            nurse.name = "female";
            nurse.id = 101110;
            nurse.Doctor = doctor;
            nurse.Patient = patient;
            nurse.DisplayNurseInfo();


        }
    }
}
