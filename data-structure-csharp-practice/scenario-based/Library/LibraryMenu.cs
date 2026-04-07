using System;

namespace BookSelf
{
    internal class LibraryMenu
    {
        private LibraryUtility utility;

        public LibraryMenu()
        {
            utility = new LibraryUtility();
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Library Menu =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Library");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        utility.AddBook(genre, title, author);
                        break;

                    case 2:
                        Console.Write("Enter Genre: ");
                        string g = Console.ReadLine();

                        Console.Write("Enter Book Title: ");
                        string t = Console.ReadLine();

                        utility.RemoveBook(g, t);
                        break;

                    case 3:
                        utility.DisplayLibrary();
                        break;

                    case 4:
                        Console.WriteLine("Exiting Library...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
