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
        static int _score;
        static int questionNum = 0;
        
        static void Main(string[] args)
        {
            //Simon I hope this isn't too convoluted
            Question question1 = new Question("question1", "answer1");
            Question question2 = new Question("question2", "answer2");
            Question question3 = new Question("question3", "answer3");
            Question question4 = new MultipleChoiceQuestion("question4", new string[] { "a", "b" }, 2);
            listOfQuestions.Add(question1);
            listOfQuestions.Add(question2);
            listOfQuestions.Add(question3);
            listOfQuestions.Add(question4);

            //Epic Intro!!!11!!1
            Console.WriteLine("Welcome to Zander's Quiz about");
            Console.WriteLine("___  ___      _                                  _       \r\n|  \\/  |     | |                                | |      \r\n| .  . | ___ | |_ ___  _ __ ___ _ __   ___  _ __| |_ ___ \r\n| |\\/| |/ _ \\| __/ _ \\| '__/ __| '_ \\ / _ \\| '__| __/ __|\r\n| |  | | (_) | || (_) | |  \\__ \\ |_) | (_) | |  | |_\\__ \\\r\n\\_|  |_/\\___/ \\__\\___/|_|  |___/ .__/ \\___/|_|   \\__|___/\r\n                               | |                       \r\n                               |_|                       ");
            Console.WriteLine("*and maybe other interests of mine, good luck getting these right");
            Console.WriteLine("Press anything to begin");
            Console.ReadKey(true);
            Console.Clear();

            //The actual quiz
            for (int i = 0; i < listOfQuestions.Count; i++)
            {
                listOfQuestions[i].Ask();

                if (listOfQuestions[i].CheckAnswer() == true)
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine("WRONG");
                }

                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
