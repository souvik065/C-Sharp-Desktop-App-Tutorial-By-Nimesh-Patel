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

namespace RDBMSExercise
{
    public partial class Departmentform : Form
    {
        sqlmethods s1 = new sqlmethods();
        DataSet ds;
        public Departmentform()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("INSERT INTO DEPT(DEPTNO,DNAME,LOC) VALUES("+txtdeptno.Text+",'"+txtdeptname.Text+"','"+txtdeptloc.Text+"')");
            s1.InsertMessage();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("UPDATE DEPT SET DEPTNO = "+txtdeptno.Text+",DNAME = '"+txtdeptname.Text+"',LOC = '"+txtdeptloc.Text+"'");
            s1.UpdateMessage();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ds = s1.ViewCommand("SELECT * FROM DEPT");
            if(ds.Tables[0].Rows.Count  > 0 )
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtdeptno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdeptname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdeptloc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("DELETE FROM DEPT WHERE DEPTNO = " + txtdeptno.Text + "");
            s1.DeleteMessage();
        }
    }
}
