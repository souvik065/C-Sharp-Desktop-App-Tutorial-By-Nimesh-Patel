namespace DemoApplication
{
    partial class MDIParent1
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
            this.partyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sidebarpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPartyQuery = new System.Windows.Forms.Button();
            this.btnExpenseQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuSubpanel = new System.Windows.Forms.Panel();
            this.SubBtnExpenseMaster = new System.Windows.Forms.Button();
            this.SubBtnIncomeMaster = new System.Windows.Forms.Button();
            this.btnSourceMaster = new System.Windows.Forms.Button();
            this.SubBtnPartyMaster = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.SubBtnDebitOrCreditQuery = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Sidebarpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuSubpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partyMasterToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // partyMasterToolStripMenuItem
            // 
            this.partyMasterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.partyMasterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.partyMasterToolStripMenuItem.Name = "partyMasterToolStripMenuItem";
            this.partyMasterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.partyMasterToolStripMenuItem.Text = "Party Master";
            this.partyMasterToolStripMenuItem.Click += new System.EventHandler(this.partyMasterToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseQueryToolStripMenuItem,
            this.partyQueryToolStripMenuItem});
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // expenseQueryToolStripMenuItem
            // 
            this.expenseQueryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.expenseQueryToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.expenseQueryToolStripMenuItem.Name = "expenseQueryToolStripMenuItem";
            this.expenseQueryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.expenseQueryToolStripMenuItem.Text = "Expense Query";
            // 
            // partyQueryToolStripMenuItem
            // 
            this.partyQueryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.partyQueryToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.partyQueryToolStripMenuItem.Name = "partyQueryToolStripMenuItem";
            this.partyQueryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.partyQueryToolStripMenuItem.Text = "Party Query";
            // 
            // Sidebarpanel
            // 
            this.Sidebarpanel.AutoScroll = true;
            this.Sidebarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Sidebarpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sidebarpanel.Controls.Add(this.panel2);
            this.Sidebarpanel.Controls.Add(this.button1);
            this.Sidebarpanel.Controls.Add(this.MenuSubpanel);
            this.Sidebarpanel.Controls.Add(this.btnmenu);
            this.Sidebarpanel.Controls.Add(this.panellogo);
            this.Sidebarpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebarpanel.Location = new System.Drawing.Point(0, 28);
            this.Sidebarpanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sidebarpanel.Name = "Sidebarpanel";
            this.Sidebarpanel.Size = new System.Drawing.Size(206, 705);
            this.Sidebarpanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SubBtnDebitOrCreditQuery);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnPartyQuery);
            this.panel2.Controls.Add(this.btnExpenseQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 203);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(202, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Income Query";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnPartyQuery
            // 
            this.btnPartyQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartyQuery.FlatAppearance.BorderSize = 0;
            this.btnPartyQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartyQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartyQuery.ForeColor = System.Drawing.Color.LightGray;
            this.btnPartyQuery.Location = new System.Drawing.Point(0, 45);
            this.btnPartyQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPartyQuery.Name = "btnPartyQuery";
            this.btnPartyQuery.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnPartyQuery.Size = new System.Drawing.Size(202, 45);
            this.btnPartyQuery.TabIndex = 3;
            this.btnPartyQuery.Text = "Party Query";
            this.btnPartyQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartyQuery.UseVisualStyleBackColor = true;
            this.btnPartyQuery.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExpenseQuery
            // 
            this.btnExpenseQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenseQuery.FlatAppearance.BorderSize = 0;
            this.btnExpenseQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseQuery.ForeColor = System.Drawing.Color.LightGray;
            this.btnExpenseQuery.Location = new System.Drawing.Point(0, 0);
            this.btnExpenseQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExpenseQuery.Name = "btnExpenseQuery";
            this.btnExpenseQuery.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnExpenseQuery.Size = new System.Drawing.Size(202, 45);
            this.btnExpenseQuery.TabIndex = 2;
            this.btnExpenseQuery.Text = "Expense Query";
            this.btnExpenseQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseQuery.UseVisualStyleBackColor = true;
            this.btnExpenseQuery.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(204, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Report";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuSubpanel
            // 
            this.MenuSubpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.MenuSubpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuSubpanel.Controls.Add(this.SubBtnExpenseMaster);
            this.MenuSubpanel.Controls.Add(this.SubBtnIncomeMaster);
            this.MenuSubpanel.Controls.Add(this.btnSourceMaster);
            this.MenuSubpanel.Controls.Add(this.SubBtnPartyMaster);
            this.MenuSubpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSubpanel.Location = new System.Drawing.Point(0, 145);
            this.MenuSubpanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuSubpanel.Name = "MenuSubpanel";
            this.MenuSubpanel.Size = new System.Drawing.Size(204, 189);
            this.MenuSubpanel.TabIndex = 5;
            // 
            // SubBtnExpenseMaster
            // 
            this.SubBtnExpenseMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnExpenseMaster.FlatAppearance.BorderSize = 0;
            this.SubBtnExpenseMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnExpenseMaster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnExpenseMaster.ForeColor = System.Drawing.Color.LightGray;
            this.SubBtnExpenseMaster.Location = new System.Drawing.Point(0, 135);
            this.SubBtnExpenseMaster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubBtnExpenseMaster.Name = "SubBtnExpenseMaster";
            this.SubBtnExpenseMaster.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.SubBtnExpenseMaster.Size = new System.Drawing.Size(202, 45);
            this.SubBtnExpenseMaster.TabIndex = 3;
            this.SubBtnExpenseMaster.Text = "Expense Master";
            this.SubBtnExpenseMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnExpenseMaster.UseVisualStyleBackColor = true;
            this.SubBtnExpenseMaster.Click += new System.EventHandler(this.SubBtnExpenseMaster_Click);
            // 
            // SubBtnIncomeMaster
            // 
            this.SubBtnIncomeMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnIncomeMaster.FlatAppearance.BorderSize = 0;
            this.SubBtnIncomeMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnIncomeMaster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnIncomeMaster.ForeColor = System.Drawing.Color.LightGray;
            this.SubBtnIncomeMaster.Location = new System.Drawing.Point(0, 90);
            this.SubBtnIncomeMaster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubBtnIncomeMaster.Name = "SubBtnIncomeMaster";
            this.SubBtnIncomeMaster.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.SubBtnIncomeMaster.Size = new System.Drawing.Size(202, 45);
            this.SubBtnIncomeMaster.TabIndex = 2;
            this.SubBtnIncomeMaster.Text = "Income Master";
            this.SubBtnIncomeMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnIncomeMaster.UseVisualStyleBackColor = true;
            this.SubBtnIncomeMaster.Click += new System.EventHandler(this.btnIncomeMaster_Click);
            // 
            // btnSourceMaster
            // 
            this.btnSourceMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSourceMaster.FlatAppearance.BorderSize = 0;
            this.btnSourceMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceMaster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceMaster.ForeColor = System.Drawing.Color.LightGray;
            this.btnSourceMaster.Location = new System.Drawing.Point(0, 45);
            this.btnSourceMaster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSourceMaster.Name = "btnSourceMaster";
            this.btnSourceMaster.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnSourceMaster.Size = new System.Drawing.Size(202, 45);
            this.btnSourceMaster.TabIndex = 1;
            this.btnSourceMaster.Text = "Source Master";
            this.btnSourceMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSourceMaster.UseVisualStyleBackColor = true;
            this.btnSourceMaster.Click += new System.EventHandler(this.button3_Click);
            // 
            // SubBtnPartyMaster
            // 
            this.SubBtnPartyMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnPartyMaster.FlatAppearance.BorderSize = 0;
            this.SubBtnPartyMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnPartyMaster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnPartyMaster.ForeColor = System.Drawing.Color.LightGray;
            this.SubBtnPartyMaster.Location = new System.Drawing.Point(0, 0);
            this.SubBtnPartyMaster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubBtnPartyMaster.Name = "SubBtnPartyMaster";
            this.SubBtnPartyMaster.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.SubBtnPartyMaster.Size = new System.Drawing.Size(202, 45);
            this.SubBtnPartyMaster.TabIndex = 0;
            this.SubBtnPartyMaster.Text = "Party Master";
            this.SubBtnPartyMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnPartyMaster.UseVisualStyleBackColor = true;
            this.SubBtnPartyMaster.Click += new System.EventHandler(this.subbtnpartymaster_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.Color.LightGray;
            this.btnmenu.Location = new System.Drawing.Point(0, 91);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnmenu.Size = new System.Drawing.Size(204, 54);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Menu";
            this.btnmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panellogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(204, 91);
            this.panellogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(206, 680);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 53);
            this.panel1.TabIndex = 4;
            // 
            // panelchildform
            // 
            this.panelchildform.AutoScroll = true;
            this.panelchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelchildform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildform.Location = new System.Drawing.Point(206, 28);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(932, 652);
            this.panelchildform.TabIndex = 5;
            // 
            // SubBtnDebitOrCreditQuery
            // 
            this.SubBtnDebitOrCreditQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnDebitOrCreditQuery.FlatAppearance.BorderSize = 0;
            this.SubBtnDebitOrCreditQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnDebitOrCreditQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnDebitOrCreditQuery.ForeColor = System.Drawing.Color.LightGray;
            this.SubBtnDebitOrCreditQuery.Location = new System.Drawing.Point(0, 135);
            this.SubBtnDebitOrCreditQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubBtnDebitOrCreditQuery.Name = "SubBtnDebitOrCreditQuery";
            this.SubBtnDebitOrCreditQuery.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.SubBtnDebitOrCreditQuery.Size = new System.Drawing.Size(202, 45);
            this.SubBtnDebitOrCreditQuery.TabIndex = 5;
            this.SubBtnDebitOrCreditQuery.Text = "Debit Credit Query";
            this.SubBtnDebitOrCreditQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnDebitOrCreditQuery.UseVisualStyleBackColor = true;
            this.SubBtnDebitOrCreditQuery.Click += new System.EventHandler(this.SubBtnDebitOrCreditQuery_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 733);
            this.Controls.Add(this.panelchildform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sidebarpanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Sidebarpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MenuSubpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyMasterToolStripMenuItem;
        private System.Windows.Forms.Panel Sidebarpanel;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel MenuSubpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPartyQuery;
        private System.Windows.Forms.Button btnExpenseQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SubBtnPartyMaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelchildform;
        private System.Windows.Forms.Button SubBtnIncomeMaster;
        private System.Windows.Forms.Button btnSourceMaster;
        private System.Windows.Forms.Button SubBtnExpenseMaster;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyQueryToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SubBtnDebitOrCreditQuery;

    }
}



