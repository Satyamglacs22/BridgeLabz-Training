//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level1
//{
//    public class Chocolates
//    {
//        public static void Main()
//        {
//            int choco = int.Parse(Console.ReadLine());
//            int children = int.Parse(Console.ReadLine());
//            int[] arr = new int[2];
//            NumberOfChocolates(choco, children, arr);
//            Console.WriteLine($"Each Children gets {arr[0]} chocolates");
//            Console.WriteLine($"Number of Chocolates left is {arr[1]}");
//        }
//        public static int[] NumberOfChocolates(int choco, int children, int[] arr)
//        {
//            int eachchild = choco / children;
//            int leftchoco = choco % children;
//            arr[0] = eachchild;
//            arr[1] = leftchoco;
//            return arr;
//        }
//    }
//}
