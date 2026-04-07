using System;
using System.Collections.Generic;

namespace SmartWarehouse
{
    class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine("Item added successfully.\n");
        }

        public void DisplayAllItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items in storage.");
                return;
            }

            Console.WriteLine("---- Stored Items ----");
            foreach (T item in items)
            {
                item.DisplayItem();
            }
        }
    }
}
