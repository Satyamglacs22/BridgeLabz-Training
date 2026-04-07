using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Banking_System
{
    

    public abstract class BankAccount
    {
        private int accountNumber;
        private string holderName;
        protected double balance;

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value > 0)
                    accountNumber = value;
            }
        }

        public string HolderName
        {
            get { return holderName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    holderName = value;
            }
        }

        public double Balance
        {
            get { return balance; }
            protected set
            {
                if (value >= 0)
                    balance = value;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public abstract double CalculateInterest();

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account No   : " + AccountNumber);
            Console.WriteLine("Holder Name  : " + HolderName);
            Console.WriteLine("Balance      : " + Balance);
        }
    }


}
