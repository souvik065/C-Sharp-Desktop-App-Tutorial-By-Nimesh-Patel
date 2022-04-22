namespace restaurantmenu
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
            this.components = new System.ComponentModel.Container();
            this.category = new System.Windows.Forms.ListBox();
            this.dishes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelcategory = new System.Windows.Forms.Label();
            this.labeldishname = new System.Windows.Forms.Label();
            this.labelrate = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderlist = new System.Windows.Forms.ListBox();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ftotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gst = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.finalamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(25, 35);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(188, 342);
            this.category.TabIndex = 0;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // dishes
            // 
            this.dishes.FormattingEnabled = true;
            this.dishes.Location = new System.Drawing.Point(261, 35);
            this.dishes.Name = "dishes";
            this.dishes.Size = new System.Drawing.Size(133, 69);
            this.dishes.TabIndex = 0;
            this.dishes.SelectedIndexChanged += new System.EventHandler(this.dishes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dish Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category : ";
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Location = new System.Drawing.Point(331, 118);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(39, 13);
            this.labelcategory.TabIndex = 1;
            this.labelcategory.Text = "Rate : ";
            // 
            // labeldishname
            // 
            this.labeldishname.AutoSize = true;
            this.labeldishname.Location = new System.Drawing.Point(331, 151);
            this.labeldishname.Name = "labeldishname";
            this.labeldishname.Size = new System.Drawing.Size(39, 13);
            this.labeldishname.TabIndex = 1;
            this.labeldishname.Text = "Rate : ";
            // 
            // labelrate
            // 
            this.labelrate.AutoSize = true;
            this.labelrate.Location = new System.Drawing.Point(331, 187);
            this.labelrate.Name = "labelrate";
            this.labelrate.Size = new System.Drawing.Size(39, 13);
            this.labelrate.TabIndex = 1;
            this.labelrate.Text = "Rate : ";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(114, 384);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // orderlist
            // 
            this.orderlist.FormattingEnabled = true;
            this.orderlist.Location = new System.Drawing.Point(461, 35);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(128, 342);
            this.orderlist.TabIndex = 4;
            this.orderlist.SelectedIndexChanged += new System.EventHandler(this.orderlist_SelectedIndexChanged);
            // 
            // totalamount
            // 
            this.totalamount.Location = new System.Drawing.Point(540, 384);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(49, 20);
            this.totalamount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Amount :";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(33, 384);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 7;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(114, 414);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total :";
            // 
            // ftotal
            // 
            this.ftotal.AutoSize = true;
            this.ftotal.Location = new System.Drawing.Point(701, 35);
            this.ftotal.Name = "ftotal";
            this.ftotal.Size = new System.Drawing.Size(35, 13);
            this.ftotal.TabIndex = 9;
            this.ftotal.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "GST 18% : ";
            // 
            // gst
            // 
            this.gst.AutoSize = true;
            this.gst.Location = new System.Drawing.Point(701, 69);
            this.gst.Name = "gst";
            this.gst.Size = new System.Drawing.Size(35, 13);
            this.gst.TabIndex = 9;
            this.gst.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Final Amount : ";
            // 
            // finalamount
            // 
            this.finalamount.AutoSize = true;
            this.finalamount.Location = new System.Drawing.Point(701, 107);
            this.finalamount.Name = "finalamount";
            this.finalamount.Size = new System.Drawing.Size(35, 13);
            this.finalamount.TabIndex = 9;
            this.finalamount.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 737);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox category;
        private System.Windows.Forms.ListBox dishes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Label labeldishname;
        private System.Windows.Forms.Label labelrate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox orderlist;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ftotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label finalamount;
    }
}

