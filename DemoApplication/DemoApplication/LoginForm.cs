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
    public partial class LoginForm : Form
    {
        DataSet ds;
        QueryCalss q1 = new QueryCalss();
        public LoginForm()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegistration reg = new FrmRegistration();
           
            reg.ShowDialog();
            this.Close();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           /* string username;
            string password;
            ds = q1.ViewCommand("SELECT *FROM USERDATA WHERE USERNAME = '"+txtUsername.Text+"' AND PASSWORD = '"+txtPassword.Text+"' ");*/
            


            ds = q1.ViewCommand("SELECT USERNAME,PASSWORD FROM USERDATA WHERE USERNAME = '" + txtUsername.Text.Trim() + "' AND PASSWORD = '" + txtPassword.Text.Trim() + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    MDIParent1 home = new MDIParent1();
                    home.ShowDialog();
                    
                    //this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect 'Username' and 'Password'. ","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnclose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
