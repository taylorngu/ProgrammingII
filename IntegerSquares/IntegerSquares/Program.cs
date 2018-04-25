using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers to be squared:");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            var squares = from n in numbers
                          select Math.Pow(n, 2);

            Console.WriteLine("The squares of your numbers are:");

            foreach (int i in squares)
            {
                Console.Write(String.Format("{0} ", i));
            }
            Console.WriteLine(""); 
        }
    }
}
