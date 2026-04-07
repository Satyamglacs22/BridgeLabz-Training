using System;

namespace StringBuilder_LinerSearch_BinarySearch
{
    internal class FirstLastOccurrence
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 2, 3 };
            int target = 2;

            int first = -1, last = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    if (first == -1)
                        first = i;
                    last = i;
                }
            }

            Console.WriteLine("First Index: " + first);
            Console.WriteLine("Last Index: " + last);
        }
    }
}
