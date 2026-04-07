using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding.Map
{
    internal class Frequency
    {
        public static void Main()
        {
            List<string> ls = new List<string>();
            TakeInput(ls);

            CalculateFrequency(ls);
        }
        public static void TakeInput(List<string> ls)
        {
            Console.WriteLine("Enter the Number of Words in the Book");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} Word");
                string input = Console.ReadLine();
                ls.Add(input);
            }
        }
        public static void CalculateFrequency(List<string> ls)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string e in ls)
            {
                map[e] = map.GetValueOrDefault(e, 0) + 1;
            }

            foreach (var e in map)
            {
                Console.WriteLine(e.Key + " " + e.Value);
            }
        }


    }
}
