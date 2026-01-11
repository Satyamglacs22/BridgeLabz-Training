using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class MergeSort
    {
        static void MergeSortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSortArray(arr, left, mid);
                MergeSortArray(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex] <= R[jIndex])
                    arr[k++] = L[iIndex++];
                else
                    arr[k++] = R[jIndex++];
            }

            while (iIndex < n1)
                arr[k++] = L[iIndex++];

            while (jIndex < n2)
                arr[k++] = R[jIndex++];
        }

        static void Main()
        {
            int[] prices = { 350, 200, 450, 150, 300 };

            MergeSortArray(prices, 0, prices.Length - 1);

            Console.WriteLine("Sorted Book Prices:");
            foreach (int p in prices)
            {
                Console.Write(p + " ");
            }
        }
    }
}
