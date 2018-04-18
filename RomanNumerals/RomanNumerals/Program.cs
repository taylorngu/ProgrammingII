using System;

namespace RomanNumerals
{
    class Program
    {
        public static string str = "";
        public static int[] num = new int[4];

        public static void ToRomanThousands() // computes thousands
        {
            int m = 0;
            m = num[0];

            for (int t = 1; t <= m; t++)
            {
                str += 'M';
            }

        }

        public static void ToRoman(int a, string b, char c, string d, char e)
        {

            // five 
            int z = 0;
            z = num[a] / 5;

            if (num[a] == 9)
            {
                str += b;
                num[a] -= 9;
            }
            else
            {
                for (int t = 1; t <= z; t++)
                {
                    str += c;
                }
            }


            // one
            int y = num[a] - 5 * z;

            if (num[a] == 4)
            {
                str += d;
                num[a] -= 4;
            }
            else
            {
                for (int t = 1; t <= y; t++)
                {
                    str += e;
                }
            }

        }

        static void Main()
        {
            bool cont = true;

            do
            {

                Console.WriteLine("Enter a decimal number less than 4000 to convert to Roman Numerals. \nEnter -1 to quit.");
                int a = Convert.ToInt16(Console.ReadLine());

                if (a == -1)
                {
                    System.Environment.Exit(0);
                    cont = false;
                }
                else if (a >= 4000)
                {
                    Console.Write("Error: Please enter valid values\n\n");
                }
                else
                {
                    // expands 'a'
                    num[0] = a / 1000;
                    num[1] = a % 1000 / 100;
                    num[2] = a % 1000 % 100 / 10;
                    num[3] = a % 1000 % 100 % 10;

                    // converts to roman numerals
                    ToRomanThousands();
                    ToRoman(1, "CM", 'D', "CD", 'C');
                    ToRoman(2, "XC", 'L', "XL", 'X');
                    ToRoman(3, "IX", 'V', "IV", 'I');

                    Console.WriteLine(String.Format("The number {0} converted to Roman Numerals is {1}\n", a, str));
                    str = "";

                }

            }
            while (cont);
        }
    }
}




