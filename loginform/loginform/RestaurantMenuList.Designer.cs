namespace loginform
{
    partial class RestaurantMenuList
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
            this.components = new System.ComponentModel.Container();
            this.finalamount = new System.Windows.Forms.Label();
            this.gst = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ftotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.orderlist = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.labelrate = new System.Windows.Forms.Label();
            this.labeldishname = new System.Windows.Forms.Label();
            this.labelcategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dishes = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.category = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finalamount
            // 
            this.finalamount.AutoSize = true;
            this.finalamount.Location = new System.Drawing.Point(708, 172);
            this.finalamount.Name = "finalamount";
            this.finalamount.Size = new System.Drawing.Size(35, 13);
            this.finalamount.TabIndex = 29;
            this.finalamount.Text = "label5";
            // 
            // gst
            // 
            this.gst.AutoSize = true;
            this.gst.Location = new System.Drawing.Point(708, 134);
            this.gst.Name = "gst";
            this.gst.Size = new System.Drawing.Size(35, 13);
            this.gst.TabIndex = 28;
            this.gst.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Final Amount : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "GST 18% : ";
            // 
            // ftotal
            // 
            this.ftotal.AutoSize = true;
            this.ftotal.Location = new System.Drawing.Point(708, 100);
            this.ftotal.Name = "ftotal";
            this.ftotal.Size = new System.Drawing.Size(35, 13);
            this.ftotal.TabIndex = 25;
            this.ftotal.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total :";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(121, 479);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 23;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click_1);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(40, 449);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 22;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Amount :";
            // 
            // totalamount
            // 
            this.totalamount.Location = new System.Drawing.Point(547, 449);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(49, 20);
            this.totalamount.TabIndex = 20;
            // 
            // orderlist
            // 
            this.orderlist.FormattingEnabled = true;
            this.orderlist.Location = new System.Drawing.Point(468, 100);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(128, 342);
            this.orderlist.TabIndex = 19;
            this.orderlist.SelectedIndexChanged += new System.EventHandler(this.orderlist_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(121, 449);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // labelrate
            // 
            this.labelrate.AutoSize = true;
            this.labelrate.Location = new System.Drawing.Point(338, 252);
            this.labelrate.Name = "labelrate";
            this.labelrate.Size = new System.Drawing.Size(39, 13);
            this.labelrate.TabIndex = 17;
            this.labelrate.Text = "Rate : ";
            // 
            // labeldishname
            // 
            this.labeldishname.AutoSize = true;
            this.labeldishname.Location = new System.Drawing.Point(338, 216);
            this.labeldishname.Name = "labeldishname";
            this.labeldishname.Size = new System.Drawing.Size(39, 13);
            this.labeldishname.TabIndex = 16;
            this.labeldishname.Text = "Rate : ";
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Location = new System.Drawing.Point(338, 183);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(39, 13);
            this.labelcategory.TabIndex = 15;
            this.labelcategory.Text = "Rate : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rate : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dish Name : ";
            // 
            // dishes
            // 
            this.dishes.FormattingEnabled = true;
            this.dishes.Location = new System.Drawing.Point(268, 100);
            this.dishes.Name = "dishes";
            this.dishes.Size = new System.Drawing.Size(133, 69);
            this.dishes.TabIndex = 11;
            this.dishes.SelectedIndexChanged += new System.EventHandler(this.dishes_SelectedIndexChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(32, 100);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(188, 342);
            this.category.TabIndex = 10;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 30;
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
            this.simpleCalculationToolStripMenuItem.Click += new System.EventHandler(this.simpleCalculationToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
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
            this.restaurantToolStripMenuItem.Click += new System.EventHandler(this.restaurantToolStripMenuItem_Click);
            // 
            // RestaurantMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 713);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.finalamount);
            this.Controls.Add(this.gst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ftotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.labelrate);
            this.Controls.Add(this.labeldishname);
            this.Controls.Add(this.labelcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishes);
            this.Controls.Add(this.category);
            this.Name = "RestaurantMenuList";
            this.Text = "RestaurantMenuList";
            this.Load += new System.EventHandler(this.RestaurantMenuList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label finalamount;
        private System.Windows.Forms.Label gst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ftotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.ListBox orderlist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label labelrate;
        private System.Windows.Forms.Label labeldishname;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox dishes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox category;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
    }
}