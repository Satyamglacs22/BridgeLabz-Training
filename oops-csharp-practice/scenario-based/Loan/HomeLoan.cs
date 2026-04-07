using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    internal class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant)
            : base(applicant, 240, 0.08)   // 20 years
        {
        }

        public override void ApproveLoan()
        {
            if (applicant.CreditScore >= 700 && applicant.Income >= 50000)
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
