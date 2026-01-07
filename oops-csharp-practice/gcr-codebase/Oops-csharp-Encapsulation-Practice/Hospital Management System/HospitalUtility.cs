using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Hospital_Management_System
{
    

    public class HospitalUtility
    {
        public void Run()
        {
            List<Patient> patients = new List<Patient>();

            Patient inPatient = new InPatient(5, 2000)
            {
                PatientId = 1,
                Name = "Ramesh",
                Age = 45
            };
            inPatient.SetDiagnosis("Pneumonia");

            Patient outPatient = new OutPatient(500)
            {
                PatientId = 2,
                Name = "Suresh",
                Age = 30
            };
            outPatient.SetDiagnosis("Fever");

            patients.Add(inPatient);
            patients.Add(outPatient);

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine("Bill Amount : " + patient.CalculateBill());

                if (patient is IMedicalRecord)
                {
                    IMedicalRecord record = (IMedicalRecord)patient;
                    record.AddRecord("Initial Checkup Done");
                    record.AddRecord("Medicines Prescribed");
                    record.ViewRecords();
                }

                Console.WriteLine("-------------------------------");
            }
        }
    }

}
