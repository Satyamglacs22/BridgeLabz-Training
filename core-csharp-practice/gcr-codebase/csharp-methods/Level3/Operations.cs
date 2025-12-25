//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class Operations
//    {
//        public static void Main()
//        {
//            int[,] a = GenerateMatrix(3, 3);
//            int[,] b = GenerateMatrix(3, 3);

//            Display(Add(a, b));
//            Display(Subtract(a, b));
//            Display(Multiply(a, b));
//            Display(Transpose(a));

//            Console.WriteLine(Determinant2x2(new int[,] { { 1, 2 }, { 3, 4 } }));
//            Console.WriteLine(Determinant3x3(a));
//        }

//        public static int[,] GenerateMatrix(int r, int c)
//        {
//            Random random = new Random();
//            int[,] m = new int[r, c];

//            for (int i = 0; i < r; i++)
//                for (int j = 0; j < c; j++)
//                    m[i, j] = random.Next(1, 10);

//            return m;
//        }

//        public static int[,] Add(int[,] a, int[,] b)
//        {
//            int[,] r = new int[3, 3];
//            for (int i = 0; i < 3; i++)
//                for (int j = 0; j < 3; j++)
//                    r[i, j] = a[i, j] + b[i, j];
//            return r;
//        }

//        public static int[,] Subtract(int[,] a, int[,] b)
//        {
//            int[,] r = new int[3, 3];
//            for (int i = 0; i < 3; i++)
//                for (int j = 0; j < 3; j++)
//                    r[i, j] = a[i, j] - b[i, j];
//            return r;
//        }

//        public static int[,] Multiply(int[,] a, int[,] b)
//        {
//            int[,] r = new int[3, 3];
//            for (int i = 0; i < 3; i++)
//                for (int j = 0; j < 3; j++)
//                    for (int k = 0; k < 3; k++)
//                        r[i, j] += a[i, k] * b[k, j];
//            return r;
//        }

//        public static int[,] Transpose(int[,] a)
//        {
//            int[,] t = new int[3, 3];
//            for (int i = 0; i < 3; i++)
//                for (int j = 0; j < 3; j++)
//                    t[j, i] = a[i, j];
//            return t;
//        }

//        public static int Determinant2x2(int[,] m)
//        {
//            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
//        }

//        public static int Determinant3x3(int[,] m)
//        {
//            return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
//                 - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
//                 + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
//        }

//        public static void Display(int[,] m)
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                    Console.Write(m[i, j] + " ");
//                Console.WriteLine();
//            }
//        }
//    }
//}
