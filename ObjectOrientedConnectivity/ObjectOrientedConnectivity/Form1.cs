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
namespace ObjectOrientedConnectivity
{
    public partial class Form1 : Form
    {
        class1 obj = new class1();
        DataSet ds = new System.Data.DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            obj.ExeCommand("INSERT INTO EmployeeDetail(EMPNAME,EMPDEPT,SALARY) VALUES('"+txtempname.Text+"','"+txtdept.Text+"',"+txtsalary.Text+")");
            obj.Insertmesage();
            txtempname.Clear();
            txtdept.Clear();
            txtsalary.Clear();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ds = obj.viewData("SELECT * FROM EmployeeDetail");
            if (ds.Tables[0].Rows.Count > 0)
            { 
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            obj.ExeCommand("UPDATE EmployeeDetail SET EMPNAME = '"+txtempname.Text+"',EMPDEPT = '"+txtdept.Text+"',SALARY="+txtsalary.Text+" WHERE EMPID = "+txtempname.Tag+"");
            obj.Updatemessage();
            txtempname.Clear();
            txtdept.Clear();
            txtsalary.Clear();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            obj.ExeCommand("DELETE FROM EmployeeDetail WHERE EMPID = "+txtempname.Tag+"");
            obj.Deleteemessage();
            txtempname.Clear();
            txtdept.Clear();
            txtsalary.Clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtempname.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtempname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdept.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsalary.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
