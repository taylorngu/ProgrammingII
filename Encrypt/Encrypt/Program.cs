using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string phrase = "";
                int shift = 0;

                do
                {
                    StringBuilder sb = new StringBuilder();

                    Console.WriteLine("Enter a positive whole number greater than 0 to shift by. Enter 'QQQ' to stop.");
                    shift = Convert.ToInt16(Console.ReadLine());

                    if (shift < 0)
                    {
                        throw new Exception();
                    }

                    Console.WriteLine("Input a phrase or series of numbers to encrypt.");
                    phrase = Console.ReadLine();

                    foreach (char c in phrase)
                    {
                        char newChar = ' ';

                        if (char.IsLetterOrDigit(c) == true)
                        {
                            if (char.IsLower(c))
                            {
                                newChar = LowerShift(c, shift);
                            }
                            else if (char.IsUpper(c))
                            {
                                newChar = UpperShift(c, shift);
                            }
                            else
                            {
                                newChar = NumShift(c, shift);
                            }

                            sb.Append(newChar);
                        }
                        else
                        {
                            sb.Append(c);
                        }

                    }

                    Console.WriteLine("The encrypted phrase is:\n{0}", sb);

                } while (phrase != "QQQ");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid values.");
            }
        }

        public static char LowerShift(char c, int shift)
        {
            int place = c + shift;

            while (place > 'z')
            {
                place = ('a' - 1) + (place - 'z');
            }

            return (char)place;
        }

        public static char UpperShift(char c, int shift)
        {
            int place = c + shift;

            while (place > 'Z')
            {
                place = ('A' - 1) + (place - 'Z');
            }

            return (char)place;
        }

        public static char NumShift(char c, int shift)
        {
            int place = c + shift;

            while (place > '9')
            {
                place = ('0' - 1) + (place - '9');
            }

            return (char)place;
        }

    }
}

