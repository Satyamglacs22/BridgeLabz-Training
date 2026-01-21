using System;
using System.Collections.Generic;

namespace SmartCheckout
{
    internal class SmartCheckoutUtility : ISmartCheckout
    {
        private Queue<Customer> customerQueue;
        private Dictionary<string, Item> itemMap;

        public SmartCheckoutUtility()
        {
            customerQueue = new Queue<Customer>();
            itemMap = new Dictionary<string, Item>();

            // Preload items (can be made user-input also)
            itemMap.Add("Milk", new Item("Milk", 50, 10));
            itemMap.Add("Bread", new Item("Bread", 30, 20));
            itemMap.Add("Rice", new Item("Rice", 60, 15));
        }

        // Add customer to queue
        public void AddCustomer(Customer customer)
        {
            customerQueue.Enqueue(customer);
            Console.WriteLine("Customer added to billing queue.");
        }

        // Remove customer from queue
        public void RemoveCustomer()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Customer removed = customerQueue.Dequeue();
            Console.WriteLine($"Customer {removed.CustomerName} removed from queue.");
        }

        // Billing process
        public void ProcessBilling()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }

            Customer customer = customerQueue.Dequeue();
            double totalBill = 0;

            Console.WriteLine($"\nBilling for {customer.CustomerName}");

            foreach (string itemName in customer.Items)
            {
                if (itemMap.ContainsKey(itemName))
                {
                    Item item = itemMap[itemName];

                    if (item.Stock > 0)
                    {
                        totalBill += item.Price;
                        item.Stock--;
                        Console.WriteLine($"{itemName} - ₹{item.Price}");
                    }
                    else
                    {
                        Console.WriteLine($"{itemName} - Out of Stock");
                    }
                }
                else
                {
                    Console.WriteLine($"{itemName} not available.");
                }
            }

            Console.WriteLine($"Total Bill: ₹{totalBill}\n");
        }
    }
}
