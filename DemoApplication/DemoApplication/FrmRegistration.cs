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

    public partial class FrmRegistration : Form
    {
        DataSet ds;
        QueryCalss q1 = new QueryCalss();
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmpassword.Text == "")
            {
                MessageBox.Show("Username and Password Field are Emplty","Registration Failed!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == txtConfirmpassword.Text)
            {
                q1.ExeCommand("INSERT INTO USERDATA (USERNAME,PASSWORD) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')");
                MessageBox.Show("Registered Successfully...");


            }
            else
            {

                MessageBox.Show("Password are not macthing, Re-enter the password", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmpassword.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.ShowDialog();
            this.Close();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
