using System;

class RectanglePerimeter
{
    static void Main()
    {
        int l = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int perimeter = 2 * (l + b);

        Console.WriteLine(perimeter);
    }
}
