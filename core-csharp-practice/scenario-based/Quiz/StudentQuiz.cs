using System;

namespace Quiz
{
    public class StudentQuiz
    {
        //This program is a menu-driven Quiz application . 
        // It stores correct answers and student answers for 10 questions using arrays.
        //The program allows the user to compare answers, count the total number of correct responses, and 
        //display feedback for each question (correct or wrong) and also Percentage and Pass Or Fail Status.
        //A loop-based menu lets the user choose different operations until they decide to exit.




        string[] correctAnswers = new string[10];
        string[] studentAnswers = new string[10];

        public static void Main()
        {
            StudentQuiz qz = new StudentQuiz();

            Console.WriteLine("Enter correct answers and student answers:");
            // User Input
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Correct Answer {i + 1}: ");
                qz.correctAnswers[i] = Console.ReadLine();

                Console.Write($"Student Answer {i + 1}: ");
                qz.studentAnswers[i] = Console.ReadLine();
            }

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n---- Quiz Menu ----");
                Console.WriteLine("1. Total Correct Answers");
                Console.WriteLine("2. Feedback");
                Console.WriteLine("3. Percentage & Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Total Correct Answers: " + qz.GetCorrectCount());
                        break;

                    case 2:
                        qz.ShowFeedback();
                        break;

                    case 3:
                        qz.ShowPercentageAndResult();
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting Quiz...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // Method to count correct answers
        public int GetCorrectCount()
        {
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            return count;
        }

        // Method to give feedback
        public void ShowFeedback()
        {
            for (int i = 0; i < 10; i++)
            {
                if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Q{i + 1}: Correct");
                }
                else
                {
                    Console.WriteLine($"Q{i + 1}: Wrong (Correct: {correctAnswers[i]})");
                }
            }
        }

        // Method to calculate percentage and check pass/fail
        public void ShowPercentageAndResult()
        {
            int correctCount = GetCorrectCount();
            double percentage = (correctCount / 10.0) * 100;

            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage >= 40)
            {
                Console.WriteLine("Result: PASS");
            }
            else
            {
                Console.WriteLine("Result: FAIL");
            }
        }
    }
}
