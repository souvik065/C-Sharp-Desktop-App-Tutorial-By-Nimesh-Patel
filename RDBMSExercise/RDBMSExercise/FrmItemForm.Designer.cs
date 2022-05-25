namespace RDBMSExercise
{
    partial class FrmItemForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtTotalAmountOfProduct = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtActualPrice = new System.Windows.Forms.TextBox();
            this.comboBoxORDID = new System.Windows.Forms.ComboBox();
            this.comboBoxPRODID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 500);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtTotalAmountOfProduct);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtActualPrice);
            this.panel1.Controls.Add(this.comboBoxORDID);
            this.panel1.Controls.Add(this.comboBoxPRODID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 204);
            this.panel1.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(623, 91);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 13;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(367, 159);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 7;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(262, 159);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(162, 159);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(56, 159);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 10;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtTotalAmountOfProduct
            // 
            this.txtTotalAmountOfProduct.Location = new System.Drawing.Point(498, 93);
            this.txtTotalAmountOfProduct.Name = "txtTotalAmountOfProduct";
            this.txtTotalAmountOfProduct.Size = new System.Drawing.Size(119, 20);
            this.txtTotalAmountOfProduct.TabIndex = 6;
            this.txtTotalAmountOfProduct.TextChanged += new System.EventHandler(this.txtTotalAmountOfProduct_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(85, 96);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(119, 20);
            this.txtQty.TabIndex = 6;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // txtActualPrice
            // 
            this.txtActualPrice.Location = new System.Drawing.Point(728, 27);
            this.txtActualPrice.Name = "txtActualPrice";
            this.txtActualPrice.Size = new System.Drawing.Size(119, 20);
            this.txtActualPrice.TabIndex = 6;
            // 
            // comboBoxORDID
            // 
            this.comboBoxORDID.FormattingEnabled = true;
            this.comboBoxORDID.Location = new System.Drawing.Point(85, 24);
            this.comboBoxORDID.Name = "comboBoxORDID";
            this.comboBoxORDID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxORDID.TabIndex = 4;
            // 
            // comboBoxPRODID
            // 
            this.comboBoxPRODID.FormattingEnabled = true;
            this.comboBoxPRODID.Location = new System.Drawing.Point(387, 24);
            this.comboBoxPRODID.Name = "comboBoxPRODID";
            this.comboBoxPRODID.Size = new System.Drawing.Size(167, 21);
            this.comboBoxPRODID.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ACTUALPRICE :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TOTAL AMOUNT OF PRODUCT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "QTY :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "PRODID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ORDID :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click_1);
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
            // FrmItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 785);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmItemForm";
            this.Text = "FrmItemForm";
            this.Load += new System.EventHandler(this.FrmItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtActualPrice;
        private System.Windows.Forms.ComboBox comboBoxPRODID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxORDID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalAmountOfProduct;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.Button btnCal;
    }
}