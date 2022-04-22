namespace valueSwaping
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnshiftright = new System.Windows.Forms.Button();
            this.btnshiftleft = new System.Windows.Forms.Button();
            this.multishiftleft = new System.Windows.Forms.Button();
            this.multishiftright = new System.Windows.Forms.Button();
            this.shiftalltoright = new System.Windows.Forms.Button();
            this.shiftalltoleft = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadd2 = new System.Windows.Forms.Button();
            this.btnremove2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 277);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(316, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(120, 277);
            this.listBox2.TabIndex = 0;
            // 
            // btnshiftright
            // 
            this.btnshiftright.Location = new System.Drawing.Point(204, 50);
            this.btnshiftright.Name = "btnshiftright";
            this.btnshiftright.Size = new System.Drawing.Size(75, 23);
            this.btnshiftright.TabIndex = 1;
            this.btnshiftright.Text = ">";
            this.btnshiftright.UseVisualStyleBackColor = true;
            this.btnshiftright.Click += new System.EventHandler(this.btnshiftright_Click);
            // 
            // btnshiftleft
            // 
            this.btnshiftleft.Location = new System.Drawing.Point(204, 92);
            this.btnshiftleft.Name = "btnshiftleft";
            this.btnshiftleft.Size = new System.Drawing.Size(75, 23);
            this.btnshiftleft.TabIndex = 1;
            this.btnshiftleft.Text = "<";
            this.btnshiftleft.UseVisualStyleBackColor = true;
            this.btnshiftleft.Click += new System.EventHandler(this.btnshiftleft_Click);
            // 
            // multishiftleft
            // 
            this.multishiftleft.Location = new System.Drawing.Point(204, 183);
            this.multishiftleft.Name = "multishiftleft";
            this.multishiftleft.Size = new System.Drawing.Size(75, 23);
            this.multishiftleft.TabIndex = 1;
            this.multishiftleft.Text = "<<";
            this.multishiftleft.UseVisualStyleBackColor = true;
            this.multishiftleft.Click += new System.EventHandler(this.multishiftleft_Click);
            // 
            // multishiftright
            // 
            this.multishiftright.Location = new System.Drawing.Point(204, 141);
            this.multishiftright.Name = "multishiftright";
            this.multishiftright.Size = new System.Drawing.Size(75, 23);
            this.multishiftright.TabIndex = 1;
            this.multishiftright.Text = ">>";
            this.multishiftright.UseVisualStyleBackColor = true;
            this.multishiftright.Click += new System.EventHandler(this.multishiftright_Click);
            // 
            // shiftalltoright
            // 
            this.shiftalltoright.Location = new System.Drawing.Point(204, 229);
            this.shiftalltoright.Name = "shiftalltoright";
            this.shiftalltoright.Size = new System.Drawing.Size(75, 23);
            this.shiftalltoright.TabIndex = 1;
            this.shiftalltoright.Text = ">>>";
            this.shiftalltoright.UseVisualStyleBackColor = true;
            this.shiftalltoright.Click += new System.EventHandler(this.shiftalltoright_Click);
            // 
            // shiftalltoleft
            // 
            this.shiftalltoleft.Location = new System.Drawing.Point(204, 272);
            this.shiftalltoleft.Name = "shiftalltoleft";
            this.shiftalltoleft.Size = new System.Drawing.Size(75, 23);
            this.shiftalltoleft.TabIndex = 1;
            this.shiftalltoleft.Text = "<<<";
            this.shiftalltoleft.UseVisualStyleBackColor = true;
            this.shiftalltoleft.Click += new System.EventHandler(this.shiftalltoleft_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(44, 363);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(44, 402);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadd2
            // 
            this.btnadd2.Location = new System.Drawing.Point(361, 363);
            this.btnadd2.Name = "btnadd2";
            this.btnadd2.Size = new System.Drawing.Size(75, 23);
            this.btnadd2.TabIndex = 1;
            this.btnadd2.Text = "Add";
            this.btnadd2.UseVisualStyleBackColor = true;
            this.btnadd2.Click += new System.EventHandler(this.btnadd2_Click);
            // 
            // btnremove2
            // 
            this.btnremove2.Location = new System.Drawing.Point(361, 402);
            this.btnremove2.Name = "btnremove2";
            this.btnremove2.Size = new System.Drawing.Size(75, 23);
            this.btnremove2.TabIndex = 1;
            this.btnremove2.Text = "Remove";
            this.btnremove2.UseVisualStyleBackColor = true;
            this.btnremove2.Click += new System.EventHandler(this.btnremove2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 507);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.multishiftright);
            this.Controls.Add(this.shiftalltoleft);
            this.Controls.Add(this.shiftalltoright);
            this.Controls.Add(this.multishiftleft);
            this.Controls.Add(this.btnshiftleft);
            this.Controls.Add(this.btnremove2);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnshiftright);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnshiftright;
        private System.Windows.Forms.Button btnshiftleft;
        private System.Windows.Forms.Button multishiftleft;
        private System.Windows.Forms.Button multishiftright;
        private System.Windows.Forms.Button shiftalltoright;
        private System.Windows.Forms.Button shiftalltoleft;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd2;
        private System.Windows.Forms.Button btnremove2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

