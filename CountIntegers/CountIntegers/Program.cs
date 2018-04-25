using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawNumbers = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\testRead.txt").Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = Array.ConvertAll(rawNumbers, int.Parse);
            

            var match = from i in numbers
                        orderby i 
                        group i by i into x
                        let count = x.Count()
                        select count;

            int occur = match.Count();

            Console.WriteLine();

            int key = 1;

            foreach (int i in match)
            {
                Console.WriteLine(String.Format("Key {0} occured {1} times.", key++, i));
            }

        }
    }
}
