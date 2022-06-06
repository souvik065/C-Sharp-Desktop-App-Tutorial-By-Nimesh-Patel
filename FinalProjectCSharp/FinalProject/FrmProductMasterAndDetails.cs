using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class FrmProductMasterAndDetails : Form
    {

       
        Int32 productID = 0;
        
        public FrmProductMasterAndDetails()
        {
            InitializeComponent();
        }



        public DataTable CreateTable()
        {
            DataTable ProductTable = new DataTable();


            ProductTable.Columns.Add("PRODUCTID");
            ProductTable.Columns.Add("QTY");
            ProductTable.Columns.Add("UNIT");
            ProductTable.Columns.Add("PURCHASERATE");
            ProductTable.Columns.Add("SALESRATE");
            ProductTable.Columns.Add("CGSTPERCENTAGE");
            ProductTable.Columns.Add("CGSTAMOUNT");
            ProductTable.Columns.Add("SGSTPERCENTAGE");
            ProductTable.Columns.Add("SGSTAMOUNT");
            ProductTable.Columns.Add("IGSTPERCENTAGE");
            ProductTable.Columns.Add("IGSTAMOUNT");
            ProductTable.Columns.Add("BASICRATE");
            ProductTable.Columns.Add("MRP");
            return ProductTable;

        }

        public void Reset()
        {
            txtProductName.Clear();
            comboBoxCategory.SelectedIndex = 0;
            txtQTY.Text = "1";
            comboBoxUnit.SelectedIndex = 1;
            txtPurchaseRate.Clear();
            txtSalesRate.Clear();
            txtCGSTRate.Text = "0.00";
            txtCGSTAmount.Text = "0.00";
            txtSGSTRate.Text = "0.00";
            txtSGSTAmount.Text = "0.00";
            txtIGSTRate.Text = "0.00";
            txtIGSTAmount.Text = "0.00";
            txtBasicRate.Clear();
            txtMRP.Clear();
            productID = 0;

        }

        public void InsertIntoProductMaster()
        {
            
                SQLQueryClass.con.Open();
                SqlCommand cmd = new SqlCommand("InsertIntoProductMaster", SQLQueryClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTNAME", txtProductName.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@SUBCATEGORYID", comboBoxSubCategory.SelectedValue).DbType = DbType.Int32;

                // cmd.ExecuteNonQuery();
                productID = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Inserted into Product Master Successfully");

                SQLQueryClass.con.Close();   
            
        }

        private void InsertProductDetail()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("InsertIntoProductDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTID", productID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@QTY", txtQTY.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@UNIT", comboBoxUnit.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PURCHASERATE", txtPurchaseRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SALESRATE", txtSalesRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPERCENTAGE", txtCGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAMOUNT", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPERCENTAGE", txtSGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAMOUNT", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPERCENTAGE", txtIGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAMOUNT", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@BASICRATE", txtBasicRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MRP", txtMRP.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Detail Inserted Successfully");

            SQLQueryClass.con.Close();

            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails);
        }

        public void UpdateProductDetails()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateProductDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTDETAILID", txtQTY.Tag).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@PRODUCTID", productID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@QTY", txtQTY.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@UNIT", comboBoxUnit.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PURCHASERATE", txtPurchaseRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SALESRATE", txtSalesRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPERCENTAGE", txtCGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAMOUNT", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPERCENTAGE", txtSGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAMOUNT", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPERCENTAGE", txtIGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAMOUNT", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@BASICRATE", txtBasicRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MRP", txtMRP.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Detail Updated Successfully");

            SQLQueryClass.con.Close();

            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails);
            txtQTY.Tag = null;
        }





        public void GrideViewDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }


        public void FillData()
        {
            txtQTY.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            productID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtQTY.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxUnit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPurchaseRate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSalesRate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCGSTRate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCGSTAmount.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSGSTRate.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSGSTAmount.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtIGSTRate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtIGSTAmount.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtBasicRate.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtMRP.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }
      
        
        public void GSTCAl()
        {
            if (Convert.ToDecimal(txtCGSTRate.Text) > Convert.ToDecimal(0.00) || Convert.ToDecimal(txtSGSTRate.Text) > Convert.ToDecimal(0.00))
            {
                txtIGSTRate.ReadOnly = true;
                txtIGSTAmount.ReadOnly = true;

                txtCGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtCGSTRate.Text) / 100);
                txtSGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtSGSTRate.Text) / 100);

                txtBasicRate.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) + Convert.ToDecimal(txtCGSTAmount.Text) + Convert.ToDecimal(txtSGSTAmount.Text));

            }
            else if (Convert.ToDecimal(txtIGSTRate.Text) > Convert.ToDecimal(0.00))
            {
                txtCGSTRate.ReadOnly = true;
                txtCGSTAmount.ReadOnly = true;
                txtSGSTRate.ReadOnly = true;
                txtSGSTAmount.ReadOnly = true;

                txtIGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtIGSTRate.Text) / 100);

                txtBasicRate.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) + Convert.ToDecimal(txtIGSTAmount.Text));
            }

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProductMasterAndDetails_Load(object sender, EventArgs e)
        {
   

        }

       

        private void FrmProductMasterAndDetails_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGetProductDetails.GetProductDetails' table. You can move, or remove it, as needed.
            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails);
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);

             comboBoxUnit.SelectedIndex = 0;


            

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listSubCategoryDetailsTableAdapter.Fill(this.dSListSubCategoryDetails.ListSubCategoryDetails,Convert.ToInt32(comboBoxCategory.SelectedValue));
        }
        

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            InsertIntoProductMaster();

            if (txtQTY.Tag == null)
            {
                
                InsertProductDetail();
                
            }
            else
            {
                UpdateProductDetails();

            }

            

            Reset();

            




        }


        private void txtSGSTRate_KeyDown_1(object sender, KeyEventArgs e)
        {
            GSTCAl();
        }

        private void txtIGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            GSTCAl();
        }

        private void txtCGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            GSTCAl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GrideViewDelete();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();

        }

        private void txtSGSTAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
