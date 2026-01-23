using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionAssignment
{
    internal class DivisionExample
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numeric values only");
            }
        }
    }
}
