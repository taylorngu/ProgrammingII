using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortNumbers
{
    public partial class Form1 : Form
    {
        public int[] even = new int[10];
        public int[] odd = new int[10];
        public int[] neg = new int[10];
        public int count = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt16(txtIn.Text);
            lblEnt.Text = Convert.ToString(count + 1);

            if (n < 0)
            {
                txtIn.Clear(); 
                neg[count] = n;
                count++;
            }
            else if (n % 2 == 0)
            {
                txtIn.Clear();
                even[count] = n;
                count++;
            }
            else 
            {
                txtIn.Clear();
                odd[count] = n;
                count++;
            }

            if (count == 10)
            {

                btnOut.Enabled = false; 

                foreach (int i in neg)
                {
                    if (i != 0)
                    {
                        lblNeg.Text += String.Format("{0} ", i.ToString());
                    }
                }
                foreach (int i in even)
                {
                    if (i != 0)
                    {
                        lblEven.Text += String.Format("{0} ", i.ToString());
                    }
                }
                foreach (int i in odd)
                {
                    if (i != 0)
                    {
                        lblOdd.Text += String.Format("{0} ", i.ToString());
                    }
                }
            
            }


        }
    }
}
