using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunRecur1
{

    class Program
    {

        static void CountRecur(int n)
        {

            if (n > 1)
            {
                CountRecur(n - 1);
            }

            Console.WriteLine("{0}", n);

        }


        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter a number from which to count up to:");
            int a = Convert.ToInt16(Console.ReadLine());

            CountRecur(a);

        }
    }
}
