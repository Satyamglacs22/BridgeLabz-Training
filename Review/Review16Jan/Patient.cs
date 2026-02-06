using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
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
