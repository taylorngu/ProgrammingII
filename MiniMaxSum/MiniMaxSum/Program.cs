using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the miniMaxSum function below.
     */
    static void miniMaxSum(int[] arr)
    {

        long total = 0;
        long max = 0;
        long min = 0;

        foreach (int i in arr)
        {
            total += i;
        }

        min = total - arr.Max();
        max = total - arr.Min();

        Console.WriteLine(String.Format("{0} {1}", min, max));

    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
