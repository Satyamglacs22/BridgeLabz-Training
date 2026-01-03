using System;

class Book
{
    public string title;
    public string author;
    public double price;

    // Default Constructor
    public Book()
    {
        title = "Not Available";
        author = "Unknown";
        price = 0;
    }

    // Parameterized Constructor
    public Book(string t, string a, double p)
    {
        title = t;
        author = a;
        price = p;
    }

    public void DisplayBook()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }

    static void Main()
    {
        Book b1 = new Book(); // default
        Book b2 = new Book("C# Basics", "John", 450); // parameterized

        b1.DisplayBook();
        Console.WriteLine();
        b2.DisplayBook();
    }
}
