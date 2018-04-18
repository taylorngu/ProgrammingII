using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polygon
{
    public partial class Form1 : Form
    {

        Polygon[] shapes = new Polygon[5];
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (radTri.Checked == true)
            {
                shapes[count++] = new EquTri(Convert.ToDouble(txtIn.Text));

            }
            else if (radSqu.Checked == true)
            {
                shapes[count++] = new Squ(Convert.ToDouble(txtIn.Text));

            }
            else if (radPent.Checked == true)
            {
                shapes[count++] = new Pent(Convert.ToDouble(txtIn.Text));

            }

            else if (radHex.Checked == true)
            {
                shapes[count++] = new Hex(Convert.ToDouble(txtIn.Text));

            }
            else if (radOct.Checked == true)
            {
                shapes[count++] = new Oct(Convert.ToDouble(txtIn.Text));

            }



        }

        private void btnArea_Click(object sender, EventArgs e)
        {

            double totalArea = 0;

            foreach (Polygon p in shapes)
            {
                totalArea += p.getArea();
                lblOut.Text += p.ToString();

            }

            lblOut.Text += String.Format("The total area of all the shapes is: {0:F2} square inches", Math.Round(totalArea, 2));


        }

    } abstract class Polygon
        {
            public double side { get; set; }
            public Polygon(double side)
            {

                this.side = side;
            
            }

            abstract public double getArea();


        }
        class EquTri : Polygon
        {

            public EquTri(double side) : base(side) { }
            public override double getArea()
            {

                return ((Math.Sqrt(3) / 4) * side * side);
                
            }
            public override string ToString()
            {
                return String.Format("Equalateral triangle with sides of {0} inches has an area of {1} square inches\n\n", Convert.ToString(side), Math.Round(this.getArea(), 2));
            }

        }
        class Squ : Polygon
        {

            public Squ(double side) : base(side) { }
            public override double getArea()
            {

                return (side * side);

            }
            public override string ToString()
            {
                return String.Format("Square with sides of {0} inches has an area of {1} square inches\n\n", Convert.ToString(side), Math.Round(this.getArea(), 2));
            }
        }
        class Pent : Polygon
        {

            public Pent(double side) : base(side) { }
            public override double getArea()
            {

                return (side * side) * (.25 * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))));

            }
            public override string ToString()
            {
                return String.Format("Pentagon with sides of {0} inches has an area of {1} square inches\n\n", Convert.ToString(side), Math.Round(this.getArea(), 2));
            }

        }
        class Hex : Polygon
        {

            public Hex(double side) : base(side) { }
            public override double getArea()
            {

                return ((3 * (Math.Sqrt(3)))/2) * side * side;

            }
            public override string ToString()
            {
                return String.Format("Hexagon with sides of {0} inches has an area of {1} square inches\n\n", Convert.ToString(side), Math.Round(this.getArea(), 2));
            }

        }
        class Oct : Polygon
        {

            public Oct(double side) : base(side) { }
            public override double getArea()
            {

                return (2* (1 + Math.Sqrt(2)) * side * side);

            }
            public override string ToString()
            {
                return String.Format("Octagon with sides of {0} inches has an area of {1} square inches\n\n", Convert.ToString(side), Math.Round(this.getArea(), 2));

            }

        }
    
}

