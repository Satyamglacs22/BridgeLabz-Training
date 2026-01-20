using System;

namespace GenericProduct
{
    internal class Clothing : Product
    {
        private string size;

        public Clothing(string name, int id, double price, string size)
            : base(name, id, price)
        {
            this.size = size;
        }

        public override void DisplayItem()
        {
            Console.WriteLine($"[Clothing] {ProductId}, {ProductName}, Size: {size}, Price: {Price}");
        }
    }
}
