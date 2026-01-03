using System;

// Superclass
class BankAccount
{
    public int accNo;
    public double balance;
}

// SavingsAccount class
class SavingsAccount : BankAccount
{
    public double interestRate;

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine("Account No  : " + accNo);
        Console.WriteLine("Balance     : " + balance);
        Console.WriteLine("Interest    : " + interestRate);
    }
}

// CheckingAccount class
class CheckingAccount : BankAccount
{
    public int withdrawLimit;

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine("Account No  : " + accNo);
        Console.WriteLine("Balance     : " + balance);
        Console.WriteLine("Limit       : " + withdrawLimit);
    }
}

// FixedDepositAccount class
class FixedDepositAccount : BankAccount
{
    public int years;

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Account No  : " + accNo);
        Console.WriteLine("Balance     : " + balance);
        Console.WriteLine("Years       : " + years);
    }
}

class BankAccount1
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount();
        s.accNo = 101;
        s.balance = 50000;
        s.interestRate = 4.5;
        s.DisplayAccountType();

        Console.WriteLine();

        CheckingAccount c = new CheckingAccount();
        c.accNo = 102;
        c.balance = 30000;
        c.withdrawLimit = 10000;
        c.DisplayAccountType();

        Console.WriteLine();

        FixedDepositAccount f = new FixedDepositAccount();
        f.accNo = 103;
        f.balance = 100000;
        f.years = 5;
        f.DisplayAccountType();
    }
}
