using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionAssignment
{
    internal class ExceptionPropagation
    {
        static void Method1()
        {
            int x = 10 / 1;
        }

        static void Method2()
        {
            Method1();
        }

        static void Main(string[] args)
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }
    }
}
