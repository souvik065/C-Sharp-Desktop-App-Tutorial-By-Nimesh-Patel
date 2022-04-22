using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total.Text = Convert.ToString(Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total.Text = Convert.ToString(Convert.ToInt32(txtA.Text) - Convert.ToInt32(txtB.Text));
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total.Text = Convert.ToString(Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total.Text = Convert.ToString(Convert.ToDouble(txtA.Text) / Convert.ToDouble(txtB.Text));
        }
    }
}