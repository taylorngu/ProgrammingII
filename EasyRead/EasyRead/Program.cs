using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace EasyRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToAdd = "Help";
            string someText = "SOS";
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\testRead.txt";  // this resolves to My Documents
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
            File.WriteAllText(fileName, textToAdd); //textToAdd is a string
            File.AppendAllText(fileName, someText);  // adds to a file

        }
    }
}
