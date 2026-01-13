using System;
using System.Text;

namespace StringBuilder_LinerSearch_BinarySearch
{
    internal class RemoveDuplicates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (char ch in input)
            {
                if (!result.ToString().Contains(ch))
                {
                    result.Append(ch);
                }
            }

            Console.WriteLine("After removing duplicates: " + result);
        }
    }
}
