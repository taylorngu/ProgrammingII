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
                int num = 0;

                Console.WriteLine("Enter grades, enter '-1' to stop");

                do
                {
                    Console.WriteLine("Enter a grade:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    if (grade != -1)
                    {
                        total += grade;
                        num++;
                    }
                }
                while (grade != -1);

                average = total / num;

                Console.WriteLine("The average of the grades is: {0}", Math.Round(average, 2));

            }

            catch
            {

                Console.WriteLine("Please enter values");
            }
        }

    }
}
