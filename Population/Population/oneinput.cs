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
    public partial class oneinput : Form
    {
        string kind = "";
        Form1 form1;

        public oneinput(string kind, Form1 form1)
        {
            this.form1 = form1;
            this.kind = kind; 
            InitializeComponent();
        }

        private void oneinput_Load(object sender, EventArgs e)
        {
            if (kind == "bRate")
            {
                lblIn1.Text = "Enter number of births per day:";
            }
            else
            {
                lblIn1.Text = "Enter number of deaths per day:";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int BDCount = Convert.ToInt32(txtIn1.Text);

                if (kind == "bRate")
                {
                    form1.CalcBDRate(BDCount, "Birth");
                    this.Close();
                }
                else
                {
                    form1.CalcBDRate(BDCount, "Death");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid values.");
                txtIn1.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
