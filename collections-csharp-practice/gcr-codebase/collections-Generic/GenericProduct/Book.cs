using System;

namespace GenericProduct
{
    internal class Book : Product
    {
        private string author;

        public Book(string name, int id, double price, string author)
            : base(name, id, price)
        {
            this.author = author;
        }

        public override void DisplayItem()
        {
            Console.WriteLine($"[Book] {ProductId}, {ProductName}, Author: {author}, Price: {Price}");
        }
    }
}
