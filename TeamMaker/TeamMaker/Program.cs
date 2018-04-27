using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[] { "Taylor", "Jordan", "Chris", "Aman", "Tyler", "Sydney", "Daniel", "Nick Barnes", "Nick Broza", "Pierce", "Eli", "Evie", "Shamyl", "Kush", "Cole", "Jake", "Kaitlyn", "Brenna"};

            var teams = from x in Enumerable.Range(0, names.Length)
                        let index = x % (names.Count() / 3)
                        group names[x] by index into groups
                        select groups;
                       


            foreach (var v in teams) 
            {
                Console.WriteLine("Team {0}: {1}", v.Key, String.Join(", ", v.ToArray()));
            }


        }
    }
}
