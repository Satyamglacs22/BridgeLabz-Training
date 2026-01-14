//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithm
//{
//    internal class FibonacciComparison
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Recursive Fibonacci (10): " + FibonacciRecursive(10));
//            Console.WriteLine("Iterative Fibonacci (50): " + FibonacciIterative(50));
//        }

//        static int FibonacciRecursive(int n)
//        {
//            if (n <= 1)
//                return n;

//            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
//        }

//        static int FibonacciIterative(int n)
//        {
//            int a = 0, b = 1, sum = 0;

//            for (int i = 2; i <= n; i++)
//            {
//                sum = a + b;
//                a = b;
//                b = sum;
//            }
//            return b;
//        }
//    }
//}
