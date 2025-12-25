//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace Level3
//{
//    public class FootballHeights
//    {
//        public static void Main()
//        {
//            int[] heights = FindHeights(11);

//            int sum = FindSum(heights);
//            int min = FindMin(heights);
//            int max = FindMax(heights);

//            double mean = (double)sum / heights.Length;

//            Console.WriteLine(min);
//            Console.WriteLine(max);
//            Console.WriteLine(mean);
//        }

//        public static int[] FindHeights(int size)
//        {
//            Random random = new Random();
//            int[] heights = new int[size];

//            for (int i = 0; i < size; i++)
//                heights[i] = random.Next(150, 251);

//            return heights;
//        }

//        public static int FindSum(int[] arr)
//        {
//            int sum = 0;
//            foreach (int x in arr) sum += x;
//            return sum;
//        }

//        public static int FindMin(int[] arr)
//        {
//            int min = arr[0];
//            foreach (int x in arr)
//                if (x < min)
//                    min = x;
//            return min;
//        }

//        public static int FindMax(int[] arr)
//        {
//            int max = arr[0];
//            foreach (int x in arr) if (x > max) max = x;
//            return max;
//        }
//    }
//}
