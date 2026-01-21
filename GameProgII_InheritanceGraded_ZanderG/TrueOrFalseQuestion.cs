using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_InheritanceGraded_ZanderG
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string QuestionText, bool answerAsBool) : base(QuestionText, answerAsBool.ToString())
        {
            
        }
    }
}
