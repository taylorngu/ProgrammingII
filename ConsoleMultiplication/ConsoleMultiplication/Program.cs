using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WriteUp
{
    class Program
    {
        static void multiplyLoop(int n, int m)
        {

            int total = 0;

            for (int i = m; i > 0; i--)
            {
                total += n;
            }

            Console.WriteLine(String.Format("The result of multiplication using iteration is: {0}", total));

        }

        static void multiplyRecur(int n, int m, int total)
        {

            if (m >= 1)
            {
                multiplyRecur(n, m-1, total +=n);
            }
            else
            {
                Console.WriteLine(String.Format("The result of multiplication using recursion is: {0}", total)); 
            }


        }


        static void Main(string[] args)
        {

            int total = 0;

            Console.WriteLine("Enter a number to multiply:");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter a number to multiply by:");
            int b = Convert.ToInt16(Console.ReadLine());

            multiplyRecur(a, b, total);
            multiplyLoop(a, b);

            


        }
    }
}
