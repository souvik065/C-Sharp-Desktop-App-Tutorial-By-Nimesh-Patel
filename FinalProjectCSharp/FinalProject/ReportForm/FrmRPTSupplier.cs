using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.ReportForm
{
    public partial class FrmRPTSupplier : Form
    {
        public FrmRPTSupplier()
        {
            InitializeComponent();
        }

        private void FrmRPTSupplier_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
