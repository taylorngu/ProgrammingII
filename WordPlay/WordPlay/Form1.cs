using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordPlay
{
    public partial class Form1 : Form
    {

        string[] nouns = { "wall", "giraffe", "statue", "bookbag" };
        string[] adjectives = { "bendy", "slick", "long", "short" };
        string[] adverbs = { "gently", "hesitantly", "confidently", "loudly" };
        string[] verbs = { "ran", "jumped", "swam", "flew" };
        string prev = "";
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {

            Random gen = new System.Random();

            string str = String.Format("The {0} {1} {2} {3}.", adjectives[gen.Next(0, adjectives.Length)], nouns[gen.Next(0, nouns.Length)], adverbs[gen.Next(0, adverbs.Length)], verbs[gen.Next(0, verbs.Length)]);

            if (str != prev)
            {
                count++;
                lblCount.Text = Convert.ToString(count); 
                prev = str;
                lblOut.Text = str;
            }
            else
            { 
            
                lblOut.Text = String.Format("It took {0} tries to match sentences!", count);
                lblOut.Text = String.Format("Sentence: {0}", str);
                btnMake.Enabled = false; 

            }



        }
    }
}
