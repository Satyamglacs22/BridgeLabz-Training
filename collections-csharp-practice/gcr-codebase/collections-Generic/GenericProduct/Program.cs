using System;

namespace GenericProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<Book> bookStorage = new Storage<Book>();
            Storage<Clothing> clothingStorage = new Storage<Clothing>();

            // ===== BOOK INPUT =====
            Console.WriteLine("Enter Book Details");
            Console.Write("Book Name: ");
            string bName = Console.ReadLine();

            Console.Write("Book ID: ");
            int bId = int.Parse(Console.ReadLine());

            Console.Write("Book Price: ");
            double bPrice = double.Parse(Console.ReadLine());

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Book book = new Book(bName, bId, bPrice, author);
            bookStorage.AddItem(book);

            // ===== CLOTHING INPUT =====
            Console.WriteLine("\nEnter Clothing Details");
            Console.Write("Clothing Name: ");
            string cName = Console.ReadLine();

            Console.Write("Clothing ID: ");
            int cId = int.Parse(Console.ReadLine());

            Console.Write("Clothing Price: ");
            double cPrice = double.Parse(Console.ReadLine());

            Console.Write("Size: ");
            string size = Console.ReadLine();

            Clothing cloth = new Clothing(cName, cId, cPrice, size);
            clothingStorage.AddItem(cloth);

            // ===== DISCOUNT INPUT =====
            Console.Write("\nEnter discount percentage for Book: ");
            double bookDiscount = double.Parse(Console.ReadLine());
            DiscountUtility.ApplyDiscount(book, bookDiscount);

            Console.Write("Enter discount percentage for Clothing: ");
            double clothDiscount = double.Parse(Console.ReadLine());
            DiscountUtility.ApplyDiscount(cloth, clothDiscount);

            // ===== DISPLAY =====
            Console.WriteLine("\n--- Final Catalog ---");
            bookStorage.DisplayAllItems();
            clothingStorage.DisplayAllItems();
        }
    }
}
