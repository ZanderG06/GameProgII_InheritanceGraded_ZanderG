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
            for(int i = 0; i < _answerOptions.Length; i++)
            {
                Console.WriteLine($"({i+1}) {_answerOptions[i]}");
            }

            bool checkingForParse = true;

            while (checkingForParse)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int inputInt))
                {
                    if(inputInt > 0 && inputInt <= _answerOptions.Length)
                    {
                        if (inputInt == _correctAnswer)
                        {
                            checkingForParse = false;
                            return true;
                        }
                        else
                        {
                            checkingForParse = false;
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Answer not valid, please use the numbers besides the answers");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Answer not valid, please use the numbers besides the answers");
                    continue;
                }
            }

            return false;
        }
    }
}
