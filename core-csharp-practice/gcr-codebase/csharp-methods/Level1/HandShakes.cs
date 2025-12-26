//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;

//namespace Method.Level1
//{
//    public class HandShakes
//    {
//        public static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            int totalhandshakes = FindHandShakes(n);
//            Console.WriteLine($"Number of HandShakes for {n} student is {totalhandshakes}");
//        }
//        public static int FindHandShakes(int k)
//        {
//            int total = (k * (k - 1)) / 2;
//            return total;
//        }
//    }
//}
