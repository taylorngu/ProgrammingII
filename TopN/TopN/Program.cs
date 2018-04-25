using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopN
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter at least 10 integers:");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            Console.WriteLine("Now enter how many top numbers you want to see:");
            int count = Convert.ToInt16(Console.ReadLine());
            int[] top = numbers.OrderByDescending(i => i).Take(count).ToArray();

            Console.WriteLine(String.Format("The top {0} items in the list are:", count));

            foreach (int i in top)
            {
                Console.WriteLine(i.ToString());
            }
                      

        }
    }
}
