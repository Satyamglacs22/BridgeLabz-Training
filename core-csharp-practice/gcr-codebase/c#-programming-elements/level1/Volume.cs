using System;

public class Volume
{
    public static void Main()
    {
        double radius = 6378.0;

        double km = (4.0 / 3.0) * 3.14 * radius * radius * radius;
        double miles = km * 0.239913;

        Console.WriteLine(
            "The Volume of the earth in cubic kilometers is " + km +
            " and cubic miles is " + miles
        );
    }
}
