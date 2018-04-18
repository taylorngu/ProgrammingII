namespace MuseumManager
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
            this.lblPrompWName = new System.Windows.Forms.Label();
            this.lblPrompAName = new System.Windows.Forms.Label();
            this.lblPrompYear = new System.Windows.Forms.Label();
            this.lblPrompFile = new System.Windows.Forms.Label();
            this.txtWname = new System.Windows.Forms.TextBox();
            this.txtAname = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.picArtwork = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompWName
            // 
            this.lblPrompWName.Location = new System.Drawing.Point(17, 14);
            this.lblPrompWName.Name = "lblPrompWName";
            this.lblPrompWName.Size = new System.Drawing.Size(156, 13);
            this.lblPrompWName.TabIndex = 0;
            this.lblPrompWName.Text = "Enter the work\'s name: ";
            // 
            // lblPrompAName
            // 
            this.lblPrompAName.Location = new System.Drawing.Point(17, 40);
            this.lblPrompAName.Name = "lblPrompAName";
            this.lblPrompAName.Size = new System.Drawing.Size(145, 13);
            this.lblPrompAName.TabIndex = 1;
            this.lblPrompAName.Text = "Enter the artist\'s name: ";
            // 
            // lblPrompYear
            // 
            this.lblPrompYear.Location = new System.Drawing.Point(17, 66);
            this.lblPrompYear.Name = "lblPrompYear";
            this.lblPrompYear.Size = new System.Drawing.Size(179, 35);
            this.lblPrompYear.TabIndex = 2;
            this.lblPrompYear.Text = "Enter the year the work was produced: ";
            // 
            // lblPrompFile
            // 
            this.lblPrompFile.Location = new System.Drawing.Point(17, 101);
            this.lblPrompFile.Name = "lblPrompFile";
            this.lblPrompFile.Size = new System.Drawing.Size(179, 34);
            this.lblPrompFile.TabIndex = 3;
            this.lblPrompFile.Text = "Find the file with a photo of the artwork:";
            // 
            // txtWname
            // 
            this.txtWname.Location = new System.Drawing.Point(202, 7);
            this.txtWname.Name = "txtWname";
            this.txtWname.Size = new System.Drawing.Size(100, 20);
            this.txtWname.TabIndex = 4;
            // 
            // txtAname
            // 
            this.txtAname.Location = new System.Drawing.Point(202, 33);
            this.txtAname.Name = "txtAname";
            this.txtAname.Size = new System.Drawing.Size(100, 20);
            this.txtAname.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(202, 63);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(202, 96);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find Photo...";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // picArtwork
            // 
            this.picArtwork.Location = new System.Drawing.Point(17, 134);
            this.picArtwork.Name = "picArtwork";
            this.picArtwork.Size = new System.Drawing.Size(285, 158);
            this.picArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtwork.TabIndex = 8;
            this.picArtwork.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add to Library";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblShow
            // 
            this.lblShow.Location = new System.Drawing.Point(103, 327);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(93, 23);
            this.lblShow.TabIndex = 10;
            this.lblShow.Text = "Show Library";
            this.lblShow.UseVisualStyleBackColor = true;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 358);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picArtwork);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAname);
            this.Controls.Add(this.txtWname);
            this.Controls.Add(this.lblPrompFile);
            this.Controls.Add(this.lblPrompYear);
            this.Controls.Add(this.lblPrompAName);
            this.Controls.Add(this.lblPrompWName);
            this.Name = "Form1";
            this.Text = "Museum Manager";
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompWName;
        private System.Windows.Forms.Label lblPrompAName;
        private System.Windows.Forms.Label lblPrompYear;
        private System.Windows.Forms.Label lblPrompFile;
        private System.Windows.Forms.TextBox txtWname;
        private System.Windows.Forms.TextBox txtAname;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox picArtwork;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button lblShow;
    }
}

