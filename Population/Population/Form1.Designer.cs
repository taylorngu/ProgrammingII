namespace Population
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
            this.btnActualDR = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.CalculateAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualBR = new System.Windows.Forms.Button();
            this.grpGrowth = new System.Windows.Forms.GroupBox();
            this.btnFuturePop = new System.Windows.Forms.Button();
            this.btnNetGR = new System.Windows.Forms.Button();
            this.btnGlobalGR = new System.Windows.Forms.Button();
            this.btnNationalGR = new System.Windows.Forms.Button();
            this.btnCDR = new System.Windows.Forms.Button();
            this.btnDensity = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.grpPop = new System.Windows.Forms.GroupBox();
            this.grpBD = new System.Windows.Forms.GroupBox();
            this.btnCBR = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.mnuMain.SuspendLayout();
            this.grpGrowth.SuspendLayout();
            this.grpPop.SuspendLayout();
            this.grpBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualDR
            // 
            this.btnActualDR.Location = new System.Drawing.Point(6, 106);
            this.btnActualDR.Name = "btnActualDR";
            this.btnActualDR.Size = new System.Drawing.Size(137, 23);
            this.btnActualDR.TabIndex = 9;
            this.btnActualDR.Text = "Actual Death Rate";
            this.btnActualDR.UseVisualStyleBackColor = true;
            this.btnActualDR.Click += new System.EventHandler(this.btnActualDR_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateAllToolStripMenuItem,
            this.removeItemToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(2, 3);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(245, 24);
            this.mnuMain.TabIndex = 16;
            this.mnuMain.Text = "MenuStrip1";
            // 
            // CalculateAllToolStripMenuItem
            // 
            this.CalculateAllToolStripMenuItem.Name = "CalculateAllToolStripMenuItem";
            this.CalculateAllToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.CalculateAllToolStripMenuItem.Text = "Calculate All";
            this.CalculateAllToolStripMenuItem.Click += new System.EventHandler(this.CalculateAllToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click_1);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ClearToolStripMenuItem.Text = "Clear All";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // btnActualBR
            // 
            this.btnActualBR.Location = new System.Drawing.Point(6, 77);
            this.btnActualBR.Name = "btnActualBR";
            this.btnActualBR.Size = new System.Drawing.Size(137, 23);
            this.btnActualBR.TabIndex = 8;
            this.btnActualBR.Text = "Actual Birth Rate";
            this.btnActualBR.UseVisualStyleBackColor = true;
            this.btnActualBR.Click += new System.EventHandler(this.btnActualBR_Click);
            // 
            // grpGrowth
            // 
            this.grpGrowth.Controls.Add(this.btnFuturePop);
            this.grpGrowth.Controls.Add(this.btnNetGR);
            this.grpGrowth.Controls.Add(this.btnGlobalGR);
            this.grpGrowth.Controls.Add(this.btnNationalGR);
            this.grpGrowth.Location = new System.Drawing.Point(169, 32);
            this.grpGrowth.Name = "grpGrowth";
            this.grpGrowth.Size = new System.Drawing.Size(150, 140);
            this.grpGrowth.TabIndex = 19;
            this.grpGrowth.TabStop = false;
            this.grpGrowth.Text = "Population Growth Rates";
            // 
            // btnFuturePop
            // 
            this.btnFuturePop.Location = new System.Drawing.Point(6, 106);
            this.btnFuturePop.Name = "btnFuturePop";
            this.btnFuturePop.Size = new System.Drawing.Size(137, 23);
            this.btnFuturePop.TabIndex = 13;
            this.btnFuturePop.Text = "Population in the Future";
            this.btnFuturePop.UseVisualStyleBackColor = true;
            this.btnFuturePop.Click += new System.EventHandler(this.btnFuturePop_Click);
            // 
            // btnNetGR
            // 
            this.btnNetGR.Location = new System.Drawing.Point(6, 77);
            this.btnNetGR.Name = "btnNetGR";
            this.btnNetGR.Size = new System.Drawing.Size(137, 23);
            this.btnNetGR.TabIndex = 12;
            this.btnNetGR.Text = "Net Population";
            this.btnNetGR.UseVisualStyleBackColor = true;
            this.btnNetGR.Click += new System.EventHandler(this.btnNetGR_Click);
            // 
            // btnGlobalGR
            // 
            this.btnGlobalGR.Location = new System.Drawing.Point(6, 48);
            this.btnGlobalGR.Name = "btnGlobalGR";
            this.btnGlobalGR.Size = new System.Drawing.Size(137, 23);
            this.btnGlobalGR.TabIndex = 11;
            this.btnGlobalGR.Text = "Global Population";
            this.btnGlobalGR.UseVisualStyleBackColor = true;
            this.btnGlobalGR.Click += new System.EventHandler(this.btnGlobalGR_Click);
            // 
            // btnNationalGR
            // 
            this.btnNationalGR.Location = new System.Drawing.Point(6, 19);
            this.btnNationalGR.Name = "btnNationalGR";
            this.btnNationalGR.Size = new System.Drawing.Size(137, 23);
            this.btnNationalGR.TabIndex = 10;
            this.btnNationalGR.Text = "National Population";
            this.btnNationalGR.UseVisualStyleBackColor = true;
            this.btnNationalGR.Click += new System.EventHandler(this.btnNationalGR_Click);
            // 
            // btnCDR
            // 
            this.btnCDR.Location = new System.Drawing.Point(6, 48);
            this.btnCDR.Name = "btnCDR";
            this.btnCDR.Size = new System.Drawing.Size(137, 23);
            this.btnCDR.TabIndex = 7;
            this.btnCDR.Text = "Crude Death Rate (CDR)";
            this.btnCDR.UseVisualStyleBackColor = true;
            this.btnCDR.Click += new System.EventHandler(this.btnCDR_Click);
            // 
            // btnDensity
            // 
            this.btnDensity.Location = new System.Drawing.Point(6, 19);
            this.btnDensity.Name = "btnDensity";
            this.btnDensity.Size = new System.Drawing.Size(137, 23);
            this.btnDensity.TabIndex = 0;
            this.btnDensity.Text = "Population Density";
            this.btnDensity.UseVisualStyleBackColor = true;
            this.btnDensity.Click += new System.EventHandler(this.btnDensity_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(162, 19);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(137, 23);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "Doubling Time";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // grpPop
            // 
            this.grpPop.Controls.Add(this.btnDouble);
            this.grpPop.Controls.Add(this.btnDensity);
            this.grpPop.Location = new System.Drawing.Point(13, 178);
            this.grpPop.Name = "grpPop";
            this.grpPop.Size = new System.Drawing.Size(306, 54);
            this.grpPop.TabIndex = 18;
            this.grpPop.TabStop = false;
            this.grpPop.Text = "Population";
            // 
            // grpBD
            // 
            this.grpBD.Controls.Add(this.btnActualDR);
            this.grpBD.Controls.Add(this.btnActualBR);
            this.grpBD.Controls.Add(this.btnCDR);
            this.grpBD.Controls.Add(this.btnCBR);
            this.grpBD.Location = new System.Drawing.Point(13, 32);
            this.grpBD.Name = "grpBD";
            this.grpBD.Size = new System.Drawing.Size(150, 140);
            this.grpBD.TabIndex = 17;
            this.grpBD.TabStop = false;
            this.grpBD.Text = "Birth/Death Rates";
            // 
            // btnCBR
            // 
            this.btnCBR.Location = new System.Drawing.Point(6, 19);
            this.btnCBR.Name = "btnCBR";
            this.btnCBR.Size = new System.Drawing.Size(137, 23);
            this.btnCBR.TabIndex = 6;
            this.btnCBR.Text = "Crude Birth Rate (CBR)";
            this.btnCBR.UseVisualStyleBackColor = true;
            this.btnCBR.Click += new System.EventHandler(this.btnCBR_Click);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(13, 243);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(306, 147);
            this.lstOut.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 404);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.grpGrowth);
            this.Controls.Add(this.grpPop);
            this.Controls.Add(this.grpBD);
            this.Controls.Add(this.lstOut);
            this.Name = "Form1";
            this.Text = "Population Calculator";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpGrowth.ResumeLayout(false);
            this.grpPop.ResumeLayout(false);
            this.grpBD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnActualDR;
        internal System.Windows.Forms.MenuStrip mnuMain;
        internal System.Windows.Forms.ToolStripMenuItem CalculateAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        internal System.Windows.Forms.Button btnActualBR;
        internal System.Windows.Forms.GroupBox grpGrowth;
        internal System.Windows.Forms.Button btnFuturePop;
        internal System.Windows.Forms.Button btnNetGR;
        internal System.Windows.Forms.Button btnGlobalGR;
        internal System.Windows.Forms.Button btnNationalGR;
        internal System.Windows.Forms.Button btnCDR;
        internal System.Windows.Forms.Button btnDensity;
        internal System.Windows.Forms.Button btnDouble;
        internal System.Windows.Forms.GroupBox grpPop;
        internal System.Windows.Forms.GroupBox grpBD;
        internal System.Windows.Forms.Button btnCBR;
        internal System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
    }
}

