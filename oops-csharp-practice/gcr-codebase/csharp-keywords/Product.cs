using System;

class Product
{
    // static variable
    public static int Discount = 10;

    // readonly variable
    public readonly int ProductID;

    public string ProductName;
    public int Price;
    public int Quantity;

    public Product(int id, string name, int price, int quantity)
    {
        this.ProductID = id;
        this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(int d)
    {
        Discount = d;
    }

    public void Display()
    {
        Console.WriteLine("Product ID  : " + ProductID);
        Console.WriteLine("Name        : " + ProductName);
        Console.WriteLine("Price       : " + Price);
        Console.WriteLine("Quantity    : " + Quantity);
        Console.WriteLine("Discount(%) : " + Discount);
    }

    static void Main()
    {
        Product p = new Product(101, "Pen", 10, 5);

        if (p is Product)
        {
            p.Display();
        }
    }
}
