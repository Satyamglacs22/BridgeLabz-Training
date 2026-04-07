using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTime
{
    public class MovieUtility
    {
        private string[,] movies;
        private int count;

        public void AddMovies()
        {
            Console.WriteLine("Enter No of Movies to Be Added");
            count = int.Parse(Console.ReadLine());

            movies = new string[count, 2];
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Movie Name to Be Added");
                movies[i, 0] = Console.ReadLine();

                Console.WriteLine("Enter Time Stamp ");
                movies[i, 1] = Console.ReadLine();



            }
            Console.WriteLine("Movies Added SuccessFully");
        }
        public void SearchMovies()
        {
            Console.WriteLine("Enter the Movies that You Want to Search");
            string movieToSearch = Console.ReadLine();
            bool found = false;

            for(int i = 0; i < movies.GetLength(0); i++)
            {
                
                if (movies[i, 0].ToLower().Contains(movieToSearch.ToLower()))
                {
                    Console.WriteLine($"Movie Name is :{movies[i, 0]} and Its Time Stamp Is {movies[i, 1]}");
                    found = true;
                }
                
            }
            if (!found)
            {
                Console.WriteLine("Movie Not Found!");

            }

        }






        public void DisplayMovies()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Movie Name is :{movies[i, 0]} And Its Time Stamp is :{movies[i, 1]}");
            }
        }
    }
}
