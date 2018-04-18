using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace WriteSomeText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\SomeText.txt";
                FileStream outFile = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);
                Console.WriteLine("Enter some text to be written to a file.");
                string response = Console.ReadLine();
                writer.WriteLine(response);
                
                // The following must be done in order
                writer.Close();
                outFile.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }


        }
    }
}
