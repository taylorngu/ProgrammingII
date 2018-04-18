using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseSorter
{
    public partial class Form1 : Form
    {

        string[] gry = new string[3];
        int gryC = 0; 
        string[] huf = new string[6];
        int hufC = 0;
        string[] rav = new string[9];
        int ravC = 0; 
        string[] sly = new string[5];
        int slyC = 0; 

        string[][] names = new string[4][];

        public Form1()
        {
            InitializeComponent();
            names[0] = gry;
            names[1] = huf;
            names[2] = rav;
            names[3] = sly; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string student = txtName.Text;
            string house = cmbHouse.SelectedItem.ToString();

            if (house == "Gryffindor")
            {

                if (gryC == 3)
                {
                    MessageBox.Show("The house count has been reached. Please choose another house.");
                }
                else
                {
                    gry[gryC] = student;
                    lstG.Items.Add(student); 
                    gryC++;
                    txtName.Clear();
                }

            }
            else if (house == "Hufflepuff")
            {
                if (hufC == 6)
                {
                    MessageBox.Show("The house count has been reached. Please choose another house.");
                }
                else
                {
                    huf[hufC] = student;
                    lstH.Items.Add(student);
                    hufC++;
                    txtName.Clear();
                }
            }
            else if (house == "Ravenclaw")
            {
                if (ravC == 9)
                {
                    MessageBox.Show("The house count has been reached. Please choose another house.");
                }
                else
                {
                    rav[ravC] = student;
                    lstR.Items.Add(student);
                    ravC++;
                    txtName.Clear();
                }
            }
            else
            {
                if (slyC == 5)
                {
                    MessageBox.Show("The house count has been reached. Please choose another house.");
                }
                else
                {
                    sly[slyC] = student;
                    lstS.Items.Add(student);
                    slyC++;
                    txtName.Clear();
                }
            }
        }

    }
}
