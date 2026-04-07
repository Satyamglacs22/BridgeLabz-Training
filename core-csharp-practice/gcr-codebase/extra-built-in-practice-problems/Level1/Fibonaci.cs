using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class Fibonaci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = FibonaciFind(n);
            Console.WriteLine($"Fibonaci Numbers upto {n} numbers is :{result}");

        }
        public static int FibonaciFind(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return FibonaciFind(n - 2) + FibonaciFind(n - 1);
        }
    }
}
