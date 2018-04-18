namespace Population
{
    partial class oneinput
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.lblIn1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(118, 35);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 64;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(173, 6);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(100, 20);
            this.txtIn1.TabIndex = 62;
            // 
            // lblIn1
            // 
            this.lblIn1.Location = new System.Drawing.Point(12, 9);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(169, 23);
            this.lblIn1.TabIndex = 60;
            this.lblIn1.Text = "Label1";
            // 
            // oneinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 66);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.lblIn1);
            this.Name = "oneinput";
            this.Text = "oneinput";
            this.Load += new System.EventHandler(this.oneinput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.TextBox txtIn1;
        internal System.Windows.Forms.Label lblIn1;


    }
}