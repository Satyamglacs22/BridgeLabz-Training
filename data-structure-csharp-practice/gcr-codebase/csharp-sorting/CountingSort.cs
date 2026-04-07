using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class CountingSort
    {
        static void Main()
        {
            int[] ages = { 12, 15, 11, 14, 13, 12, 16 };
            int min = 10;
            int max = 18;

            int[] count = new int[max - min + 1];

            for (int i = 0; i < ages.Length; i++)
            {
                count[ages[i] - min]++;
            }

            Console.WriteLine("Sorted Student Ages:");
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    Console.Write((i + min) + " ");
                    count[i]--;
                }
            }
        }
    }
}
