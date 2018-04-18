namespace WordMaker
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(96, 38);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(89, 23);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make Words";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(260, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 67);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(260, 95);
            this.lstOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnMake);
            this.Name = "Form1";
            this.Text = "Word Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

