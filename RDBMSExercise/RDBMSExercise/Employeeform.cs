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
            }


            
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("INSERT INTO EMP(EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) VALUES("+txtempno.Text+",'"+txtename.Text.ToUpper()+"','"+txtjob.Text.ToUpper()+"',"+comboBoxmgr.SelectedValue+",'"+dateTimePickerhiredate.Text+"',"+txtsal.Text+","+txtcomm.Text+","+comboBoxdeptno.SelectedValue+")");
            s1.InsertMessage();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ds = s1.ViewCommand("SELECT * FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void comboBoxmgr_MouseClick(object sender, MouseEventArgs e)
        {
            ds = s1.ViewCommand("SELECT EMPNO,ENAME FROM EMP");
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBoxmgr.DataSource = ds.Tables[0];
                comboBoxmgr.DisplayMember = "ENAME";
                comboBoxmgr.ValueMember = "EMPNO";
            }
        }
    }
}
