using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding
{
    internal class Symmetric
    {
        public static void Main()
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            FindSymmetric(set1, set2);
        }

        public static void FindSymmetric(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>();

            // Elements in set1 but not in set2
            foreach (var e in set1)
            {
                if (!set2.Contains(e))
                {
                    result.Add(e);
                }
            }

            // Elements in set2 but not in set1
            foreach (var e in set2)
            {
                if (!set1.Contains(e))
                {
                    result.Add(e);
                }
            }

            Console.WriteLine("Symmetric Difference:");
            foreach (var e in result)
            {
                Console.Write(e + " ");
            }
        }
    }
}
