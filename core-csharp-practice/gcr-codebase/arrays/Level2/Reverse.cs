//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level2
//{
//    public class Reverse
//    {
//        public static void Main() {
            
//                int n = int.Parse(Console.ReadLine());
//                int count = 0;
//                int k = n;  
//                while (k != 0)
//                {
//                    count++;
//                    int digit = k % 10;
//                     k /= 10;
//                }
//            int[] arr = new int[count];
//            int j = 0;
//            while (n != 0)
//            {
//                int num = n % 10;
//                arr[j] = num;
//                j++;

//                n /= 10;

//            }
//            for(int i =0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i]);
//            }
               
//            }
//        }
//}
