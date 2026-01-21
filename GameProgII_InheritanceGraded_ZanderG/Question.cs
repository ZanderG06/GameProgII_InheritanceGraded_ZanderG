using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_InheritanceGraded_ZanderG
{
    internal class Question
    {
        string _questionText;
        string _answerText;

        public Question(string question, string answer)
        {
            _questionText = question;
            _answerText = answer;
        }

        public void Ask()
        {
            Console.WriteLine(_questionText);
        }

        public virtual bool CheckAnswer()
        {
            return true;
        }
    }
}
