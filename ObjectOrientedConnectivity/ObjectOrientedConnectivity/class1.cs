using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace ObjectOrientedConnectivity
{
    class class1
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KP7KMGJ;Initial Catalog=ObjectOrientedConnectivity;User ID=sa;Password=123456");


        public void ExeCommand(String str)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(str,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataSet viewData(String str)
        {
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void Insertmesage()
        {
            MessageBox.Show("Inserteed Successfully","Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void Updatemessage()
        {
            MessageBox.Show("Updated Successfully","Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void Deleteemessage()
        {
            MessageBox.Show("Deleted Successfully", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
