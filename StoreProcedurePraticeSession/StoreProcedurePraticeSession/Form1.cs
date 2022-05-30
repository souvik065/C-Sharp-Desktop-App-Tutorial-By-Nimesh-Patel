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

namespace StoreProcedurePraticeSession
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

            SqlCommand cmd = new SqlCommand("InsertDeptDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNAME", txtDeptName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@LOC", txtLocation.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted SuccessFully");

            SqlMethods.con.Close();
            this.getDeptDetailsTableAdapter.Fill(this.department.GetDeptDetails);
            
        }

        private void Update()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateDeptDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DEPTNO",txtDeptName.Tag).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@DNAME", txtDeptName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@LOC", txtLocation.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated SuccessFully");

            SqlMethods.con.Close();
            this.getDeptDetailsTableAdapter.Fill(this.department.GetDeptDetails);
            //this.getDeptDetailsTableAdapter.Fill(this.dataSet1.GetDeptDetails);
        }

        private void FillData()
        {
            txtDeptName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDeptName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLocation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void Delete()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteDeptDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DEPTNO", txtDeptName.Tag).DbType = DbType.Int32;
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated SuccessFully");

            SqlMethods.con.Close();
            this.getDeptDetailsTableAdapter.Fill(this.department.GetDeptDetails);  
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'department.GetDeptDetails' table. You can move, or remove it, as needed.
            this.getDeptDetailsTableAdapter.Fill(this.department.GetDeptDetails);
            

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.getDeptDetailsTableAdapter.Fill(this.department.GetDeptDetails);
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
