namespace Animals
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblPromp = new System.Windows.Forms.Label();
            this.grpAnim = new System.Windows.Forms.GroupBox();
            this.radBird = new System.Windows.Forms.RadioButton();
            this.radCat = new System.Windows.Forms.RadioButton();
            this.radDog = new System.Windows.Forms.RadioButton();
            this.grpAnim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(76, 347);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(15, 93);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(184, 251);
            this.lblOut.TabIndex = 1;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromp
            // 
            this.lblPromp.Location = new System.Drawing.Point(12, 9);
            this.lblPromp.Name = "lblPromp";
            this.lblPromp.Size = new System.Drawing.Size(194, 39);
            this.lblPromp.TabIndex = 2;
            this.lblPromp.Text = "What type of animal would you like to create?";
            this.lblPromp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpAnim
            // 
            this.grpAnim.Controls.Add(this.radBird);
            this.grpAnim.Controls.Add(this.radCat);
            this.grpAnim.Controls.Add(this.radDog);
            this.grpAnim.Location = new System.Drawing.Point(18, 41);
            this.grpAnim.Name = "grpAnim";
            this.grpAnim.Size = new System.Drawing.Size(187, 49);
            this.grpAnim.TabIndex = 3;
            this.grpAnim.TabStop = false;
            this.grpAnim.Text = "Choices";
            // 
            // radBird
            // 
            this.radBird.AutoSize = true;
            this.radBird.Location = new System.Drawing.Point(138, 24);
            this.radBird.Name = "radBird";
            this.radBird.Size = new System.Drawing.Size(43, 17);
            this.radBird.TabIndex = 2;
            this.radBird.TabStop = true;
            this.radBird.Text = "Bird";
            this.radBird.UseVisualStyleBackColor = true;
            // 
            // radCat
            // 
            this.radCat.AutoSize = true;
            this.radCat.Location = new System.Drawing.Point(75, 24);
            this.radCat.Name = "radCat";
            this.radCat.Size = new System.Drawing.Size(41, 17);
            this.radCat.TabIndex = 1;
            this.radCat.TabStop = true;
            this.radCat.Text = "Cat";
            this.radCat.UseVisualStyleBackColor = true;
            // 
            // radDog
            // 
            this.radDog.AutoSize = true;
            this.radDog.Location = new System.Drawing.Point(6, 24);
            this.radDog.Name = "radDog";
            this.radDog.Size = new System.Drawing.Size(45, 17);
            this.radDog.TabIndex = 0;
            this.radDog.TabStop = true;
            this.radDog.Text = "Dog";
            this.radDog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 382);
            this.Controls.Add(this.grpAnim);
            this.Controls.Add(this.lblPromp);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Animals";
            this.grpAnim.ResumeLayout(false);
            this.grpAnim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblPromp;
        private System.Windows.Forms.GroupBox grpAnim;
        private System.Windows.Forms.RadioButton radBird;
        private System.Windows.Forms.RadioButton radCat;
        private System.Windows.Forms.RadioButton radDog;
    }
}

