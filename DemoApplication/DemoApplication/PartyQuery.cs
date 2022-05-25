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
    public partial class PartyQuery : Form
    {
        DataSet ds;
        QueryCalss q1 = new QueryCalss();
        public PartyQuery()
        {
            InitializeComponent();
        }

       
        public void ListAllParty()
        {
            ds = q1.ViewCommand("SELECT PARTYID,PARTYNAME FROM PARTYMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBoxPartyID.DataSource = ds.Tables[0];
                comboBoxPartyID.DisplayMember = "PARTYNAME";
                comboBoxPartyID.ValueMember = "PARTYID";
                comboBoxPartyID.SelectedIndex = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = q1.ViewCommand("SELECT PARTYID,EXPENSEDATE,EXPENSECATEGORY FROM EXPENSEMASTER WHERE EXPENSEDATE BETWEEN '"+dateTimePickerSatrtDate.Text+"' AND '"+dateTimePickerEndDate.Text+"' AND PARTYID = "+comboBoxPartyID.SelectedValue+" ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PartyQuery_Load(object sender, EventArgs e)
        {
            ListAllParty();
        }
    }
}
