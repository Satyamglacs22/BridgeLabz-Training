using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    public class LibraryManagement
    {
    // This program is a menu-driven Library Management System developed in . 
    // It uses a two-dimensional string array to store book details such as title, author, and status. 
    // The application follows a role-based approach, allowing users to log in either as a User or an Admin.
    // The Admin has full access to add new books, display all books, search for a specific book, and check the library
    // status, while the User can only view books, search for them, and check availability. The program makes use of loop
    // and switch-case statements to display interactive menus and continues to run until the user chooses to exit. Overall, 
    // it demonstrates the practical use of arrays, methods, conditional logic, and menu-driven programming in C#.
        public static void Main(string[] args)
        {
            LibraryManagement lm = new LibraryManagement();

            Console.WriteLine("Enter number of books:");
            int n = int.Parse(Console.ReadLine());

            string[,] books = new string[n, 3];

            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Select Role =====");
                Console.WriteLine("1. User");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                int role = int.Parse(Console.ReadLine());

                switch (role)
                {
                    // ---------------- USER MENU ----------------
                    case 1:
                        bool userExit = false;

                        while (!userExit)
                        {
                            Console.WriteLine("\n--- User Menu ---");
                            Console.WriteLine("1. Display All Books");
                            Console.WriteLine("2. Search Book");
                            Console.WriteLine("3. Show Status");
                            Console.WriteLine("4. Back");
                            Console.Write("Enter choice: ");
                            int userChoice = int.Parse(Console.ReadLine());

                            switch (userChoice)
                            {
                                case 1:
                                    lm.DisplayBooks(books, n);
                                    break;

                                case 2:
                                    Console.Write("Enter title to search: ");
                                    string title = Console.ReadLine();
                                    lm.SearchBook(books, title, n);
                                    break;

                                case 3:
                                    lm.ShowStatus(n);
                                    break;

                                case 4:
                                    userExit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }
                        }
                        break;

                    // ---------------- ADMIN MENU ----------------
                    case 2:
                        bool adminExit = false;

                        while (!adminExit)
                        {
                            Console.WriteLine("\n--- Admin Menu ---");
                            Console.WriteLine("1. Add Books");
                            Console.WriteLine("2. Display All Books");
                            Console.WriteLine("3. Search Book");
                            Console.WriteLine("4. Show Status");
                            Console.WriteLine("5. Back");
                            Console.Write("Enter choice: ");
                            int adminChoice = int.Parse(Console.ReadLine());

                            switch (adminChoice)
                            {
                                case 1:
                                    lm.AddBooks(books, n);
                                    break;

                                case 2:
                                    lm.DisplayBooks(books, n);
                                    break;

                                case 3:
                                    Console.Write("Enter title to search: ");
                                    string title = Console.ReadLine();
                                    lm.SearchBook(books, title, n);
                                    break;

                                case 4:
                                    lm.ShowStatus(n);
                                    break;

                                case 5:
                                    adminExit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }
                        }
                        break;

                    // ---------------- EXIT ----------------
                    case 3:
                        exitApp = true;
                        Console.WriteLine("Application Terminated");
                        break;

                    default:
                        Console.WriteLine("Invalid Role Selection");
                        break;
                }
            }
        }

        // ---------------- METHODS ----------------

        public void AddBooks(string[,] books, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Book {i + 1}");
                Console.Write("Title: ");
                books[i, 0] = Console.ReadLine();
                Console.Write("Author: ");
                books[i, 1] = Console.ReadLine();
                Console.Write("Status: ");
                books[i, 2] = Console.ReadLine();
            }
        }

        public void DisplayBooks(string[,] books, int n)
        {
            Console.WriteLine("\n--- Book List ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}");
            }
        }

        public void SearchBook(string[,] books, string searchBook, int n)
        {
            bool found = false;
            searchBook = searchBook.ToLower();

            for (int i = 0; i < n; i++)
            {
                if (books[i, 0].ToLower().Contains(searchBook))
                {
                    Console.WriteLine($"Book Found → Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book Not Found");
            }
        }

        public void ShowStatus(int n)
        {
            if (n > 0)
                Console.WriteLine("Library has books available");
            else
                Console.WriteLine("No books available");
        }
    }
}
