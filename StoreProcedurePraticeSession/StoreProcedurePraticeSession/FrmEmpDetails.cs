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
    public partial class FrmEmpDetails : Form
    {
        public FrmEmpDetails()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("InsertEmpDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ENAME", txtEmpName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ADDRESS", richTextBoxAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@HIREDATE", txtHireDate.Text).DbType = DbType.Date;

            cmd.Parameters.AddWithValue("@DEPTNO", comboBoxDept.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@MGR", txtMGR.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@SAL", txtSal.Text).DbType = DbType.Decimal;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted SuccessFully");

            SqlMethods.con.Close();

            this.getEmpDetailsTableAdapter.Fill(this.empDataSet.GetEmpDetails);
           

        }

        private void Update()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateEmpDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EMPNO", txtEmpName.Tag).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ENAME", txtEmpName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ADDRESS", richTextBoxAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@HIREDATE", txtHireDate.Text).DbType = DbType.Date;
           // cmd.Parameters.AddWithValue("@DEPTNO", txtDept.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@MGR", txtMGR.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@SAL", txtSal.Text).DbType = DbType.Decimal;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated SuccessFully");

            SqlMethods.con.Close();

            this.getEmpDetailsTableAdapter.Fill(this.empDataSet.GetEmpDetails);

           
        }


        private void Delete()
        {

            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteEmpDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EMPNO", txtEmpName.Tag).DbType = DbType.String;
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated SuccessFully");

            SqlMethods.con.Close();

            this.getEmpDetailsTableAdapter.Fill(this.empDataSet.GetEmpDetails);

        }

        private void FillData()
        {
            txtEmpName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtHireDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           // txtDept.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMGR.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmpDetails_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'listAllDeptDetails._ListAllDeptDetails' table. You can move, or remove it, as needed.
            this.listAllDeptDetailsTableAdapter.Fill(this.listAllDeptDetails._ListAllDeptDetails);
            // TODO: This line of code loads data into the 'empDataSet.GetEmpDetails' table. You can move, or remove it, as needed.
            this.getEmpDetailsTableAdapter.Fill(this.empDataSet.GetEmpDetails);
            comboBoxDept.SelectedIndex = 0;

        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.getEmpDetailsTableAdapter.Fill(this.empDataSet.GetEmpDetails);

        }
    }
}
