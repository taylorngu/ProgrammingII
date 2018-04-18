using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Sum(int num1, int num2)
        {

            int sum = num1 + num2;
            Console.WriteLine("Sum: {0}", sum);

        }

        static void Difference(int num1, int num2)
        {

            int dif = num1 - num2;
            Console.WriteLine("Difference: {0}", dif);

        }


        static int Product(int num1, int num2)
        {

            return num1 * num2;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter another integer");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Sum(num1, num2);
            Difference(num1, num2);
            Console.WriteLine("Product: {0}", Product(num1, num2));
        }
    }
}
