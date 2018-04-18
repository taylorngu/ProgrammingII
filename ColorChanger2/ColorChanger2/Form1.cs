using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorChanger2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* public void ChangeColor(int num)
        {
            
            switch (num)
            { 
            
                case 1:
                    BackColor = Color.Red;
                    break; 
                case 2:
                    BackColor = Color.Blue;
                    break; 
                case 3:
                    BackColor = Color.Yellow;
                    break; 
                case 4:
                    BackColor = Color.Green;
                    break; 
                case 5: 
                    BackColor = Color.Purple;
                    break; 

            }


        } */


        private void button1_Click(object sender, EventArgs e)
        {

            if (btnStartStop.Text == "Start")
            {

                btnStartStop.Text = "Stop";
                tmrColor.Start();

            }
            else
            {

                btnStartStop.Text = "Start";
                tmrColor.Stop();

            }
        }

        private void tmrColor_Tick(object sender, EventArgs e)
        {

            Random gen = new Random();
            int num = gen.Next(1, 225);
            // ChangeColor(num);

            int red = gen.Next(0, 225);
            int green = gen.Next(0, 225);
            int blue = gen.Next(0, 225);

            BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
