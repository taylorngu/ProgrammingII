using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial 
{
    class Program
    {
        static void factLoop(int n)
        {

            int total = 1;

            for (int i = n; i > 0; i--)
            {
                total *= i;
            }

            Console.WriteLine(String.Format("The result of the factorial using iteration is: {0}", total));

        }

        static void factRecur(int n, int total)
        {

            if (n >= 1)
            {
                factRecur(n - 1, total *=n);
            }
            else
            {
                Console.WriteLine(String.Format("The result of the factorial using recursion is: {0}", total));
            }


        }


        static void Main(string[] args)
        {

            int total = 1;

            Console.WriteLine("Enter the number for which to compute the factorial");
            int a = Convert.ToInt16(Console.ReadLine());

            factRecur(a, total);
            factLoop(a);


        }
    }
}
