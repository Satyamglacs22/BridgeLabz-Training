using System;

class LibraryBook
{
    public string title;
    public string author;
    public double price;
    public bool available;

    public LibraryBook(string t, string a, double p)
    {
        title = t;
        author = a;
        price = p;
        available = true;
    }

    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book Borrowed");
        }
        else
        {
            Console.WriteLine("Book Not Available");
        }
    }

    static void Main()
    {
        LibraryBook b = new LibraryBook("C# Guide", "Mark", 300);
        b.BorrowBook();
        b.BorrowBook();
    }
}
