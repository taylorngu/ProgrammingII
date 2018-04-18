using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunRecurPrintDig
{
    class Program
    {

        static int PrintDigits(int n)
        {


            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + (PrintDigits(n - 1));
                
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The digits in the number {0} are: {1}", n, PrintDigits(n));




        }
    }
}
