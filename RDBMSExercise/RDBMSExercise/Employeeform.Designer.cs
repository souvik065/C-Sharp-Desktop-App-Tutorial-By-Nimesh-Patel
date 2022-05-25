namespace RDBMSExercise
{
    partial class Employeeform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnview = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.comboBoxmgr = new System.Windows.Forms.ComboBox();
            this.dateTimePickerhiredate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxdeptno = new System.Windows.Forms.ComboBox();
            this.txtcomm = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtempno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.comboBoxmgr);
            this.panel1.Controls.Add(this.dateTimePickerhiredate);
            this.panel1.Controls.Add(this.comboBoxdeptno);
            this.panel1.Controls.Add(this.txtcomm);
            this.panel1.Controls.Add(this.txtsal);
            this.panel1.Controls.Add(this.txtjob);
            this.panel1.Controls.Add(this.txtename);
            this.panel1.Controls.Add(this.txtempno);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 136);
            this.panel1.TabIndex = 1;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(321, 106);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 6;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(216, 106);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(116, 106);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(10, 106);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // comboBoxmgr
            // 
            this.comboBoxmgr.FormattingEnabled = true;
            this.comboBoxmgr.Location = new System.Drawing.Point(622, 16);
            this.comboBoxmgr.Name = "comboBoxmgr";
            this.comboBoxmgr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxmgr.TabIndex = 5;
            this.comboBoxmgr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxmgr_MouseClick);
            // 
            // dateTimePickerhiredate
            // 
            this.dateTimePickerhiredate.Location = new System.Drawing.Point(658, 67);
            this.dateTimePickerhiredate.Name = "dateTimePickerhiredate";
            this.dateTimePickerhiredate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerhiredate.TabIndex = 4;
            // 
            // comboBoxdeptno
            // 
            this.comboBoxdeptno.FormattingEnabled = true;
            this.comboBoxdeptno.Items.AddRange(new object[] {
            "NULL"});
            this.comboBoxdeptno.Location = new System.Drawing.Point(449, 67);
            this.comboBoxdeptno.Name = "comboBoxdeptno";
            this.comboBoxdeptno.Size = new System.Drawing.Size(106, 21);
            this.comboBoxdeptno.TabIndex = 3;
            this.comboBoxdeptno.SelectedIndexChanged += new System.EventHandler(this.comboBoxdeptno_SelectedIndexChanged);
            // 
            // txtcomm
            // 
            this.txtcomm.Location = new System.Drawing.Point(229, 67);
            this.txtcomm.Name = "txtcomm";
            this.txtcomm.Size = new System.Drawing.Size(100, 20);
            this.txtcomm.TabIndex = 2;
            this.txtcomm.TextChanged += new System.EventHandler(this.txtcomm_TextChanged);
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(46, 67);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 2;
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(426, 16);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(100, 20);
            this.txtjob.TabIndex = 2;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(234, 13);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 2;
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(62, 13);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "DEPTNO :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "COMM :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "SAL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "HIREDATE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "MGR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "JOB :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMPNO :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 558);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productDetailsToolStripMenuItem,
            this.employeeDetailsToolStripMenuItem,
            this.departmentDetailsToolStripMenuItem,
            this.customerDetailsToolStripMenuItem,
            this.itemDetailsToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // productDetailsToolStripMenuItem
            // 
            this.productDetailsToolStripMenuItem.Name = "productDetailsToolStripMenuItem";
            this.productDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.productDetailsToolStripMenuItem.Text = "Product Details";
            this.productDetailsToolStripMenuItem.Click += new System.EventHandler(this.productDetailsToolStripMenuItem_Click);
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            // 
            // departmentDetailsToolStripMenuItem
            // 
            this.departmentDetailsToolStripMenuItem.Name = "departmentDetailsToolStripMenuItem";
            this.departmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.departmentDetailsToolStripMenuItem.Text = "Department Details";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            // 
            // itemDetailsToolStripMenuItem
            // 
            this.itemDetailsToolStripMenuItem.Name = "itemDetailsToolStripMenuItem";
            this.itemDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.itemDetailsToolStripMenuItem.Text = "Item Details";
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // Employeeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 785);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Employeeform";
            this.Text = "Employeeform";
            this.Load += new System.EventHandler(this.Employeeform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.ComboBox comboBoxmgr;
        private System.Windows.Forms.DateTimePicker dateTimePickerhiredate;
        private System.Windows.Forms.ComboBox comboBoxdeptno;
        private System.Windows.Forms.TextBox txtcomm;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
    }
}