using System;

namespace BookSelf
{
    internal class LibraryUtility : ILibrary
    {
        // ===== Custom HashMap Bucket =====
        private class GenreNode
        {
            public string Genre;
            public Library Head;      // LinkedList of books
            public GenreNode Next;    // Collision handling

            public GenreNode(string genre)
            {
                Genre = genre;
                Head = null;
                Next = null;
            }
        }

        private GenreNode[] table;
        private int size = 5;

        public LibraryUtility()
        {
            table = new GenreNode[size];
        }

        // ===== Hash Function =====
        private int GetIndex(string genre)
        {
            int sum = 0;
            foreach (char ch in genre)
            {
                sum += ch;
            }
            return sum % size;
        }

        // ===== ADD BOOK =====
        public void AddBook(string genre, string title, string author)
        {
            int index = GetIndex(genre);
            GenreNode current = table[index];

            while (current != null)
            {
                if (current.Genre.Equals(genre))
                {
                    AddBookToList(current, title, author);
                    return;
                }
                current = current.Next;
            }

            GenreNode newGenre = new GenreNode(genre);
            newGenre.Next = table[index];
            table[index] = newGenre;

            AddBookToList(newGenre, title, author);
        }

        private void AddBookToList(GenreNode genreNode, string title, string author)
        {
            Library temp = genreNode.Head;

            while (temp != null)
            {
                if (temp.Title.Equals(title))
                {
                    Console.WriteLine("Duplicate book not allowed.");
                    return;
                }
                temp = temp.Next;
            }

            Library newBook = new Library(title, author);
            newBook.Next = genreNode.Head;
            genreNode.Head = newBook;

            Console.WriteLine("Book added successfully.");
        }

        // ===== REMOVE BOOK =====
        public void RemoveBook(string genre, string title)
        {
            int index = GetIndex(genre);
            GenreNode current = table[index];

            while (current != null)
            {
                if (current.Genre.Equals(genre))
                {
                    RemoveFromList(current, title);
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Genre not found.");
        }

        private void RemoveFromList(GenreNode genreNode, string title)
        {
            Library curr = genreNode.Head;
            Library prev = null;

            while (curr != null)
            {
                if (curr.Title.Equals(title))
                {
                    if (prev == null)
                        genreNode.Head = curr.Next;
                    else
                        prev.Next = curr.Next;

                    Console.WriteLine("Book removed successfully.");
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }

            Console.WriteLine("Book not found.");
        }

        // ===== DISPLAY =====
        public void DisplayLibrary()
        {
            for (int i = 0; i < size; i++)
            {
                GenreNode genre = table[i];
                while (genre != null)
                {
                    Console.WriteLine("\nGenre: " + genre.Genre);
                    Library book = genre.Head;

                    if (book == null)
                        Console.WriteLine("  No books");

                    while (book != null)
                    {
                        Console.WriteLine("  " + book.Title + " by " + book.Author);
                        book = book.Next;
                    }
                    genre = genre.Next;
                }
            }
        }
    }
}
