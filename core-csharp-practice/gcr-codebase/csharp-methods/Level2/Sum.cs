//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class Sum
//    {
//        public static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            int show = FindSum(n);

//            Console.WriteLine($"Sum upto {n} numbers is {show}");
//        }

//        public static int FindSum(int n)
//        {
//            if (n == 0)
//            {
//                return 0;
//            }

//            return n + FindSum(n - 1);
//        }
//    }
//}
