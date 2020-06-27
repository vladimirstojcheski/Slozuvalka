using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сложувалка
{
    public class Question
    {
        public String answerOne { get; set; }
        public String answerTwo { get; set; }
        public String answerThree { get; set; }
        public String answerFour { get; set; }
        public String correctAnswer { get; set; }

        public Question(String answerOne, String answerTwo, String answerThree, 
            String answerFour, String correctAnswer)
        {
            this.answerOne = answerOne;
            this.answerTwo = answerTwo;
            this.answerThree = answerThree;
            this.answerFour = answerFour;
            this.correctAnswer = correctAnswer;
        }
    }
}
