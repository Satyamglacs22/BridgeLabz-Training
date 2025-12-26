//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level2
//{
//    public class Quadratic
//    {
//        public static void Main()
//        {
//            double a = double.Parse(Console.ReadLine());
//            double b = double.Parse(Console.ReadLine());
//            double c = double.Parse(Console.ReadLine());

//            double[] roots = FindRoots(a, b, c);

//            if (roots.Length == 0)
//            {
//                Console.WriteLine("No real roots");
//            }
//            else
//            {
//                for (int i = 0; i < roots.Length; i++)
//                {
//                    Console.WriteLine(roots[i]);
//                }
//            }
//        }

//        public static double[] FindRoots(double a, double b, double c)
//        {
//            double delta = Math.Pow(b, 2) - 4 * a * c;

//            if (delta > 0)
//            {
//                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
//                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
//                return new double[] { root1, root2 };
//            }
//            else if (delta == 0)
//            {
//                double root = -b / (2 * a);
//                return new double[] { root };
//            }
//            else
//            {
//                return new double[0];
//            }
//        }
//    }
//}
