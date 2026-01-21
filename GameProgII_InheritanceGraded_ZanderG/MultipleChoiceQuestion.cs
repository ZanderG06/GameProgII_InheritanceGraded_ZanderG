using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_InheritanceGraded_ZanderG
{
    internal class MultipleChoiceQuestion : Question
    {
        string[] _answerOptions;
        int _correctAnswer;
        
        public MultipleChoiceQuestion(string question, string answer, string[] options, int correct, int numberOfQuestions) : base(question, answer)
        {
            _answerOptions = options;
            _correctAnswer = correct;
        }

        public override bool CheckAnswer()
        {
            return base.CheckAnswer();
        }
    }
}
