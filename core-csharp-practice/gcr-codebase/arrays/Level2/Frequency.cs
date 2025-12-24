using System;
using System.Collections.Generic;
using System.Text;

namespace Level2
{
    public class Frequency
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = n;
            int count = 0;
            while (k != 0)
            {
                count++;
                int digit = k % 10;
                k /= 10;
            }
            int[] arr = new int[count];
            int j = 0;
            while (n != 0)
            {
                int digit = n % 10;
                arr[j++] = digit;
                n /= 10;
            }
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach(int num in arr)
            {
                map[num] = map.GetValueOrDefault(num, 0) + 1;
            }
            foreach (var e in map)
            {
                Console.WriteLine($"{e.Key}-->{e.Value}");
            }

        }
    }
}
