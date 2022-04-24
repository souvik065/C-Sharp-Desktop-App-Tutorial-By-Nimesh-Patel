namespace AccountDemoApp
{
    partial class AccountFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnset = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndestroy = new System.Windows.Forms.Button();
            this.btngc = new System.Windows.Forms.Button();
            this.btntemp = new System.Windows.Forms.Button();
            this.btngenerated = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Balance :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(34, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(196, 44);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(372, 44);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(100, 20);
            this.txtbalance.TabIndex = 1;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(67, 82);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnset
            // 
            this.btnset.Location = new System.Drawing.Point(191, 82);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(75, 23);
            this.btnset.TabIndex = 2;
            this.btnset.Text = "Set";
            this.btnset.UseVisualStyleBackColor = true;
            this.btnset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(326, 82);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(75, 23);
            this.btnget.TabIndex = 2;
            this.btnget.Text = "Get";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(67, 111);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndestroy
            // 
            this.btndestroy.Location = new System.Drawing.Point(191, 111);
            this.btndestroy.Name = "btndestroy";
            this.btndestroy.Size = new System.Drawing.Size(75, 23);
            this.btndestroy.TabIndex = 2;
            this.btndestroy.Text = "Destroy";
            this.btndestroy.UseVisualStyleBackColor = true;
            this.btndestroy.Click += new System.EventHandler(this.btndestroy_Click);
            // 
            // btngc
            // 
            this.btngc.Location = new System.Drawing.Point(326, 111);
            this.btngc.Name = "btngc";
            this.btngc.Size = new System.Drawing.Size(75, 23);
            this.btngc.TabIndex = 2;
            this.btngc.Text = "GC";
            this.btngc.UseVisualStyleBackColor = true;
            this.btngc.Click += new System.EventHandler(this.btngc_Click);
            // 
            // btntemp
            // 
            this.btntemp.Location = new System.Drawing.Point(67, 140);
            this.btntemp.Name = "btntemp";
            this.btntemp.Size = new System.Drawing.Size(75, 23);
            this.btntemp.TabIndex = 3;
            this.btntemp.Text = "Temp";
            this.btntemp.UseVisualStyleBackColor = true;
            this.btntemp.Click += new System.EventHandler(this.btntemp_Click);
            // 
            // btngenerated
            // 
            this.btngenerated.Location = new System.Drawing.Point(191, 140);
            this.btngenerated.Name = "btngenerated";
            this.btngenerated.Size = new System.Drawing.Size(210, 23);
            this.btngenerated.TabIndex = 3;
            this.btngenerated.Text = "Get Generated";
            this.btngenerated.UseVisualStyleBackColor = true;
            this.btngenerated.Click += new System.EventHandler(this.btngenerated_Click);
            // 
            // AccountFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 484);
            this.Controls.Add(this.btngenerated);
            this.Controls.Add(this.btntemp);
            this.Controls.Add(this.btngc);
            this.Controls.Add(this.btndestroy);
            this.Controls.Add(this.btnget);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AccountFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndestroy;
        private System.Windows.Forms.Button btngc;
        private System.Windows.Forms.Button btntemp;
        private System.Windows.Forms.Button btngenerated;
    }
}

