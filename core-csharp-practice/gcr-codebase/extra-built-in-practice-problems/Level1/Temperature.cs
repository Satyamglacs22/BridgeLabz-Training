using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class Temperature
    {
        public static void Main()
        {
            double temp = double.Parse(Console.ReadLine());

            Console.WriteLine("Press 1 for Celsius to Fahrenheit");
            Console.WriteLine("Press 2 for Fahrenheit to Celsius");

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(CelsiusToFahrenheit(temp));
                    break;

                case 2:
                    Console.WriteLine(FahrenheitToCelsius(temp));
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
