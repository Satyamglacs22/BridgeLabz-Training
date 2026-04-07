using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionAssignment
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg) : base(msg) { }
    }

    internal class AgeValidation
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age must be 18 or above");
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
