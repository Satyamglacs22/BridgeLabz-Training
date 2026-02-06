using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{

//    Hospital Patient Management System
//● Concepts: Patient, Doctor, Bill classes.
//● OOP: Encapsulation (Properties), Abstraction (Interface IPayable), Inheritance
//(InPatient, OutPatient : Patient), Polymorphism(DisplayInfo).

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
