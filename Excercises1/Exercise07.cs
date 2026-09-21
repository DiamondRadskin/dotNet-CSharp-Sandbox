

using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals
{
    internal class Exercise07
    {
        public void exercise()
        {
            int[] grades = new int[7] {96, 74, 88, 68, 91, 82, 59 };

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 75)
                {
                    if (grades[i] >= 90)
                    {
                        Console.WriteLine($"grade: {grades[i]} --- status: PASSED_HONORS!");
                    }
                    else if (grades[i] >= 75 && grades[i] <= 89)
                    {
                        Console.WriteLine($"grade: {grades[i]} --- status: PASSED_REGULAR!");
                    }
                }
                else if (grades[i] < 75)
                {
                    if (grades[i] >= 65)
                    {
                        Console.WriteLine($"grade: {grades[i]} --- status: FAILED_REMEDIAL!");
                    }
                    else if (grades[i] < 65)
                    {
                        Console.WriteLine($"grade: {grades[i]} --- status: FAILED_RETAKE!");
                    }
                }
            }
        }
    }
}
