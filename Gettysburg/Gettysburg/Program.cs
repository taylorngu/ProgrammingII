using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace Gettysburg
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] address = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Gettysburg.txt").Split(new char[] {' ', '.', ',', '?','!',';', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);

            var match = from s in address
                        where s.ToLower() == "we"
                        select s;

            int occur = match.Count(); 

            Console.WriteLine();
            
            Console.WriteLine(String.Format("{0} occurance(s) of the search term 'we' were found in the Gettysburg Address.", occur));
            

        }
    }
}
