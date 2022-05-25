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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Insert()
        {
            Global.con.Open();
            SqlCommand cmd = new SqlCommand("EmpInsert", Global.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ENAME", txtFullName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@DEPARTMENT", txtDept.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@ADDRESS", richTextBoxAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@SALARY", txtSal.Text).DbType = DbType.Decimal;
            cmd.ExecuteNonQuery();
            lblmsg.Text = "INSERTED!!!!!";
            Global.con.Close();
            this.empGetTableAdapter.Fill(this.dsEmpGet.EmpGet);

        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEmpGet.EmpGet' table. You can move, or remove it, as needed.
            this.empGetTableAdapter.Fill(this.dsEmpGet.EmpGet);

        }
    }
}
