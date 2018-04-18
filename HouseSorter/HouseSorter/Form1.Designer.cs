namespace HouseSorter
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
            this.lblPromp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPromp2 = new System.Windows.Forms.Label();
            this.cmbHouse = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblG = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lstG = new System.Windows.Forms.ListBox();
            this.lstH = new System.Windows.Forms.ListBox();
            this.lstR = new System.Windows.Forms.ListBox();
            this.lstS = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPromp
            // 
            this.lblPromp.Location = new System.Drawing.Point(165, 15);
            this.lblPromp.Name = "lblPromp";
            this.lblPromp.Size = new System.Drawing.Size(89, 17);
            this.lblPromp.TabIndex = 0;
            this.lblPromp.Text = "Student Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblPromp2
            // 
            this.lblPromp2.Location = new System.Drawing.Point(167, 35);
            this.lblPromp2.Name = "lblPromp2";
            this.lblPromp2.Size = new System.Drawing.Size(169, 23);
            this.lblPromp2.TabIndex = 2;
            this.lblPromp2.Text = "Select House to Sort Student";
            this.lblPromp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbHouse
            // 
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.Items.AddRange(new object[] {
            "Gryffindor",
            "Hufflepuff",
            "Ravenclaw",
            "Slytherin"});
            this.cmbHouse.Location = new System.Drawing.Point(189, 61);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(121, 21);
            this.cmbHouse.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to House";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblG
            // 
            this.lblG.Location = new System.Drawing.Point(21, 123);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(100, 23);
            this.lblG.TabIndex = 5;
            this.lblG.Text = "Gryffindor";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH
            // 
            this.lblH.Location = new System.Drawing.Point(147, 123);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(100, 23);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "Hufflepuff";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblR
            // 
            this.lblR.Location = new System.Drawing.Point(273, 123);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(100, 23);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "Ravenclaw";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS
            // 
            this.lblS.Location = new System.Drawing.Point(401, 123);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(100, 23);
            this.lblS.TabIndex = 8;
            this.lblS.Text = "Slytherin";
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstG
            // 
            this.lstG.FormattingEnabled = true;
            this.lstG.Location = new System.Drawing.Point(10, 149);
            this.lstG.Name = "lstG";
            this.lstG.Size = new System.Drawing.Size(121, 95);
            this.lstG.TabIndex = 9;
            // 
            // lstH
            // 
            this.lstH.FormattingEnabled = true;
            this.lstH.Location = new System.Drawing.Point(137, 149);
            this.lstH.Name = "lstH";
            this.lstH.Size = new System.Drawing.Size(121, 95);
            this.lstH.TabIndex = 10;
            // 
            // lstR
            // 
            this.lstR.FormattingEnabled = true;
            this.lstR.Location = new System.Drawing.Point(264, 149);
            this.lstR.Name = "lstR";
            this.lstR.Size = new System.Drawing.Size(121, 95);
            this.lstR.TabIndex = 11;
            // 
            // lstS
            // 
            this.lstS.FormattingEnabled = true;
            this.lstS.Location = new System.Drawing.Point(391, 149);
            this.lstS.Name = "lstS";
            this.lstS.Size = new System.Drawing.Size(121, 95);
            this.lstS.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 254);
            this.Controls.Add(this.lstS);
            this.Controls.Add(this.lstR);
            this.Controls.Add(this.lstH);
            this.Controls.Add(this.lstG);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbHouse);
            this.Controls.Add(this.lblPromp2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPromp);
            this.Name = "Form1";
            this.Text = "House Sorter for New Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPromp2;
        private System.Windows.Forms.ComboBox cmbHouse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.ListBox lstG;
        private System.Windows.Forms.ListBox lstH;
        private System.Windows.Forms.ListBox lstR;
        private System.Windows.Forms.ListBox lstS;
    }
}

