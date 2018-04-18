using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            OperatingSystem opSys = Environment.OSVersion;
            PlatformID opSysID = opSys.Platform;

            string[] logicalDrives = Environment.GetLogicalDrives();
            string driveString = "";
            foreach (string drive in logicalDrives)
            {
                driveString += drive + "   ";
            }

            lstOutput.Items.Add(""); 
            lstOutput.Items.Add("Operating System:\t\t" + opSys);
            lstOutput.Items.Add("Operating System ID:\t" + opSysID);
            lstOutput.Items.Add("Common Language Runtime:\t" + Environment.Version);
            lstOutput.Items.Add("Machine Name:\t\t" + Environment.MachineName);

            lstOutput.Items.Add("");
            lstOutput.Items.Add("User ID:\t\t\t" + Environment.UserName);
            lstOutput.Items.Add("Current Directory:\t\t" + Environment.CurrentDirectory);
            lstOutput.Items.Add("Drives Present:\t\t" + driveString);


        }
    }
}
