//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class LeapYearProgram
//    {
//        public static void Main()
//        {
//            int year = int.Parse(Console.ReadLine());

//            bool result = IsLeapYear(year);

//            if (result)
//            {
//                Console.WriteLine("Year is a Leap Year");
//            }
//            else
//            {
//                Console.WriteLine("Year is not a Leap Year");
//            }
//        }


//        public static bool IsLeapYear(int year)
//        {

//            if (year < 1582)
//            {
//                return false;
//            }


//            if (year % 400 == 0)
//            {
//                return true;
//            }
//            else if (year % 4 == 0 && year % 100 != 0)
//            {
//                return true;
//            }

//            return false;
//        }
//    }
//}
