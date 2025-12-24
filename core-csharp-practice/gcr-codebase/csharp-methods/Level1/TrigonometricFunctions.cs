//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level1
//{
//    public class TrigonometricFunctions
//    {
//        public static void Main()
//        {
//            double angle = double.Parse(Console.ReadLine());

//            double sin, cos, tan;
//            CalculateTrig(angle, out sin, out cos, out tan);

//            Console.WriteLine("Sine: " + sin);
//            Console.WriteLine("Cosine: " + cos);
//            Console.WriteLine("Tangent: " + tan);
//        }

//        public static void CalculateTrig(double angle,
//                                         out double sin,
//                                         out double cos,
//                                         out double tan)
//        {
//            double radians = angle * Math.PI / 180;

//            sin = Math.Sin(radians);
//            cos = Math.Cos(radians);
//            tan = Math.Tan(radians);
//        }
//    }
//}
