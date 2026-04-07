using System;

namespace BookBuddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BooksUtility utility = new BooksUtility();
            int choice;

            do
            {
                BookMenu.ShowMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddBooks();
                        break;
                    case 2:
                        utility.SortBooks();
                        break;
                    case 3:
                        utility.SearchBooks();
                        break;
                    case 4:
                        utility.DisplayBooks();
                        break;
                    case 5:
                        Console.WriteLine("Exiting BookBuddy...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
