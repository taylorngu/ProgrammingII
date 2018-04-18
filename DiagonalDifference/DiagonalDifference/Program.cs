using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the diagonalDifference function below.
     */
    static int diagonalDifference(int[][] a)
    {

        int primDA = 0;
        int secDA = 0;

        for (int i = 0, j = a.Count() - 1; i < a.Count(); i++, j--)
        {
            primDA += a[i][i];
            secDA += a[j][i];
        }

        return Math.Abs(primDA - secDA);

    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++)
        {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
