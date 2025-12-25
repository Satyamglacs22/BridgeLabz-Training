//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class RandomNumbers
//    {
//        public static void Main()
//        {
//            int[] arr = Generate4DigitRandomArray(5);
//            double[] result = FindAverageMinMax(arr);

//            Console.WriteLine("Average: " + result[0]);
//            Console.WriteLine("Min: " + result[1]);
//            Console.WriteLine("Max: " + result[2]);
//        }

//        public static int[] Generate4DigitRandomArray(int size)
//        {
//            int[] arr = new int[size];
//            Random rand = new Random();

//            for (int i = 0; i < size; i++)
//                arr[i] = rand.Next(1000, 10000);

//            return arr;
//        }

//        public static double[] FindAverageMinMax(int[] numbers)
//        {
//            int min = numbers[0], max = numbers[0], sum = 0;

//            foreach (int n in numbers)
//            {
//                sum += n;
//                min = Math.Min(min, n);
//                max = Math.Max(max, n);
//            }

//            return new double[] { (double)sum / numbers.Length, min, max };
//        }
//    }
//}
