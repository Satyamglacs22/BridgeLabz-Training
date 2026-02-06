using Review1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
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
