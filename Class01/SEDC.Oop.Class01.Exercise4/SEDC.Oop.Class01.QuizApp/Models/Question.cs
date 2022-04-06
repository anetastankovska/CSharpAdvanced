using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Answers { get; set; }

        private string correctAnswer;

        public Question() { }

        public Question(string text, string[] answers, string correct)
        {
            Text = text;
            Answers = answers;
            correctAnswer = correct;
        }

        public bool isAnswerCorrect(string answer)
        {
            return correctAnswer.StartsWith(answer);
        }
    }
}
