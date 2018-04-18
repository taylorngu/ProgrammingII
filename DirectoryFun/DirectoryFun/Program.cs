using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace DirectoryFun
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            Console.WriteLine("***** End Directory Info *****");

        }
    }
}
