//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class NumberAnalyzer
//    {
//        public static void Main()
//        {
//            int number = int.Parse(Console.ReadLine());

           int count = CountDigits(number);
//            int[] digits = GetDigits(number, count);

//            Console.WriteLine(FindSum(digits));
//            Console.WriteLine(FindSquareSum(digits));
//            Console.WriteLine(IsHarshad(number, digits));

//            int[,] freq = FindFrequency(digits);
//            for (int i = 0; i < 10; i++)
//                Console.WriteLine(freq[i, 0] + " " + freq[i, 1]);
//        }

//        public static int CountDigits(int number)
//        {
//            int count = 0;
//            while (number > 0)
//            {
//                count++;
//                number /= 10;
//            }
//            return count;
//        }

//        public static int[] GetDigits(int number, int count)
//        {
//            int[] digits = new int[count];
//            for (int i = count - 1; i >= 0; i--)
//            {
//                digits[i] = number % 10;
//                number /= 10;
//            }
//            return digits;
//        }

//        public static int FindSum(int[] digits)
//        {
//            int sum = 0;
//            foreach (int d in digits) sum += d;
//            return sum;
//        }

//        public static double FindSquareSum(int[] digits)
//        {
//            double sum = 0;
//            foreach (int d in digits) sum += Math.Pow(d, 2);
//            return sum;
//        }

//        public static bool IsHarshad(int number, int[] digits)
//        {
//            int sum = FindSum(digits);
//            return number % sum == 0;
//        }

//        public static int[,] FindFrequency(int[] digits)
//        {
//            int[,] freq = new int[10, 2];

//            for (int i = 0; i < 10; i++)
//                freq[i, 0] = i;

//            foreach (int d in digits)
//                freq[d, 1]++;

//            return freq;
//        }
//    }
//}
