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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 808);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnProducts);
            this.panel3.Controls.Add(this.btnSubCategory);
            this.panel3.Controls.Add(this.btnCategory);
            this.panel3.Location = new System.Drawing.Point(0, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 196);
            this.panel3.TabIndex = 9;
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
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
            this.btnSubCategory.FlatAppearance.BorderSize = 0;
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
            this.btnCategory.FlatAppearance.BorderSize = 0;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Masters";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 808);
            this.panel4.TabIndex = 8;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 808);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel4;
    }
}



