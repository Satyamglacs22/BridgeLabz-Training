using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class Maximum
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            FindMaximum(a, b, c);
        }
        public static void FindMaximum(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine($"Maximum among the three number is a : {a}");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine($"Maximum among the three number is b : {b}");
            }
            else
            {
                Console.WriteLine($"Maximum among the three number is c : {c}");
            }
        }
    }
}
