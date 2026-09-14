using System;
using System.Collections.Generic;
using System.Text;

namespace MiscExercises
{
    internal class studentGradesAverage
    {
        public void task()
        {
            string[] status = new string[5]
            {
               "student 01|77|80|75|01",
               "student 02|85|81|84|02",
               "student 03|74|72|73|03",
               "student 04|90|89|87|04",
               "student 05|88|84|86|05"
            };

            Console.Write("Enter Student No. - ");
            string studentNumber = Console.ReadLine();


            foreach (string stat in status)
            {
                string[] data = stat.Split('|');
                string student = data[0];
                int english = int.Parse(data[1]);
                int math = int.Parse(data[2]);
                int science = int.Parse(data[3]);
                string studentNo = data[4];

                int average = computedAverage(english, math, science);




                if (studentNumber == studentNo && studentNo == "01")
                {

                    if (average >= 75)
                    {
                        Console.WriteLine($"\n{student}: average = {average} passed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }
                    else
                    {
                        Console.WriteLine($"\n{student}: average = {average} failed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }

                }
                if (studentNumber == studentNo && studentNo == "02")
                {

                    if (average >= 75)
                    {
                        Console.WriteLine($"\n{student}: average = {average} passed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }
                    else
                    {
                        Console.WriteLine($"\n{student}: average = {average} failed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }


                }
                if (studentNumber == studentNo && studentNo == "03")
                {

                    if (average >= 75)
                    {
                        Console.WriteLine($"\n{student}: average = {average} passed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }
                    else
                    {
                        Console.WriteLine($"\n{student}: average = {average} failed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }


                }
                if (studentNumber == studentNo && studentNo == "04")
                {

                    if (average >= 75)
                    {
                        Console.WriteLine($"\n{student}: average = {average} passed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }
                    else
                    {
                        Console.WriteLine($"\n{student}: average = {average} failed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }


                }
                if (studentNumber == studentNo && studentNo == "05")
                {

                    if (average >= 75)
                    {
                        Console.WriteLine($"\n{student}: average = {average} passed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }
                    else
                    {
                        Console.WriteLine($"\n{student}: average = {average} failed");
                        Console.WriteLine($"\n[english: {english}, math: {math}, science: {science}]");
                    }


                }



            }

        }
        public int computedAverage(int english, int math, int science)
        {
            int average = (english + math + science) / 3;

            return average;
        }
    }
}
