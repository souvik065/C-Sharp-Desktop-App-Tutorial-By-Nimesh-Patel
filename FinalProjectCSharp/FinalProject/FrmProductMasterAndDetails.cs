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
            //comboBoxUnit.SelectedIndex = 0;
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

        public void InsertProdutDetails()
        {
            SQLQueryClass.con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("InsertIntoProductDetails",SQLQueryClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTID", dataGridView1.Rows[i].Cells[0].Value).DbType = DbType.Int32;
                cmd.Parameters.AddWithValue("@QTY",Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@UNIT", dataGridView1.Rows[i].Cells[2].Value).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@PURCHASERATE", Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@SALESRATE", Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@CGSTPERCENTAGE", Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@CGSTAMOUNT", Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@SGSTPERCENTAGE",Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@SGSTAMOUNT", Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@IGSTPERCENTAGE", Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@IGSTAMOUNT", Convert.ToDecimal(dataGridView1.Rows[i].Cells[10].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@BASICRATE", Convert.ToDecimal(dataGridView1.Rows[i].Cells[11].Value)).DbType = DbType.Decimal;
                cmd.Parameters.AddWithValue("@MRP", Convert.ToDecimal(dataGridView1.Rows[i].Cells[12].Value)).DbType = DbType.Decimal;
                cmd.ExecuteNonQuery();

            }

            SQLQueryClass.con.Close();
            MessageBox.Show("Product Details Inserted Successfully");
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

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProductMasterAndDetails_Load(object sender, EventArgs e)
        {
   

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProductMasterAndDetails_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);

            Reset();
            CreateTable();

            comboBoxUnit.Items.Add("--Select Unit--");
            comboBoxUnit.Items.Add("Kg");
            comboBoxUnit.Items.Add("g");
            comboBoxUnit.Items.Add("mg");
            comboBoxUnit.Items.Add("L");
            comboBoxUnit.Items.Add("ml");

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

            dataGridView1.Rows.Add(productID,txtQTY.Text, comboBoxUnit.Text, txtPurchaseRate.Text, txtSalesRate.Text, txtCGSTRate.Text, txtCGSTAmount.Text, txtSGSTRate.Text, txtSGSTAmount.Text, txtIGSTRate.Text, txtIGSTAmount.Text, txtBasicRate.Text, txtMRP.Text);
            
            /*
            DataRow dr = ProductTable.NewRow();
            dr[0] = productID;
            dr[1] = txtQTY.Text;
            dr[2] = comboBoxUnit.Text;
            dr[3] = txtPurchaseRate.Text;
            dr[4] = txtSalesRate.Text;
            dr[5] = txtCGSTRate.Text;
            dr[6] = txtCGSTAmount.Text;
            dr[7] = txtSGSTRate.Text;
            dr[8] = txtSGSTAmount.Text;
            dr[9] = txtIGSTRate.Text;
            dr[10] = txtIGSTAmount.Text;
            dr[11] = txtBasicRate.Text;
            dr[12] = txtMRP.Text;
            ProductTable.Rows.Add(dr);
            */



            




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
            InsertProdutDetails();
            dataGridView1.Rows.Clear();
        }
    }
}
