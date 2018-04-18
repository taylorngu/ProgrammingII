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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCBR_Click(object sender, EventArgs e)
        {
            OpenForms("bRate", "Crude Birth Rate (CBR)", 1);
        }

        private void btnCDR_Click(object sender, EventArgs e)
        {
            OpenForms("dRate", "Crude Death Rate (CDR)", 1);
        }

        private void btnActualBR_Click(object sender, EventArgs e)
        {
            OpenForms("actBR", "Actual Birth Rate", 2);
        }

        private void btnActualDR_Click(object sender, EventArgs e)
        {
            OpenForms("actDR", "Actual Death Rate", 2);
        }

        private void btnDensity_Click(object sender, EventArgs e)
        {
            OpenForms("popDensity", "Population Density", 2);
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            OpenForms("doubleTime", "DoublingTime", 3);
        }

        private void btnNationalGR_Click(object sender, EventArgs e)
        {
            OpenForms("natGR", "National Population Growth Rate", 4);
        }

        private void btnGlobalGR_Click(object sender, EventArgs e)
        {
            OpenForms("globalGR", "Global Population Growth Rate", 2);
        }

        private void btnNetGR_Click(object sender, EventArgs e)
        {
            OpenForms("netGR", "Net Population Growth Rate", 3);
        }

        private void btnFuturePop_Click(object sender, EventArgs e)
        {
            OpenForms("popFuture", "Population in the Future", 5);
        }

        #region OpenForms

        public void OpenForms(string kind, string title, int size)
        {
            Form form;

            if (size == 1)
            {
                form = new oneinput(kind, this);
                form.Text = title;
                form.ShowDialog();
            }
            else if (size == 2)
            {
                form = new twoinput(kind, this);
                form.Text = title;
                form.ShowDialog();
            }
            else if (size == 3)
            {
                form = new threeinput(kind, this);
                form.Text = title;
                form.ShowDialog();
            }
            else if (size == 4)
            {
                form = new fourinput(kind, this);
                form.Text = title;
                form.ShowDialog();
            }
            else 
            {
                form = new fiveinput(kind, this);
                form.Text = title;
                form.ShowDialog();
            }
        }

        #endregion 

        #region Menu

        private void CalculateAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calcAll = new calcall(this);
            calcAll.ShowDialog(); 
        }

        private void removeItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                lstOut.Items.Remove(lstOut.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
        }

        #endregion

        #region Calculations

        public void CalcBDRate(int BDCount, string BD)
        {
            double BDrate = (BDCount * 365) / 1000;
            lstOut.Items.Add(String.Format("Crude {0} Rate:\t\t{1} {2}s per 1,000 people", BD, BDrate, BD.ToLower()));
        }

        public void CalcActBDRate(int BDCount, long population, string BD)
        {
            double BDRate = ((BDCount * 365) / population) * 100;
            lstOut.Items.Add(String.Format("Actual {0} Rate:\t\t{1}%", BD, Math.Round(BDRate, 2)));
        }

        public void CalcPopDensity(long population, int area, string units)
        {
            double popDensity = population / area;

            lstOut.Items.Add(String.Format("Population Density:\t\t{0} people/person per {1}", Math.Round(popDensity), units));
        }

        public void CalcDoubleTime(int births, int deaths, long population)
        {
            double doubleTime = 70 / ((births * 365) - (deaths * 365)) / population * 100;
            lstOut.Items.Add(String.Format("Doubling Time of Population:\t{0}", Math.Round(doubleTime, 2)));
        }

        public void CalcGlobalGR(int births, int deaths)
        {
            double globalGR = ((births * 365) - (deaths * 365)) / 7500000000;
            lstOut.Items.Add(String.Format("Global Population Growth:\t{0}%", Math.Round(globalGR * 100, 8)));
        }

        public void CalcNetGR(int births, int deaths, long population)
        {
            double netGR = (((births * 365) - (deaths * 365)) / population) * 100;
            lstOut.Items.Add(String.Format("Net Population Growth:\t{0}%", Math.Round(netGR, 2)));
        }

        public void CalcNatGR(int births, int deaths, int immigration, int emigration)
        {
            double natpopGR = ((((births * 365) / 1000) + ((immigration * 365) / 1000)) - (((deaths * 365) / 1000) + ((emigration * 365) / 1000))) / 10;
            lstOut.Items.Add(String.Format("National Population Growth:\t{0}%", Math.Round(natpopGR, 2)));
        }

        public void CalcPopFuture(int births, int deaths, int immigration, int emigration, long population)
        {
            double popFuture = population + ((population / 1000 * births) - (population / 1000 * deaths)) + (immigration - emigration);
            lstOut.Items.Add(String.Format("Population in the Future:\t{0}", Math.Round(popFuture)));
        }

        #endregion

        
    }    
}
