using System;

public class KmToMiles1
{
    public static void Main()
    {
        double km;
        Console.Write("Enter distance in kilometers: ");
        km = double.Parse(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
