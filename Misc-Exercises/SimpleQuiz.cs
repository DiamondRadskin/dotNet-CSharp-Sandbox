using System;
using System.Collections.Generic;
using System.Text;

namespace MiscExercises
{
    internal class SimpleQuiz
    {
        public void task()
        {
            string[] quiz = new string[15]
            {
                "Is fish a cat?|False|1",
                "Is Manila in Europe?|False|1",
                "Is the Earth flat?|False|1",
                "Is apple a fruit?|True|1",
                "Is whale a mammal?|True|1",


                "1+1 =?|2|2",
                "4 x 4 =?|16|2",
                "250/25 =?|10|2",
                "80-90 =?|-10|2",
                "-50 x 2 =?|-100|2",

                "Does 15 % 4 == 3 evaluate to true in C#?|True|3",
                "What is the output of (5 > 3) && !(10 <= 2)?|True|3",
                "If int x = 5; what is the value of ++x + x++?|12|3",
                "In C#, what is the value of 17 / 4 * 2?|8|3",
                "What is the result of 2 + 3 * 4 - 6 / 2?|11|3"


            };

            Console.Write("Choose difficulty 1 (easy), 2 (medium), 3 (hard): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());

            foreach (string QA in quiz)
            {
                string[] quizAnswer = QA.Split('|');


                if (difficulty == 1 && quizAnswer[2] == "1")
                {
                    Console.Write("Easy Question - ");
                    Console.Write($"{quizAnswer[0]}: ");
                    string answer = Console.ReadLine();

                    if (answer == quizAnswer[1])
                    {
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                }
                if (difficulty == 2 && quizAnswer[2] == "2")
                {
                    Console.Write("Medium Question - ");
                    Console.Write($"{quizAnswer[0]}: ");
                    string answer = Console.ReadLine();

                    if (answer == quizAnswer[1])
                    {
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }

                }
                if (difficulty == 3 && quizAnswer[2] == "3")
                {
                    Console.Write("Hard Question - ");
                    Console.Write($"{quizAnswer[0]}: ");
                    string answer = Console.ReadLine();

                    if (answer == quizAnswer[1])
                    {
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }

                }

            }
        }
    }
}
