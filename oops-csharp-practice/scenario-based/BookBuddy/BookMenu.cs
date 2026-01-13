using System;
using System.Collections.Generic;
using System.Text;

namespace BookBuddy
{
    internal class BookMenu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n--- BookBuddy Menu ---");
            Console.WriteLine("1. Add Books");
            Console.WriteLine("2. Sort Books");
            Console.WriteLine("3. Search Books by Author");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
        }
    }
}
