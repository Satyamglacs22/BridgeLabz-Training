using System;
using System.Collections.Generic;
using System.Text;

class Invoice
{
    // Method to split invoice string into tasks
    public string[] ParseInvoice(string input)
    {
        return input.Split(',');
    }

    // Method to calculate total amount
    public int GetTotalAmount(string[] tasks)
    {
        int total = 0;

        foreach (string task in tasks)
        {
            string[] parts = task.Split('-');

            if (parts.Length == 2)
            {
                string amountPart = parts[1].Trim();   // "3000 INR"
                string[] amountArr = amountPart.Split(' ');

                int amount = int.Parse(amountArr[0]);
                total += amount;
            }
        }
        return total;
    }

    // Method to display invoice
    public void DisplayInvoice(string[] tasks)
    {
        Console.WriteLine("\n--- INVOICE DETAILS ---");
        foreach (string task in tasks)
        {
            Console.WriteLine(task.Trim());
        }
    }
}

class Freelancers
{
    static void Main()
    {
        Invoice invoice = new Invoice();
        string[] tasks = null;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- INVOICE GENERATOR MENU ---");
            Console.WriteLine("1. Enter Invoice");
            Console.WriteLine("2. Show Invoice");
            Console.WriteLine("3. Show Total Amount");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nEnter invoice string:");
                    Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");
                    string input = Console.ReadLine();

                    tasks = invoice.ParseInvoice(input);
                    Console.WriteLine("Invoice saved successfully.");
                    break;

                case 2:
                    if (tasks == null)
                    {
                        Console.WriteLine("No invoice found. Please enter invoice first.");
                    }
                    else
                    {
                        invoice.DisplayInvoice(tasks);
                    }
                    break;

                case 3:
                    if (tasks == null)
                    {
                        Console.WriteLine("No invoice found. Please enter invoice first.");
                    }
                    else
                    {
                        int total = invoice.GetTotalAmount(tasks);
                        Console.WriteLine("Total Invoice Amount: " + total + " INR");
                    }
                    break;

                case 4:
                    exit = true;
                    Console.WriteLine("Invoice Generator Terminated.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
