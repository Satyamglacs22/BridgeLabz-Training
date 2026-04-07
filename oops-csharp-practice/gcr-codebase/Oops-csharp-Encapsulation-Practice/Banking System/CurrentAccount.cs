using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Banking_System
{
    public class CurrentAccount : BankAccount
    {
        public override double CalculateInterest()
        {
            return balance * 0.02; // 2% interest
        }
    }

}
