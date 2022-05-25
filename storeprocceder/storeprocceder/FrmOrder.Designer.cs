namespace storeprocceder
{
    partial class FrmOrder
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oRDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerDetails = new storeprocceder.GetCustomerDetails();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.getOrderDetailsTableAdapter = new storeprocceder.GetCustomerDetailsTableAdapters.GetOrderDetailsTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount :";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(137, 99);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(171, 20);
            this.txtProduct.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(137, 166);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(171, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDIDDataGridViewTextBoxColumn,
            this.pRODUCTDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getOrderDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 381);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // oRDIDDataGridViewTextBoxColumn
            // 
            this.oRDIDDataGridViewTextBoxColumn.DataPropertyName = "ORDID";
            this.oRDIDDataGridViewTextBoxColumn.HeaderText = "ORDID";
            this.oRDIDDataGridViewTextBoxColumn.Name = "oRDIDDataGridViewTextBoxColumn";
            this.oRDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTDataGridViewTextBoxColumn
            // 
            this.pRODUCTDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT";
            this.pRODUCTDataGridViewTextBoxColumn.HeaderText = "PRODUCT";
            this.pRODUCTDataGridViewTextBoxColumn.Name = "pRODUCTDataGridViewTextBoxColumn";
            this.pRODUCTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getOrderDetailsBindingSource
            // 
            this.getOrderDetailsBindingSource.DataMember = "GetOrderDetails";
            this.getOrderDetailsBindingSource.DataSource = this.getCustomerDetails;
            // 
            // getCustomerDetails
            // 
            this.getCustomerDetails.DataSetName = "GetCustomerDetails";
            this.getCustomerDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.Location = new System.Drawing.Point(57, 242);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(74, 33);
            this.BtnInsert.TabIndex = 4;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // getOrderDetailsTableAdapter
            // 
            this.getOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(137, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(217, 242);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(74, 33);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 718);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnInsert;
        private GetCustomerDetails getCustomerDetails;
        private System.Windows.Forms.BindingSource getOrderDetailsBindingSource;
        private GetCustomerDetailsTableAdapters.GetOrderDetailsTableAdapter getOrderDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}