using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding.Set
{
    internal class Compare
    {
        public static void Main()
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 2, 1 };


            bool found = CompareSet(set1, set2);
            Console.WriteLine(found);


        }
        public static bool CompareSet(HashSet<int> set1, HashSet<int> set2)
        {
            foreach (var e in set1)
            {
                if (!set2.Contains(e))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
