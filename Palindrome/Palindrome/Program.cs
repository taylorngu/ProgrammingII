using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {

        static void Main(string[] args)
        {
            string phrase = "";
            int mirCount = 0;
            int pivCount = 0;
            int notPalCount = 0;

            Console.WriteLine("Enter either a word or a phrase. Enter QQQ to stop.");
            phrase = Console.ReadLine();

            do
            {

                StringBuilder sb = new StringBuilder();
                foreach (char c in phrase)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        sb.Append(char.ToLower(c));
                    }
                }

                string phraseLetters = sb.ToString();

                char[] phraseConvert = phraseLetters.ToCharArray();
                Array.Reverse(phraseConvert);
                string phrasePal = new string(phraseConvert);

                if (phraseLetters == phrasePal)
                {
                    if (phraseLetters.Length % 2 == 0)
                    {
                        Console.WriteLine("The phrase is a MIRROR palindrome.");
                        mirCount++;
                    }
                    else
                    {
                        Console.WriteLine("The phrase is a PIVOT palindrome.");
                        pivCount++;
                    }
                }
                else
                {
                    Console.WriteLine("The phrase is NOT a palindrome.");
                    notPalCount++;
                }

                Console.WriteLine("Enter either a word or a phrase. Enter QQQ to stop.");
                phrase = Console.ReadLine();

            } while (phrase != "QQQ");

            Console.WriteLine(string.Format("Number of MIRROR palindromes entered: {0}", mirCount));
            Console.WriteLine(string.Format("Number of PIVOT palindromes entered: {0}", pivCount));
            Console.WriteLine(string.Format("Number of NON palindromes entered: {0}", notPalCount));

        }
    }
}

