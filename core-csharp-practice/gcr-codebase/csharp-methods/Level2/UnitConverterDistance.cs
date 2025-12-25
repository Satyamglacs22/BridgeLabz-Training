//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class UnitConverterDistance
//    {
//        public static void Main()
//        {
//            double km = double.Parse(Console.ReadLine());
//            double miles = double.Parse(Console.ReadLine());
//            double meters = double.Parse(Console.ReadLine());
//            double feet = double.Parse(Console.ReadLine());

//            Console.WriteLine("Km to Miles: " + ConvertKmToMiles(km));
//            Console.WriteLine("Miles to Km: " + ConvertMilesToKm(miles));
//            Console.WriteLine("Meters to Feet: " + ConvertMetersToFeet(meters));
//            Console.WriteLine("Feet to Meters: " + ConvertFeetToMeters(feet));
//        }

//        public static double ConvertKmToMiles(double km)
//        {
//            return km * 0.621371;
//        }

//        public static double ConvertMilesToKm(double miles)
//        {
//            return miles * 1.60934;
//        }

//        public static double ConvertMetersToFeet(double meters)
//        {
//            return meters * 3.28084;
//        }

//        public static double ConvertFeetToMeters(double feet)
//        {
//            return feet * 0.3048;
//        }
//    }
//}
