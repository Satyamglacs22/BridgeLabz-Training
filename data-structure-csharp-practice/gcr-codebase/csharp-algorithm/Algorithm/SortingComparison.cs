//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithm
//{
//    internal class SortingComparison
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 5, 3, 1, 4, 2 };

//            BubbleSort(arr);
//            Console.WriteLine("Bubble Sort Completed");

//            int[] arr2 = { 5, 3, 1, 4, 2 };
//            MergeSort(arr2, 0, arr2.Length - 1);
//            Console.WriteLine("Merge Sort Completed");
//        }

//        static void BubbleSort(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                for (int j = 0; j < arr.Length - 1; j++)
//                {
//                    if (arr[j] > arr[j + 1])
//                    {
//                        int temp = arr[j];
//                        arr[j] = arr[j + 1];
//                        arr[j + 1] = temp;
//                    }
//                }
//            }
//        }

//        static void MergeSort(int[] arr, int left, int right)
//        {
//            if (left >= right)
//                return;

//            int mid = (left + right) / 2;
//            MergeSort(arr, left, mid);
//            MergeSort(arr, mid + 1, right);
//            Merge(arr, left, mid, right);
//        }

//        static void Merge(int[] arr, int left, int mid, int right)
//        {
//            int[] temp = new int[right - left + 1];
//            int i = left, j = mid + 1, k = 0;

//            while (i <= mid && j <= right)
//            {
//                temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];
//            }

//            while (i <= mid)
//                temp[k++] = arr[i++];

//            while (j <= right)
//                temp[k++] = arr[j++];

//            for (int x = 0; x < temp.Length; x++)
//                arr[left + x] = temp[x];
//        }
//    }
//}
