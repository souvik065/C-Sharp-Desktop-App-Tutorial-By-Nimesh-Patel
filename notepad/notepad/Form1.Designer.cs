namespace notepad
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btncut = new System.Windows.Forms.Button();
            this.btncopy = new System.Windows.Forms.Button();
            this.btnpaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(912, 292);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(13, 312);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(94, 312);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(175, 312);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(75, 23);
            this.btnfolder.TabIndex = 1;
            this.btnfolder.Text = "Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(256, 312);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 23);
            this.btncolor.TabIndex = 1;
            this.btncolor.Text = "Colour";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(337, 311);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(75, 23);
            this.btnfont.TabIndex = 1;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btncut
            // 
            this.btncut.Location = new System.Drawing.Point(419, 312);
            this.btncut.Name = "btncut";
            this.btncut.Size = new System.Drawing.Size(75, 23);
            this.btncut.TabIndex = 2;
            this.btncut.Text = "Cut";
            this.btncut.UseVisualStyleBackColor = true;
            this.btncut.Click += new System.EventHandler(this.btncut_Click);
            // 
            // btncopy
            // 
            this.btncopy.Location = new System.Drawing.Point(500, 311);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(75, 23);
            this.btncopy.TabIndex = 2;
            this.btncopy.Text = "Copy";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // btnpaste
            // 
            this.btnpaste.Location = new System.Drawing.Point(581, 312);
            this.btnpaste.Name = "btnpaste";
            this.btnpaste.Size = new System.Drawing.Size(75, 23);
            this.btnpaste.TabIndex = 2;
            this.btnpaste.Text = "Paste";
            this.btnpaste.UseVisualStyleBackColor = true;
            this.btnpaste.Click += new System.EventHandler(this.btnpaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 452);
            this.Controls.Add(this.btnpaste);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.btncut);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btncut;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Button btnpaste;
    }
}

