using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    public class Nurse
    {
        public string name;
        public int id;
        public InPatient Patient1;
        public OutPatient Patient;
        public Doctor Doctor;

        public void DisplayNurseInfo()
        {
            Console.WriteLine($"Name ; {name}");
            Console.WriteLine($"id : {id}");
            Console.WriteLine($"Assigned to Patient {Patient.name}");
            Console.WriteLine($"Assigned to Doctor {Doctor.name}");
        }



    }
}
