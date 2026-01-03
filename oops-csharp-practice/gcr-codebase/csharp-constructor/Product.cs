using System;

class Product
{
    public string productName;
    public double price;

    public static int totalProducts = 0;

    public Product(string n, double p)
    {
        productName = n;
        price = p;
        totalProducts++;
    }

    public void DisplayProduct()
    {
        Console.WriteLine(productName + " - " + price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products : " + totalProducts);
    }

    static void Main()
    {
        Product p1 = new Product("Pen", 10);
        Product p2 = new Product("Book", 50);

        p1.DisplayProduct();
        p2.DisplayProduct();
        Product.DisplayTotalProducts();
    }
}
