using System;

class AreaOfCircle
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());
        double area = 3.14 * radius * radius;

        Console.WriteLine("The area of the circle with radius " + radius + " is: " + area);
    }
}
