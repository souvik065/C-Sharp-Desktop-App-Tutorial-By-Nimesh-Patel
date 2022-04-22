using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtresult.Text= Convert.ToString( decimal.Parse(txtvalueA.Text) + decimal.Parse(txtvalueB.Text));
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            txtresult.Text = Convert.ToString(decimal.Parse(txtvalueA.Text) - decimal.Parse(txtvalueB.Text));
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            txtresult.Text = Convert.ToString(decimal.Parse(txtvalueA.Text) * decimal.Parse(txtvalueB.Text));
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            txtresult.Text = Convert.ToString(decimal.Parse(txtvalueA.Text) / decimal.Parse(txtvalueB.Text));
        }
    }
}
