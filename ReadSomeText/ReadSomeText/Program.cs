using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace ReadSomeText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\SomeText.txt";
                FileStream inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);

                string contents = reader.ReadLine();

                Console.WriteLine("The contents of the file are:");
                Console.WriteLine(contents);

                // The following must be done in order
                reader.Close();
                inFile.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }

        }
    }
}
