namespace Polygon
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.lblPromp = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.radOct = new System.Windows.Forms.RadioButton();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.radPent = new System.Windows.Forms.RadioButton();
            this.radSqu = new System.Windows.Forms.RadioButton();
            this.radTri = new System.Windows.Forms.RadioButton();
            this.lblOut = new System.Windows.Forms.Label();
            this.grpShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 68);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Add to List";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(12, 42);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(143, 20);
            this.txtIn.TabIndex = 4;
            // 
            // lblPromp
            // 
            this.lblPromp.Location = new System.Drawing.Point(9, 9);
            this.lblPromp.Name = "lblPromp";
            this.lblPromp.Size = new System.Drawing.Size(125, 30);
            this.lblPromp.TabIndex = 5;
            this.lblPromp.Text = "Please enter the length of the side";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(12, 97);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(143, 23);
            this.btnArea.TabIndex = 6;
            this.btnArea.Text = "Show Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.radOct);
            this.grpShapes.Controls.Add(this.radHex);
            this.grpShapes.Controls.Add(this.radPent);
            this.grpShapes.Controls.Add(this.radSqu);
            this.grpShapes.Controls.Add(this.radTri);
            this.grpShapes.Location = new System.Drawing.Point(167, 12);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(211, 108);
            this.grpShapes.TabIndex = 7;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Select a Shape";
            // 
            // radOct
            // 
            this.radOct.AutoSize = true;
            this.radOct.Location = new System.Drawing.Point(95, 42);
            this.radOct.Name = "radOct";
            this.radOct.Size = new System.Drawing.Size(66, 17);
            this.radOct.TabIndex = 4;
            this.radOct.TabStop = true;
            this.radOct.Text = "Octagon";
            this.radOct.UseVisualStyleBackColor = true;
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Location = new System.Drawing.Point(95, 19);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(68, 17);
            this.radHex.TabIndex = 3;
            this.radHex.TabStop = true;
            this.radHex.Text = "Hexagon";
            this.radHex.UseVisualStyleBackColor = true;
            // 
            // radPent
            // 
            this.radPent.AutoSize = true;
            this.radPent.Location = new System.Drawing.Point(6, 62);
            this.radPent.Name = "radPent";
            this.radPent.Size = new System.Drawing.Size(71, 17);
            this.radPent.TabIndex = 2;
            this.radPent.TabStop = true;
            this.radPent.Text = "Pentagon";
            this.radPent.UseVisualStyleBackColor = true;
            // 
            // radSqu
            // 
            this.radSqu.AutoSize = true;
            this.radSqu.Location = new System.Drawing.Point(6, 42);
            this.radSqu.Name = "radSqu";
            this.radSqu.Size = new System.Drawing.Size(59, 17);
            this.radSqu.TabIndex = 1;
            this.radSqu.TabStop = true;
            this.radSqu.Text = "Square";
            this.radSqu.UseVisualStyleBackColor = true;
            // 
            // radTri
            // 
            this.radTri.AutoSize = true;
            this.radTri.Location = new System.Drawing.Point(6, 19);
            this.radTri.Name = "radTri";
            this.radTri.Size = new System.Drawing.Size(63, 17);
            this.radTri.TabIndex = 0;
            this.radTri.TabStop = true;
            this.radTri.Text = "Triangle";
            this.radTri.UseVisualStyleBackColor = true;
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(12, 132);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(366, 211);
            this.lblOut.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 352);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.grpShapes);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblPromp);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Polygon";
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label lblPromp;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.RadioButton radOct;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.RadioButton radPent;
        private System.Windows.Forms.RadioButton radSqu;
        private System.Windows.Forms.RadioButton radTri;
        private System.Windows.Forms.Label lblOut;
    }
}

