using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    public class MissingNumber
    {
        public static void Main() { 
            int n = int.Parse(Console.ReadLine());
        
            int[] arr = new int[n];
        for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //int n = arr.Length;
            int totalsum = (n * (n + 1)) / 2;
            int sum = 0;
            for(int i = 0; i <n; i++)
            {
                sum += arr[i];
            }
            int missing = totalsum - sum;
            Console.WriteLine(missing);

        }
    }
}
