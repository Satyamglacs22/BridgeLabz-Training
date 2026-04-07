using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = FactorialFind(n);
            Console.WriteLine($"Factorial upto {n} numbers is {result}");

        }
        public static int FactorialFind(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;

            }
            return n * FactorialFind(n - 1);
        }
    }
}
