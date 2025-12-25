//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class UnitConverter
//    {
//        public static void Main()
//        {
//            double fahrenheit = double.Parse(Console.ReadLine());
//            double celsius = double.Parse(Console.ReadLine());
//            double pounds = double.Parse(Console.ReadLine());
//            double kilograms = double.Parse(Console.ReadLine());
//            double gallons = double.Parse(Console.ReadLine());
//            double liters = double.Parse(Console.ReadLine());

//            Console.WriteLine("Fahrenheit to Celsius: " + ConvertFahrenheitToCelsius(fahrenheit));
//            Console.WriteLine("Celsius to Fahrenheit: " + ConvertCelsiusToFahrenheit(celsius));
//            Console.WriteLine("Pounds to Kilograms: " + ConvertPoundsToKilograms(pounds));
//            Console.WriteLine("Kilograms to Pounds: " + ConvertKilogramsToPounds(kilograms));
//            Console.WriteLine("Gallons to Liters: " + ConvertGallonsToLiters(gallons));
//            Console.WriteLine("Liters to Gallons: " + ConvertLitersToGallons(liters));
//        }

//        public static double ConvertFahrenheitToCelsius(double fahrenheit)
//        {
//            return (fahrenheit - 32) * 5 / 9;
//        }

//        public static double ConvertCelsiusToFahrenheit(double celsius)
//        {
//            return (celsius * 9 / 5) + 32;
//        }

//        public static double ConvertPoundsToKilograms(double pounds)
//        {
//            return pounds * 0.453592;
//        }

//        public static double ConvertKilogramsToPounds(double kilograms)
//        {
//            return kilograms * 2.20462;
//        }

//        public static double ConvertGallonsToLiters(double gallons)
//        {
//            return gallons * 3.78541;
//        }

//        public static double ConvertLitersToGallons(double liters)
//        {
//            return liters * 0.264172;
//        }
//    }
//}
