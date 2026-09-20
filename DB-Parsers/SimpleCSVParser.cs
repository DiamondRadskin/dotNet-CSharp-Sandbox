


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DB_Parsers
{
    internal class SimpleCSVParser
    {
        
        public void task()
        {
            string filePath = "SampleStudentGrades.csv";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int skip = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (skip > 0)
                        {
                            string[] data = line.Split(',');
                            string studentNumber = data[0];
                            string studentName = data[1];                                                
                            int english = int.Parse(data[2]);
                            int math = int.Parse(data[3]);
                            int science = int.Parse(data[4]);

                            int average = totalAverage(english, math, science);

                            

                            Console.WriteLine($"student no: {studentNumber}, student name: {studentName}");
                            Console.WriteLine($"english: {english} - {passOrFail(english)}");
                            Console.WriteLine($"math: {math} - {passOrFail(math)}");
                            Console.WriteLine($"science: {science} - {passOrFail(science)}");
                            Console.WriteLine($"average: {average} - {passOrFail(average)}");
                            Console.WriteLine("----");
                        }
                        else
                        {
                            skip++;
                        }
                        
                      

                    }
                }

            }
        }
        private int totalAverage(int english, int math, int science)
        {
            int average = (english + math + science) / 3;

            return average;
        }
        private string passOrFail(int grade)
        {
            if (grade >= 75)
            {
                return "PASSED";
            }
            else
            {
                return "FAILED";
            }
        }


    }
}
