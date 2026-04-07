using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    internal class LoanUtility
    {
        public void ProcessLoan()
        {
            Console.Write("Enter Applicant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Credit Score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter Monthly Income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter Loan Amount: ");
            double loanAmount = double.Parse(Console.ReadLine());

            Applicant applicant =
                new Applicant(name, creditScore, income, loanAmount);

            Console.WriteLine("Choose Loan Type");
            Console.WriteLine("1. Home Loan");
            Console.WriteLine("2. Auto Loan");

            int choice = int.Parse(Console.ReadLine());

            LoanApplication loan = null;

            if (choice == 1)
            {
                loan = new HomeLoan(applicant);
            }
            else if (choice == 2)
            {
                loan = new AutoLoan(applicant);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }

            loan.ApproveLoan();

            if (loan.IsApproved())
            {
                Console.WriteLine("Loan Approved");
                Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }
        }
    }
}
