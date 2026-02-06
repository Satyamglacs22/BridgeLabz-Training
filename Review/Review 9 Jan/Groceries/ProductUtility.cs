using System;
using System.Collections.Generic;

namespace Groceries
{
    public class ProductUtility
    {
        List<Product> products = new List<Product>();

        // ADMIN: Add multiple products
        public void AddProducts()
        {
            Console.Write("How many products you want to add: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Product p = new Product();

                Console.Write("Enter Product Name: ");
                p.ProductName = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.Price = int.Parse(Console.ReadLine());

                Console.Write("Enter Quantity: ");
                p.Quantity = int.Parse(Console.ReadLine());

                products.Add(p);
                Console.WriteLine("Product Added Successfully!\n");
            }
        }

        // ADMIN / USER: View products
        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No Products Available");
                return;
            }

            Console.WriteLine("\n--- Product List ---");
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.ProductName} | Price: {p.Price} | Quantity: {p.Quantity}");
            }
        }

        // USER: Buy multiple items with bill
        public void BuyProducts()
        {
            int totalBill = 0;
            bool buyMore = true;

            while (buyMore)
            {
                Console.Write("Enter product name to buy: ");
                string name = Console.ReadLine();

                Product found = products.Find(p =>
                    p.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase));

                if (found == null)
                {
                    Console.WriteLine("Product not found!");
                }
                else
                {
                    Console.Write("Enter quantity to buy: ");
                    int qty = int.Parse(Console.ReadLine());

                    if (qty <= found.Quantity)
                    {
                        int cost = qty * found.Price;
                        totalBill += cost;
                        found.Quantity -= qty;

                        Console.WriteLine($"Item added to bill: {found.ProductName}");
                        Console.WriteLine($"Cost: {cost}");
                        Console.WriteLine($"Remaining Quantity: {found.Quantity}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient stock!");
                    }
                }

                Console.Write("Do you want to buy more items? (yes/no): ");
                buyMore = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine("\n--- FINAL BILL ---");
            Console.WriteLine($"Total Amount to Pay: {totalBill}");
        }
    }
}
