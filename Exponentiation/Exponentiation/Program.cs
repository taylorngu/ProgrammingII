using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponentiation
{
    class Program
    {
        static void expoLoop(int n, int m)
        {

            int total = 1;

            for (int i = m; i > 0; i--)
            {
                total *= n;
            }

            Console.WriteLine(String.Format("The result of exponentiation using iteration is: {0}", total));

        }

        static void expoRecur(int n, int m, int total)
        {

            if (m >= 1)
            {
                expoRecur(n, m - 1, total *= n);
            }
            else
            {
                Console.WriteLine(String.Format("The result of exponentiation using recursion is: {0}", total));
            }


        }


        static void Main(string[] args)
        {

            int total = 1;

            Console.WriteLine("Enter the base");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the exponent");
            int b = Convert.ToInt16(Console.ReadLine());

            expoRecur(a, b, total);
            expoLoop(a, b);


        }
    }
}
