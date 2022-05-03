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
    public partial class Productform1 : Form
    {
        sqlmethods s1 = new sqlmethods();
        DataSet ds;
        public Productform1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtprodid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdescrip.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("INSERT INTO PRODUCT (PRODID,DESCRIP) VALUES("+txtprodid.Text+",'"+txtdescrip.Text.ToUpper()+"')");
            s1.InsertMessage();

            ds = s1.ViewCommand("SELECT * FROM PRODUCT");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ds = s1.ViewCommand("SELECT * FROM PRODUCT");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("UPDATE PRODUCT SET DESCRIP = '"+txtdescrip.Text.ToUpper()+"' WHERE PRODID = "+txtprodid.Text+"");
            s1.UpdateMessage();

            ds = s1.ViewCommand("SELECT * FROM PRODUCT");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            s1.ExeCommand("DELETE FROM PRODUCT WHERE PRODID = "+txtprodid.Text+"");
            s1.DeleteMessage();

            ds = s1.ViewCommand("SELECT * FROM PRODUCT");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
