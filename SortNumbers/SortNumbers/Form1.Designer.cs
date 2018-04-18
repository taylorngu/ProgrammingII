namespace SortNumbers
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblEven = new System.Windows.Forms.Label();
            this.lblOdd = new System.Windows.Forms.Label();
            this.lblNeg = new System.Windows.Forms.Label();
            this.lblEnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPromp
            // 
            this.lblPromp.Location = new System.Drawing.Point(16, 9);
            this.lblPromp.Name = "lblPromp";
            this.lblPromp.Size = new System.Drawing.Size(169, 57);
            this.lblPromp.TabIndex = 0;
            this.lblPromp.Text = "Enter an even, odd, or negative whole number. Press the Enter Button. Repeat this" +
                " 10 times.";
            this.lblPromp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(19, 71);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(166, 20);
            this.txtIn.TabIndex = 1;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(61, 97);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(91, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Enter Number";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblEn
            // 
            this.lblEn.Location = new System.Drawing.Point(32, 123);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(98, 20);
            this.lblEn.TabIndex = 3;
            this.lblEn.Text = "Number of Entries: ";
            // 
            // lblEven
            // 
            this.lblEven.Location = new System.Drawing.Point(16, 154);
            this.lblEven.Name = "lblEven";
            this.lblEven.Size = new System.Drawing.Size(175, 23);
            this.lblEven.TabIndex = 4;
            this.lblEven.Text = "Even Numbers: ";
            // 
            // lblOdd
            // 
            this.lblOdd.Location = new System.Drawing.Point(16, 177);
            this.lblOdd.Name = "lblOdd";
            this.lblOdd.Size = new System.Drawing.Size(169, 23);
            this.lblOdd.TabIndex = 5;
            this.lblOdd.Text = "Odd Numbers: ";
            // 
            // lblNeg
            // 
            this.lblNeg.Location = new System.Drawing.Point(16, 200);
            this.lblNeg.Name = "lblNeg";
            this.lblNeg.Size = new System.Drawing.Size(175, 24);
            this.lblNeg.TabIndex = 6;
            this.lblNeg.Text = "Negative Numbers: ";
            // 
            // lblEnt
            // 
            this.lblEnt.Location = new System.Drawing.Point(126, 123);
            this.lblEnt.Name = "lblEnt";
            this.lblEnt.Size = new System.Drawing.Size(49, 20);
            this.lblEnt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 230);
            this.Controls.Add(this.lblEnt);
            this.Controls.Add(this.lblNeg);
            this.Controls.Add(this.lblOdd);
            this.Controls.Add(this.lblEven);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.lblPromp);
            this.Name = "Form1";
            this.Text = "Number Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromp;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblEven;
        private System.Windows.Forms.Label lblOdd;
        private System.Windows.Forms.Label lblNeg;
        private System.Windows.Forms.Label lblEnt;
    }
}

