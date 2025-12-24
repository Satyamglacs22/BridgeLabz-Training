//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level1
//{
//    public class QuotientAndRemainder
//    {
//        public static void Main()
//        {
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());

//            int[] result = new int[2];
//            FindQuotientAndRemainder(a, b, result);
//            Console.WriteLine($"Quotient is : {result[0]}");
//            Console.WriteLine($"Remainder is : {result[1]}");
//        }
//        public static int[] FindQuotientAndRemainder(int a,int b, int[] result)
//        {
//            int quotient = a / b;
//            int remainder = a % b;
//            result[0] = quotient;
//            result[1] = remainder;
//            return result;
//        }
//    }
//}
