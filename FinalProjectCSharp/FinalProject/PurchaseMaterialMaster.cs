﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class PurchaseMaterialMaster : Form
    {
        

        int PurchaseMasterID = 0;
        int PurchaseDetailsID = 0;
        Boolean isExpire = false;
        public PurchaseMaterialMaster()
        {
            InitializeComponent();
        }

        private void EnablePanelContent()
        {
            panelPurchaseDetail.Enabled = false;
            panelTotalAmounts.Enabled = false;
            if (dateTimePickerPurchaseDate.Text != null && comboBoxSupplierName.SelectedIndex > 0 && txtInvoiceNo.Text != null)
            {
                panelPurchaseDetail.Enabled = true;
                panelTotalAmounts.Enabled=true;
                PurchaseMasterpanel.Enabled = false;
            }


        }


       

        private void AllCalculation()
        {
            txtTotal.Text = Convert.ToString( Convert.ToDecimal(txtRate.Text)*Convert.ToDecimal(txtQty.Text) );

            txtDiscountAmount.Text = Convert.ToString( Convert.ToDecimal(txtTotal.Text)*Convert.ToDecimal(txtDiscountPercentage.Text)/100  );

            txtTaxableAmount.Text = Convert.ToString( Convert.ToDecimal(txtTotal.Text)-Convert.ToDecimal(txtDiscountAmount.Text));

            if (Convert.ToDecimal(txtCGSTPercentage.Text) > 0 && Convert.ToDecimal(txtSGSTPercentage.Text) > 0)
            {
                txtIGSTPercentage.ReadOnly = true;
                txtIGSTAmount.ReadOnly = true;
                txtCGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtTaxableAmount.Text) * Convert.ToDecimal(txtCGSTPercentage.Text) / 100);
                txtSGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtTaxableAmount.Text) * Convert.ToDecimal(txtSGSTPercentage.Text) / 100);

                txtIGSTAmount.Text = "0";
                txtIGSTPercentage.Text = "0";



            }
            else if (Convert.ToDecimal(txtIGSTPercentage.Text) > 0)
            {
                txtCGSTPercentage.ReadOnly = true;
                txtCGSTAmount.ReadOnly = true;
                txtSGSTPercentage.ReadOnly = true;
                txtSGSTAmount.ReadOnly = true;

                txtIGSTAmount.Text = Convert.ToString( Convert.ToDecimal(txtTaxableAmount.Text) * Convert.ToDecimal(txtIGSTPercentage.Text)/100 );

                txtCGSTPercentage.Text = "0";
                txtCGSTAmount.Text = "0";
                txtSGSTPercentage.Text = "0";
                txtSGSTAmount.Text = "0";


             }

            txtNetAmount.Text = Convert.ToString( Convert.ToDecimal(txtTaxableAmount.Text) + Convert.ToDecimal(txtCGSTAmount.Text) + Convert.ToDecimal(txtSGSTAmount.Text) + Convert.ToDecimal(txtIGSTAmount.Text) );

            if (Convert.ToDecimal(txtCGSTPercentage.Text) == 0 && Convert.ToDecimal(txtSGSTPercentage.Text) == 0)
            {
                txtIGSTPercentage.Enabled = true;
                txtIGSTAmount.Enabled = true;
            }
            else if (Convert.ToDecimal(txtIGSTPercentage.Text) == 0)
            {
                txtCGSTPercentage.Enabled = true;
                txtSGSTPercentage.Enabled = true;
            }


            if (checkBoxYes.Checked == true)
            {
                dateTimePickerExpireDate.Enabled = true;
            }else if (checkBoxNo.Checked == true)
            {
                dateTimePickerExpireDate.Enabled = false;
            }


            if (checkBoxYes.Checked)
            {
                isExpire = true;
            }
            else if (checkBoxNo.Checked)
            { 
                isExpire = false;
            }

        }

        private void ResetPurchasedetailDefaultValue()
        {

            comboBoxProductName.SelectedIndex = 0;
            checkBoxYes.Checked = false;
            checkBoxNo.Checked = false;
            dateTimePickerExpireDate.Text = "";
            txtRate.Text = "0";
            txtQty.Text = "0";
            txtHSNCode.Text = "0";
            txtTotal.Text = "0";
            txtDiscountPercentage.Text = "0";
            txtDiscountAmount.Text = "0";
            txtTaxableAmount.Text = "0";
            txtCGSTPercentage.Text = "0";
            txtCGSTAmount.Text = "0";
            txtSGSTPercentage.Text = "0";
            txtSGSTAmount.Text = "0";
            txtIGSTPercentage.Text = "0";
            txtIGSTAmount.Text= "0";
            txtNetAmount.Text = "0";
            PurchaseDetailsID = 0;

        }

        private void ResetTotalAmountDefaultValue()
        {
            txtGrossAmount.Text = "0";
            txtTotalDiscountAmount.Text = "0";
            txtTotalTaxableAmount.Text = "0";
            txtTotalCGSTAmount.Text = "0";
            txtTotalSGSTAmount.Text = "0";
            txtTotalIGSTAmount.Text = "0";
            txtNetAmount.Text = "0";
            txtTradeDiscAmt.Text = "0";
            txtCashDiscAmt.Text = "0";
            txtFreighCharges.Text = "0";
            txtLabourCharges.Text = "0";
            txtNetAmount.Text = "0";
        }

       


        private void InsertIntoPurchaseMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoPurchaseMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseDate", dateTimePickerPurchaseDate.Text).DbType = DbType.Date;
            cmd.Parameters.AddWithValue("@SupplierID", comboBoxSupplierName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text).DbType = DbType.Int32;

            // cmd.ExecuteNonQuery();
            PurchaseMasterID = Convert.ToInt32(cmd.ExecuteScalar());

            MessageBox.Show("Inserted into Purchase Master Successfully");

            SQLQueryClass.con.Close();


        }


        private void InsertIntoPurchaseDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoPurchaseDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@IsExpire", isExpire).DbType = DbType.Boolean;
            cmd.Parameters.AddWithValue("@ExpireDate", dateTimePickerExpireDate.Text).DbType = DbType.Date;
            cmd.Parameters.AddWithValue("@Rate", txtRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@Qty", txtQty.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@HSNCode",txtHSNCode.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@Total",txtTotal.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountPercentage",txtDiscountPercentage.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountAmount",txtDiscountAmount.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TaxableAmount",txtTaxableAmount.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPercentage",txtCGSTPercentage.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount",txtCGSTAmount.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPercentage",txtSGSTPercentage.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPercentage", txtIGSTPercentage.Text ).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NetAmount",txtNetAmount.Text ).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();
           

            MessageBox.Show("Inserted Purchase Detail Successfully");

            SQLQueryClass.con.Close();
            this.getPurchaseDetailsTableAdapter.Fill(this.dSGetPurchaseDetail.GetPurchaseDetails, PurchaseMasterID);



        }


        private void UpdatePurchaseDetails()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePurchaseDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchasedetailID", PurchaseDetailsID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@IsExpire", isExpire).DbType = DbType.Boolean;
            cmd.Parameters.AddWithValue("@ExpireDate", dateTimePickerExpireDate.Text).DbType = DbType.Date;
            cmd.Parameters.AddWithValue("@Rate", txtRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@Qty", txtQty.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@HSNCode", txtHSNCode.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@Total", txtTotal.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountPercentage", txtDiscountPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountAmount", txtDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TaxableAmount", txtTaxableAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPercentage", txtCGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPercentage", txtSGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPercentage", txtIGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NetAmount", txtNetAmount.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();


            MessageBox.Show("Purchase Detail Updated Successfully");

            SQLQueryClass.con.Close();
            this.getPurchaseDetailsTableAdapter.Fill(this.dSGetPurchaseDetail.GetPurchaseDetails, PurchaseMasterID);


        }


        private void UpdatePurchaseMasterTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePurchaseMasterTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@TotalGrossAmount", txtGrossAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalDiscountAmount", txtTotalDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtTotalCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalNetAmount", txtTotalNetAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TradeDiscountAmount", txtTradeDiscAmt.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CashDiscountAmount", txtCashDiscAmt.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@FreighCharges", txtFreighCharges.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@LabourCharges", txtLabourCharges.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NetAmount", txtNetAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@PaymentMode", comboBoxPaymentMode.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@Remark", txtRemark.Text).DbType = DbType.String;
            



            cmd.ExecuteNonQuery();


            MessageBox.Show("Total Amounts Updated to Purchase Master Successfully");

            SQLQueryClass.con.Close();
        }

        private void DeleteFromPurchaseDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("DeleteFromPurchaseDetailTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchasedetailID", PurchaseDetailsID).DbType = DbType.Int32;
           
            cmd.ExecuteNonQuery();


            MessageBox.Show("Purchase Detail Entry Deleted Successfully");

            SQLQueryClass.con.Close();
            this.getPurchaseDetailsTableAdapter.Fill(this.dSGetPurchaseDetail.GetPurchaseDetails, PurchaseMasterID);
        }


        private void GetTotalAmount()
        {
            SqlCommand cmd = new SqlCommand("GetTotalAmount",SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseMasterID",PurchaseMasterID);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtGrossAmount.Text = ds.Tables[0].Rows[0]["GrossAmount"].ToString();
                txtTotalDiscountAmount.Text = ds.Tables[0].Rows[0]["DiscountAmount"].ToString();
                txtTotalTaxableAmount.Text = ds.Tables[0].Rows[0]["TaxableAmount"].ToString();
                txtTotalCGSTAmount.Text = ds.Tables[0].Rows[0]["CGSTAmount"].ToString();
                txtTotalSGSTAmount.Text = ds.Tables[0].Rows[0]["SGSTAmount"].ToString();
                txtTotalIGSTAmount.Text = ds.Tables[0].Rows[0]["IGSTAmount"].ToString();
                txtTotalNetAmount.Text = ds.Tables[0].Rows[0]["TotalNetAmount"].ToString();
            }
            else {
                ResetPurchasedetailDefaultValue();

            }

           


        }

        private void OtherCharges()
        {
            txtFinalNetAmount.Text = Convert.ToString((Convert.ToDecimal(txtTotalNetAmount.Text) - Convert.ToDecimal(txtTradeDiscAmt.Text) - Convert.ToDecimal(txtCashDiscAmt.Text))
                                + Convert.ToDecimal(txtFreighCharges.Text) + Convert.ToDecimal(txtLabourCharges.Text));
        }

        private void FillData()
        {
            PurchaseDetailsID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
            comboBoxProductName.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            isExpire = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            if (isExpire == true)
            {
                checkBoxYes.Checked = true;
                checkBoxNo.Checked = false;
            }
            else if (isExpire == false)
            { 
                checkBoxNo.Checked = true;
                checkBoxYes.Checked = false;
            }


            dateTimePickerExpireDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtHSNCode.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtDiscountPercentage.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
             txtDiscountAmount.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtTaxableAmount.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtCGSTPercentage.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtCGSTAmount.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtSGSTPercentage .Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtSGSTAmount.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtIGSTPercentage.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtIGSTAmount.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            txtNetAmount.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();

        }
       

        private void PurchaseMaterialMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSListProductMasterDetails.ListProductMasterDetails' table. You can move, or remove it, as needed.
            this.listProductMasterDetailsTableAdapter.Fill(this.dSListProductMasterDetails.ListProductMasterDetails);
            // TODO: This line of code loads data into the 'dSListSupplierMasterDetails.ListSupplierDetails' table. You can move, or remove it, as needed.
            this.listSupplierDetailsTableAdapter.Fill(this.dSListSupplierMasterDetails.ListSupplierDetails);
            // TODO: This line of code loads data into the 'dSListSupplierMasterDetails.ListSupplierDetails' table. You can move, or remove it, as needed.

            this.getPurchaseDetailsTableAdapter.Fill(this.dSGetPurchaseDetail.GetPurchaseDetails,PurchaseMasterID);

            ResetTotalAmountDefaultValue();

            EnablePanelContent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBoxSupplierName.SelectedIndex > 0 && txtInvoiceNo.Text != null)
            {
                InsertIntoPurchaseMaster();

            }
            if (PurchaseMasterID > 0)
            {
                EnablePanelContent();
                comboBoxProductName.Focus();
            }
           
        }

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNo.Checked = false;
            AllCalculation();

            
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxYes.Checked = false;
            AllCalculation();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PurchaseDetailsID != 0)
            {
                UpdatePurchaseDetails();
                ResetPurchasedetailDefaultValue();

            }else
            {
                InsertIntoPurchaseDetailTable();
                ResetPurchasedetailDefaultValue();
            }
            GetTotalAmount();
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtDiscountPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtCGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtSGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtIGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtNetAmount_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetPurchasedetailDefaultValue();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(PurchaseDetailsID >0)
            {
                DeleteFromPurchaseDetailTable();
                ResetPurchasedetailDefaultValue();

            }
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePurchaseMasterTable();
        }

        private void txtTradeDiscAmt_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtLabourCharges_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtFreighCharges_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtCashDiscAmt_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }
    }
}
