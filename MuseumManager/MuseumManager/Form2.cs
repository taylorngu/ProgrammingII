using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MuseumManager
{
    public partial class Form2 : Form
    {
        List<Artwork> artList = new List<Artwork>(); 

        public Form2(List<Artwork> art)
        {
            artList = art; 
            InitializeComponent();
        }

        public void displayArt(int position)
        {
            lblArtworkName.Text = artList[position].workname;
            lblArtist.Text = artList[position].artistname;
            lblYear.Text = artList[position].year;
            if (artList[position].path != "")
            {
                picArtwork.Load(artList[position].path);
            }
             
        }

        static int count = 0; 

        private void Form2_Load(object sender, EventArgs e)
        {
            displayArt(count);
            btnPrevious.Enabled = false; 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true; 
            count++; 
            if (count == artList.Count() - 1)
            {
                btnNext.Enabled = false; 
            }
            displayArt(count); 
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true; 
            count--;
            if (count == 0)
            {
                btnPrevious.Enabled = false;
            }

            displayArt(count); 
        }
    }
}
