//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithm
//{
//    internal class StringComparison
//    {
//        static void Main(string[] args)
//        {
//            int n = 10000;

//            // ================= STRING CONCATENATION =================
//            // Time Complexity: O(N^2)
//            Console.WriteLine("String Concatenation Started");

//            string normalString = "";

//            for (int i = 0; i < n; i++)
//            {
//                normalString = normalString + "A";
//            }

//            Console.WriteLine("String Concatenation Completed");

//            // ================= STRINGBUILDER CONCATENATION =================
//            // Time Complexity: O(N)
//            Console.WriteLine("\nStringBuilder Concatenation Started");

//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < n; i++)
//            {
//                sb.Append("A");
//            }

//            Console.WriteLine("StringBuilder Concatenation Completed");

//            Console.WriteLine("\nConclusion:");
//            Console.WriteLine("StringBuilder is faster and memory efficient than String");
//        }
//    }
//}
