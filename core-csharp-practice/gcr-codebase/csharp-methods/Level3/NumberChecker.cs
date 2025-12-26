//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class NumberChecker
//    {
//        public static void Main()
//        {
//            int number = int.Parse(Console.ReadLine());

//            int count = CountDigits(number);
//            int[] digits = GetDigits(number, count);

//            Console.WriteLine(IsDuck(digits));
//            Console.WriteLine(IsArmstrong(number, digits));
//            FindLargestSecondLargest(digits);
//            FindSmallestSecondSmallest(digits);
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

//        public static bool IsDuck(int[] digits)
//        {
//            foreach (int d in digits)
//                if (d != 0) return true;
//            return false;
//        }

//        public static bool IsArmstrong(int number, int[] digits)
//        {
//            int sum = 0;
//            foreach (int d in digits)
//                sum += (int)Math.Pow(d, digits.Length);
//            return sum == number;
//        }

//        public static void FindLargestSecondLargest(int[] digits)
//        {
//            int largest = int.MinValue;
//            int second = int.MinValue;

//            foreach (int d in digits)
//            {
//                if (d > largest)
//                {
//                    second = largest;
//                    largest = d;
//                }
//                else if (d > second && d != largest)
//                    second = d;
//            }

//            Console.WriteLine(largest);
//            Console.WriteLine(second);
//        }

//        public static void FindSmallestSecondSmallest(int[] digits)
//        {
//            int smallest = int.MaxValue;
//            int second = int.MaxValue;

//            foreach (int d in digits)
//            {
//                if (d < smallest)
//                {
//                    second = smallest;
//                    smallest = d;
//                }
//                else if (d < second && d != smallest)
//                    second = d;
//            }

//            Console.WriteLine(smallest);
//            Console.WriteLine(second);
//        }
//    }
//}
