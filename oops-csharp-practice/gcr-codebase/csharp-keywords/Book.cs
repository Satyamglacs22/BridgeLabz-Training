using System;

class Book
{
    // static variable
    public static string LibraryName = "Central Library";

    // readonly variable
    public readonly string ISBN;

    public string Title;
    public string Author;

    // constructor
    public Book(string isbn, string title, string author)
    {
        this.ISBN = isbn;
        this.Title = title;
        this.Author = author;
    }

    // static method
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + LibraryName);
    }

    public void DisplayBook()
    {
        Console.WriteLine("ISBN  : " + ISBN);
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Author: " + Author);
    }

    static void Main()
    {
        Book b = new Book("ISBN001", "C# Basics", "John");

        if (b is Book)
        {
            Book.DisplayLibraryName();
            b.DisplayBook();
        }
    }
}
