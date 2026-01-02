using System;

namespace BookDetails
{
    class Book
    {
        // Attributes
        public string title;
        public string author;
        public double price;

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Price  : " + price);
        }

        // Main method
        static void Main(string[] args)
        {
            // Creating Book object
            Book book = new Book();

            // Taking input from user
            Console.Write("Enter Book Title: ");
            book.title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            book.author = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            book.price = double.Parse(Console.ReadLine());

            Console.WriteLine();

            // Displaying book details
            book.DisplayBookDetails();
        }
    }
}
