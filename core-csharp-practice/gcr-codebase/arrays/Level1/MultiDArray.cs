using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class MatrixCopy
    {
        public static void Main()
        {
            
            int rows = int.Parse(Console.ReadLine());

            
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            int[] arr = new int[rows * cols];

            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    arr[index++] = matrix[i, j];
                }
            }

            Console.WriteLine("1D Array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
