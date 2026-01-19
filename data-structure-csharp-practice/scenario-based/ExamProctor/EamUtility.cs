using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProctor
{
    internal class ExamUtility : IExam
    {
        private Stack<int> navigationStack = new Stack<int>();
        private Dictionary<int, Exam> examQuestions = new Dictionary<int, Exam>();
        private Dictionary<int, string> studentAnswers = new Dictionary<int, string>();

        // Add question dynamically
        public void AddQuestion(int questionId, string correctAnswer)
        {
            if (!examQuestions.ContainsKey(questionId))
            {
                examQuestions.Add(questionId, new Exam(questionId, correctAnswer));
                Console.WriteLine("Question added successfully.");
            }
            else
            {
                Console.WriteLine("Question already exists.");
            }
        }

        // Track navigation
        public void VisitQuestion(int questionId)
        {
            if (!examQuestions.ContainsKey(questionId))
            {
                Console.WriteLine("Invalid Question ID.");
                return;
            }

            navigationStack.Push(questionId);
            Console.WriteLine("Visited Question: " + questionId);
        }

        // Go back
        public void GoBack()
        {
            if (navigationStack.Count == 0)
            {
                Console.WriteLine("No previous question.");
                return;
            }

            int last = navigationStack.Pop();
            Console.WriteLine("Moved back from Question: " + last);
        }

        // Store answer
        public void AnswerQuestion(int questionId, string answer)
        {
            if (!examQuestions.ContainsKey(questionId))
            {
                Console.WriteLine("Invalid Question ID.");
                return;
            }

            studentAnswers[questionId] = answer;
            Console.WriteLine("Answer saved.");
        }

        // Evaluate score
        public void EvaluateScore()
        {
            int score = 0;

            foreach (int qId in examQuestions.Keys)
            {
                if (studentAnswers.ContainsKey(qId))
                {
                    string studentAns = studentAnswers[qId];
                    string correctAns = examQuestions[qId].CorrectAnswer;

                    if (studentAns.Equals(correctAns,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        score++;
                    }
                }
            }

            Console.WriteLine("Exam Submitted.");
            Console.WriteLine("Final Score: " + score);
        }
    }
}
