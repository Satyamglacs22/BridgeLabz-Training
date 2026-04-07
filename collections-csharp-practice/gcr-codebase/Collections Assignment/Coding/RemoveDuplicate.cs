using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding
{
    internal class RemoveDuplicate
    {
        public static void Main()
        {
            List<int> ls = new List<int>() { 10, 10, 20, 30, 20 };

            DuplicateRemove(ls);
        }
        public static void DuplicateRemove(List<int> ls)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in ls)
            {
                set.Add(num);
            }

            foreach (var e in set)
            {
                Console.WriteLine(e);
            }
        }
    }
}
