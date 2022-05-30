namespace SPPracticeSession2
{
    partial class FrmSubCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sUBCATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBCATEGORYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSubCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoryMaster = new SPPracticeSession2.SubCategoryMaster();
            this.listCategoryNames = new SPPracticeSession2.ListCategoryNames();
            this.listCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryDetailsTableAdapter = new SPPracticeSession2.ListCategoryNamesTableAdapters.ListCategoryDetailsTableAdapter();
            this.getSubCategoryDetailsTableAdapter = new SPPracticeSession2.SubCategoryMasterTableAdapters.GetSubCategoryDetailsTableAdapter();
            this.listCategoryNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSubCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "SubCategory Master";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSubCategory);
            this.panel1.Controls.Add(this.comboBoxCategoryName);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 99);
            this.panel1.TabIndex = 2;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(479, 16);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(136, 20);
            this.txtSubCategory.TabIndex = 3;
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.DataSource = this.listCategoryDetailsBindingSource1;
            this.comboBoxCategoryName.DisplayMember = "CATEGORYNAME";
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(157, 15);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoryName.TabIndex = 2;
            this.comboBoxCategoryName.ValueMember = "CATEGORYID";
            this.comboBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryName_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(373, 64);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 30);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(267, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(161, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(55, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SubCategory Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUBCATEGORYIDDataGridViewTextBoxColumn,
            this.cATEGORYIDDataGridViewTextBoxColumn,
            this.sUBCATEGORYNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getSubCategoryDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(631, 511);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // sUBCATEGORYIDDataGridViewTextBoxColumn
            // 
            this.sUBCATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "SUBCATEGORYID";
            this.sUBCATEGORYIDDataGridViewTextBoxColumn.HeaderText = "SUBCATEGORYID";
            this.sUBCATEGORYIDDataGridViewTextBoxColumn.Name = "sUBCATEGORYIDDataGridViewTextBoxColumn";
            this.sUBCATEGORYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORYIDDataGridViewTextBoxColumn
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "CATEGORYID";
            this.cATEGORYIDDataGridViewTextBoxColumn.HeaderText = "CATEGORYID";
            this.cATEGORYIDDataGridViewTextBoxColumn.Name = "cATEGORYIDDataGridViewTextBoxColumn";
            this.cATEGORYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUBCATEGORYNAMEDataGridViewTextBoxColumn
            // 
            this.sUBCATEGORYNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUBCATEGORYNAME";
            this.sUBCATEGORYNAMEDataGridViewTextBoxColumn.HeaderText = "SUBCATEGORYNAME";
            this.sUBCATEGORYNAMEDataGridViewTextBoxColumn.Name = "sUBCATEGORYNAMEDataGridViewTextBoxColumn";
            this.sUBCATEGORYNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getSubCategoryDetailsBindingSource
            // 
            this.getSubCategoryDetailsBindingSource.DataMember = "GetSubCategoryDetails";
            this.getSubCategoryDetailsBindingSource.DataSource = this.subCategoryMaster;
            // 
            // subCategoryMaster
            // 
            this.subCategoryMaster.DataSetName = "SubCategoryMaster";
            this.subCategoryMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listCategoryNames
            // 
            this.listCategoryNames.DataSetName = "ListCategoryNames";
            this.listCategoryNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listCategoryDetailsBindingSource
            // 
            this.listCategoryDetailsBindingSource.DataMember = "ListCategoryDetails";
            this.listCategoryDetailsBindingSource.DataSource = this.listCategoryNames;
            // 
            // listCategoryDetailsTableAdapter
            // 
            this.listCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // getSubCategoryDetailsTableAdapter
            // 
            this.getSubCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // listCategoryNamesBindingSource
            // 
            this.listCategoryNamesBindingSource.DataSource = this.listCategoryNames;
            this.listCategoryNamesBindingSource.Position = 0;
            // 
            // listCategoryDetailsBindingSource1
            // 
            this.listCategoryDetailsBindingSource1.DataMember = "ListCategoryDetails";
            this.listCategoryDetailsBindingSource1.DataSource = this.listCategoryNamesBindingSource;
            // 
            // FrmSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 704);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSubCategory";
            this.Text = "FrmSubCategory";
            this.Load += new System.EventHandler(this.FrmSubCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSubCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubCategory;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ListCategoryNames listCategoryNames;
        private System.Windows.Forms.BindingSource listCategoryDetailsBindingSource;
        private ListCategoryNamesTableAdapters.ListCategoryDetailsTableAdapter listCategoryDetailsTableAdapter;
        private SubCategoryMaster subCategoryMaster;
        private System.Windows.Forms.BindingSource getSubCategoryDetailsBindingSource;
        private SubCategoryMasterTableAdapters.GetSubCategoryDetailsTableAdapter getSubCategoryDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBCATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBCATEGORYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listCategoryDetailsBindingSource1;
        private System.Windows.Forms.BindingSource listCategoryNamesBindingSource;
    }
}