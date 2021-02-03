using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<string> Answers { get; private set; }
        public int CorrectAnswer { get; set; }
        public QuizQuestion(string question)
        {
            Question = question;
            Answers = new List<string>() { };
        }

        public void AddAnswer(string answer)
        {
            Answers.Add(answer);
        }
    }
}
