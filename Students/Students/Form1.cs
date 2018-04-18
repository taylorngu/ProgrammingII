using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        private int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {

                if (count > 5)
                {

                    throw new InvalidOperationException();

                }
                else
                {
                    Student student = new Student(txtName.Text, Convert.ToDouble(txtGPA.Text));
                    lstOut.Items.Add(student.ToString());
                    count++;
                }
            }
            catch (InvalidGPAException)
            {
                MessageBox.Show("Please enter a valid GPA.");
                txtGPA.Text = "";
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("The number of students is exceeded");
                btnAdd.Enabled = false;
            }

            finally
            {
                MessageBox.Show("Now in the finally block");
                
            }

        }
    }

    public class InvalidGPAException : Exception
    {
        public InvalidGPAException()
            : base("The GPA is out of range.")
        {
        }
    }

    public class Student
    {
        public string name { get; set; }

        private double gpa;             
        public double GPA
        {
            get { return gpa; }         
            set                         
            {
                if ((value >= 0) && (value <= 4.00))
                {
                    gpa = value;
                }
                else
                {
                    throw new InvalidGPAException();
                }
            }
        }
        public Student(string name, double GPA) 
        {
            this.name = name;
            this.GPA = GPA;
        }
        public override string ToString()
        {
            return String.Format("{0}\t{1:F2}", this.name, this.GPA);
        }
    }

}
