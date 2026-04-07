using System;

class Book
{
    public string title;
    public int year;
}

class Author : Book
{
    public string name;
    public string bio;

    public void DisplayInfo()
    {
        Console.WriteLine(title + " (" + year + ")");
        Console.WriteLine("Author: " + name);
    }
}

class Book1
{
    static void Main()
    {
        Author a = new Author();
        a.title = "C# Basics";
        a.year = 2023;
        a.name = "John";

        a.DisplayInfo();
    }
}
