namespace Account
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpAChoices = new System.Windows.Forms.GroupBox();
            this.radBaby = new System.Windows.Forms.RadioButton();
            this.radNorm = new System.Windows.Forms.RadioButton();
            this.grpDW = new System.Windows.Forms.GroupBox();
            this.radWith = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.lblPromp = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtDeWith = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.grpAChoices.SuspendLayout();
            this.grpDW.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 288);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpAChoices
            // 
            this.grpAChoices.Controls.Add(this.radBaby);
            this.grpAChoices.Controls.Add(this.radNorm);
            this.grpAChoices.Location = new System.Drawing.Point(12, 99);
            this.grpAChoices.Name = "grpAChoices";
            this.grpAChoices.Size = new System.Drawing.Size(133, 82);
            this.grpAChoices.TabIndex = 2;
            this.grpAChoices.TabStop = false;
            this.grpAChoices.Text = "Account Types";
            // 
            // radBaby
            // 
            this.radBaby.AutoSize = true;
            this.radBaby.Location = new System.Drawing.Point(19, 50);
            this.radBaby.Name = "radBaby";
            this.radBaby.Size = new System.Drawing.Size(92, 17);
            this.radBaby.TabIndex = 1;
            this.radBaby.TabStop = true;
            this.radBaby.Text = "Baby Account";
            this.radBaby.UseVisualStyleBackColor = true;
            // 
            // radNorm
            // 
            this.radNorm.AutoSize = true;
            this.radNorm.Location = new System.Drawing.Point(19, 27);
            this.radNorm.Name = "radNorm";
            this.radNorm.Size = new System.Drawing.Size(105, 17);
            this.radNorm.TabIndex = 0;
            this.radNorm.TabStop = true;
            this.radNorm.Text = "Regular Account";
            this.radNorm.UseVisualStyleBackColor = true;
            // 
            // grpDW
            // 
            this.grpDW.Controls.Add(this.radWith);
            this.grpDW.Controls.Add(this.radDeposit);
            this.grpDW.Location = new System.Drawing.Point(12, 187);
            this.grpDW.Name = "grpDW";
            this.grpDW.Size = new System.Drawing.Size(133, 82);
            this.grpDW.TabIndex = 3;
            this.grpDW.TabStop = false;
            this.grpDW.Text = "Actions";
            // 
            // radWith
            // 
            this.radWith.AutoSize = true;
            this.radWith.Location = new System.Drawing.Point(19, 50);
            this.radWith.Name = "radWith";
            this.radWith.Size = new System.Drawing.Size(72, 17);
            this.radWith.TabIndex = 1;
            this.radWith.TabStop = true;
            this.radWith.Text = "Withdrawl";
            this.radWith.UseVisualStyleBackColor = true;
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(19, 27);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(61, 17);
            this.radDeposit.TabIndex = 0;
            this.radDeposit.TabStop = true;
            this.radDeposit.Text = "Deposit";
            this.radDeposit.UseVisualStyleBackColor = true;
            // 
            // lblPromp
            // 
            this.lblPromp.Location = new System.Drawing.Point(151, 99);
            this.lblPromp.Name = "lblPromp";
            this.lblPromp.Size = new System.Drawing.Size(100, 23);
            this.lblPromp.TabIndex = 4;
            this.lblPromp.Text = "Enter Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(151, 118);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(76, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // txtDeWith
            // 
            this.txtDeWith.Location = new System.Drawing.Point(154, 219);
            this.txtDeWith.Name = "txtDeWith";
            this.txtDeWith.Size = new System.Drawing.Size(76, 20);
            this.txtDeWith.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(151, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount to be \r\nDeposited/Withdrawn:";
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(12, 9);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(260, 87);
            this.lblOut.TabIndex = 8;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtDeWith);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblPromp);
            this.Controls.Add(this.grpDW);
            this.Controls.Add(this.grpAChoices);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Bank";
            this.grpAChoices.ResumeLayout(false);
            this.grpAChoices.PerformLayout();
            this.grpDW.ResumeLayout(false);
            this.grpDW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpAChoices;
        private System.Windows.Forms.RadioButton radBaby;
        private System.Windows.Forms.RadioButton radNorm;
        private System.Windows.Forms.GroupBox grpDW;
        private System.Windows.Forms.RadioButton radWith;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.Label lblPromp;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtDeWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOut;
    }
}

