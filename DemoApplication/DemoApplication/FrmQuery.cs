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
    public partial class FrmQuery : Form
    {
        DataSet ds;
        QueryCalss q1 = new QueryCalss();
        public FrmQuery()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = q1.ViewCommand("SELECT EXPENSEID,EXPENSEDATE,PARTYID,SOURCEID FROM EXPENSEMASTER WHERE EXPENSEDATE BETWEEN '"+dateTimePickerSatrtDate.Text+"' AND '"+dateTimePickerEndDate.Text+"' ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
