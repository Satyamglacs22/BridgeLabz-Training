using System;
using System.Collections.Generic;
using System.Text;
namespace AadharNumber
{
    internal class AadharUtility : IAadhar
    {
        // ===== Get Maximum =====
        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        // ===== Counting Sort =====
        public void CountingSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        // ===== Radix Sort =====
        public void RadixSort(int[] arr)
        {
            int max = GetMax(arr);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(arr, exp);
            }

            Console.WriteLine("Aadhar numbers sorted successfully.");
        }

        // ===== Binary Search =====
        public void BinarySearch(int[] arr, int key)
        {
            int low = 0, high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == key)
                {
                    Console.WriteLine("Aadhar found at index " + mid);
                    return;
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("Aadhar number not found.");
        }

        // ===== Display =====
        public void Display(int[] arr)
        {
            Console.WriteLine("Aadhar Numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
