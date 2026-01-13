using System;

namespace BookBuddy
{
    internal class BooksUtility
    {
        private string[,] books;
        private int count;

        public void AddBooks()
        {
            Console.WriteLine("Enter number of books:");
            count = int.Parse(Console.ReadLine());

            books = new string[count, 2];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Book Name:");
                books[i, 0] = Console.ReadLine();

                Console.WriteLine("Enter Author Name:");
                books[i, 1] = Console.ReadLine();
            }
        }

        public void SortBooks()
        {
            if (books == null)
            {
                Console.WriteLine("No books to sort.");
                return;
            }

            // Bubble sorting based on Book Name
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(books[i, 0], books[j, 0]) > 0)
                    {
                        // swap book name
                        string tempBook = books[i, 0];
                        books[i, 0] = books[j, 0];
                        books[j, 0] = tempBook;

                        // swap author
                        string tempAuthor = books[i, 1];
                        books[i, 1] = books[j, 1];
                        books[j, 1] = tempAuthor;
                    }
                }
            }

            Console.WriteLine("Books sorted successfully.");
        }

        public void SearchBooks()
        {
            if (books == null || count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("Enter author name to search:");
            string searchAuthor = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                // case-insensitive contains search
                if (books[i, 1]
                    .ToLower()
                    .Contains(searchAuthor.ToLower()))
                {
                    Console.WriteLine(books[i, 0] + " - " + books[i, 1]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found for this author.");
            }
        }


        public void DisplayBooks()
        {
            if (books == null)
            {
                Console.WriteLine("No books to display.");
                return;
            }

            Console.WriteLine("\nAll Books:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i, 0] + " - " + books[i, 1]);
            }
        }
    }
}
