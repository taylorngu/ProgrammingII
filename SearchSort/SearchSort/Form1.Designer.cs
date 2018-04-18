namespace SearchSort
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radBin = new System.Windows.Forms.RadioButton();
            this.radLin = new System.Windows.Forms.RadioButton();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.radRad = new System.Windows.Forms.RadioButton();
            this.radQuick = new System.Windows.Forms.RadioButton();
            this.radBubble = new System.Windows.Forms.RadioButton();
            this.radInsert = new System.Windows.Forms.RadioButton();
            this.radMerge = new System.Windows.Forms.RadioButton();
            this.radSelection = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Location = new System.Drawing.Point(7, 19);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(130, 20);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Enter a number to search:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(146, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(83, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radBin);
            this.grpSearch.Controls.Add(this.radLin);
            this.grpSearch.Controls.Add(this.txtNumber);
            this.grpSearch.Controls.Add(this.lblPrompt);
            this.grpSearch.Location = new System.Drawing.Point(15, 27);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(243, 63);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // radBin
            // 
            this.radBin.AutoSize = true;
            this.radBin.Location = new System.Drawing.Point(146, 40);
            this.radBin.Name = "radBin";
            this.radBin.Size = new System.Drawing.Size(54, 17);
            this.radBin.TabIndex = 1;
            this.radBin.TabStop = true;
            this.radBin.Text = "Binary";
            this.radBin.UseVisualStyleBackColor = true;
            // 
            // radLin
            // 
            this.radLin.AutoSize = true;
            this.radLin.Location = new System.Drawing.Point(12, 40);
            this.radLin.Name = "radLin";
            this.radLin.Size = new System.Drawing.Size(54, 17);
            this.radLin.TabIndex = 0;
            this.radLin.TabStop = true;
            this.radLin.Text = "Linear";
            this.radLin.UseVisualStyleBackColor = true;
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.radRad);
            this.grpSort.Controls.Add(this.radQuick);
            this.grpSort.Controls.Add(this.radBubble);
            this.grpSort.Controls.Add(this.radInsert);
            this.grpSort.Controls.Add(this.radMerge);
            this.grpSort.Controls.Add(this.radSelection);
            this.grpSort.Location = new System.Drawing.Point(15, 96);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(243, 90);
            this.grpSort.TabIndex = 4;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort";
            // 
            // radRad
            // 
            this.radRad.AutoSize = true;
            this.radRad.Location = new System.Drawing.Point(146, 65);
            this.radRad.Name = "radRad";
            this.radRad.Size = new System.Drawing.Size(52, 17);
            this.radRad.TabIndex = 5;
            this.radRad.TabStop = true;
            this.radRad.Text = "Radix";
            this.radRad.UseVisualStyleBackColor = true;
            // 
            // radQuick
            // 
            this.radQuick.AutoSize = true;
            this.radQuick.Location = new System.Drawing.Point(17, 65);
            this.radQuick.Name = "radQuick";
            this.radQuick.Size = new System.Drawing.Size(72, 17);
            this.radQuick.TabIndex = 4;
            this.radQuick.TabStop = true;
            this.radQuick.Text = "QuickSort";
            this.radQuick.UseVisualStyleBackColor = true;
            // 
            // radBubble
            // 
            this.radBubble.AutoSize = true;
            this.radBubble.Location = new System.Drawing.Point(146, 42);
            this.radBubble.Name = "radBubble";
            this.radBubble.Size = new System.Drawing.Size(58, 17);
            this.radBubble.TabIndex = 3;
            this.radBubble.TabStop = true;
            this.radBubble.Text = "Bubble";
            this.radBubble.UseVisualStyleBackColor = true;
            // 
            // radInsert
            // 
            this.radInsert.AutoSize = true;
            this.radInsert.Location = new System.Drawing.Point(146, 19);
            this.radInsert.Name = "radInsert";
            this.radInsert.Size = new System.Drawing.Size(65, 17);
            this.radInsert.TabIndex = 2;
            this.radInsert.TabStop = true;
            this.radInsert.Text = "Insertion";
            this.radInsert.UseVisualStyleBackColor = true;
            // 
            // radMerge
            // 
            this.radMerge.AutoSize = true;
            this.radMerge.Location = new System.Drawing.Point(17, 42);
            this.radMerge.Name = "radMerge";
            this.radMerge.Size = new System.Drawing.Size(55, 17);
            this.radMerge.TabIndex = 1;
            this.radMerge.TabStop = true;
            this.radMerge.Text = "Merge";
            this.radMerge.UseVisualStyleBackColor = true;
            // 
            // radSelection
            // 
            this.radSelection.AutoSize = true;
            this.radSelection.Location = new System.Drawing.Point(17, 19);
            this.radSelection.Name = "radSelection";
            this.radSelection.Size = new System.Drawing.Size(69, 17);
            this.radSelection.TabIndex = 0;
            this.radSelection.TabStop = true;
            this.radSelection.Text = "Selection";
            this.radSelection.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(10, 231);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(251, 225);
            this.lstOutput.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(191, 192);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(100, 192);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(72, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(273, 24);
            this.mnuMenu.TabIndex = 8;
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 469);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "Form1";
            this.Text = "Bob Ross";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton radBin;
        private System.Windows.Forms.RadioButton radLin;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton radQuick;
        private System.Windows.Forms.RadioButton radBubble;
        private System.Windows.Forms.RadioButton radInsert;
        private System.Windows.Forms.RadioButton radMerge;
        private System.Windows.Forms.RadioButton radSelection;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton radRad;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

