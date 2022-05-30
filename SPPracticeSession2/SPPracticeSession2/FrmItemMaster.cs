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

namespace SPPracticeSession2
{
    public partial class FrmItemMaster : Form
    {
        public FrmItemMaster()
        {
            InitializeComponent();
        }


        private void Insert()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("InsertItemDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYID", comboBoxCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUBCATEGORYID", comboBoxSubCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ITEMNAME", txtItemName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@QTY", txtQty.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TOTAL", txtTotal.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DESCRIPTION", richTextBoxDescription.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();


            this.getItemDetailsTableAdapter.Fill(this.dSItemMaster.GetItemDetails);
        }

      

        private void Update()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateItemDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ITEMID", txtItemName.Tag).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@CATEGORYID", comboBoxCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUBCATEGORYID", comboBoxSubCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ITEMNAME", txtItemName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@QTY", txtQty.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TOTAL", txtTotal.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DESCRIPTION", richTextBoxDescription.Text).DbType = DbType.String;

            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getItemDetailsTableAdapter.Fill(this.dSItemMaster.GetItemDetails);

        }

        private void Delete()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteItemDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ITEMID", txtItemName.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();
            this.getItemDetailsTableAdapter.Fill(this.dSItemMaster.GetItemDetails);
            
        }

        private void FillData()
        {
            txtItemName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxCategoryName.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxSubCategoryName.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtItemName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            richTextBoxDescription.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }




        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void FrmItemMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSItemMaster.GetItemDetails' table. You can move, or remove it, as needed.
            this.getItemDetailsTableAdapter.Fill(this.dSItemMaster.GetItemDetails);
            // TODO: This line of code loads data into the 'listCategoryNames.ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryNames.ListCategoryDetails);
            comboBoxCategoryName.SelectedIndex = 0;
         

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listSubCategoryDetailsTableAdapter.Fill(this.listSubCategoryDetails._ListSubCategoryDetails,Convert.ToInt32(comboBoxCategoryName.SelectedValue));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQty.Text));
        }
    }
}
