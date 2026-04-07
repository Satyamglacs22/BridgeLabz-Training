using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCheckout
{
    internal class SmartCheckoutMenu
    {
        SmartCheckoutUtility utility = new SmartCheckoutUtility();

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Add Customer");
                Console.WriteLine("2. Process Billing");
                Console.WriteLine("3. Remove Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter customer name: ");
                        string name = Console.ReadLine();
                        Customer customer = new Customer(name);

                        Console.Write("Enter number of items: ");
                        int count = int.Parse(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Enter item name: ");
                            customer.Items.Add(Console.ReadLine());
                        }

                        utility.AddCustomer(customer);
                        break;

                    case 2:
                        utility.ProcessBilling();
                        break;

                    case 3:
                        utility.RemoveCustomer();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
