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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void dialogBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepade note = new Notepade();
            note.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void simpleCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleCalculator sc = new SimpleCalculator();
            sc.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.ShowDialog();
        }

        private void restaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurantMenuList res = new RestaurantMenuList();
            res.ShowDialog();
        }
    }
}
