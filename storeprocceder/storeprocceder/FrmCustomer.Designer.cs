namespace storeprocceder
{
    partial class FrmCustomer
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getCustomerDetails = new storeprocceder.GetCustomerDetails();
            this.getCustomerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerDetailsTableAdapter = new storeprocceder.GetCustomerDetailsTableAdapters.GetCustomerDetailsTableAdapter();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "State :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "City :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(180, 106);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(267, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(180, 252);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(112, 20);
            this.txtState.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(180, 330);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(112, 20);
            this.txtCity.TabIndex = 2;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(180, 154);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(231, 70);
            this.richTextBoxAddress.TabIndex = 3;
            this.richTextBoxAddress.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 404);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTIDDataGridViewTextBoxColumn,
            this.cUSTNAMEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getCustomerDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 447);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(575, 277);
            this.dataGridView1.TabIndex = 5;
            // 
            // getCustomerDetails
            // 
            this.getCustomerDetails.DataSetName = "GetCustomerDetails";
            this.getCustomerDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerDetailsBindingSource
            // 
            this.getCustomerDetailsBindingSource.DataMember = "GetCustomerDetails";
            this.getCustomerDetailsBindingSource.DataSource = this.getCustomerDetails;
            // 
            // getCustomerDetailsTableAdapter
            // 
            this.getCustomerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUSTID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            this.cUSTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSTNAME";
            this.cUSTNAMEDataGridViewTextBoxColumn.HeaderText = "CUSTNAME";
            this.cUSTNAMEDataGridViewTextBoxColumn.Name = "cUSTNAMEDataGridViewTextBoxColumn";
            this.cUSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATEDataGridViewTextBoxColumn
            // 
            this.sTATEDataGridViewTextBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewTextBoxColumn.HeaderText = "STATE";
            this.sTATEDataGridViewTextBoxColumn.Name = "sTATEDataGridViewTextBoxColumn";
            this.sTATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            this.cITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 736);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GetCustomerDetails getCustomerDetails;
        private System.Windows.Forms.BindingSource getCustomerDetailsBindingSource;
        private GetCustomerDetailsTableAdapters.GetCustomerDetailsTableAdapter getCustomerDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
    }
}