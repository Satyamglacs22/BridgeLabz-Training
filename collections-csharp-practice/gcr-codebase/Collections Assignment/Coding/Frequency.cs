using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding
{
    internal class Frequency
    {
        public static void Main()
        {
            List<string> ls = new List<string>();
            ls.Add("Apple");
            ls.Add("Orange");
            ls.Add("Apple");


            CountFrequency(ls);

        }
        public static void CountFrequency(List<string> ls)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < ls.Count; i++)
            {
                map[ls[i]] = map.GetValueOrDefault(ls[i], 0) + 1;
            }

            foreach (var e in map)
            {
                Console.WriteLine(e.Key + "   " + e.Value);

            }
        }
    }
}
