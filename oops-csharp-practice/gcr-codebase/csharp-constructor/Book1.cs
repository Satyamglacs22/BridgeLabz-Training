using System;

class Book1
{
    public string ISBN;
    protected string title;
    private string author;

    public void SetAuthor(string a)
    {
        author = a;
    }

    public string GetAuthor()
    {
        return author;
    }
}

class EBook : Book1
{
    public void Display()
    {
        Console.WriteLine("ISBN : " + ISBN);
        Console.WriteLine("Title: " + title);
    }

    static void Main()
    {
        EBook eb = new EBook();
        eb.ISBN = "12345";
        eb.title = "C# Ebook";
        eb.SetAuthor("John");

        eb.Display();
    }
}
