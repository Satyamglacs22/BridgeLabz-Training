using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Online_Food_Delivery
{
    

    public abstract class FoodItem
    {
        private string itemName;
        protected double price;
        protected int quantity;

        public string ItemName
        {
            get { return itemName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    itemName = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        // Abstract method
        public abstract double CalculateTotalPrice();

        // Concrete method
        public void GetItemDetails()
        {
            Console.WriteLine("Item Name : " + ItemName);
            Console.WriteLine("Price     : " + Price);
            Console.WriteLine("Quantity  : " + Quantity);
        }
    }


}
