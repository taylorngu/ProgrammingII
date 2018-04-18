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
    public partial class twoinput : Form
    {

        string kind = "";
        Form1 form1;

        public twoinput(string kind, Form1 form1)
        {
            this.form1 = form1;
            this.kind = kind;
            InitializeComponent();
        }

        private void twoinput_Load(object sender, EventArgs e)
        {
            if (kind == "actBR")
            {
                lblIn1.Text = "Enter number of births per day:";
                lblIn2.Text = "Enter total population:";
            }
            else if (kind == "actDR")
            {
                lblIn1.Text = "Enter number of deaths per day:";
                lblIn2.Text = "Enter total population:";
            }
            else if (kind == "popDensity")
            {
                lblIn1.Text = "Enter current population:";
                lblIn2.Text = "Enter total area in ";
                cboUnits.Visible = true;
            }
            else
            {
                lblIn1.Text = "Enter number of births per day:";
                lblIn2.Text = "Enter number of deaths per day:";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                long population = Convert.ToInt64(txtIn2.Text);

                if (kind == "actBR")
                {
                    int births = Convert.ToInt32(txtIn1.Text);

                    form1.CalcActBDRate(births, population, "Birth");
                    this.Close();
                }

                else if (kind == "actDR")
                {
                    int deaths = Convert.ToInt32(txtIn1.Text);

                    form1.CalcActBDRate(deaths, population, "Death");
                    this.Close();
                }

                else if (kind == "popDensity")
                {
                    int area = Convert.ToInt32(txtIn2.Text);
                    char[] myChar = { 's', '²' };

                    form1.CalcPopDensity(population, area, String.Format("{0}²", cboUnits.Text.TrimEnd(myChar)));
                    this.Close();
                }

                else
                {
                    int births = Convert.ToInt32(txtIn1.Text);
                    int deaths = Convert.ToInt32(txtIn2.Text);

                    form1.CalcGlobalGR(births, deaths);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid values.");
                txtIn1.Text = "";
                txtIn2.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}