using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AP_Walter3
{
    class TriviaQuestion
    {

        private string Questions;
        private int Answer;
        private string Answer1;
        private string Answer2;
        private string Answer3;
        private string Answer4;

        // this is called the default constructor
        public TriviaQuestion()
        {
            Questions = "";
            Answer = 0;
            Answer1 = "";
            Answer2 = "";
            Answer3 = "";
            Answer4 = "";
        }

        public TriviaQuestion(string Question, int Answer, string Answer1, string Answer2, string Answer3, string Answer4)
        {
            SetQuestion(Question);
            SetAnswer(Answer);
            SetQuestion1(Answer1);
            SetQuestion2(Answer2);
            SetQuestion3(Answer3);
            SetQuestion4(Answer4);
        }

        public void SetQuestion(string param)
        {
            Questions = param;
        }
        public string GetQuestion()
        {
            return Questions;
        }

        public void SetQuestion1(string param)
        {
            Answer1 = param;
        }
        public string GetQuestion1()
        {
            return Answer1;
        }

        public void SetQuestion2(string param)
        {
            Answer2 = param;
        }
        public string GetQuestion2()
        {
            return Answer2;
        }

        public void SetQuestion3(string param)
        {
            Answer3 = param;
        }
        public string GetQuestion3()
        {
            return Answer3;
        }

        public void SetQuestion4(string param)
        {
            Answer4 = param;
        }
        public string GetQuestion4()
        {
            return Answer4;
        }

        public void SetAnswer(int param)
        {
            if (param >= 0)
            {
                Answer = param;
            }
            else
            {
                throw new FormatException("Price must be greater than 0");
            }
        }
        public int GetAnswer()
        {
            return Answer;
        }
    }
}
