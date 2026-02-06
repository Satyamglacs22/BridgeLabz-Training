using System;
using System.Collections.Generic;
using System.Text;

namespace Groceries
{
    public class Product
    {
        private string productName;
        private int price;
        private int quantity;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
