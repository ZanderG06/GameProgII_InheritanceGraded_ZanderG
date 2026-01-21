using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_InheritanceGraded_ZanderG
{
    internal class Program
    {
        static List<Question> listOfQuestions = new List<Question>();
        int _score = 0;
        public int questionNum = 0;
        
        static void Main(string[] args)
        {
            Question question1 = new Question("question1", "answer1");

            listOfQuestions.Add(question1);

            question1.Ask();

            if (question1.CheckAnswer() == true)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("WRONG");
            }
        }
    }
}
