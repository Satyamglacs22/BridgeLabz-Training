using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Hospital_Management_System
{
   

    public abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        // Sensitive data (encapsulated)
        private string diagnosis;

        public int PatientId
        {
            get { return patientId; }
            set
            {
                if (value > 0)
                    patientId = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        // Sensitive data accessed via methods only
        public void SetDiagnosis(string diagnosis)
        {
            if (!string.IsNullOrEmpty(diagnosis))
                this.diagnosis = diagnosis;
        }

        protected string GetDiagnosis()
        {
            return diagnosis;
        }

        // Abstract method
        public abstract double CalculateBill();

        // Concrete method
        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID : " + PatientId);
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
        }
    }


}
