namespace StoreProcedurePraticeSession
{
    partial class FrmEmpDetails
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMGR = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.empDataSet = new StoreProcedurePraticeSession.EmpDataSet();
            this.getEmpDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmpDetailsTableAdapter = new StoreProcedurePraticeSession.EmpDataSetTableAdapters.GetEmpDetailsTableAdapter();
            this.eMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.listAllDeptDetails = new StoreProcedurePraticeSession.ListAllDeptDetails();
            this.listAllDeptDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listAllDeptDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listAllDeptDetailsTableAdapter = new StoreProcedurePraticeSession.ListAllDeptDetailsTableAdapters.ListAllDeptDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmpDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDeptDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDeptDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDeptDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxDept);
            this.panel1.Controls.Add(this.richTextBoxAddress);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtMGR);
            this.panel1.Controls.Add(this.txtSal);
            this.panel1.Controls.Add(this.txtHireDate);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 267);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(374, 218);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 30);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(268, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(162, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(61, 219);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMGR
            // 
            this.txtMGR.Location = new System.Drawing.Point(162, 142);
            this.txtMGR.Name = "txtMGR";
            this.txtMGR.Size = new System.Drawing.Size(129, 20);
            this.txtMGR.TabIndex = 1;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(555, 143);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(129, 20);
            this.txtSal.TabIndex = 1;
            this.txtSal.TextChanged += new System.EventHandler(this.txtSal_TextChanged);
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(167, 91);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(124, 20);
            this.txtHireDate.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(167, 20);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(194, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Deptpartment :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "MGR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Salary :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hire Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPNODataGridViewTextBoxColumn,
            this.eNAMEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.hIREDATEDataGridViewTextBoxColumn,
            this.dEPTDataGridViewTextBoxColumn,
            this.mGRDataGridViewTextBoxColumn,
            this.sALDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getEmpDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 340);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(556, 9);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(137, 58);
            this.richTextBoxAddress.TabIndex = 8;
            this.richTextBoxAddress.Text = "";
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmpDetailsBindingSource
            // 
            this.getEmpDetailsBindingSource.DataMember = "GetEmpDetails";
            this.getEmpDetailsBindingSource.DataSource = this.empDataSet;
            // 
            // getEmpDetailsTableAdapter
            // 
            this.getEmpDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // eMPNODataGridViewTextBoxColumn
            // 
            this.eMPNODataGridViewTextBoxColumn.DataPropertyName = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.HeaderText = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.Name = "eMPNODataGridViewTextBoxColumn";
            this.eMPNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNAMEDataGridViewTextBoxColumn
            // 
            this.eNAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.HeaderText = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.Name = "eNAMEDataGridViewTextBoxColumn";
            this.eNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hIREDATEDataGridViewTextBoxColumn
            // 
            this.hIREDATEDataGridViewTextBoxColumn.DataPropertyName = "HIREDATE";
            this.hIREDATEDataGridViewTextBoxColumn.HeaderText = "HIREDATE";
            this.hIREDATEDataGridViewTextBoxColumn.Name = "hIREDATEDataGridViewTextBoxColumn";
            this.hIREDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEPTDataGridViewTextBoxColumn
            // 
            this.dEPTDataGridViewTextBoxColumn.DataPropertyName = "DEPT";
            this.dEPTDataGridViewTextBoxColumn.HeaderText = "DEPT";
            this.dEPTDataGridViewTextBoxColumn.Name = "dEPTDataGridViewTextBoxColumn";
            this.dEPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mGRDataGridViewTextBoxColumn
            // 
            this.mGRDataGridViewTextBoxColumn.DataPropertyName = "MGR";
            this.mGRDataGridViewTextBoxColumn.HeaderText = "MGR";
            this.mGRDataGridViewTextBoxColumn.Name = "mGRDataGridViewTextBoxColumn";
            this.mGRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALDataGridViewTextBoxColumn
            // 
            this.sALDataGridViewTextBoxColumn.DataPropertyName = "SAL";
            this.sALDataGridViewTextBoxColumn.HeaderText = "SAL";
            this.sALDataGridViewTextBoxColumn.Name = "sALDataGridViewTextBoxColumn";
            this.sALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DataSource = this.listAllDeptDetailsBindingSource1;
            this.comboBoxDept.DisplayMember = "DeptName";
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(555, 87);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDept.TabIndex = 9;
            this.comboBoxDept.ValueMember = "DEPTNO";
            // 
            // listAllDeptDetails
            // 
            this.listAllDeptDetails.DataSetName = "ListAllDeptDetails";
            this.listAllDeptDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listAllDeptDetailsBindingSource
            // 
            this.listAllDeptDetailsBindingSource.DataSource = this.listAllDeptDetails;
            this.listAllDeptDetailsBindingSource.Position = 0;
            // 
            // listAllDeptDetailsBindingSource1
            // 
            this.listAllDeptDetailsBindingSource1.DataMember = "ListAllDeptDetails";
            this.listAllDeptDetailsBindingSource1.DataSource = this.listAllDeptDetailsBindingSource;
            // 
            // listAllDeptDetailsTableAdapter
            // 
            this.listAllDeptDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpDetails";
            this.Text = "FrmEmpDetails";
            this.Load += new System.EventHandler(this.FrmEmpDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmpDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDeptDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDeptDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDeptDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMGR;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource getEmpDetailsBindingSource;
        private EmpDataSetTableAdapters.GetEmpDetailsTableAdapter getEmpDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.BindingSource listAllDeptDetailsBindingSource;
        private ListAllDeptDetails listAllDeptDetails;
        private System.Windows.Forms.BindingSource listAllDeptDetailsBindingSource1;
        private ListAllDeptDetailsTableAdapters.ListAllDeptDetailsTableAdapter listAllDeptDetailsTableAdapter;
    }
}