namespace Population
{
    partial class threeinput
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
            // txtIn3
            // 
            this.txtIn3.Location = new System.Drawing.Point(201, 63);
            this.txtIn3.Name = "txtIn3";
            this.txtIn3.Size = new System.Drawing.Size(100, 20);
            this.txtIn3.TabIndex = 43;
            // 
            // lblIn3
            // 
            this.lblIn3.Location = new System.Drawing.Point(13, 66);
            this.lblIn3.Name = "lblIn3";
            this.lblIn3.Size = new System.Drawing.Size(184, 23);
            this.lblIn3.TabIndex = 44;
            this.lblIn3.Text = "Label2";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(145, 92);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 45;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(201, 37);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(100, 20);
            this.txtIn2.TabIndex = 42;
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(201, 11);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(100, 20);
            this.txtIn1.TabIndex = 41;
            // 
            // lblIn2
            // 
            this.lblIn2.Location = new System.Drawing.Point(13, 40);
            this.lblIn2.Name = "lblIn2";
            this.lblIn2.Size = new System.Drawing.Size(183, 23);
            this.lblIn2.TabIndex = 40;
            this.lblIn2.Text = "Label2";
            // 
            // lblIn1
            // 
            this.lblIn1.Location = new System.Drawing.Point(12, 14);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(183, 23);
            this.lblIn1.TabIndex = 39;
            this.lblIn1.Text = "Label1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // threeinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 127);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtIn3);
            this.Controls.Add(this.lblIn3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.lblIn2);
            this.Controls.Add(this.lblIn1);
            this.Name = "threeinput";
            this.Text = "threeinput";
            this.Load += new System.EventHandler(this.threeinput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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