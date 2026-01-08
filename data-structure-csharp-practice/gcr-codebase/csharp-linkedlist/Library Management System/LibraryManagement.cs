using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Library_Management_System
{
    // Node Class
    public class BookNode
    {
        public int BookId;
        public string Title;
        public string Author;
        public string Genre;
        public bool IsAvailable;
        public BookNode Prev;
        public BookNode Next;

        public BookNode(int id, string title, string author, string genre)
        {
            BookId = id;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = true;
            Prev = null;
            Next = null;
        }
    }

    // Doubly Linked List Class
    public class LibraryLinkedList
    {
        private BookNode head;
        private BookNode tail;

        // Add at Beginning
        public void AddAtBeginning(int id, string title, string author, string genre)
        {
            BookNode node = new BookNode(id, title, author, genre);

            if (head == null)
            {
                head = tail = node;
                return;
            }

            node.Next = head;
            head.Prev = node;
            head = node;
        }

        // Add at End
        public void AddAtEnd(int id, string title, string author, string genre)
        {
            BookNode node = new BookNode(id, title, author, genre);

            if (head == null)
            {
                head = tail = node;
                return;
            }

            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }

        // Remove by Book ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            BookNode temp = head;
            while (temp != null)
            {
                if (temp.BookId == id)
                {
                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    else
                        head = temp.Next;

                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;
                    else
                        tail = temp.Prev;

                    Console.WriteLine("Book removed successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found");
        }

        // Search by Title
        public void SearchByTitle(string title)
        {
            BookNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Title.Equals(title))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Book not found");
        }

        // Search by Author
        public void SearchByAuthor(string author)
        {
            BookNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Author.Equals(author))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Book not found");
        }

        // Update Availability
        public void UpdateAvailability(int id, bool status)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.BookId == id)
                {
                    temp.IsAvailable = status;
                    Console.WriteLine("Availability updated");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found");
        }

        // Display Forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No books available");
                return;
            }

            BookNode temp = head;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.Next;
            }
        }

        // Display Reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No books available");
                return;
            }

            BookNode temp = tail;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.Prev;
            }
        }

        // Count Total Books
        public int CountBooks()
        {
            int count = 0;
            BookNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        private void DisplayBook(BookNode book)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
    }

    // Main / Utility Class
    public class LibraryManagement
    {
        public static void Main(string[] args)
        {
            LibraryLinkedList list = new LibraryLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Library Management System ---");
                Console.WriteLine("1. Add Book at Beginning");
                Console.WriteLine("2. Add Book at End");
                Console.WriteLine("3. Remove Book by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Search by Author");
                Console.WriteLine("6. Update Availability");
                Console.WriteLine("7. Display Forward");
                Console.WriteLine("8. Display Reverse");
                Console.WriteLine("9. Count Books");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                        Console.Write("Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();

                        if (choice == 1)
                            list.AddAtBeginning(id, title, author, genre);
                        else
                            list.AddAtEnd(id, title, author, genre);
                        break;

                    case 3:
                        Console.Write("Enter Book ID: ");
                        list.RemoveById(int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("Enter Title: ");
                        list.SearchByTitle(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Enter Author: ");
                        list.SearchByAuthor(Console.ReadLine());
                        break;

                    case 6:
                        Console.Write("Enter Book ID: ");
                        int bid = int.Parse(Console.ReadLine());
                        Console.Write("Available (true/false): ");
                        bool status = bool.Parse(Console.ReadLine());
                        list.UpdateAvailability(bid, status);
                        break;

                    case 7:
                        list.DisplayForward();
                        break;

                    case 8:
                        list.DisplayReverse();
                        break;

                    case 9:
                        Console.WriteLine("Total Books: " + list.CountBooks());
                        break;

                    case 0:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
