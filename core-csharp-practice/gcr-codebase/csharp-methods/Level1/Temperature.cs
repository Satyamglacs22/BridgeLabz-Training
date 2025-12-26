//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace Method.Level1
//{
//    public class Temperature
//    {
//        public static void Main()
//        {
//            double windSpeed = double.Parse(Console.ReadLine());
//            double temp = double.Parse(Console.ReadLine());

//            double windChill = FindWindChill(temp, windSpeed);
//            Console.WriteLine($"WindChill is {windChill}");
//        }

//        public static double FindWindChill(double temp, double windSpeed)
//        {
//            double windChill = 35.74
//                               + 0.6215 * temp
//                               + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);

//            return windChill;
//        }
//    }
//}
