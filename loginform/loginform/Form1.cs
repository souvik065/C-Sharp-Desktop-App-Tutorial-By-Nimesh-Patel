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
    public partial class Form1 : Form
    {
        string username = "Souvik";
        int password = 123456;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == username & txtpassword.Text == password.ToString())
            {
                MessageBox.Show("Login Successfully");
            }
        }
    }
}
