using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] {"Rome","London", "Nairobi", "Zurich", "Los Angeles", "New Delhi", "Amsterdam", "Abu Dhabi", "Paris", "Anaheim"};

            var cityMatch = from s in cities
                            where s.ToLower().StartsWith("a")
                            where s.ToLower().EndsWith("m")
                            select s;

            Console.WriteLine("The city names beginning with 'A' and ending with 'M' are:");

            foreach (string s in cityMatch)
            {
                Console.Write(String.Format("{0} ", s));
            }
            Console.WriteLine("");
        }
    }
}
