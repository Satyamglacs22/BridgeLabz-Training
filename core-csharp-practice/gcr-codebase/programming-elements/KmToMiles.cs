using System;

class KmToMiles
{
    static void Main()
    {
        double km = double.Parse(Console.ReadLine());
        double miles = km * 0.621371;

        Console.WriteLine(miles);
    }
}
