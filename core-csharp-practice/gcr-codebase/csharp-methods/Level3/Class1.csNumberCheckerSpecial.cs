//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class NumberCheckerSpecial
//    {
//        public static void Main()
//        {
//            int number = int.Parse(Console.ReadLine());

//            Console.WriteLine(IsPrime(number));
//            Console.WriteLine(IsNeon(number));
//            Console.WriteLine(IsSpy(number));
//            Console.WriteLine(IsAutomorphic(number));
//            Console.WriteLine(IsBuzz(number));
//        }

//        public static bool IsPrime(int n)
//        {
//            if (n <= 1) return false;
//            for (int i = 2; i <= Math.Sqrt(n); i++)
//                if (n % i == 0) return false;
//            return true;
//        }

//        public static bool IsNeon(int n)
//        {
//            int square = n * n;
//            int sum = 0;
//            while (square > 0)
//            {
//                sum += square % 10;
//                square /= 10;
//            }
//            return sum == n;
//        }

//        public static bool IsSpy(int n)
//        {
//            int sum = 0, product = 1;
//            while (n > 0)
//            {
//                int d = n % 10;
//                sum += d;
//                product *= d;
//                n /= 10;
//            }
//            return sum == product;
//        }

//        public static bool IsAutomorphic(int n)
//        {
//            int square = n * n;
//            return square.ToString().EndsWith(n.ToString());
//        }

//        public static bool IsBuzz(int n)
//        {
//            return n % 7 == 0 || n % 10 == 7;
//        }
//    }
//}
