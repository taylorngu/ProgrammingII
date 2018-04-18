namespace Population
{
    partial class fiveinput
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
            this.txtIn5 = new System.Windows.Forms.TextBox();
            this.lblIn5 = new System.Windows.Forms.Label();
            this.txtIn4 = new System.Windows.Forms.TextBox();
            this.lblIn4 = new System.Windows.Forms.Label();
            this.txtIn3 = new System.Windows.Forms.TextBox();
            this.lblIn3 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.lblIn2 = new System.Windows.Forms.Label();
            this.lblIn1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIn5
            // 
            this.txtIn5.Location = new System.Drawing.Point(178, 117);
            this.txtIn5.Name = "txtIn5";
            this.txtIn5.Size = new System.Drawing.Size(100, 20);
            this.txtIn5.TabIndex = 46;
            // 
            // lblIn5
            // 
            this.lblIn5.Location = new System.Drawing.Point(18, 91);
            this.lblIn5.Name = "lblIn5";
            this.lblIn5.Size = new System.Drawing.Size(135, 23);
            this.lblIn5.TabIndex = 49;
            this.lblIn5.Text = "Enter immigration per day:";
            // 
            // txtIn4
            // 
            this.txtIn4.Location = new System.Drawing.Point(178, 91);
            this.txtIn4.Name = "txtIn4";
            this.txtIn4.Size = new System.Drawing.Size(100, 20);
            this.txtIn4.TabIndex = 45;
            // 
            // lblIn4
            // 
            this.lblIn4.Location = new System.Drawing.Point(18, 117);
            this.lblIn4.Name = "lblIn4";
            this.lblIn4.Size = new System.Drawing.Size(135, 23);
            this.lblIn4.TabIndex = 47;
            this.lblIn4.Text = "Enter emigration per day:";
            // 
            // txtIn3
            // 
            this.txtIn3.Location = new System.Drawing.Point(178, 65);
            this.txtIn3.Name = "txtIn3";
            this.txtIn3.Size = new System.Drawing.Size(100, 20);
            this.txtIn3.TabIndex = 43;
            // 
            // lblIn3
            // 
            this.lblIn3.Location = new System.Drawing.Point(18, 65);
            this.lblIn3.Name = "lblIn3";
            this.lblIn3.Size = new System.Drawing.Size(154, 23);
            this.lblIn3.TabIndex = 44;
            this.lblIn3.Text = "Enter number of deaths day:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(122, 147);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 48;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(178, 39);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(100, 20);
            this.txtIn2.TabIndex = 42;
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(178, 13);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(100, 20);
            this.txtIn1.TabIndex = 41;
            // 
            // lblIn2
            // 
            this.lblIn2.Location = new System.Drawing.Point(18, 39);
            this.lblIn2.Name = "lblIn2";
            this.lblIn2.Size = new System.Drawing.Size(154, 23);
            this.lblIn2.TabIndex = 40;
            this.lblIn2.Text = "Enter number of births per day:";
            // 
            // lblIn1
            // 
            this.lblIn1.Location = new System.Drawing.Point(18, 13);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(135, 23);
            this.lblIn1.TabIndex = 39;
            this.lblIn1.Text = "Enter current population:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fiveinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtIn5);
            this.Controls.Add(this.lblIn5);
            this.Controls.Add(this.txtIn4);
            this.Controls.Add(this.lblIn4);
            this.Controls.Add(this.txtIn3);
            this.Controls.Add(this.lblIn3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.lblIn2);
            this.Controls.Add(this.lblIn1);
            this.Name = "fiveinput";
            this.Text = "fiveinput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtIn5;
        internal System.Windows.Forms.Label lblIn5;
        internal System.Windows.Forms.TextBox txtIn4;
        internal System.Windows.Forms.Label lblIn4;
        internal System.Windows.Forms.TextBox txtIn3;
        internal System.Windows.Forms.Label lblIn3;
        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.TextBox txtIn2;
        internal System.Windows.Forms.TextBox txtIn1;
        internal System.Windows.Forms.Label lblIn2;
        internal System.Windows.Forms.Label lblIn1;
        private System.Windows.Forms.Button btnCancel;
    }
}