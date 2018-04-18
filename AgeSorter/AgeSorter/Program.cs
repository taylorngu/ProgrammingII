using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgeSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new System.Random(); 
            List<int> memberAge = new List<int>();
            List<int> youngerAges = new List<int>();
            List<int> olderAges = new List<int>();

            for (int i = 0; i < 100; i++)
            { 
            
                memberAge.Add(gen.Next(15, 23));
            
            }

            youngerAges = memberAge.FindAll(item => item < 20);
            olderAges = memberAge.FindAll(item => item >= 20);

            youngerAges.Sort();
            olderAges.Sort(); 

            Console.WriteLine("Number of members below 20 years of age: {0}", youngerAges.Count());
            Console.WriteLine();
            DisplayAges(youngerAges);

            Console.WriteLine();
            Console.WriteLine("Number of members at or above 20 years of age: {0}", olderAges.Count());
            Console.WriteLine();
            DisplayAges(olderAges); 
            
        }

        public static void DisplayAges(List<int> agesList)
        {
            string ages = ""; 

            foreach (int i in agesList)
            {

                ages += String.Format("{0}, ", i);

            }

            Console.WriteLine(ages.TrimEnd(new char[] { ' ', ',' })); 
        
        }
    }
}
