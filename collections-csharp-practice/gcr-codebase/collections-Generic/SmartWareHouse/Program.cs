using System;
using System.Text;
using System.Collections.Generic;

namespace SmartWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            Storage<Furniture> furnitureStorage = new Storage<Furniture>();

            int choice;

            do
            {
                Console.WriteLine("\n1. Add Electronics");
                Console.WriteLine("2. Add Groceries");
                Console.WriteLine("3. Add Furniture");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Electronics e = new Electronics();

                        Console.Write("Enter Item ID: ");
                        e.SetItemId(int.Parse(Console.ReadLine()));

                        Console.Write("Enter Item Name: ");
                        e.SetItemName(Console.ReadLine());

                        Console.Write("Enter Warranty Years: ");
                        e.SetWarrantyYears(int.Parse(Console.ReadLine()));

                        electronicsStorage.AddItem(e);
                        break;

                    case 2:
                        Groceries g = new Groceries();

                        Console.Write("Enter Item ID: ");
                        g.SetItemId(int.Parse(Console.ReadLine()));

                        Console.Write("Enter Item Name: ");
                        g.SetItemName(Console.ReadLine());

                        Console.Write("Enter Expiry Date: ");
                        g.SetExpiryDate(Console.ReadLine());

                        groceriesStorage.AddItem(g);
                        break;

                    case 3:
                        Furniture f = new Furniture();

                        Console.Write("Enter Item ID: ");
                        f.SetItemId(int.Parse(Console.ReadLine()));

                        Console.Write("Enter Item Name: ");
                        f.SetItemName(Console.ReadLine());

                        Console.Write("Enter Material: ");
                        f.SetMaterial(Console.ReadLine());

                        furnitureStorage.AddItem(f);
                        break;

                    case 4:
                        electronicsStorage.DisplayAllItems();
                        groceriesStorage.DisplayAllItems();
                        furnitureStorage.DisplayAllItems();
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
