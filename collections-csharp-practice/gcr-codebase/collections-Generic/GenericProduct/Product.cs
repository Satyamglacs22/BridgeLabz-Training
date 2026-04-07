using System;

namespace GenericProduct
{
    internal class Product
    {
        private string productName;
        private int productId;
        private double price;

        public Product(string productName, int productId, double price)
        {
            this.productName = productName;
            this.productId = productId;
            this.price = price;
        }

        public string ProductName
        {
            get { return productName; }
        }

        public int ProductId
        {
            get { return productId; }
        }

        public double Price
        {
            get { return price; }
        }

        //  SAFE METHOD to update price
        public void ApplyDiscount(double percentage)
        {
            double discount = price * percentage / 100;
            price -= discount;
        }

        public virtual void DisplayItem()
        {
            Console.WriteLine($"ID: {productId}, Name: {productName}, Price: {price}");
        }
    }
}
