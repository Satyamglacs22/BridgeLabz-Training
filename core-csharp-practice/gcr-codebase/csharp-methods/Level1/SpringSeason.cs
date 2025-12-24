//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level1
//{
//    public class SpringSeason
//    {
//        public static void Main()
//        {
//            Console.WriteLine("Enter Month");
//            int m = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Date");
//            int d = int.Parse(Console.ReadLine());

//            String Season = CheckSpring(m, d);
//            Console.WriteLine(Season);
//        }
//        public static String CheckSpring(int m, int d)
//        {
//            if((m>=3 && d>20 && d<32)|| ((m==4) && d>0 && d<30)||( (m == 5) && d > 0 && d < 30) || ((m == 6) && d > 0 && d < 21))
//            {
//                return "Spring Season";
//            }
//            else
//            {
//                return "Not a Spring Season";
//            }
//        }
//    }
//}
