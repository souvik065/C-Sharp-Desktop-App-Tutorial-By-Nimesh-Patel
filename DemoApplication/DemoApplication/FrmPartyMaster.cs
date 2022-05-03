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
    public partial class FrmPartyMaster : Form
    {
        QueryCalss q1 = new QueryCalss();
        DataSet ds;
        public FrmPartyMaster()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("INSERT INTO PARTYMASTER(PARTYNAME,ADDRESS,MOBILENO) VALUES('"+txtPartyName.Text+"','"+txtAddress.Text+"',"+txtMobileNo.Text+")");
            q1.InsertMessage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("UPDATE PARTYMASTER SET PARTYNAME = '"+txtPartyName.Text+"',ADDRESS = '"+txtAddress.Text+"',MOBILENO = "+txtMobileNo.Text+" ");
            q1.UpdateMessage();

            txtPartyName.Clear();
            txtAddress.Clear();
            txtMobileNo.Clear();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds = q1.ViewCommand("SELECT * FROM PARTYMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPartyName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPartyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMobileNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("DELETE FROM PARTYMASTER WHERE PARTYID = "+txtPartyName.Tag+"");
            q1.DeleteMessage();
        }
    }
}
