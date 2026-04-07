using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionAssignment
{
    internal class FinallyExample
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Result: " + (a / b));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Operation completed");
            }
        }
    }
}
