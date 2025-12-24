//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level1
//{
//    public class SmallestAndLargest
//    {
//        public static void Main()
//        {
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int c = int.Parse(Console.ReadLine());

//            int[] result = LargestAndSmallestFind(a, b, c);

//            Console.WriteLine("Smallest: " + result[0]);
//            Console.WriteLine("Largest: " + result[1]);
//        }

//        public static int[] LargestAndSmallestFind(int a, int b, int c)
//        {
//            int[] arr = new int[2];

//            int smallest = a;
//            int largest = a;

//            if (b < smallest)
//                smallest = b;
//            if (c < smallest)
//                smallest = c;

//            if (b > largest)
//                largest = b;
//            if (c > largest)
//                largest = c;

//            arr[0] = smallest;
//            arr[1] = largest;

//            return arr;
//        }
//    }
//}
