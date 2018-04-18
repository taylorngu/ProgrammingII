using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Addup
{
    class Program
    {

        static int computeSum(int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += i;
            }
            return total;
        }

        static int computeSumRecursively(int n)
{
   if (n == 1)
      return 1;
   else
      return n + (computeSumRecursively(n - 1));
}


        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to compute the sum to:");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(String.Format("The sum of the numbers from 1 to {0} computed with a loop is {1}", n, computeSum(n)));
            Console.WriteLine(String.Format("The sum of the numbers from 1 to {0} computed recursively is {1}", n, computeSumRecursively (n)));




        }
    }
}
