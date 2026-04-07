using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Banking_System
{
   

    public class BankUtility
    {
        public void Run()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            BankAccount savings = new SavingsAccount
            {
                AccountNumber = 101,
                HolderName = "Rahul"
            };
            savings.Deposit(10000);

            BankAccount current = new CurrentAccount
            {
                AccountNumber = 102,
                HolderName = "Amit"
            };
            current.Deposit(20000);

            accounts.Add(savings);
            accounts.Add(current);

            foreach (BankAccount account in accounts)
            {
                account.DisplayAccountDetails();
                Console.WriteLine("Interest     : " + account.CalculateInterest());

                if (account is ILoanable)
                {
                    ILoanable loan = (ILoanable)account;
                    Console.WriteLine("Loan Eligible: " + loan.CalculateLoanEligibility());
                    loan.ApplyForLoan(50000);
                }

                Console.WriteLine("----------------------------");
            }
        }
    }


}
