using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder_LinerSearch_BinarySearch
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);
            StringBuilder reversed = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversed.Append(sb[i]);
            }

            Console.WriteLine("Reversed String: " + reversed);
            //Console.ReadLine(); 
        }
    }
}
