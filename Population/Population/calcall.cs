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
    public partial class calcall : Form
    {
        Form1 form1;

        public calcall(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                long population = Convert.ToInt64(txtIn1.Text);
                int births = Convert.ToInt32(txtIn2.Text);
                int deaths = Convert.ToInt32(txtIn3.Text);
                int immigration = Convert.ToInt32(txtIn4.Text);
                int emigration = Convert.ToInt32(txtIn5.Text);
                int area = Convert.ToInt32(txtIn6.Text);
                char[] myChar = { 's', '²'};

                form1.CalcBDRate(births, "Birth");
                form1.CalcBDRate(deaths, "Death");
                form1.CalcActBDRate(births, population, "Birth");
                form1.CalcActBDRate(deaths, population, "Death");
                form1.CalcPopDensity(population, area, String.Format("{0}²", cboUnits.Text.TrimEnd(myChar)));
                form1.CalcDoubleTime(births, deaths, population);
                form1.CalcNatGR(births, deaths, immigration, emigration);
                form1.CalcGlobalGR(births, deaths);
                form1.CalcNetGR(births, deaths, population);
                form1.CalcPopFuture(births, deaths, immigration, emigration, population);
                
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter valid values.");
                txtIn1.Text = "";
                txtIn2.Text = "";
                txtIn3.Text = "";
                txtIn4.Text = "";
                txtIn5.Text = "";
                txtIn6.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
