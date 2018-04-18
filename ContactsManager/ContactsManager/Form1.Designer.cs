namespace ContactsManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrompFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblStreetAD = new System.Windows.Forms.Label();
            this.lblCityAD = new System.Windows.Forms.Label();
            this.lblStateAD = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtStreetAD = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(359, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.sortToolStripMenuItem.Text = "Sort Address Book";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.searchToolStripMenuItem.Text = "Search Address Book";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.deleteToolStripMenuItem.Text = "Delete Contacts";
            // 
            // lblPrompFName
            // 
            this.lblPrompFName.AutoSize = true;
            this.lblPrompFName.Location = new System.Drawing.Point(26, 38);
            this.lblPrompFName.Name = "lblPrompFName";
            this.lblPrompFName.Size = new System.Drawing.Size(60, 13);
            this.lblPrompFName.TabIndex = 1;
            this.lblPrompFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(26, 64);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "LastName:";
            // 
            // lblStreetAD
            // 
            this.lblStreetAD.AutoSize = true;
            this.lblStreetAD.Location = new System.Drawing.Point(26, 90);
            this.lblStreetAD.Name = "lblStreetAD";
            this.lblStreetAD.Size = new System.Drawing.Size(82, 13);
            this.lblStreetAD.TabIndex = 3;
            this.lblStreetAD.Text = "Street Address: ";
            // 
            // lblCityAD
            // 
            this.lblCityAD.AutoSize = true;
            this.lblCityAD.Location = new System.Drawing.Point(26, 116);
            this.lblCityAD.Name = "lblCityAD";
            this.lblCityAD.Size = new System.Drawing.Size(27, 13);
            this.lblCityAD.TabIndex = 4;
            this.lblCityAD.Text = "City:";
            // 
            // lblStateAD
            // 
            this.lblStateAD.AutoSize = true;
            this.lblStateAD.Location = new System.Drawing.Point(26, 142);
            this.lblStateAD.Name = "lblStateAD";
            this.lblStateAD.Size = new System.Drawing.Size(35, 13);
            this.lblStateAD.TabIndex = 5;
            this.lblStateAD.Text = "State:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(121, 35);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(222, 20);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(121, 61);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(222, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtStreetAD
            // 
            this.txtStreetAD.Location = new System.Drawing.Point(121, 87);
            this.txtStreetAD.Name = "txtStreetAD";
            this.txtStreetAD.Size = new System.Drawing.Size(222, 20);
            this.txtStreetAD.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(121, 113);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(222, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(121, 139);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(222, 20);
            this.txtState.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 198);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAD);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblStateAD);
            this.Controls.Add(this.lblCityAD);
            this.Controls.Add(this.lblStreetAD);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblPrompFName);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.Text = "Contact Manager";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblPrompFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblStreetAD;
        private System.Windows.Forms.Label lblCityAD;
        private System.Windows.Forms.Label lblStateAD;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtStreetAD;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnAdd;

    }
}

