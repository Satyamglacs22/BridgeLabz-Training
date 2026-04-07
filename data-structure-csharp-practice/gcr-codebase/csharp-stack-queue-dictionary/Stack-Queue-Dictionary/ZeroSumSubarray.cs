using System;
using System.Collections.Generic;

class ZeroSumSubarray
{
    static void Check(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        int sum = 0;

        foreach (int num in arr)
        {
            sum += num;

            if (set.Contains(sum))
            {
                Console.WriteLine("Zero sum subarray exists");
                return;
            }
            set.Add(sum);
        }
        Console.WriteLine("No zero sum subarray");
    }

    static void Main()
    {
        int[] arr = { 4, 2, -3, 1, 6 };
        Check(arr);
    }
}
