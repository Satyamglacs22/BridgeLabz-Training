using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class BubbleSort
    {
        static void Main()
        {
            int[] marks = { 65, 85, 45, 90, 75 };

            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = 0; j < marks.Length - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Student Marks:");
            foreach (int m in marks)
            {
                Console.Write(m + " ");
            }
        }
    }
}
