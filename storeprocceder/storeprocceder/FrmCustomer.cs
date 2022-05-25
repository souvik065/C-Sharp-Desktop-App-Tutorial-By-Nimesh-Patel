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
    public partial class FrmCustomer : Form
    {
        SqlCommand cmd;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            cmd = new SqlCommand("InsertCustomerDetails",Global.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUSTNAME",txtCustomerName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ADDRESS", richTextBoxAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@STATE", txtState.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@CITY", txtCity.Text).DbType = DbType.String;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted Successfully...");
            Global.con.Close();
            this.getCustomerDetailsTableAdapter.Fill(this.getCustomerDetails._GetCustomerDetails);
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getCustomerDetails._GetCustomerDetails' table. You can move, or remove it, as needed.
            this.getCustomerDetailsTableAdapter.Fill(this.getCustomerDetails._GetCustomerDetails);

        }
    }
}
