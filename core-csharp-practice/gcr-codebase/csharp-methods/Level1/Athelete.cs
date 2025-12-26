//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level1
//{
//    public class Athelete
//    {
//        public static void Main()
//        {
//            double s1 = int.Parse(Console.ReadLine());
//            double s2 = int.Parse(Console.ReadLine());
//            double s3 = int.Parse(Console.ReadLine());

//            double perimeter = s1 + s2 + s3;

//            double round = FindRounds(perimeter, 5.0);
//            Console.WriteLine($"Number of Rounds Require is {round}");

//        }
//        public static double FindRounds(double p, double km)
//        {
//            double inm = km * 1000;
//            double rounds = inm / p;
//            return rounds;
//        }
//    }
//}
