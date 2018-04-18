using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace SearchSortConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\dataToSort.txt";

            string[] numbers = new string[1000000];

            Random gen = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToString(gen.Next());
            }

            File.WriteAllLines(fileName, numbers);

        }
    }
}
