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
    public partial class FrmOrderForm : Form
    {
        DataSet ds;
        sqlmethods s1 = new sqlmethods();
        public FrmOrderForm()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtOrderDate.Text = "";
            comboBoxCommPlan.SelectedIndex = -1;
            comboBoxCustID.SelectedIndex = -1;
            txtShipDate.Text = "";
            txtTotal.Clear();
        }

        public void ReView()
        {
            ds = s1.ViewCommand("SELECT ORDID,ORDDATE,COMMPLAN,CUSTID,SHIPDATE,TOTAL FROM ORD");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmOrderForm_Load(object sender, EventArgs e)
        {
            comboBoxCommPlan.Items.Add("A");
            comboBoxCommPlan.Items.Add("B");
            comboBoxCommPlan.Items.Add("C");
            comboBoxCommPlan.Items.Add("D");
            comboBoxCommPlan.SelectedIndex = -1;

            ds = s1.ViewCommand("SELECT CUSTID,NAME FROM CUSTOMER");
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBoxCustID.DataSource = ds.Tables[0];
                comboBoxCustID.ValueMember = "CUSTID";
                comboBoxCustID.DisplayMember = "NAME";
                comboBoxCustID.SelectedIndex = -1;
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("INSERT INTO ORD (ORDDATE,COMMPLAN,CUSTID,SHIPDATE,TOTAL) VALUES('" + txtOrderDate.Text + "','" + comboBoxCommPlan.Text + "'," + comboBoxCustID.SelectedValue + ",'" + txtShipDate.Text + "'," + txtTotal.Text + ")");
            s1.InsertMessage();

            Reset();
            ReView();

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ReView();
            Reset();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("DELETE FROM ORD WHERE ORDID = "+txtOrderDate.Tag+"");
            s1.DeleteMessage();
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

        private void customerDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Customerform cust = new Customerform();
            cust.ShowDialog();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOrderDate.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOrderDate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxCommPlan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxCustID.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtShipDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("UPDATE ORD SET ORDDATE = '"+txtOrderDate.Text+"' , COMMPLAN = '"+comboBoxCommPlan.Text+"', CUSTID = "+comboBoxCustID.SelectedValue+", SHIPDATE = '"+txtShipDate.Text+"', TOTAL = "+txtTotal.Text+" WHERE ORDID = "+txtOrderDate.Tag+"");
            s1.UpdateMessage();
            ReView();
            Reset();

        }
    }
}
