using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the staircase function below.
     */
    static void staircase(int n)
    {

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new String(' ', n - (i + 1)) + new String('#', i + 1));
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
