using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {

        static void ConvertInchesToYards(int inches)
        {

            int yard = inches / 36;
            int feet = (inches % 36) / 12;
            int inch = (inches % 36 % 12) % 12;

            Console.WriteLine("{0} yards {1} feet {2} inches", yard, feet, inch);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter inches:");
            int inches = Convert.ToInt16(Console.ReadLine());

            ConvertInchesToYards(inches);

        }
    }
}
