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

namespace SPPracticeSession2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("InsertCategoryDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYNAME", txtCategory.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getCategoryDetailsTableAdapter.Fill(this.categoryMaster.GetCategoryDetails);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }


        private void Update()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateCategoryDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYNAME", txtCategory.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@CATEGORYID", txtCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getCategoryDetailsTableAdapter.Fill(this.categoryMaster.GetCategoryDetails);

        }

        private void Delete()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteCategoryDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
       
            cmd.Parameters.AddWithValue("@CATEGORYID", txtCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getCategoryDetailsTableAdapter.Fill(this.categoryMaster.GetCategoryDetails);

        }

        private void FillData()
        {
            txtCategory.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoryMaster.GetCategoryDetails' table. You can move, or remove it, as needed.
            this.getCategoryDetailsTableAdapter.Fill(this.categoryMaster.GetCategoryDetails);

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
    }
}
