using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    public class Bill
    {
        public void GenerateBill(IPayable Payable)
        {
            int amount = Payable.Fee();

            Console.WriteLine($"Bill Amount is : {amount}");

        }
    }
}
