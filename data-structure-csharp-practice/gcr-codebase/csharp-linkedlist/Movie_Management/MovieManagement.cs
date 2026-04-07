using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Movie_Management
{
    // Node Class
    public class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public MovieNode Prev;
        public MovieNode Next;

        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Prev = null;
            Next = null;
        }
    }

    // Doubly Linked List Class
    public class MovieLinkedList
    {
        private MovieNode head;
        private MovieNode tail;

        // Add at Beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode node = new MovieNode(title, director, year, rating);

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
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode node = new MovieNode(title, director, year, rating);

            if (head == null)
            {
                head = tail = node;
                return;
            }

            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }

        // Remove by Movie Title
        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.Title.Equals(title))
                {
                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    else
                        head = temp.Next;

                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;
                    else
                        tail = temp.Prev;

                    Console.WriteLine("Movie removed successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Movie not found");
        }

        // Search by Director
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Director.Equals(director))
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movie found for given director");
        }

        // Search by Rating
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Rating >= rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movie found with given rating");
        }

        // Display Forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movies available");
                return;
            }

            MovieNode temp = head;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Next;
            }
        }

        // Display Reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movies available");
                return;
            }

            MovieNode temp = tail;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Prev;
            }
        }

        private void DisplayMovie(MovieNode movie)
        {
            Console.WriteLine($"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}");
        }
    }

    // Main / Utility Class
    public class MovieManagement
    {
        public static void Main(string[] args)
        {
            MovieLinkedList list = new MovieLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Movie Management System ---");
                Console.WriteLine("1. Add Movie at Beginning");
                Console.WriteLine("2. Add Movie at End");
                Console.WriteLine("3. Remove Movie by Title");
                Console.WriteLine("4. Search by Director");
                Console.WriteLine("5. Search by Rating");
                Console.WriteLine("6. Display Forward");
                Console.WriteLine("7. Display Reverse");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Director: ");
                        string director = Console.ReadLine();
                        Console.Write("Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Rating: ");
                        double rating = double.Parse(Console.ReadLine());

                        if (choice == 1)
                            list.AddAtBeginning(title, director, year, rating);
                        else
                            list.AddAtEnd(title, director, year, rating);
                        break;

                    case 3:
                        Console.Write("Enter Title: ");
                        list.RemoveByTitle(Console.ReadLine());
                        break;

                    case 4:
                        Console.Write("Enter Director: ");
                        list.SearchByDirector(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Enter Minimum Rating: ");
                        list.SearchByRating(double.Parse(Console.ReadLine()));
                        break;

                    case 6:
                        list.DisplayForward();
                        break;

                    case 7:
                        list.DisplayReverse();
                        break;

                    case 0:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
