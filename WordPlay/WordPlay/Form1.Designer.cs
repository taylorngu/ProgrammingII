namespace WordPlay
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
            this.btnMake = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblCountOut = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(79, 47);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(110, 23);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make a Sentence";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(12, 9);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(236, 23);
            this.lblOut.TabIndex = 1;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountOut
            // 
            this.lblCountOut.Location = new System.Drawing.Point(15, 82);
            this.lblCountOut.Name = "lblCountOut";
            this.lblCountOut.Size = new System.Drawing.Size(186, 23);
            this.lblCountOut.TabIndex = 2;
            this.lblCountOut.Text = "Sentences generated before a match: ";
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(200, 82);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 23);
            this.lblCount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 113);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCountOut);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnMake);
            this.Name = "Form1";
            this.Text = "Word Play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblCountOut;
        private System.Windows.Forms.Label lblCount;
    }
}

