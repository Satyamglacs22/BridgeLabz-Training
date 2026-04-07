using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding.Set
{
    internal class UnionAndIntersection
    {
        public static void Main()
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            Union(set1, set2);
            Intersection(set1, set2);
        }

        public static void Union(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> union = new HashSet<int>(set1);

            foreach (var e in set2)
            {
                union.Add(e);
            }

            Console.WriteLine("Union of both sets:");
            foreach (var e in union)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }

        public static void Intersection(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> intersection = new HashSet<int>();

            foreach (var e in set1)
            {
                if (set2.Contains(e))
                {
                    intersection.Add(e);
                }
            }

            Console.WriteLine("Intersection of both sets:");
            foreach (var e in intersection)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}
