using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunRecurSum
{
    class Program
    {

        static int Sum(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + (Sum(n - 1));
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to compute the sum to:");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(String.Format("The sum of the first {0} natural numbers is {1}", n, Sum(n)));




        }
    }
}
