namespace FinalProject
{
    partial class FrmProductMasterAndDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.listCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryDetails = new FinalProject.FinalProjectDataSets.ListCategoryDetails();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.listSubCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSListSubCategoryDetails = new FinalProject.FinalProjectDataSets.DSListSubCategoryDetails();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtSalesRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCGSTRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSGSTRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIGSTRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBasicRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtCGSTAmount = new System.Windows.Forms.TextBox();
            this.txtSGSTAmount = new System.Windows.Forms.TextBox();
            this.txtIGSTAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subCategoryDetails = new FinalProject.FinalProjectDataSets.SubCategoryDetails();
            this.listCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter();
            this.listSubCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.DSListSubCategoryDetailsTableAdapters.ListSubCategoryDetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListSubCategoryDetails)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.50812F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.49188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 651F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 65);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(813, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(91, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(842, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(1270, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sub-Category :";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(260, 14);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(330, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxCategory.DataSource = this.listCategoryDetailsBindingSource;
            this.comboBoxCategory.DisplayMember = "CATEGORYNAME";
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(959, 10);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(186, 30);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.ValueMember = "CATEGORYID";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // listCategoryDetailsBindingSource
            // 
            this.listCategoryDetailsBindingSource.DataMember = "ListCategoryDetails";
            this.listCategoryDetailsBindingSource.DataSource = this.listCategoryDetails;
            // 
            // listCategoryDetails
            // 
            this.listCategoryDetails.DataSetName = "ListCategoryDetails";
            this.listCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxSubCategory.DataSource = this.listSubCategoryDetailsBindingSource;
            this.comboBoxSubCategory.DisplayMember = "SUBCATEGORYNAME";
            this.comboBoxSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(1430, 10);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(190, 30);
            this.comboBoxSubCategory.TabIndex = 7;
            this.comboBoxSubCategory.ValueMember = "SUBCATEGORYID";
            // 
            // listSubCategoryDetailsBindingSource
            // 
            this.listSubCategoryDetailsBindingSource.DataMember = "ListSubCategoryDetails";
            this.listSubCategoryDetailsBindingSource.DataSource = this.dSListSubCategoryDetails;
            // 
            // dSListSubCategoryDetails
            // 
            this.dSListSubCategoryDetails.DataSetName = "DSListSubCategoryDetails";
            this.dSListSubCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(181, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "QTY :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(409, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unit :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(792, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Purchase Rate :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(1303, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sales Rate :";
            // 
            // txtQTY
            // 
            this.txtQTY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQTY.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQTY.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTY.Location = new System.Drawing.Point(262, 9);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(78, 22);
            this.txtQTY.TabIndex = 6;
            this.txtQTY.Text = "1";
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUnit.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "--Select Unit --",
            "Kg",
            "mg",
            "L",
            "ml"});
            this.comboBoxUnit.Location = new System.Drawing.Point(478, 5);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(137, 30);
            this.comboBoxUnit.TabIndex = 7;
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchaseRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchaseRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseRate.Location = new System.Drawing.Point(961, 9);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(118, 22);
            this.txtPurchaseRate.TabIndex = 6;
            this.txtPurchaseRate.Text = "0";
            // 
            // txtSalesRate
            // 
            this.txtSalesRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalesRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSalesRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalesRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesRate.Location = new System.Drawing.Point(1433, 9);
            this.txtSalesRate.Name = "txtSalesRate";
            this.txtSalesRate.Size = new System.Drawing.Size(119, 22);
            this.txtSalesRate.TabIndex = 6;
            this.txtSalesRate.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(169, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "CGST :";
            // 
            // txtCGSTRate
            // 
            this.txtCGSTRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCGSTRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCGSTRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCGSTRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTRate.Location = new System.Drawing.Point(258, 13);
            this.txtCGSTRate.Name = "txtCGSTRate";
            this.txtCGSTRate.Size = new System.Drawing.Size(57, 22);
            this.txtCGSTRate.TabIndex = 6;
            this.txtCGSTRate.Text = "0";
            this.txtCGSTRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCGSTRate_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(876, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "SGST :";
            // 
            // txtSGSTRate
            // 
            this.txtSGSTRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSGSTRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSGSTRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSGSTRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTRate.Location = new System.Drawing.Point(961, 13);
            this.txtSGSTRate.Name = "txtSGSTRate";
            this.txtSGSTRate.Size = new System.Drawing.Size(52, 22);
            this.txtSGSTRate.TabIndex = 6;
            this.txtSGSTRate.Text = "0";
            this.txtSGSTRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSGSTRate_KeyDown_1);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(1355, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "IGST :";
            // 
            // txtIGSTRate
            // 
            this.txtIGSTRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIGSTRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIGSTRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIGSTRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGSTRate.Location = new System.Drawing.Point(1435, 13);
            this.txtIGSTRate.Name = "txtIGSTRate";
            this.txtIGSTRate.Size = new System.Drawing.Size(52, 22);
            this.txtIGSTRate.TabIndex = 6;
            this.txtIGSTRate.Text = "0";
            this.txtIGSTRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIGSTRate_KeyDown);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(127, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Basic Rate :";
            // 
            // txtBasicRate
            // 
            this.txtBasicRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBasicRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBasicRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBasicRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicRate.Location = new System.Drawing.Point(260, 11);
            this.txtBasicRate.Name = "txtBasicRate";
            this.txtBasicRate.Size = new System.Drawing.Size(100, 22);
            this.txtBasicRate.TabIndex = 6;
            this.txtBasicRate.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(885, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "MRP :";
            // 
            // txtMRP
            // 
            this.txtMRP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMRP.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMRP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(985, 11);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(110, 22);
            this.txtMRP.TabIndex = 6;
            this.txtMRP.Text = "0";
            // 
            // txtCGSTAmount
            // 
            this.txtCGSTAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCGSTAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCGSTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCGSTAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTAmount.Location = new System.Drawing.Point(331, 13);
            this.txtCGSTAmount.Name = "txtCGSTAmount";
            this.txtCGSTAmount.Size = new System.Drawing.Size(89, 22);
            this.txtCGSTAmount.TabIndex = 6;
            this.txtCGSTAmount.Text = "0";
            // 
            // txtSGSTAmount
            // 
            this.txtSGSTAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSGSTAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSGSTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSGSTAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTAmount.Location = new System.Drawing.Point(1027, 13);
            this.txtSGSTAmount.Name = "txtSGSTAmount";
            this.txtSGSTAmount.Size = new System.Drawing.Size(82, 22);
            this.txtSGSTAmount.TabIndex = 6;
            this.txtSGSTAmount.Text = "0";
            this.txtSGSTAmount.TextChanged += new System.EventHandler(this.txtSGSTAmount_TextChanged);
            // 
            // txtIGSTAmount
            // 
            this.txtIGSTAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIGSTAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIGSTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIGSTAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGSTAmount.Location = new System.Drawing.Point(1502, 13);
            this.txtIGSTAmount.Name = "txtIGSTAmount";
            this.txtIGSTAmount.Size = new System.Drawing.Size(88, 22);
            this.txtIGSTAmount.TabIndex = 6;
            this.txtIGSTAmount.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1309, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(1463, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSubCategory, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCategory, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtProductName, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1904, 51);
            this.tableLayoutPanel2.TabIndex = 9;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 13;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtQTY, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxUnit, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSalesRate, 11, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPurchaseRate, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 10, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 116);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1904, 41);
            this.tableLayoutPanel3.TabIndex = 10;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 13;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCGSTRate, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCGSTAmount, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSGSTRate, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSGSTAmount, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 9, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtIGSTAmount, 11, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtIGSTRate, 10, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 157);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1904, 49);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 11;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtBasicRate, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtMRP, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnClear, 9, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAdd, 7, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 206);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1904, 45);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 906);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1904, 75);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(421, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(897, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1373, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 901);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 5);
            this.panel1.TabIndex = 15;
            // 
            // subCategoryDetails
            // 
            this.subCategoryDetails.DataSetName = "SubCategoryDetails";
            this.subCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listCategoryDetailsTableAdapter
            // 
            this.listCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // listSubCategoryDetailsTableAdapter
            // 
            this.listSubCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.Qty,
            this.Unit,
            this.PurchaseRate,
            this.SalesRate,
            this.CGSTPercentage,
            this.CGSTAmount,
            this.SGSTPercentage,
            this.SGSTAmount,
            this.IGSTPercentage,
            this.IGSTAmount,
            this.BasicRate,
            this.MRP});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1904, 650);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ColProductID
            // 
            this.ColProductID.HeaderText = "PRODUCTID";
            this.ColProductID.Name = "ColProductID";
            this.ColProductID.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "QTY";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "UNIT";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // PurchaseRate
            // 
            this.PurchaseRate.HeaderText = "PURCHASERATE";
            this.PurchaseRate.Name = "PurchaseRate";
            this.PurchaseRate.ReadOnly = true;
            // 
            // SalesRate
            // 
            this.SalesRate.HeaderText = "SALESRATE";
            this.SalesRate.Name = "SalesRate";
            this.SalesRate.ReadOnly = true;
            // 
            // CGSTPercentage
            // 
            this.CGSTPercentage.HeaderText = "CGSTPERCENTAGE";
            this.CGSTPercentage.Name = "CGSTPercentage";
            this.CGSTPercentage.ReadOnly = true;
            // 
            // CGSTAmount
            // 
            this.CGSTAmount.HeaderText = "CGSTAMOUNT";
            this.CGSTAmount.Name = "CGSTAmount";
            this.CGSTAmount.ReadOnly = true;
            // 
            // SGSTPercentage
            // 
            this.SGSTPercentage.HeaderText = "SGSTPERCENTAGE";
            this.SGSTPercentage.Name = "SGSTPercentage";
            this.SGSTPercentage.ReadOnly = true;
            // 
            // SGSTAmount
            // 
            this.SGSTAmount.HeaderText = "SGSTAMOUNT";
            this.SGSTAmount.Name = "SGSTAmount";
            this.SGSTAmount.ReadOnly = true;
            // 
            // IGSTPercentage
            // 
            this.IGSTPercentage.HeaderText = "IGSTPERCENTAGE";
            this.IGSTPercentage.Name = "IGSTPercentage";
            this.IGSTPercentage.ReadOnly = true;
            // 
            // IGSTAmount
            // 
            this.IGSTAmount.HeaderText = "IGSTAMOUNT";
            this.IGSTAmount.Name = "IGSTAmount";
            this.IGSTAmount.ReadOnly = true;
            // 
            // BasicRate
            // 
            this.BasicRate.HeaderText = "BASICRATE";
            this.BasicRate.Name = "BasicRate";
            this.BasicRate.ReadOnly = true;
            // 
            // MRP
            // 
            this.MRP.HeaderText = "MRP";
            this.MRP.Name = "MRP";
            this.MRP.ReadOnly = true;
            // 
            // FrmProductMasterAndDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 981);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmProductMasterAndDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductMasterAndDetails";
            this.Load += new System.EventHandler(this.FrmProductMasterAndDetails_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListSubCategoryDetails)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.TextBox txtSalesRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCGSTRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSGSTRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIGSTRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBasicRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox txtCGSTAmount;
        private System.Windows.Forms.TextBox txtSGSTAmount;
        private System.Windows.Forms.TextBox txtIGSTAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private FinalProjectDataSets.SubCategoryDetails subCategoryDetails;
        private FinalProjectDataSets.ListCategoryDetails listCategoryDetails;
        private System.Windows.Forms.BindingSource listCategoryDetailsBindingSource;
        private FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter listCategoryDetailsTableAdapter;
        private System.Windows.Forms.BindingSource listSubCategoryDetailsBindingSource;
        private FinalProjectDataSets.DSListSubCategoryDetails dSListSubCategoryDetails;
        private FinalProjectDataSets.DSListSubCategoryDetailsTableAdapters.ListSubCategoryDetailsTableAdapter listSubCategoryDetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
    }
}