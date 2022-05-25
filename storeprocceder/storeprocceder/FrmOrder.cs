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


namespace storeprocceder
{
    public partial class FrmOrder : Form
    {
        SqlCommand cmd;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            Global.con.Open();

            cmd = new SqlCommand("InsertOrderDetails", Global.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCT", txtProduct.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.Decimal;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted Succesfully");
            Global.con.Close();
            this.getOrderDetailsTableAdapter.Fill(this.getCustomerDetails.GetOrderDetails);
        }

        private void Update()
        {
            Global.con.Open();

            cmd = new SqlCommand("UpdateOrderDetails", Global.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ORDID",txtProduct.Tag).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@PRODUCT", txtProduct.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.Decimal;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully");
            Global.con.Close();
            this.getOrderDetailsTableAdapter.Fill(this.getCustomerDetails.GetOrderDetails);
        }

        private void Delete()
        {
            Global.con.Open();

            cmd = new SqlCommand("DeleteOrderDetails", Global.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ORDID", txtProduct.Tag).DbType = DbType.Int32;
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Succesfully");
            Global.con.Close();
            this.getOrderDetailsTableAdapter.Fill(this.getCustomerDetails.GetOrderDetails);
        }

        private void FillData()
        {
            txtProduct.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProduct.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getCustomerDetails.GetOrderDetails' table. You can move, or remove it, as needed.
            this.getOrderDetailsTableAdapter.Fill(this.getCustomerDetails.GetOrderDetails);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
