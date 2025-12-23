//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Arrays
//{
//    public class OddEvenArray
//    {
//        public static void Main()
//        {
//            Console.Write("Enter a number: ");
//            int number = int.Parse(Console.ReadLine());

//            if (number <= 0)
//            {
//                Console.WriteLine("Not a natural number");
//                return;
//            }

//            int[] even = new int[number / 2 + 1];
//            int[] odd = new int[number / 2 + 1];

//            int evenIndex = 0;
//            int oddIndex = 0;

//            for (int i = 1; i <= number; i++)
//            {
//                if (i % 2 == 0)
//                    even[evenIndex++] = i;
//                else
//                    odd[oddIndex++] = i;
//            }

//            Console.WriteLine("Even Numbers:");
//            for (int i = 0; i < evenIndex; i++)
//                Console.Write(even[i] + " ");

//            Console.WriteLine("\nOdd Numbers:");
//            for (int i = 0; i < oddIndex; i++)
//                Console.Write(odd[i] + " ");
//        }
//    }
//}
