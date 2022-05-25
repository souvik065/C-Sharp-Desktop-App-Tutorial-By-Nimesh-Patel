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
    public partial class FrmIncomeQuery : Form
    {
        DataSet ds;
        QueryCalss q1 = new QueryCalss();
        public FrmIncomeQuery()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = q1.ViewCommand("SELECT * FROM INCOMEMASTER WHERE INCOMEDATE BETWEEN '"+dateTimePickerSatrtDate.Text+"' AND '"+dateTimePickerEndDate.Text+"' ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
