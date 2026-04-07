using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Banking_System
{
    public interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }


}
