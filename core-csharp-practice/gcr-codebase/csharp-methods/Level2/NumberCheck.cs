//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class NumberCheck
//    {
//        public static void Main()
//        {
//            int[] arr = new int[5];

//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());

//                if (IsPositive(arr[i]))
//                {
//                    Console.WriteLine(IsEven(arr[i]) ? "Positive Even" : "Positive Odd");
//                }
//                else
//                {
//                    Console.WriteLine("Negative");
//                }
//            }

//            int result = Compare(arr[0], arr[arr.Length - 1]);
//            Console.WriteLine(result == 0 ? "Equal" : result == 1 ? "First Greater" : "First Smaller");
//        }

//        public static bool IsPositive(int n) => n >= 0;
//        public static bool IsEven(int n) => n % 2 == 0;

//        public static int Compare(int a, int b)
//        {
//            if (a > b) return 1;
//            if (a == b) return 0;
//            return -1;
//        }
//    }
//}
