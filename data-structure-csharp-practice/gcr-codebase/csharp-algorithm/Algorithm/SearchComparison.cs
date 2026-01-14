//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithm
//{
//    internal class SearchComparison
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[10000];

//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = i + 1;
//            }

//            int target = 9000;

//            Console.WriteLine("Linear Search Index: " + LinearSearch(arr, target));
//            Console.WriteLine("Binary Search Index: " + BinarySearch(arr, target));
//        }

//        static int LinearSearch(int[] arr, int target)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == target)
//                    return i;
//            }
//            return -1;
//        }

//        static int BinarySearch(int[] arr, int target)
//        {
//            int left = 0;
//            int right = arr.Length - 1;

//            while (left <= right)
//            {
//                int mid = (left + right) / 2;

//                if (arr[mid] == target)
//                    return mid;
//                else if (arr[mid] < target)
//                    left = mid + 1;
//                else
//                    right = mid - 1;
//            }
//            return -1;
//        }
//    }
//}
