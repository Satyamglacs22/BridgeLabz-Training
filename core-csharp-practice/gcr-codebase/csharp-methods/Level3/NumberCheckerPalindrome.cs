//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class NumberCheckerPalindrome
//    {
//        public static void Main()
//        {
//            int number = int.Parse(Console.ReadLine());

//            int count = CountDigits(number);
//            int[] digits = GetDigits(number, count);
//            int[] reversed = ReverseArray(digits);

//            Console.WriteLine(CompareArrays(digits, reversed));
//            Console.WriteLine(IsPalindrome(digits));
//            Console.WriteLine(IsDuck(digits));
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

//        public static int[] ReverseArray(int[] arr)
//        {
//            int[] rev = new int[arr.Length];
//            for (int i = 0; i < arr.Length; i++)
//                rev[i] = arr[arr.Length - 1 - i];
//            return rev;
//        }

//        public static bool CompareArrays(int[] a, int[] b)
//        {
//            for (int i = 0; i < a.Length; i++)
//                if (a[i] != b[i]) return false;
//            return true;
//        }

//        public static bool IsPalindrome(int[] digits)
//        {
//            return CompareArrays(digits, ReverseArray(digits));
//        }

//        public static bool IsDuck(int[] digits)
//        {
//            foreach (int d in digits)
//                if (d != 0) return true;
//            return false;
//        }
//    }
//}
