using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding.Set
{
    internal class SortedSet1
    {
        public static void Main()
        {
            HashSet<int> set = new HashSet<int>() { 5, 4, 1, 2, 6, 3 };

            SetSorted(set);



        }
        public static void SetSorted(HashSet<int> set)
        {
            SortedSet<int> result = new SortedSet<int>();
            foreach (var e in set)
            {
                result.Add(e);
            }
            foreach (var e in result)
            {
                Console.WriteLine(e);
            }
        }
    }
}
