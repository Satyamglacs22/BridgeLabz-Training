using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    public class Patient
    {
        public string name;
        public int age;
        public int id;
        public string doctorAssigned;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Patient Name :{name}");
            Console.WriteLine($"Patient Age :{age}");
            Console.WriteLine($"Patient id :{id}");
            Console.WriteLine($"Doctor's Assigned : {doctorAssigned}");
        }
    }
}
