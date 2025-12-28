using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class Calculator
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(Add(a, b));
                    break;

                case 2:
                    Console.WriteLine(Sub(a, b));
                    break;
                case 3:
                    Console.WriteLine(Mul(a, b));
                    break;
                case 4:
                    Console.WriteLine(Div(a, b));
                    break;
            }
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
