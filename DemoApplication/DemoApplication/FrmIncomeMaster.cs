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
    public partial class FrmIncomeMaster : Form
    {
        QueryCalss q1 = new QueryCalss();
        DataSet ds;
        public FrmIncomeMaster()
        {
            InitializeComponent();
        }

        public void ReView()
        {
            ds = q1.ViewCommand("SELECT * FROM INCOMEMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ListAllSource()
        {
            ds = q1.ViewCommand("SELECT SOURCEID,SOURCENAME FROM SOURCEMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBoxSourceID.DataSource = ds.Tables[0];
                comboBoxSourceID.DisplayMember = "SOURCENAME";
                comboBoxSourceID.ValueMember = "SOURCEID";
                comboBoxSourceID.SelectedIndex = -1;
            }
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

        public void Reset()
        {
            dateTimePickerIncomeDate.Text = "";
            comboBoxPartyID.SelectedIndex = -1;
            comboBoxSourceID.SelectedIndex = -1;
            txtAmount.Clear();
            comboBoxPaymentMode.SelectedIndex = -1;
            txtReference.Clear();
            dateTimePickerChequeDate.Text = "";
            richTextBoxRemark.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxPartyID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmIncomeMaster_Load(object sender, EventArgs e)
        {
            ListAllSource();
            ListAllParty();

            dateTimePickerIncomeDate.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("INSERT INTO INCOMEMASTER (INCOMEDATE,PARTYID,SOURCEID,AMOUNT,PAYMENTMODE,REFERENCE,CHEQUEDATE,REMARK) VALUES('"+dateTimePickerIncomeDate.Text+"',"+comboBoxPartyID.SelectedValue+","+comboBoxSourceID.SelectedValue+","+txtAmount.Text+",'"+comboBoxPaymentMode.Text+"','"+txtReference.Text+"','"+dateTimePickerChequeDate.Text+"','"+richTextBoxRemark.Text+"')");
            q1.InsertMessage();

            ReView();
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ReView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("UPDATE INCOMEMASTER SET INCOMEDATE = '" + dateTimePickerIncomeDate.Text + "',PARTYID = " + comboBoxPartyID.SelectedValue + ",SOURCEID = " + comboBoxSourceID.SelectedValue + ",AMOUNT ='" + txtAmount.Text + "',PAYMENTMODE = '" + comboBoxPaymentMode.Text + "', REFERENCE = '" + txtReference.Text + "', CHEQUEDATE = '" + dateTimePickerChequeDate.Text + "', REMARK = '" + richTextBoxRemark.Text + "' WHERE INCOMEID = " + dateTimePickerIncomeDate.Tag + " ");
            q1.UpdateMessage();

            ReView();
            Reset();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePickerIncomeDate.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePickerIncomeDate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxPartyID.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxSourceID.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxPaymentMode.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtReference.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerChequeDate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            richTextBoxRemark.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("DELETE FROM INCOMEMASTER WHERE INCOMEID = "+dateTimePickerIncomeDate.Tag+"");
            q1.DeleteMessage();

            ReView();
            Reset();
        }
    }
}
