using System;

namespace Method.Level2
{
    public class UnitConverterLength
    {
        public static void Main()
        {
            double yards = double.Parse(Console.ReadLine());
            double feet = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double inches = double.Parse(Console.ReadLine());
            double inchValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Yards to Feet: " + ConvertYardsToFeet(yards));
            Console.WriteLine("Feet to Yards: " + ConvertFeetToYards(feet));
            Console.WriteLine("Meters to Inches: " + ConvertMetersToInches(meters));
            Console.WriteLine("Inches to Meters: " + ConvertInchesToMeters(inches));
            Console.WriteLine("Inches to Centimeters: " + ConvertInchesToCentimeters(inchValue));
        }

        public static double ConvertYardsToFeet(double yards)
        {
            return yards * 3;
        }

        public static double ConvertFeetToYards(double feet)
        {
            return feet * 0.333333;
        }

        public static double ConvertMetersToInches(double meters)
        {
            return meters * 39.3701;
        }

        public static double ConvertInchesToMeters(double inches)
        {
            return inches * 0.0254;
        }

        public static double ConvertInchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
    }
}
