using System;
using System.Collections.Generic;
using System.Text;

namespace Scenario
{
    public class StudentScores
    {
        public static void Main()
        {
            // Creating object of StudentScores class

            StudentScores obj = new StudentScores();

            // Taking number of students from the user
            Console.WriteLine("Enter number of students:");
            int n = int.Parse(Console.ReadLine());

            // Creating array to store student scores
            int[] scores = new int[n];

            // Taking scores input from the user
            for (int i = 0; i < n; i++)
            {
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write($"Enter score for student {i + 1}: ");
                    int value = int.Parse(Console.ReadLine());

                    // Checking for negative score
                    if (value < 0)
                    {
                        Console.WriteLine("Score cannot be negative. Try again.");
                    }
                    else
                    {
                        scores[i] = value;
                        validInput = true;
                    }
                }
            }

            // Boolean variable to control menu loop
            bool check = true;

            // Menu will repeat until user chooses Exit
            while (check)
            {
                // Displaying menu options
                Console.WriteLine("\nPress 1 to calculate average score");
                Console.WriteLine("Press 2 to find highest and lowest scores");
                Console.WriteLine("Press 3 to display scores above average");
                Console.WriteLine("Press 4 to exit");

                // Taking user choice
                int choice = int.Parse(Console.ReadLine());

                // Switch case to perform selected operation
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Average Score: " + obj.CalculateAverage(scores));
                        break;

                    case 2:
                        obj.FindHighestAndLowest(scores);
                        break;

                    case 3:
                        obj.DisplayAboveAverage(scores);
                        break;

                    case 4:
                        Console.WriteLine("Program terminated.");
                        check = false; // Stops the while loop
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        // Method to calculate average score
        public double CalculateAverage(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return (double)sum / arr.Length;
        }

        // Method to find highest and lowest scores
        public void FindHighestAndLowest(int[] arr)
        {
            int highest = arr[0];
            int lowest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > highest)
                    highest = arr[i];

                if (arr[i] < lowest)
                    lowest = arr[i];
            }

            Console.WriteLine("Highest Score: " + highest);
            Console.WriteLine("Lowest Score: " + lowest);
        }

        // Method to display scores above average
        public void DisplayAboveAverage(int[] arr)
        {
            double average = CalculateAverage(arr);

            Console.WriteLine("Scores above average (" + average + "):");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > average)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
