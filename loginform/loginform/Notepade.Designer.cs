namespace loginform
{
    partial class Notepade
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnfont = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnpaste = new System.Windows.Forms.Button();
            this.btncopy = new System.Windows.Forms.Button();
            this.btncut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleCalculationToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.dialogBoxToolStripMenuItem,
            this.toolStripMenuItem1,
            this.restaurantToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // simpleCalculationToolStripMenuItem
            // 
            this.simpleCalculationToolStripMenuItem.Name = "simpleCalculationToolStripMenuItem";
            this.simpleCalculationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.simpleCalculationToolStripMenuItem.Text = "Simple calculation";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // dialogBoxToolStripMenuItem
            // 
            this.dialogBoxToolStripMenuItem.Name = "dialogBoxToolStripMenuItem";
            this.dialogBoxToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dialogBoxToolStripMenuItem.Text = "Dailog Box";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.restaurantToolStripMenuItem.Text = "Restaurant Menu List";
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(333, 466);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(75, 23);
            this.btnfont.TabIndex = 4;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(252, 467);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 23);
            this.btncolor.TabIndex = 5;
            this.btncolor.Text = "Colour";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click_1);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(171, 467);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(75, 23);
            this.btnfolder.TabIndex = 6;
            this.btnfolder.Text = "Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(90, 467);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(9, 467);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 8;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(912, 423);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnpaste
            // 
            this.btnpaste.Location = new System.Drawing.Point(577, 467);
            this.btnpaste.Name = "btnpaste";
            this.btnpaste.Size = new System.Drawing.Size(75, 23);
            this.btnpaste.TabIndex = 9;
            this.btnpaste.Text = "Paste";
            this.btnpaste.UseVisualStyleBackColor = true;
            this.btnpaste.Click += new System.EventHandler(this.btnpaste_Click);
            // 
            // btncopy
            // 
            this.btncopy.Location = new System.Drawing.Point(496, 466);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(75, 23);
            this.btncopy.TabIndex = 10;
            this.btncopy.Text = "Copy";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // btncut
            // 
            this.btncut.Location = new System.Drawing.Point(415, 467);
            this.btncut.Name = "btncut";
            this.btncut.Size = new System.Drawing.Size(75, 23);
            this.btncut.TabIndex = 11;
            this.btncut.Text = "Cut";
            this.btncut.UseVisualStyleBackColor = true;
            this.btncut.Click += new System.EventHandler(this.btncut_Click);
            // 
            // Notepade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 561);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnpaste);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.btncut);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Notepade";
            this.Text = "Notepade";
            this.Load += new System.EventHandler(this.Notepade_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnpaste;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Button btncut;
    }
}