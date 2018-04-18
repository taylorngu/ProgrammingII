using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {

        s = s.TrimEnd('M');

        int hours = 0;

        List<string> time = new List<string>(s.Split(':'));


        if (s[8] == 'P')
        {
            if (time[0] != "12")
            {
                hours = Convert.ToInt16(time[0]) + 12;

                time[0] = hours.ToString();
            }
        }
        else if (s[8] == 'A')
        {
            if (time[0] == "12")
            {
                time[0] = "00";
            }
        }


        return String.Format("{0}:{1}:{2}", time[0], time[1], time[2].TrimEnd('P', 'A'));
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
