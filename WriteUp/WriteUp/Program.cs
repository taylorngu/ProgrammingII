using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WriteUp
{
    class Program
    {
        static void writeUpLoop(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }

        static void writeUpRecursively(int n)
        {
            
            if (n > 1)
            {
                writeUpRecursively(n - 1);
            }
            Console.WriteLine("{0}", n);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number from which to count up:");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Counting up with a loop...");
            writeUpLoop(a);

            Console.WriteLine("Counting up recursively...");
            writeUpRecursively(a);


        }
    }
}
