using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProctor
{
    internal interface IExam
    {
        void VisitQuestion(int questionId);
        void GoBack();
        void AnswerQuestion(int questionId,string answer);
        void EvaluateScore();
    }
}
