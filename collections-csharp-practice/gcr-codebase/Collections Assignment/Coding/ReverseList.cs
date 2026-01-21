using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding
{
    internal class ReverseList
    {

        public static void Main()
        {
            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Add(20);
            ls.Add(30);

            ListReverse(ls);

            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine($"{ls[i]} ");
            }
        }

        public static void ListReverse(List<int> ls)
        {
            int left = 0;
            int right = ls.Count - 1;
            while (left < right)
            {
                int temp = ls[left];
                ls[left] = ls[right];
                ls[right] = temp;
                left++;
                right--;
            }
        }
    }
}
