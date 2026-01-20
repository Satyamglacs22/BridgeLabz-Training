using System;
using System.Collections.Generic;
using System.Text;

namespace AadharNumber
{
    internal class AadharMenu
    {
        private int[] arr;   // size 12 digit array
        private AadharUtility utility;

        public AadharMenu()
        {
            utility = new AadharUtility();

            Console.Write("Enter 12-digit Aadhar number: ");
            long aadhar = long.Parse(Console.ReadLine());

            arr = ConvertToArray(aadhar);
        }

        // 🔹 Long → int[12] conversion
        private int[] ConvertToArray(long number)
        {
            int[] digits = new int[12];

            for (int i = 11; i >= 0; i--)
            {
                digits[i] = (int)(number % 10);
                number = number / 10;
            }

            return digits;
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Sort Digits (Radix Sort)");
                Console.WriteLine("2. Search Digit (Binary Search)");
                Console.WriteLine("3. Display Digits");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.RadixSort(arr);
                        break;

                    case 2:
                        Console.Write("Enter digit to search (0-9): ");
                        int key = int.Parse(Console.ReadLine());
                        utility.BinarySearch(arr, key);
                        break;

                    case 3:
                        utility.Display(arr);
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                }

            } while (choice != 4);
        }
    }
}
