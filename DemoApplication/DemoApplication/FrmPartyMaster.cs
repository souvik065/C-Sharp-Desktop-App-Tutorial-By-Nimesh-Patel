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

        public void Reset()
        {
            txtPartyName.Clear();
            richTextBoxAddress.Clear();
            txtMobileNo.Clear();
        }

        public void ReView()
        {
            ds = q1.ViewCommand("SELECT * FROM PARTYMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("INSERT INTO PARTYMASTER(PARTYNAME,ADDRESS,MOBILENO) VALUES('"+txtPartyName.Text+"','"+richTextBoxAddress.Text+"',"+txtMobileNo.Text+")");
            q1.InsertMessage();

            ReView();
            Reset();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("UPDATE PARTYMASTER SET PARTYNAME = '"+txtPartyName.Text+"',ADDRESS = '"+richTextBoxAddress.Text+"',MOBILENO = "+txtMobileNo.Text+" ");
            q1.UpdateMessage();

            ReView();

            Reset();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            ReView();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPartyName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPartyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMobileNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("DELETE FROM PARTYMASTER WHERE PARTYID = "+txtPartyName.Tag+"");
            q1.DeleteMessage();

            txtPartyName.Clear();
            richTextBoxAddress.Clear();
            txtMobileNo.Clear();

            ReView();
            Reset();
        }

        private void FrmPartyMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
