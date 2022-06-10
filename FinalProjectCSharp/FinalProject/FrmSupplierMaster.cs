using System;
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
    public partial class FrmSupplierMaster : Form
    {
        public FrmSupplierMaster()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("InsertIntoSupplierMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUPPLIERNAME", txtSupplierName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ADDRESS", richTextBoxAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@EMAILID", txtEmail.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@MOBILENO", txtMobileNo.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@CONTACTPERSON", txtContactPerson.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@REMARK", richTextBoxRemark.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

            
        }

       


        private void Update()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateSupplierMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUPPLIERID", txtSupplierName.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUPPLIERNAME", txtSupplierName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ADDRESS", richTextBoxAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@EMAILID", txtEmail.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@MOBILENO", txtMobileNo.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@CONTACTPERSON", txtContactPerson.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@REMARK", richTextBoxRemark.Text).DbType = DbType.String;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

           

        }

        private void Delete()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteFromSupplierMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SUBCATEGORYID", txtSupplierName.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

           

        }

        private void FillData()
        {
            txtSupplierName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMobileNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtContactPerson.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBoxRemark.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void FrmSupplierMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGetSupplierDetails.GetSupplierMasterDetails' table. You can move, or remove it, as needed.
            this.getSupplierMasterDetailsTableAdapter.Fill(this.dSGetSupplierDetails.GetSupplierMasterDetails);

        }
    }
}
