using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shapes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Shape
        {

            public string name { get; set; }

            public Shape(string name)
            {
                this.name = name;
            }

            public abstract double getArea();
            public string getName()
            {
            return name; 
            }

        
        }
        class Rectangle : Shape
        {
            public double width {get; set;}
            public double height {get; set;}

            public Rectangle(double width, double height) : base ("Rectangle")
            {
                this.width = width;
                this.height = height; 
        
            }
            public override double  getArea()
            {
                return width*height;
            }

        
        }
        class Circle : Shape
        {
            public double radius {get; set;}

            public Circle(double radius) : base ("Circle")
            {
                this.radius = radius; 
        
            }
            public override double  getArea()
            {
            return Math.PI * radius * radius;
            }

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {

            Rectangle rect = new Rectangle(5, 10);

            lblOut.Text = String.Format("You created a {0} with width {1} and height {2}. It has an area of {3}.\n", rect.getName(), rect.width, rect.height, rect.getArea());

            Circle circ = new Circle(5);

            lblOut.Text += String.Format("You created a {0} with a radius {1}. It has an area of {2}.\n", circ.getName(), circ.radius, circ.getArea());


        }
    }
}
