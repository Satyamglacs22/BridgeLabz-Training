using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCheckout
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Item(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
