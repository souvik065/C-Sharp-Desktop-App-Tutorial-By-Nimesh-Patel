using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDBMSExercise
{
    public partial class Employeeform : Form
    {
        sqlmethods s1 = new sqlmethods();
        DataSet ds;
        public Employeeform()
        {
            InitializeComponent();
        }

        private void Employeeform_Load(object sender, EventArgs e)
        {
            ds = s1.ViewCommand("SELECT DEPTNO,DNAME FROM DEPT");
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                comboBoxdeptno.DataSource = ds.Tables[0];
                comboBoxdeptno.DisplayMember = "DNAME";
                comboBoxdeptno.ValueMember = "DEPTNO";
                comboBoxdeptno.SelectedIndex = -0;
                
            }

            ds = s1.ViewCommand("SELECT EMPNO,ENAME FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {

                comboBoxmgr.DataSource = ds.Tables[0];
                comboBoxmgr.DisplayMember = "ENAME";
                comboBoxmgr.ValueMember = "EMPNO";
                comboBoxmgr.SelectedIndex = -1;
            }

            txtcomm.Text ="0";
            
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
           

            s1.ExeCommand("INSERT INTO EMP(EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) VALUES("+txtempno.Text+",'"+txtename.Text.ToUpper()+"','"+txtjob.Text.ToUpper()+"',"+comboBoxmgr.SelectedValue+",'"+dateTimePickerhiredate.Text+"',"+txtsal.Text+","+txtcomm.Text+","+comboBoxdeptno.SelectedValue+")");
            s1.InsertMessage();

            ds = s1.ViewCommand("SELECT * FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            

            txtempno.Clear();
            txtcomm.Text = "0";
            txtename.Clear();
            txtjob.Clear();
            txtsal.Clear();
            comboBoxmgr.SelectedIndex = -1;
            comboBoxdeptno.SelectedIndex = -1;
            dateTimePickerhiredate.Text = "";

            ds = s1.ViewCommand("SELECT EMPNO,ENAME FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {

                comboBoxmgr.DataSource = ds.Tables[0];
                comboBoxmgr.DisplayMember = "ENAME";
                comboBoxmgr.ValueMember = "EMPNO";
                comboBoxmgr.SelectedIndex = -1;
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("UPDATE EMP SET EMPNO = "+txtempno.Text+",ENAME = '"+txtename.Text+"',JOB = '"+txtjob.Text+"',MGR = "+comboBoxmgr.SelectedValue+",HIREDATE = '"+dateTimePickerhiredate.Text+"',SAL = '"+txtsal.Text+"',COMM = '"+txtcomm.Text+"',DEPTNO = "+comboBoxdeptno.SelectedValue+" WHERE EMPNO = '"+txtempno.Text+"'");
            s1.UpdateMessage();

            ds = s1.ViewCommand("SELECT * FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ds = s1.ViewCommand("SELECT * FROM EMP ORDER BY MGR ASC");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void comboBoxmgr_MouseClick(object sender, MouseEventArgs e)
        {

           
        }

        private void txtcomm_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxdeptno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("DELETE FROM EMP WHERE EMPNO = "+txtempno.Text+" ");
            s1.DeleteMessage();
            ds = s1.ViewCommand("SELECT * FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            txtempno.Clear();
            txtcomm.Text = "0";
            txtename.Clear();
            txtjob.Clear();
            txtsal.Clear();
            comboBoxmgr.SelectedIndex = -1;
            comboBoxdeptno.SelectedIndex = -1;
            dateTimePickerhiredate.Text = "";

            ds = s1.ViewCommand("SELECT EMPNO,ENAME FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {

                comboBoxmgr.DataSource = ds.Tables[0];
                comboBoxmgr.DisplayMember = "ENAME";
                comboBoxmgr.ValueMember = "EMPNO";
                comboBoxmgr.SelectedIndex = -1;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtempno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtename.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtjob.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxmgr.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerhiredate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtcomm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxdeptno.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productform1 prod = new Productform1();
            prod.ShowDialog();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employeeform emp = new Employeeform();
            emp.ShowDialog();
        }

        private void departmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departmentform dept = new Departmentform();
            dept.ShowDialog();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customerform cust = new Customerform();
            cust.ShowDialog();
        }

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemForm item = new FrmItemForm();
            item.ShowDialog();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderForm order = new FrmOrderForm();
            order.ShowDialog();
        }
    }
}
