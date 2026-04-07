using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Hospital_Management_System
{



    public class HospitalMain
    {
        public static void Main(string[] args)
        {
            HospitalUtility utility = new HospitalUtility();
            utility.Run();

            Console.ReadLine();
        }
    }


}
