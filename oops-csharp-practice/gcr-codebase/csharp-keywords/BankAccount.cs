using System;

class BankAccount
{
    // static variable (shared by all accounts)
    public static string bankName = "State Bank";

    // static variable to count accounts
    public static int totalAccounts = 0;

    // readonly variable (cannot be changed later)
    public readonly int AccountNumber;

    // normal instance variable
    public string AccountHolderName;

    // constructor
    public BankAccount(int accountNumber, string accountHolderName)
    {
        // using this keyword to avoid confusion
        this.AccountNumber = accountNumber;
        this.AccountHolderName = accountHolderName;
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // method to display details
    public void Display()
    {
        Console.WriteLine("Bank Name : " + bankName);
        Console.WriteLine("Account No: " + AccountNumber);
        Console.WriteLine("Holder    : " + AccountHolderName);
    }

    static void Main()
    {
        BankAccount acc = new BankAccount(101, "Rohit");

        // using is operator
        if (acc is BankAccount)
        {
            acc.Display();
        }

        BankAccount.GetTotalAccounts();
    }
}
