using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WriteDown
{
    class Program
    {
        static void writeDownLoop(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine("{0}", i);
            }
        }

        static void writeDownRecursively(int n)
        {
            Console.WriteLine("{0}", n);
            if (n > 1)
            {
                writeDownRecursively(n - 1);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number from which to count down:");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Counting down with a loop...");
            writeDownLoop(a);

            Console.WriteLine("Counting down recursively...");
            writeDownLoop(a);


        }
    }
}
