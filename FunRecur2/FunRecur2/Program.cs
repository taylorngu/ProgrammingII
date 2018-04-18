using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunRecur2
{
    class Program
    {

        static void CountDown(int n)
        {

            Console.WriteLine("{0}", n);
            if (n > 1)
            {

                CountDown(n - 1); 
            
            }
        
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from which to count down to:");
            int a = Convert.ToInt16(Console.ReadLine());

            CountDown(a);

        }
    }
}
