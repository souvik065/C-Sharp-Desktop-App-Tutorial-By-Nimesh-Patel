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
    public partial class FrmItemForm : Form
    {
        DataSet ds;
        sqlmethods s1 = new sqlmethods();
        public FrmItemForm()
        {
            InitializeComponent();
        }

        public void CalculateTotalAmount()
        {
            txtTotalAmountOfProduct.Clear();
            txtTotalAmountOfProduct.Text = Convert.ToString(Convert.ToDecimal(txtActualPrice.Text) * Convert.ToDecimal(txtQty.Text));
        }

        public void ReView()
        {
            ds = s1.ViewCommand("SELECT ORDID,ITEMID,PRODID,ACTUALPRICE,QTY,ITEMTOT FROM ITEM  ");
            //INNER JOIN PRODUCT ON ITEM.PRODID = PRODUCT.PRODID
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        public void ListAllORDID()
        {
            ds = s1.ViewCommand("SELECT ORDID FROM ORD");
            if (ds.Tables[0].Rows.Count > 0)
            {
                comboBoxORDID.DataSource = ds.Tables[0];
                comboBoxORDID.DisplayMember = "ORDID";
                comboBoxORDID.ValueMember = "ORDID";
                comboBoxORDID.SelectedIndex = -1;
            }
        }

        public void ListAllPRODID()
        {
            ds = s1.ViewCommand("SELECT PRODID,DESCRIP FROM PRODUCT");
            if (ds.Tables[0].Rows.Count > 0)
            { 
                comboBoxPRODID.DataSource = ds.Tables[0];
                comboBoxPRODID.ValueMember = "PRODID";
                comboBoxPRODID.DisplayMember = "DESCRIP";
                comboBoxPRODID.SelectedIndex = -1;
            }
        }

        private void FrmItemForm_Load(object sender, EventArgs e)
        {
            ListAllORDID();
            ListAllPRODID();
        }

        public void Reset()
        {
            comboBoxORDID.SelectedIndex = -1;
            comboBoxPRODID.SelectedIndex = -1;
            txtActualPrice.Clear();
            txtQty.Clear();
            txtTotalAmountOfProduct.Clear();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("INSERT INTO ITEM (ORDID,PRODID,ACTUALPRICE,QTY,ITEMTOT) VALUES("+comboBoxORDID.SelectedValue+","+comboBoxPRODID.SelectedValue+","+txtActualPrice.Text+","+txtQty.Text+","+txtTotalAmountOfProduct.Text+")");
            s1.InsertMessage();
            Reset();
            ReView();
        }

        private void txtTotalAmountOfProduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ReView();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("UPDATE ITEM SET ORDID = "+comboBoxORDID.SelectedValue+", PRODID = "+comboBoxPRODID.SelectedValue+",ACTUALPRICE = "+txtActualPrice.Text+",QTY = "+txtQty.Text+",ITEMTOT = "+txtTotalAmountOfProduct.Text+" WHERE ITEMID = "+comboBoxORDID.Tag+" ");
            s1.UpdateMessage();
            Reset();
            ReView();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxORDID.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxORDID.Tag = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxPRODID.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtActualPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTotalAmountOfProduct.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("DELETE FROM ITEM WHERE ITEMID = "+comboBoxORDID.Tag+" ");
            s1.DeleteMessage();
            Reset();
            ReView();
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

        private void btnCal_Click(object sender, EventArgs e)
        {
            txtTotalAmountOfProduct.Clear();
            txtTotalAmountOfProduct.Text = Convert.ToString(Convert.ToDecimal(txtActualPrice.Text) * Convert.ToDecimal(txtQty.Text));
        }

        private void customerDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }


    }
}
