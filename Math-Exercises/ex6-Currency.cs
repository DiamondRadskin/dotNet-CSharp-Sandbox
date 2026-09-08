using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Exercises
{
    internal class ex6
    {
        public void exercise()
        {
            while (true)
            {

                Console.Write("Please input PHP amount to covent - ");
                double phpAmount = Convert.ToDouble(Console.ReadLine());


                Console.Write("Type 1) to convert to USD, type 2 to convert to YEN, type 3 to exit - ");
                int toConvert = Convert.ToInt32(Console.ReadLine());

                double phpConverted = 0;
                
                if (toConvert == 1)
                {
                    phpConverted = phpAmount * 62.27;
                }
                if (toConvert == 2)
                {
                    phpConverted = phpAmount * 0.28;
                }
                if(toConvert == 3)
                {
                    Console.WriteLine("Thank you!!");
                    break;
                }
                
                
                Console.WriteLine(phpConverted);
            }

            //Console.WriteLine(toConvert);

            /*
            Console.Write($"Enter your amount of php: ");
            double PHP = Convert.ToDouble(Console.ReadLine());


            double exchangeCurrency = 62.27;

            double USD = converToUSD(exchangeCurrency, PHP);*/


        }

        public double converToUSD(double exchangeCurrency, double PHP)
        {
            double USD = exchangeCurrency * PHP;

            return USD;

        }
    }

}
