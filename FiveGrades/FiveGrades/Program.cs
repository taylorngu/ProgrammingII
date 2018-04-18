using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiveGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                double grade = 0;
                double total = 0;
                double average = 0;

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Enter a grade:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    total += grade;

                }

                average = total / 5;

                Console.WriteLine("The average of the grades is: {0}", Math.Round(average, 2));


            }
            catch
            {

                Console.WriteLine("Please enter a value");

            }

        }
    }
}
