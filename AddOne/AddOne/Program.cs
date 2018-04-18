using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddOne
{
    class Program
    {

        static void Main(string[] args)
        {

            double[,] numbers = new double[3, 4] { { 1.2, 5.7, 9.4, 3.3 }, 
                                                   { 7.5, 3.2, 6.7, 8.1 }, 
                                                   { 6.1, 2.5, 4.7, 8.2 } };

            Console.WriteLine("The contents of the array are:");
            for (int r = 0; r < numbers.GetLength(0); r++)
            {
                for (int c = 0; c < numbers.GetLength(1); c++)
                {

                    Console.Write("{0} ", numbers[r, c]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("The contents of the array are:");
            for (int r = 0; r < numbers.GetLength(0); r++)
            {
                for (int c = 0; c < numbers.GetLength(1); c++)
                {

                    Console.Write("{0} ", numbers[r, c] + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
