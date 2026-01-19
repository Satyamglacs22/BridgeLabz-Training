using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProctor
{
    internal class Exam
    {
        private int questionId;
        private string correctAnswer;


        public Exam(int questionId, string correctAnswer)
        {
            this.questionId = questionId;
            this.correctAnswer = correctAnswer;

        }
        public int QuestionId
        {
            get
            {
                return questionId;
            }
            set
            {
                questionId = value;
            }

        }
        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                correctAnswer = value;
            }
        }
    }
}
