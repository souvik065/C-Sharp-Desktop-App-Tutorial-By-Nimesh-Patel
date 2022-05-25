namespace storeprocceder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsEmpGet = new storeprocceder.dsEmpGet();
            this.empGetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empGetTableAdapter = new storeprocceder.dsEmpGetTableAdapters.EmpGetTableAdapter();
            this.eMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salary  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 1;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(142, 312);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(170, 20);
            this.txtSal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Department  :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(142, 97);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(323, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(142, 158);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(170, 20);
            this.txtDept.TabIndex = 2;
            this.txtDept.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(142, 362);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(142, 204);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(179, 79);
            this.richTextBoxAddress.TabIndex = 5;
            this.richTextBoxAddress.Text = "";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(70, 405);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPIDDataGridViewTextBoxColumn,
            this.eNAMEDataGridViewTextBoxColumn,
            this.dEPARTMENTDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.sALARYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empGetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 464);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(619, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // dsEmpGet
            // 
            this.dsEmpGet.DataSetName = "dsEmpGet";
            this.dsEmpGet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empGetBindingSource
            // 
            this.empGetBindingSource.DataMember = "EmpGet";
            this.empGetBindingSource.DataSource = this.dsEmpGet;
            // 
            // empGetTableAdapter
            // 
            this.empGetTableAdapter.ClearBeforeFill = true;
            // 
            // eMPIDDataGridViewTextBoxColumn
            // 
            this.eMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMPID";
            this.eMPIDDataGridViewTextBoxColumn.HeaderText = "EMPID";
            this.eMPIDDataGridViewTextBoxColumn.Name = "eMPIDDataGridViewTextBoxColumn";
            this.eMPIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNAMEDataGridViewTextBoxColumn
            // 
            this.eNAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.HeaderText = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.Name = "eNAMEDataGridViewTextBoxColumn";
            this.eNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEPARTMENTDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.Name = "dEPARTMENTDataGridViewTextBoxColumn";
            this.dEPARTMENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALARYDataGridViewTextBoxColumn
            // 
            this.sALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.Name = "sALARYDataGridViewTextBoxColumn";
            this.sALARYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsEmpGet dsEmpGet;
        private System.Windows.Forms.BindingSource empGetBindingSource;
        private dsEmpGetTableAdapters.EmpGetTableAdapter empGetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
    }
}

