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
        
        static void Main(string[] args)
        {
            //Simon I hope this isn't too convoluted
            Question question1 = new Question("What popular energy drink company owns 2 F1 teams?*", "Red Bull");
            Question question2 = new Question("What car manufacturer won the first F1 Constructor's Championship in 1958?", "Vanwall");
            Question question3 = new Question("What driver won their 4th straight F1 Driver's Championship in 2024?", "Max Verstappen");
            Question question4 = new MultipleChoiceQuestion("Which 2 F1 drivers are the only 2 to hold 7 F1 Driver's Championships?*", new string[] { "Lewis Hamilton & Michael Schumacher", "Max Verstappen & Sebastian Vettel", "Fernando Alonso & Jenson Button" }, 1);
            Question question5 = new MultipleChoiceQuestion("Which race was the first World Championship F1 Race?", new string[] { "1951 Monaco Grand Prix", "1950 Indianapolis 500", "1952 Italian Grand Prix", "1950 British Grand Prix" }, 4);
            Question question6 = new MultipleChoiceQuestion("Who is the current reigning F1 Driver's Champion?*", new string[] { "Oscar Piastri", "Max Verstappen", "Lando Norris", "Charles Leclerc", "George Russell" }, 3);
            Question question7 = new TrueOrFalseQuestion("True or False? Mercedes has won the most F1 Constructor's Championships.*", false);
            Question question8 = new TrueOrFalseQuestion("True or False? Lewis Hamilton won the F1 Driver's Championship in his rookie season in 2007.", false);
            Question question9 = new TrueOrFalseQuestion("True or False? In 2009 Honda's F1 team was sold for only £1.", true);
            listOfQuestions.Add(question1);
            listOfQuestions.Add(question4);
            listOfQuestions.Add(question7);
            listOfQuestions.Add(question2);
            listOfQuestions.Add(question5);
            listOfQuestions.Add(question8);
            listOfQuestions.Add(question3);
            listOfQuestions.Add(question6);
            listOfQuestions.Add(question9);

            //Epic Intro!!!11!!1
            Console.WriteLine("Welcome to Zander's Quiz about");
            Console.WriteLine("                                                  \r\n                                                  \r\n██████ ▄▄▄  ▄▄▄▄  ▄▄   ▄▄ ▄▄ ▄▄ ▄▄     ▄▄▄    ▄██ \r\n██▄▄  ██▀██ ██▄█▄ ██▀▄▀██ ██ ██ ██    ██▀██    ██ \r\n██    ▀███▀ ██ ██ ██   ██ ▀███▀ ██▄▄▄ ██▀██    ██ \r\n                                                  ");
            Console.WriteLine("\nAnswers marked with * are up to date as of the 2025 F1 season and may change");
            Console.WriteLine("Press anything to begin");
            Console.ReadKey(true);
            Console.Clear();

            //The actual quiz
            for (int i = 0; i < listOfQuestions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}");
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

            Console.WriteLine($"Your Final Score: {_score}/{listOfQuestions.Count}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
