using System;
using System.Collections.Generic;

class PairWithSum
{
    static void FindPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(target - num))
            {
                Console.WriteLine("Pair found");
                return;
            }
            set.Add(num);
        }
        Console.WriteLine("Pair not found");
    }

    static void Main()
    {
        int[] arr = { 8, 7, 2, 5, 3, 1 };
        FindPair(arr, 10);
    }
}
