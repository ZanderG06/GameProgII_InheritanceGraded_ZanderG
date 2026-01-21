using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_InheritanceGraded_ZanderG
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string question, string answer, string QuestionText, bool answerAsBool) : base(question, answer)
        {
            answer = answerAsBool.ToString();
        }
    }
}
