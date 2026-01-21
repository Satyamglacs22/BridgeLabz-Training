using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding
{
    internal class NthElement
    {
        public static void Main()
        {
            List<int> ls = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ElementNth(ls);
        }

        public static void ElementNth(List<int> ls)
        {
            Console.WriteLine("Enter the value from the last:");
            int k = int.Parse(Console.ReadLine());

            int n = ls.Count;

            if (k <= 0 || k > n)
            {
                Console.WriteLine("Invalid value of k");
                return;
            }

            int index = n - k;
            Console.WriteLine("Nth element from last is: " + ls[index]);
        }
    }
}
