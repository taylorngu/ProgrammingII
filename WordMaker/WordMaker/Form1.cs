using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {

            string phrase = txtInput.Text;

            List<string> wordList = new List<string>(phrase.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));

            foreach (string i in wordList)
            {

                lstOutput.Items.Add(i.ToString()); 
            
            }

        }
    }
}
