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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        string artPath = "";
        public List<Artwork> artList = new List<Artwork>();

        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "*.jpg|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picArtwork.Load(dlg.FileName);
                artPath = dlg.FileName; 
            }

            dlg.Dispose();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Artwork museumArt = new Artwork(txtWname.Text, txtAname.Text, txtYear.Text);

            if (artPath != "")
            {
                museumArt.path = artPath; 
            }

            artList.Add(museumArt);
            txtAname.Text = "";
            txtWname.Text = "";
            txtYear.Text = "";
            picArtwork.Image = null; 
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(artList); 
            form.ShowDialog();  
        }
    }    
    public class Artwork
        {

            public string workname { get; set; }
            public string artistname { get; set; }
            public string year { get; set; }
            public string path { get; set; }

            public Artwork(string workname = "", string artistname = "", string year = "", string path = "")
            {

                this.workname = workname;
                this.artistname = artistname;
                this.year = year;
                this.path = path;

            }

        }
}
