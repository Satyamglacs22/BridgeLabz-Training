//using System;
//using System.Collections.Generic;
//using System.Text;


//namespace Level3
//{
//    public class Collinear
//    {
//        public static void Main()
//        {
//            double x1 = double.Parse(Console.ReadLine());
//            double y1 = double.Parse(Console.ReadLine());
//            double x2 = double.Parse(Console.ReadLine());
//            double y2 = double.Parse(Console.ReadLine());
//            double x3 = double.Parse(Console.ReadLine());
//            double y3 = double.Parse(Console.ReadLine());

//            Console.WriteLine(IsCollinearBySlope(x1, y1, x2, y2, x3, y3));
//            Console.WriteLine(IsCollinearByArea(x1, y1, x2, y2, x3, y3));
//        }

//        public static bool IsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
//        {
//            double slope1 = (y2 - y1) / (x2 - x1);
//            double slope2 = (y3 - y2) / (x3 - x2);
//            return slope1 == slope2;
//        }

//        public static bool IsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
//        {
//            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
//            return area == 0;
//        }
//    }
//}
