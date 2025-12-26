using System;

class VolumeOfCylinder
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        double volume = 3.14 * radius * radius * height;

        Console.WriteLine(
            "The volume of the cylinder with radius " +
            radius +
            " and height " +
            height +
            " is: " +
            volume
        );
    }
}
