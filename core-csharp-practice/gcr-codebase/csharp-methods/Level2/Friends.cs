//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class Friends
//    {
//        public static void Main()
//        {
//            int[] ages = new int[3];
//            double[] heights = new double[3];
//            string[] names = { "Amar", "Akbar", "Anthony" };

//            for (int i = 0; i < 3; i++)
//            {
//                ages[i] = int.Parse(Console.ReadLine());
//                heights[i] = double.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Youngest: " + names[FindYoungest(ages)]);
//            Console.WriteLine("Tallest: " + names[FindTallest(heights)]);
//        }

//        public static int FindYoungest(int[] ages)
//        {
//            int minIndex = 0;
//            for (int i = 1; i < ages.Length; i++)
//                if (ages[i] < ages[minIndex])
//                    minIndex = i;
//            return minIndex;
//        }

//        public static int FindTallest(double[] heights)
//        {
//            int maxIndex = 0;
//            for (int i = 1; i < heights.Length; i++)
//                if (heights[i] > heights[maxIndex])
//                    maxIndex = i;
//            return maxIndex;
//        }
//    }
//}
