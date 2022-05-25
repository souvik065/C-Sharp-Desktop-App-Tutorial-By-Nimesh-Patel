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
    public partial class Customerform : Form
    {
        sqlmethods s1 = new sqlmethods();
        DataSet ds;

        public Customerform()
        {
            InitializeComponent();
        }

        public void ReView()
        {
            ds = s1.ViewCommand("SELECT CUSTID,NAME,ADDRESS,CITY,STATE,ZIP,AREA,PHONE,REPID,CREDITLIMIT,COMMENTS FROM CUSTOMER INNER JOIN EMP ON CUSTOMER.REPID = EMP.EMPNO ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        public void Reset()
        {
            txtName.Clear();
            richTextBoxAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtArea.Clear();
            txtPhone.Clear();
            comboBoxRepID.SelectedIndex = -1;
        }


        public void ListAllRepID()
        {
            DataSet ds;
            ds = s1.ViewCommand("SELECT EMPNO,ENAME FROM EMP");
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBoxRepID.DataSource = ds.Tables[0];
                comboBoxRepID.DisplayMember = "ENAME";
                comboBoxRepID.ValueMember = "EMPNO";
                comboBoxRepID.SelectedIndex = -1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("INSERT INTO CUSTOMER (NAME,ADDRESS,CITY,STATE,ZIP,AREA,PHONE,REPID) VALUES('"+txtName.Text+"','"+richTextBoxAddress.Text+"','"+txtCity.Text+"','"+txtState.Text+"',"+txtZip.Text+",'"+txtArea.Text+"',"+txtPhone.Text+","+comboBoxRepID.SelectedValue+")");
            s1.InsertMessage();

            ReView();
            Reset();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            ReView();
        }

        private void Customerform_Load(object sender, EventArgs e)
        {
            ListAllRepID();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("UPDATE CUSTOMER SET NAME = '" + txtName.Text + "', ADDRESS = '" + richTextBoxAddress.Text + "', CITY = '" + txtCity.Text + "', STATE = '" + txtState.Text + "', ZIP = " + txtZip.Text + ", AREA = '" + txtArea.Text + "', PHONE = " + txtPhone.Text + ",REPID = " + comboBoxRepID.SelectedValue + " , CREDITLIMIT = " + txtCreditLimit.Text + ", COMMENTS = '" + richTextBoxComments.Text + "' WHERE CUSTID = " + txtName.Tag + " ");
            s1.UpdateMessage();

            ReView();
            Reset();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("DELETE FROM CUSTOMER WHERE CUSTID = "+txtName.Tag+" ");
            s1.DeleteMessage();

            ReView();
            Reset();
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtState.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtZip.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtArea.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxRepID.SelectedValue = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtCreditLimit.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            richTextBoxComments.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
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

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRepID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
