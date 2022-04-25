using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace loginform
{
    public partial class Connectivity : Form
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-kp7kmgj;Initial Catalog=demo;User ID=sa;Password=123456");
        public Connectivity()
        {
            InitializeComponent();
        }

        private void Connectivity_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO EmpMaster(Name,Address,MobileNo)Values('"+txtName.Text+"','"+txtAddress.Text+"','"+txtMobileNo.Text+"')",con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            lblmsg.Text = "Inserted!....1";
        }
    }
}
