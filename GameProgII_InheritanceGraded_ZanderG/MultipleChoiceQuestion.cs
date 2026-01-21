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

        public MultipleChoiceQuestion(string question, string[] answers, int correctAnswer) : base(question, answers.ToString())
        {
            _answerOptions = answers;
            _correctAnswer = correctAnswer;
        }

        public override bool CheckAnswer()
        {
            string input = Console.ReadLine();

            int inputInt = int.Parse(input);
            
            if(inputInt == _correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
