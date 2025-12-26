//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Arrays
//{
//    public class Largest
//    {
//        public static void Main()
//        {
//            Console.Write("Enter a number: ");
//            int number = int.Parse(Console.ReadLine());

//            // PriorityQueue<Element, Priority>
//            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

//            // Step 1: Extract digits and add to PQ
//            while (number != 0)
//            {
//                int digit = number % 10;

//                // negative priority -> max heap behavior
//                pq.Enqueue(digit, -digit);

//                number /= 10;
//            }

//            // Step 2: Get largest and second largest
//            int largest = pq.Dequeue();

//            int secondLargest = largest;
//            while (pq.Count > 0)
//            {
//                int val = pq.Dequeue();
//                if (val != largest)
//                {
//                    secondLargest = val;
//                    break;
//                }
//            }

//            Console.WriteLine($"Largest = {largest}");
//            Console.WriteLine($"Second Largest = {secondLargest}");
//        }
//    }
//}
