using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddColors
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> firstColors = new List<string>() { "blue", "pink", "purple" };
            List<string> secondColors = new List<string>() { "navy", "violet" };

            Console.WriteLine("The colors in the first list are:");
            DisplayColors(firstColors);
            Console.WriteLine(); 

            Console.WriteLine("The colors in the second list are:");
            DisplayColors(secondColors);
            Console.WriteLine();

            firstColors.AddRange(secondColors); 

            Console.WriteLine("The colors in the first list after using AddRange:");
            DisplayColors(firstColors);
            Console.WriteLine();

        }

        public static void DisplayColors(List<string> colors)
        {
        
            foreach (string s in colors)
            { 
                Console.Write(String.Format("{0}\t", s)); 
            }

            Console.WriteLine();
        
        }
    }
}
