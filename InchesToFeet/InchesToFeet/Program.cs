using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {

        static void ConvertInchesToFeet(int inches)
        {

            int feet = inches / 12;
            int inch = inches % 12;

            Console.WriteLine("{0} feet {1} inches", feet, inch);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter inches:");
            int inches = Convert.ToInt16(Console.ReadLine());

            ConvertInchesToFeet(inches);

        }
    }
}
