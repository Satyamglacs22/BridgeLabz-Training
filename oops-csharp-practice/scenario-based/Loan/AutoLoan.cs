using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    internal class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant)
            : base(applicant, 60, 0.10)   // 5 years
        {
        }

        public override void ApproveLoan()
        {
            if (applicant.CreditScore >= 650 && applicant.Income >= 30000)
            {
                SetApprovalStatus(true);
            }
        }

        public override double CalculateEMI()
        {
            double P = applicant.LoanAmount;
            double R = interestRate / 12;
            int N = term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }
    }
}
