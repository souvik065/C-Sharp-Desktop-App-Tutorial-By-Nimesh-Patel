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
    public partial class FrmExpenseMaster : Form
    {
        QueryCalss q1 = new QueryCalss();
        DataSet ds;
        public FrmExpenseMaster()
        {
            InitializeComponent();
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
            dateTimePickerExpenseDate.Text = "";
            comboBoxExpenseCategory.SelectedIndex = -1;
            comboBoxPartyID.SelectedIndex = -1;
            comboBoxSourceID.SelectedIndex = -1;
            txtAmount.Clear();
            comboBoxPaymentMode.SelectedIndex = -1;
            txtReference.Clear();
            dateTimePickerExpenseDate.Text = "";
            richTextBoxRemark.Clear();
        }

        public void ReView()
        {
            ds = q1.ViewCommand("SELECT * FROM EXPENSEMASTER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("INSERT INTO EXPENSEMASTER (EXPENSEDATE,EXPENSECATEGORY,PARTYID,SOURCEID,AMOUNT,PAYMENTMODE,REFERENCE,CHEQUEDATE,REMARK) VALUES('" + dateTimePickerExpenseDate.Text + "','" + comboBoxExpenseCategory.Text + "',"+comboBoxPartyID.SelectedValue+","+comboBoxSourceID.SelectedValue+","+txtAmount.Text+",'"+comboBoxPaymentMode.Text+"','"+txtReference.Text+"','"+dateTimePickerChequeDate.Text+"','"+richTextBoxRemark.Text+"')");
            q1.InsertMessage();

            Reset();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ReView();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("UPDATE EXPENSEMASTER SET EXPENSEDATE ='" + dateTimePickerExpenseDate.Text + "', EXPENSECATEGORY = '" + comboBoxExpenseCategory.Text + "', PARTYID = " + comboBoxPartyID.SelectedValue + ", SOURCEID = " + comboBoxSourceID.SelectedValue + ", AMOUNT = " + txtAmount.Text + " , PAYMENTMODE = '" + comboBoxPaymentMode.Text + "', REFERENCE = '" + txtReference.Text + "' , CHEQUEDATE = '" + dateTimePickerChequeDate.Text + "' ,REMARK =  '" + richTextBoxRemark.Text + "' WHERE EXPENSEID = "+dateTimePickerExpenseDate.Tag+" ");
            q1.UpdateMessage();

            Reset();
        }

       
        private void FrmExpenseMaster_Load(object sender, EventArgs e)
        {
            ListAllParty();
            ListAllSource();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePickerExpenseDate.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePickerExpenseDate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxExpenseCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxPartyID.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxSourceID.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxPaymentMode.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtReference.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePickerChequeDate.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            richTextBoxRemark.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            q1.ExeCommand("DELETE FROM EXPENSEMASTER WHERE EXPENSEID = "+dateTimePickerExpenseDate.Tag+" ");
            q1.DeleteMessage();

            ReView();
            Reset();
        }
    }
}
