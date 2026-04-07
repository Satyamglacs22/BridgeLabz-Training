using System;

class Circle
{
    public double radius;

    // Default constructor
    public Circle() : this(1.0)
    {
        // calling parameterized constructor
    }

    // Parameterized constructor
    public Circle(double r)
    {
        radius = r;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + (Math.PI * radius * radius));
    }

    static void Main()
    {
        Circle c1 = new Circle();
        Circle c2 = new Circle(5);

        c1.Display();
        Console.WriteLine();
        c2.Display();
    }
}
