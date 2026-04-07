using System;
using System.Collections.Generic;

class LongestConsecutive
{
    static int FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);
        int longest = 0;

        foreach (int num in arr)
        {
            if (!set.Contains(num - 1))
            {
                int count = 1;
                int current = num;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }
        return longest;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(FindLongest(arr));
    }
}
