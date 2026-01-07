using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Banking_System
{
   

    public class BankingMain
    {
        public static void Main(string[] args)
        {
            BankUtility utility = new BankUtility();
            utility.Run();

            Console.ReadLine();
        }
    }


}
