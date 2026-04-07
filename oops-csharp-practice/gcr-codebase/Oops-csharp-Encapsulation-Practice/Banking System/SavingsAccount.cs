using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Banking_System
{
    public class SavingsAccount : BankAccount, ILoanable
    {
        public override double CalculateInterest()
        {
            return balance * 0.04; // 4% interest
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine("Loan Applied for Amount: " + amount);
        }

        public double CalculateLoanEligibility()
        {
            return balance * 5; // 5x of balance
        }
    }


}
