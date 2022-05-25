using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class FrmSource : Form
    {
        QueryCalss q1 = new QueryCalss();
        DataSet ds;
        public FrmSource()
        {
            InitializeComponent();
        }

        public void ReView()
        {
            ds = q1.ViewCommand("SELECT * FROM SOURCEMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("INSERT INTO SOURCEMASTER(SOURCENAME) VALUES('"+txtSourceName.Text+"') ");
            q1.InsertMessage();

            ReView();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ReView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("UPDATE SOURCEMASTER SET SOURCENAME = '"+txtSourceName.Text+"' WHERE SOURCEID = "+txtSourceName.Text+"");
            q1.UpdateMessage();

            txtSourceName.Clear();

            ReView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("DELETE FROM SOURCEMASTER WHERE SOURCEID = "+txtSourceName.Tag+"");

            txtSourceName.Clear();

            ReView();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSourceName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSourceName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
