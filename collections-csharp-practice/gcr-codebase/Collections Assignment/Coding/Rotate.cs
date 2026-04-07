using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding
{
    internal class Rotate
    {
        public static void Main()
        {
            List<int> ls = new List<int>() { 10, 20, 30, 40, 50 };

            ListRotate(ls);

            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }
        }

        public static void ListRotate(List<int> ls)
        {
            Console.WriteLine("Enter the value upto which you want to rotate the list:");
            int k = int.Parse(Console.ReadLine());

            int n = ls.Count;
            k = k % n;

            List<int> temp = new List<int>();

            // Step 1: add elements from k to end
            for (int i = k; i < n; i++)
            {
                temp.Add(ls[i]);
            }

            // Step 2: add first k elements
            for (int i = 0; i < k; i++)
            {
                temp.Add(ls[i]);
            }

            // Step 3: copy back to original list
            for (int i = 0; i < n; i++)
            {
                ls[i] = temp[i];
            }
        }
    }
}
