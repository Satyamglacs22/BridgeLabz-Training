using System;
using System.Collections.Generic;
using System.Text;


class User
{
    public string Name;
    public string Address;
    public string Number;
}

class Bank
{
    public string BankName;
    public string IFSC;
    public string Address;

    public BankAccount CreateAccount(int acc, double initial, User user)
    {
        BankAccount b = new BankAccount();
        b.AccountNumber = acc;
        b.Balance = initial;
        b.user = user;
        b.bank = this;
        return b;
    }

    public void ShowBankDetails()
    {
        Console.WriteLine("Bank Name : " + BankName);
        Console.WriteLine("IFSC      : " + IFSC);
        Console.WriteLine("Address   : " + Address);
    }
}

class BankAccount
{
    public int AccountNumber;
    public double Balance;
    public Bank bank;
    public User user;

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        double d = amount;
        if (amount > Balance)
            Console.WriteLine("Insufficient Balance");
        else
        {
            double check = Balance - d;
            if (check < 5000)
            {
                Console.WriteLine($"Cannot WithDrawl {d} , Enter Some Other Amount Less than {d}. ");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Balance: " + Balance);
    }

    public void ShowAccountDetails()
    {
        Console.WriteLine("Account No : " + AccountNumber);
        Console.WriteLine("Holder    : " + user.Name);
        Console.WriteLine("Address :" + user.Address);
        Console.WriteLine("Mobile Number : " + user.Number);
        Console.WriteLine("Bank      : " + bank.BankName);
        Console.WriteLine("IFSC      : " + bank.IFSC);
    }
}

class Banking
{
    static void Main()
    {
        Bank bank = new Bank();
        bank.BankName = "State Bank of India";
        bank.IFSC = "SBIN0001234";
        bank.Address = "New Delhi";

        User user = new User();
        //user.Name = Console.ReadLine();
        //user.Address = Console.ReadLine();
        //user.Number = Console.ReadLine();

        BankAccount account = null;
        bool exitApp = false;

        // ================= MAIN LOOP =================
        while (!exitApp)
        {
            Console.WriteLine("\n--- MAIN MENU ---");
            Console.WriteLine("1. Bank (Admin)");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit Application");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                // ================= ADMIN MENU =================
                case 1:
                    bool exitAdmin = false;

                    while (!exitAdmin)
                    {
                        Console.WriteLine("\n--- BANK (ADMIN) MENU ---");
                        Console.WriteLine("1. Create Account");
                        Console.WriteLine("2. Show Bank Details");
                        Console.WriteLine("3. Exit Admin Menu");
                        Console.Write("Enter choice: ");
                        int bChoice = int.Parse(Console.ReadLine());

                        switch (bChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter UserName");

                                user.Name = Console.ReadLine();
                                Console.WriteLine("Enter User Address");
                                user.Address = Console.ReadLine();
                                Console.WriteLine("Enter User Mobile Number");
                                user.Number = Console.ReadLine();
                                account = bank.CreateAccount(101, 5000, user);
                                Console.WriteLine("Account Created Successfully");
                                break;

                            case 2:
                                bank.ShowBankDetails();
                                break;

                            case 3:
                                exitAdmin = true; 
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    break;

                // ================= USER MENU =================
                case 2:
                    if (account == null)
                    {
                        Console.WriteLine("No account found. Please create account first.");
                        break;
                    }

                    bool exitUser = false;

                    while (!exitUser)
                    {
                        Console.WriteLine("\n--- USER MENU ---");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Check Balance");
                        Console.WriteLine("4. Show Account Details");
                        Console.WriteLine("5. Exit User Menu");
                        Console.Write("Enter choice: ");
                        int uChoice = int.Parse(Console.ReadLine());

                        switch (uChoice)
                        {
                            case 1:
                                Console.Write("Enter amount: ");
                                account.Deposit(double.Parse(Console.ReadLine()));
                                break;

                            case 2:
                                Console.Write("Enter amount: ");
                                account.Withdraw(double.Parse(Console.ReadLine()));
                                break;

                            case 3:
                                account.CheckBalance();
                                break;

                            case 4:
                                account.ShowAccountDetails();
                                break;

                            case 5:
                                exitUser = true; 
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    break;

                // ================= EXIT APPLICATION =================
                case 3:
                    exitApp = true;
                    Console.WriteLine("Thank You!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
