using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.ECommerce
{
   

    public abstract class Product
    {
        private int productId;
        private string name;
        protected double price;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value > 0)
                    productId = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
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

        // Abstract method
        public abstract double CalculateDiscount();

        // Concrete method
        public double CalculateFinalPrice(double tax)
        {
            return price + tax - CalculateDiscount();
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product ID   : " + ProductId);
            Console.WriteLine("Product Name : " + Name);
            Console.WriteLine("Base Price   : " + Price);
        }
    }


}
