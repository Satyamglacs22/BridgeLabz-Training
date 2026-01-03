using System;

class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    public void SetBalance(double b)
    {
        balance = b;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : BankAccount
{
    public void Show()
    {
        Console.WriteLine(accountNumber + " - " + accountHolder);
    }

    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        sa.accountNumber = 1001;
        sa.accountHolder = "Suresh";
        sa.SetBalance(5000);

        sa.Show();
        Console.WriteLine("Balance : " + sa.GetBalance());
    }
}
