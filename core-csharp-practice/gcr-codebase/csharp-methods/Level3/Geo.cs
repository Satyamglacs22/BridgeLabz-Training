//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class Geo
//    {
//        public static void Main()
//        {
//            double x1 = double.Parse(Console.ReadLine());
//            double y1 = double.Parse(Console.ReadLine());
//            double x2 = double.Parse(Console.ReadLine());
//            double y2 = double.Parse(Console.ReadLine());

//            Console.WriteLine(GetDistance(x1, y1, x2, y2));

//            double[] line = GetLineEquation(x1, y1, x2, y2);
//            Console.WriteLine(line[0]);
//            Console.WriteLine(line[1]);
//        }

//        public static double GetDistance(double x1, double y1, double x2, double y2)
//        {
//            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//        }

//        public static double[] GetLineEquation(double x1, double y1, double x2, double y2)
//        {
//            double m = (y2 - y1) / (x2 - x1);
//            double b = y1 - m * x1;
//            return new double[] { m, b };
//        }
//    }
//}
