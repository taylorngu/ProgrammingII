using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Population
{
    public partial class threeinput : Form
    {
        string kind = "";
        Form1 form1;

        public threeinput(string kind, Form1 form1)
        {
            this.form1 = form1;
            this.kind = kind; 
            InitializeComponent();
        }

        private void threeinput_Load(object sender, EventArgs e)
        {
            lblIn1.Text = "Enter number of births per day:";
            lblIn2.Text = "Enter number of deaths per day:";
            lblIn3.Text = "Enter total population:";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {

                int births = Convert.ToInt32(txtIn1.Text);
                int deaths = Convert.ToInt32(txtIn2.Text);
                long population = Convert.ToInt64(txtIn3.Text);

                if (kind == "netGR")
                {
                    form1.CalcNetGR(births, deaths, population);
                    this.Close();
                }

                else
                {
                    form1.CalcDoubleTime(births, deaths, population);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid values.");
                txtIn1.Text = "";
                txtIn2.Text = "";
                txtIn3.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

