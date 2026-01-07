using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Hospital_Management_System
{
    

    public class InPatient : Patient, IMedicalRecord
    {
        private int numberOfDays;
        private double perDayCharge;
        private List<string> medicalRecords = new List<string>();

        public InPatient(int days, double charge)
        {
            if (days > 0)
                numberOfDays = days;

            if (charge > 0)
                perDayCharge = charge;
        }

        public override double CalculateBill()
        {
            return numberOfDays * perDayCharge;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (string record in medicalRecords)
            {
                Console.WriteLine("- " + record);
            }
        }
    }


}
