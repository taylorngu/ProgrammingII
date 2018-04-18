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
    public partial class fourinput : Form
    {
        string kind = "";
        Form1 form1;

        public fourinput(string kind, Form1 form1)
        {
            this.form1 = form1;
            this.kind = kind;
            InitializeComponent();
        }

       private void btnCalc_Click(object sender, EventArgs e)
       {
           try
           {
               int births = Convert.ToInt32(txtIn1.Text);
               int deaths = Convert.ToInt32(txtIn2.Text);
               int immigration = Convert.ToInt32(txtIn3.Text);
               int emigration = Convert.ToInt32(txtIn4.Text);

               form1.CalcNatGR(births, deaths, emigration, immigration);
           }
           catch
           {
               MessageBox.Show("Please enter valid values.");
               txtIn1.Text = "";
               txtIn2.Text = "";
               txtIn3.Text = "";
               txtIn4.Text = "";
           }
       }

       private void btnCancel_Click(object sender, EventArgs e)
       {
           this.Close();
       }
        
    }
}
