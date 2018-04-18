using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Account
        {

            public decimal nbalance { get; set; }
            public decimal obalance { get; set; }
            public decimal amount { get; set; }
            public bool dewith {get; set;}
            public bool baby { get; set; }
            public bool err = false;

            public virtual void Calc(bool dewith, decimal amount)
            {

                if (dewith == true)
                {

                    nbalance = obalance + amount;

                }
                else if (dewith == false)
                {
                    nbalance = obalance - amount;
                }
            }

            public override string ToString()
            {
                if (baby == false)
                {
                    if (dewith == true)
                    {

                        return String.Format("Original balance: {0}" + System.Environment.NewLine + "Amount deposited: {1}" + System.Environment.NewLine + "New balance: {2}", obalance, amount, nbalance);

                    }
                    else
                    {
                        return String.Format("Original balance: {0}" + System.Environment.NewLine + "Amount withdrawn: {1}" + System.Environment.NewLine + "New balance: {2}", obalance, amount, nbalance);
                    }
                }
                else
                {
                    
                    return "You have a baby account, you cannot withdraw more than $5 at a time";

                }

            }
        
        }

        class BabyAccount : Account
        {

            public override void Calc(bool dewith, decimal amount)
            {
             
                if (amount < 6)
                {
                    if (dewith == true)
                    {
                        nbalance = obalance + amount;
                    }
                    else
                    {
                        nbalance = obalance - amount;
                    }
                }
                else if (amount >= 6)
                {
                    err = false; 
                }
            }
        
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (radNorm.Checked == true)
            {

                Account check = new Account();
                check.obalance = Convert.ToDecimal(txtBalance.Text);
                check.amount = Convert.ToDecimal(txtDeWith.Text);
                check.Calc(check.dewith, check.amount);

                if (radDeposit.Checked == true)
                {
                    check.dewith = true;
                }
                else
                {
                    check.dewith = false;
                }

                check.baby = false;
                lblOut.Text = check.ToString();

            }
            else
            {

                BabyAccount baby = new BabyAccount();
                baby.obalance = Convert.ToDecimal(txtBalance.Text);
                baby.amount = Convert.ToDecimal(txtDeWith.Text);
                baby.Calc(baby.dewith, baby.amount);

                if (radDeposit.Checked == true)
                {
                    baby.dewith = true;
                }
                else
                {
                    baby.dewith = false;
                }
                baby.baby = true;
                lblOut.Text = baby.ToString();
            
            
            }



        }

    }
}
