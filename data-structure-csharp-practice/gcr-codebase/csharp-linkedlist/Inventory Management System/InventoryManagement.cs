using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Inventory_Management_System
{
    // Node Class
    public class ItemNode
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;
        public ItemNode Next;

        public ItemNode(int id, string name, int qty, double price)
        {
            ItemId = id;
            ItemName = name;
            Quantity = qty;
            Price = price;
            Next = null;
        }
    }

    // Singly Linked List Class
    public class InventoryLinkedList
    {
        private ItemNode head;

        // Add at Beginning
        public void AddAtBeginning(int id, string name, int qty, double price)
        {
            ItemNode node = new ItemNode(id, name, qty, price);
            node.Next = head;
            head = node;
        }

        // Add at End
        public void AddAtEnd(int id, string name, int qty, double price)
        {
            ItemNode node = new ItemNode(id, name, qty, price);

            if (head == null)
            {
                head = node;
                return;
            }

            ItemNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = node;
        }

        // Remove Item by ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            if (head.ItemId == id)
            {
                head = head.Next;
                Console.WriteLine("Item removed successfully");
                return;
            }

            ItemNode temp = head;
            while (temp.Next != null && temp.Next.ItemId != id)
                temp = temp.Next;

            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Item removed successfully");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        // Update Quantity
        public void UpdateQuantity(int id, int qty)
        {
            ItemNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    temp.Quantity = qty;
                    Console.WriteLine("Quantity updated");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        // Search by ID
        public void SearchById(int id)
        {
            ItemNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    DisplayItem(temp);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        // Search by Name
        public void SearchByName(string name)
        {
            ItemNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.ItemName.Equals(name))
                {
                    DisplayItem(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Item not found");
        }

        // Calculate Total Inventory Value
        public void CalculateTotalValue()
        {
            double total = 0;
            ItemNode temp = head;

            while (temp != null)
            {
                total += temp.Price * temp.Quantity;
                temp = temp.Next;
            }

            Console.WriteLine("Total Inventory Value: " + total);
        }

        // Display All Items
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            ItemNode temp = head;
            while (temp != null)
            {
                DisplayItem(temp);
                temp = temp.Next;
            }
        }

        private void DisplayItem(ItemNode item)
        {
            Console.WriteLine($"ID: {item.ItemId}, Name: {item.ItemName}, Qty: {item.Quantity}, Price: {item.Price}");
        }
    }

    // Main / Utility Class
    public class InventoryManagement
    {
        public static void Main(string[] args)
        {
            InventoryLinkedList list = new InventoryLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Inventory Management System ---");
                Console.WriteLine("1. Add Item at Beginning");
                Console.WriteLine("2. Add Item at End");
                Console.WriteLine("3. Remove Item by ID");
                Console.WriteLine("4. Update Quantity");
                Console.WriteLine("5. Search by ID");
                Console.WriteLine("6. Search by Name");
                Console.WriteLine("7. Display All Items");
                Console.WriteLine("8. Total Inventory Value");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                        Console.Write("Item ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Item Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Quantity: ");
                        int qty = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());

                        if (choice == 1)
                            list.AddAtBeginning(id, name, qty, price);
                        else
                            list.AddAtEnd(id, name, qty, price);
                        break;

                    case 3:
                        Console.Write("Enter Item ID: ");
                        list.RemoveById(int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("Enter Item ID: ");
                        int itemId = int.Parse(Console.ReadLine());
                        Console.Write("New Quantity: ");
                        int newQty = int.Parse(Console.ReadLine());
                        list.UpdateQuantity(itemId, newQty);
                        break;

                    case 5:
                        Console.Write("Enter Item ID: ");
                        list.SearchById(int.Parse(Console.ReadLine()));
                        break;

                    case 6:
                        Console.Write("Enter Item Name: ");
                        list.SearchByName(Console.ReadLine());
                        break;

                    case 7:
                        list.DisplayAll();
                        break;

                    case 8:
                        list.CalculateTotalValue();
                        break;

                    case 0:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
