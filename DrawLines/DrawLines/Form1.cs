using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawLines
{
    public struct Coordinates
    {
        public int x;
        public int y;

        public Coordinates(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    public partial class Form1 : Form
    {
        public Coordinates[] coor = new Coordinates[10];
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (count > 9)
            {
                lblOut.Text = "No more points can be added. Click Draw to draw your lines.";
            
            }
            else 
            {
            
                Coordinates point = new Coordinates(e.X, e.Y);
                coor[count] = point;
                count++;
                lblOut.Text = String.Format("Point number {0} is at {1}. {2}", count, e.X, e.Y);

            }

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            Graphics frmSurface = this.CreateGraphics();
            Pen bluePen = new Pen(Color.DarkBlue, 2);

            for (int i = 0; i < count - 1; i++)
            {

                frmSurface.DrawLine(bluePen, coor[i].x, coor[i].y, coor[i + 1].x, coor[i+1].y);
            
            }

            lblOut.Text = String.Format("You drew {0} lines.", count - 1);
        }

    }
}
