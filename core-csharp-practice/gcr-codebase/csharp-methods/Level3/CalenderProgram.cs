//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class CalendarProgram
//    {
//        public static void Main()
//        {
//            int month = int.Parse(Console.ReadLine());
//            int year = int.Parse(Console.ReadLine());

//            PrintCalendar(month, year);
//        }

//        public static void PrintCalendar(int month, int year)
//        {
//            string[] months = { "", "January", "February", "March", "April", "May", "June",
//                                "July", "August", "September", "October", "November", "December" };

//            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

//            if (month == 2 && IsLeapYear(year))
//                days[2] = 29;

//            int firstDay = GetFirstDay(month, year);

//            Console.WriteLine(months[month] + " " + year);
//            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

//            for (int i = 0; i < firstDay; i++)
//                Console.Write("    ");

//            for (int day = 1; day <= days[month]; day++)
//            {
//                Console.Write($"{day,3} ");
//                if ((day + firstDay) % 7 == 0)
//                    Console.WriteLine();
//            }
//        }

//        public static bool IsLeapYear(int year)
//        {
//            return year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
//        }

//        public static int GetFirstDay(int month, int year)
//        {
//            int y0 = year - (14 - month) / 12;
//            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
//            int m0 = month + 12 * ((14 - month) / 12) - 2;
//            return (1 + x + 31 * m0 / 12) % 7;
//        }
//    }
//}
