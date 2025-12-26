using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
    }
}
