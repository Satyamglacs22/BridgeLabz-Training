using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class InsertionSort
    {
        static void Main()
        {
            int[] empIds = { 105, 101, 109, 102, 108 };

            for (int i = 1; i < empIds.Length; i++)
            {
                int key = empIds[i];
                int j = i - 1;

                while (j >= 0 && empIds[j] > key)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }

                empIds[j + 1] = key;
            }

            Console.WriteLine("Sorted Employee IDs:");
            foreach (int id in empIds)
            {
                Console.Write(id + " ");
            }
        }
    }
}
