namespace FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MastersSubPanel = new System.Windows.Forms.Panel();
            this.btnSalesReturn = new System.Windows.Forms.Button();
            this.btnSalesMaster = new System.Windows.Forms.Button();
            this.btnPurchasereturn = new System.Windows.Forms.Button();
            this.btnPurchaseMaster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bodypanel = new System.Windows.Forms.Panel();
            this.btnCategoryRPT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MastersSubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MastersSubPanel);
            this.panel1.Controls.Add(this.btnMaster);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 808);
            this.panel1.TabIndex = 6;
            // 
            // MastersSubPanel
            // 
            this.MastersSubPanel.BackColor = System.Drawing.Color.White;
            this.MastersSubPanel.Controls.Add(this.btnCategoryRPT);
            this.MastersSubPanel.Controls.Add(this.btnSalesReturn);
            this.MastersSubPanel.Controls.Add(this.btnSalesMaster);
            this.MastersSubPanel.Controls.Add(this.btnPurchasereturn);
            this.MastersSubPanel.Controls.Add(this.btnPurchaseMaster);
            this.MastersSubPanel.Controls.Add(this.button1);
            this.MastersSubPanel.Controls.Add(this.btnProducts);
            this.MastersSubPanel.Controls.Add(this.btnSubCategory);
            this.MastersSubPanel.Controls.Add(this.btnCategory);
            this.MastersSubPanel.Location = new System.Drawing.Point(0, 143);
            this.MastersSubPanel.Name = "MastersSubPanel";
            this.MastersSubPanel.Size = new System.Drawing.Size(200, 451);
            this.MastersSubPanel.TabIndex = 9;
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSalesReturn.Location = new System.Drawing.Point(-1, 350);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Size = new System.Drawing.Size(200, 44);
            this.btnSalesReturn.TabIndex = 1;
            this.btnSalesReturn.Text = "Sales Return";
            this.btnSalesReturn.UseVisualStyleBackColor = true;
            this.btnSalesReturn.Click += new System.EventHandler(this.btnSalesReturn_Click);
            // 
            // btnSalesMaster
            // 
            this.btnSalesMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesMaster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSalesMaster.Location = new System.Drawing.Point(-1, 300);
            this.btnSalesMaster.Name = "btnSalesMaster";
            this.btnSalesMaster.Size = new System.Drawing.Size(200, 44);
            this.btnSalesMaster.TabIndex = 1;
            this.btnSalesMaster.Text = "Sales Master";
            this.btnSalesMaster.UseVisualStyleBackColor = true;
            this.btnSalesMaster.Click += new System.EventHandler(this.btnSalesMaster_Click);
            // 
            // btnPurchasereturn
            // 
            this.btnPurchasereturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasereturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasereturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPurchasereturn.Location = new System.Drawing.Point(-1, 250);
            this.btnPurchasereturn.Name = "btnPurchasereturn";
            this.btnPurchasereturn.Size = new System.Drawing.Size(200, 44);
            this.btnPurchasereturn.TabIndex = 1;
            this.btnPurchasereturn.Text = "Purchase Return";
            this.btnPurchasereturn.UseVisualStyleBackColor = true;
            this.btnPurchasereturn.Click += new System.EventHandler(this.btnPurchasereturn_Click);
            // 
            // btnPurchaseMaster
            // 
            this.btnPurchaseMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseMaster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPurchaseMaster.Location = new System.Drawing.Point(0, 200);
            this.btnPurchaseMaster.Name = "btnPurchaseMaster";
            this.btnPurchaseMaster.Size = new System.Drawing.Size(200, 44);
            this.btnPurchaseMaster.TabIndex = 1;
            this.btnPurchaseMaster.Text = "Purchase Master";
            this.btnPurchaseMaster.UseVisualStyleBackColor = true;
            this.btnPurchaseMaster.Click += new System.EventHandler(this.btnPurchaseMaster_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(0, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Supplier Master";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnProducts.Location = new System.Drawing.Point(0, 100);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 44);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSubCategory.Location = new System.Drawing.Point(0, 50);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(200, 44);
            this.btnSubCategory.TabIndex = 0;
            this.btnSubCategory.Text = "Sub-Category";
            this.btnSubCategory.UseVisualStyleBackColor = true;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCategory_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCategory.Location = new System.Drawing.Point(0, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 44);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.BackColor = System.Drawing.Color.White;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnMaster.Image = ((System.Drawing.Image)(resources.GetObject("btnMaster.Image")));
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.Location = new System.Drawing.Point(0, 100);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(200, 43);
            this.btnMaster.TabIndex = 8;
            this.btnMaster.Text = "Masters";
            this.btnMaster.UseVisualStyleBackColor = false;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 100);
            this.panel2.TabIndex = 7;
            // 
            // Bodypanel
            // 
            this.Bodypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bodypanel.Location = new System.Drawing.Point(200, 0);
            this.Bodypanel.Name = "Bodypanel";
            this.Bodypanel.Size = new System.Drawing.Size(1070, 808);
            this.Bodypanel.TabIndex = 8;
            // 
            // btnCategoryRPT
            // 
            this.btnCategoryRPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryRPT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryRPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCategoryRPT.Location = new System.Drawing.Point(0, 400);
            this.btnCategoryRPT.Name = "btnCategoryRPT";
            this.btnCategoryRPT.Size = new System.Drawing.Size(200, 44);
            this.btnCategoryRPT.TabIndex = 1;
            this.btnCategoryRPT.Text = "Category RPT";
            this.btnCategoryRPT.UseVisualStyleBackColor = true;
            this.btnCategoryRPT.Click += new System.EventHandler(this.btnCategoryRPT_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 808);
            this.Controls.Add(this.Bodypanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.panel1.ResumeLayout(false);
            this.MastersSubPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MastersSubPanel;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel Bodypanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPurchaseMaster;
        private System.Windows.Forms.Button btnPurchasereturn;
        private System.Windows.Forms.Button btnSalesMaster;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Button btnCategoryRPT;
    }
}



