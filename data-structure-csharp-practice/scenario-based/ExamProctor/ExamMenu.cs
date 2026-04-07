using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProctor
{
    internal class ExamMenu
    {
        private ExamUtility utility = new ExamUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Exam Proctor Menu ---");
                Console.WriteLine("1. Add Question");
                Console.WriteLine("2. Visit Question");
                Console.WriteLine("3. Go Back");
                Console.WriteLine("4. Answer Question");
                Console.WriteLine("5. Submit Exam");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Question ID: ");
                        int qId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Correct Answer: ");
                        string correct = Console.ReadLine();
                        utility.AddQuestion(qId, correct);
                        break;

                    case 2:
                        Console.Write("Enter Question ID to visit: ");
                        int visitId = int.Parse(Console.ReadLine());
                        utility.VisitQuestion(visitId);
                        break;

                    case 3:
                        utility.GoBack();
                        break;

                    case 4:
                        Console.Write("Enter Question ID: ");
                        int ansId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Your Answer: ");
                        string ans = Console.ReadLine();
                        utility.AnswerQuestion(ansId, ans);
                        break;

                    case 5:
                        utility.EvaluateScore();
                        break;

                    case 6:
                        Console.WriteLine("Exiting Exam System.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
