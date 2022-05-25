namespace DemoApplication
{
    partial class FrmExpenseMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxExpenseCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxRemark = new System.Windows.Forms.RichTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPartyID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSourceID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(449, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Master";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(383, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expense Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Expense Date :";
            // 
            // comboBoxExpenseCategory
            // 
            this.comboBoxExpenseCategory.FormattingEnabled = true;
            this.comboBoxExpenseCategory.Location = new System.Drawing.Point(565, 22);
            this.comboBoxExpenseCategory.Name = "comboBoxExpenseCategory";
            this.comboBoxExpenseCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExpenseCategory.TabIndex = 2;
            // 
            // dateTimePickerExpenseDate
            // 
            this.dateTimePickerExpenseDate.Location = new System.Drawing.Point(156, 22);
            this.dateTimePickerExpenseDate.Name = "dateTimePickerExpenseDate";
            this.dateTimePickerExpenseDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerExpenseDate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 62);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.richTextBoxRemark);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtReference);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimePickerChequeDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxExpenseCategory);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxPaymentMode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxPartyID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBoxSourceID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePickerExpenseDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 240);
            this.panel2.TabIndex = 6;
            // 
            // richTextBoxRemark
            // 
            this.richTextBoxRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxRemark.Location = new System.Drawing.Point(841, 117);
            this.richTextBoxRemark.Name = "richTextBoxRemark";
            this.richTextBoxRemark.Size = new System.Drawing.Size(175, 76);
            this.richTextBoxRemark.TabIndex = 6;
            this.richTextBoxRemark.Text = "";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnView.Location = new System.Drawing.Point(461, 187);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 37);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(323, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "PartyID :";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(126, 122);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(129, 20);
            this.txtReference.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(185, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 37);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsert.Location = new System.Drawing.Point(46, 187);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 37);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.Location = new System.Drawing.Point(904, 27);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(396, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "SourceID :";
            // 
            // dateTimePickerChequeDate
            // 
            this.dateTimePickerChequeDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerChequeDate.Location = new System.Drawing.Point(531, 121);
            this.dateTimePickerChequeDate.Name = "dateTimePickerChequeDate";
            this.dateTimePickerChequeDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerChequeDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(672, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Payment Mode :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Reference :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxPaymentMode
            // 
            this.comboBoxPaymentMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPaymentMode.FormattingEnabled = true;
            this.comboBoxPaymentMode.Location = new System.Drawing.Point(825, 69);
            this.comboBoxPaymentMode.Name = "comboBoxPaymentMode";
            this.comboBoxPaymentMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPaymentMode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(812, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount :";
            // 
            // comboBoxPartyID
            // 
            this.comboBoxPartyID.FormattingEnabled = true;
            this.comboBoxPartyID.Location = new System.Drawing.Point(100, 69);
            this.comboBoxPartyID.Name = "comboBoxPartyID";
            this.comboBoxPartyID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPartyID.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(396, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cheque Date :";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxSourceID
            // 
            this.comboBoxSourceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSourceID.FormattingEnabled = true;
            this.comboBoxSourceID.Location = new System.Drawing.Point(500, 69);
            this.comboBoxSourceID.Name = "comboBoxSourceID";
            this.comboBoxSourceID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSourceID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(750, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Remark :";
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1138, 431);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // FrmExpenseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmExpenseMaster";
            this.Text = "FrmExpenseMaster";
            this.Load += new System.EventHandler(this.FrmExpenseMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxExpenseCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpenseDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSourceID;
        private System.Windows.Forms.ComboBox comboBoxPartyID;
        private System.Windows.Forms.ComboBox comboBoxPaymentMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxRemark;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.DateTimePicker dateTimePickerChequeDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}