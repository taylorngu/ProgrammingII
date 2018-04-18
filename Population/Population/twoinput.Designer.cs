namespace Population
{
    partial class twoinput
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.lblIn2 = new System.Windows.Forms.Label();
            this.lblIn1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboUnits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(132, 72);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 43;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(188, 38);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(100, 20);
            this.txtIn2.TabIndex = 42;
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(188, 12);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(100, 20);
            this.txtIn1.TabIndex = 41;
            // 
            // lblIn2
            // 
            this.lblIn2.Location = new System.Drawing.Point(13, 41);
            this.lblIn2.Name = "lblIn2";
            this.lblIn2.Size = new System.Drawing.Size(169, 23);
            this.lblIn2.TabIndex = 40;
            this.lblIn2.Text = "Label2";
            // 
            // lblIn1
            // 
            this.lblIn1.Location = new System.Drawing.Point(13, 15);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(169, 23);
            this.lblIn1.TabIndex = 39;
            this.lblIn1.Text = "Label1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboUnits
            // 
            this.cboUnits.FormattingEnabled = true;
            this.cboUnits.Items.AddRange(new object[] {
            "kilometers²"});
            this.cboUnits.Location = new System.Drawing.Point(102, 38);
            this.cboUnits.Name = "cboUnits";
            this.cboUnits.Size = new System.Drawing.Size(80, 21);
            this.cboUnits.TabIndex = 45;
            this.cboUnits.Text = "miles²";
            this.cboUnits.Visible = false;
            // 
            // twoinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 107);
            this.Controls.Add(this.cboUnits);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.lblIn2);
            this.Controls.Add(this.lblIn1);
            this.Name = "twoinput";
            this.Text = "twoinput";
            this.Load += new System.EventHandler(this.twoinput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.TextBox txtIn2;
        internal System.Windows.Forms.TextBox txtIn1;
        internal System.Windows.Forms.Label lblIn2;
        internal System.Windows.Forms.Label lblIn1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboUnits;

    }
}