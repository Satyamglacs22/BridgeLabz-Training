using System;

namespace StringBuilder_LinerSearch_BinarySearch
{
    internal class FirstNegativeNumber
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, -3, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("First Negative Number: " + arr[i]);
                    break;
                }
            }
        }
    }
}
