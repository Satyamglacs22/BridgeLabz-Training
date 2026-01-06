using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    public class Doctor
    {
        public string name;
        public int id;
        public string specilization;

        public void DisplayDoctorInfo()
        {
            Console.WriteLine($"Doctor's Name : {name}");
            Console.WriteLine($"Doctor's id : {id}");
            Console.WriteLine($"Doctor's Specilization : {specilization}");
        }
    }
}
