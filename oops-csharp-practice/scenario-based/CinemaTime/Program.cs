//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTime
{
    class Program
    {
        public static void Main()
        {
            MovieMenu m = new MovieMenu();
            m.Show();
            MovieUtility u = new MovieUtility();

            //int n = int.Parse(Console.ReadLine());
            bool check = false;
            while (!check)
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        u.AddMovies();
                        m.Show();
                        break;
                    case 2:
                         u.SearchMovies();
                         m.Show();
                        break;

                    case 3:
                            u.DisplayMovies();
                            m.Show();
                        break;

                    case 4:
                        check = true;
                        break;
                }
            }

        }
    }
}