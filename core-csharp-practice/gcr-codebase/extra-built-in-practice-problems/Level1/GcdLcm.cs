using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class GcdLcm
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int Gcd = GcdFind(a, b);
            Console.WriteLine($"GCD of two numbers is {Gcd}");
            int Lcm = LcmFind(Gcd, a, b);
            Console.WriteLine($"Lcm of two numbers is {Lcm}");
        }
        public static int GcdFind(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int LcmFind(int Gcd, int a, int b)
        {
            return (a * b) / Gcd;
        }
    }
}
