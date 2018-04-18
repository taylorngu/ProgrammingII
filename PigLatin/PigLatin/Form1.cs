using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string phrase = txtInput.Text;
            string vowelstring = "AaEeIiOoUu";
            string translation = "";
            lblOut.Text = "";

            List<string> wordList = new List<string> (phrase.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));

            foreach (string s in wordList)
            {
                char firstletter = s[0];

                if (vowelstring.Contains(firstletter) == true)
                {
                    translation += Vowels(s);
                }
                else
                {
                    translation += Consonants(s);
                }
            }

            lblOut.Text = translation; 
        }

        static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public static string Consonants(string s)
        {
            string start = s.Substring(0, s.IndexOfAny(vowels)); 
            string end = s.Substring(s.IndexOfAny(vowels));

            return (end + start + "ay "); 
        }

        public static string Vowels(string s)
        {
            return (s + "way "); 
        }
    }
}
