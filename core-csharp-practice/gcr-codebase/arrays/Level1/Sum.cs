//using System;
//using System.Collections.Generic;
//using System.Text;


//namespace Arrays
//{
//    public class Sum
//    {
//        public static void Main()
//        {
//            double[] arr = new double[10];
//            int i = 0;

//            // input loop
//            while (i < 10)
//            {
//                double value = double.Parse(Console.ReadLine());

//                if (value <= 0)
//                    break;

//                arr[i] = value;
//                i++;
//            }

//            double sum = 0.0;

//            // sum only entered values
//            for (int j = 0; j < i; j++)
//            {
//                Console.WriteLine(arr[j]);
//                sum += arr[j];
//            }

//            Console.WriteLine($"Total Value is {sum}");
//        }
//    }
//}
