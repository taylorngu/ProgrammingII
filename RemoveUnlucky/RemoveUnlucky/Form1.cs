using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoveUnlucky
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        List<int> numberList = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {

            Random gen = new System.Random(); 

            for (int i = 0; i < 10; i++)
            {

                numberList.Add(gen.Next(0, 101)); 
            
            }

            DisplayNumbers(); 
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int unluckyNum = Convert.ToInt16(txtInput.Text);

                if (numberList.Remove(unluckyNum) == false)
                {
                    throw new NotSupportedException(); 
                }

                DisplayNumbers();
            }
            catch (NotSupportedException)
            {

                MessageBox.Show("Please enter numbers displayed in the list");

            }
            catch
            {

                MessageBox.Show("Invalid Input"); 
            
            }

        }

        public void DisplayNumbers()
        {
            lblOut.Text = ""; 
            foreach (int i in numberList)
            {

                lblOut.Text += String.Format("{0}\n", i);

            }
        }


    }
}
