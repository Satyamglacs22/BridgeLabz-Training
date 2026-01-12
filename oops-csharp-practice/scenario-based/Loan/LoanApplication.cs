using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    internal abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected int term;
        protected double interestRate;

        private bool isApproved;

        public LoanApplication(Applicant applicant, int term, double interestRate)
        {
            this.applicant = applicant;
            this.term = term;
            this.interestRate = interestRate;
            this.isApproved = false;
        }

        protected void SetApprovalStatus(bool status)
        {
            isApproved = status;
        }

        public bool IsApproved()
        {
            return isApproved;
        }

        public abstract void ApproveLoan();
        public abstract double CalculateEMI();
    }
}
