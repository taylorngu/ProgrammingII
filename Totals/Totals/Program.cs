using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Totals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 4] { { 5, 1, 9, 3 }, 
                                             { 7, 8, 6, 4 }, 
                                             { 2, 4, 9, 5 } };
            double[] totals = new double[3];

            Console.WriteLine("The contents of the array are:");
            for (int r = 0; r < numbers.GetLength(0); r++)
            {
                for (int c = 0; c < numbers.GetLength(1); c++)
                {

                    Console.Write("{0} ", numbers[r, c]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("The totals of the rows are:");
            
            double count = 0;

            for (int r = 0; r < numbers.GetLength(0); r++)
            {
                for (int c = 0; c < numbers.GetLength(1); c++)
                {
                    count += numbers[r, c];
                }
                Console.Write("{0} ", count);
                totals[r] = count; 
                count = 0; 

            }
            Console.WriteLine();

            Console.WriteLine("The averages of the rows are:");

            for (int i = 0; i < totals.Length; i++)
            {
                Console.Write(String.Format("{0:F2} ", totals[i] / numbers.GetLength(1)));

            }

            Console.WriteLine();


        }
    }
}
