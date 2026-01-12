using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoanUtility utility = new LoanUtility();
            utility.ProcessLoan();
        }
    }
}
