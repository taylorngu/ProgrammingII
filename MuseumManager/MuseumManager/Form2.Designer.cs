namespace MuseumManager
{
    partial class Form2
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
            this.picArtwork = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPrompYear = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblPrompArtist = new System.Windows.Forms.Label();
            this.lblArtworkName = new System.Windows.Forms.Label();
            this.lblPrompAName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // picArtwork
            // 
            this.picArtwork.Location = new System.Drawing.Point(20, 122);
            this.picArtwork.Name = "picArtwork";
            this.picArtwork.Size = new System.Drawing.Size(260, 173);
            this.picArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtwork.TabIndex = 19;
            this.picArtwork.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(160, 301);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(79, 301);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPrompYear
            // 
            this.lblPrompYear.Location = new System.Drawing.Point(157, 71);
            this.lblPrompYear.Name = "lblPrompYear";
            this.lblPrompYear.Size = new System.Drawing.Size(35, 13);
            this.lblPrompYear.TabIndex = 16;
            this.lblPrompYear.Text = "Year: ";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(157, 94);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(123, 25);
            this.lblYear.TabIndex = 15;
            // 
            // lblArtist
            // 
            this.lblArtist.Location = new System.Drawing.Point(157, 40);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(123, 22);
            this.lblArtist.TabIndex = 13;
            // 
            // lblPrompArtist
            // 
            this.lblPrompArtist.Location = new System.Drawing.Point(157, 18);
            this.lblPrompArtist.Name = "lblPrompArtist";
            this.lblPrompArtist.Size = new System.Drawing.Size(35, 13);
            this.lblPrompArtist.TabIndex = 12;
            this.lblPrompArtist.Text = "Artist: ";
            // 
            // lblArtworkName
            // 
            this.lblArtworkName.Location = new System.Drawing.Point(20, 40);
            this.lblArtworkName.Name = "lblArtworkName";
            this.lblArtworkName.Size = new System.Drawing.Size(119, 79);
            this.lblArtworkName.TabIndex = 11;
            // 
            // lblPrompAName
            // 
            this.lblPrompAName.Location = new System.Drawing.Point(20, 18);
            this.lblPrompAName.Name = "lblPrompAName";
            this.lblPrompAName.Size = new System.Drawing.Size(100, 23);
            this.lblPrompAName.TabIndex = 10;
            this.lblPrompAName.Text = "Artwork Name: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 343);
            this.Controls.Add(this.picArtwork);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblPrompYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblPrompArtist);
            this.Controls.Add(this.lblArtworkName);
            this.Controls.Add(this.lblPrompAName);
            this.Name = "Form2";
            this.Text = "Museum Library";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picArtwork;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblPrompYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblPrompArtist;
        private System.Windows.Forms.Label lblArtworkName;
        private System.Windows.Forms.Label lblPrompAName;

    }
}