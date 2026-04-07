using System;

class Circle
{
    public double Radius;

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    static void Main()
    {
        Circle c = new Circle();

        Console.Write("Enter Radius: ");
        c.Radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Area of Circle: " + c.CalculateArea());
        Console.WriteLine("Circumference of Circle: " + c.CalculateCircumference());
    }
}
