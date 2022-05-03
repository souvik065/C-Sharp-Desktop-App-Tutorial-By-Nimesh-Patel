using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace DemoApplication
{
    class QueryCalss
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KP7KMGJ;Initial Catalog=DemoApplicationInC#;User ID=sa;Password=123456");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        
        public void ExeCommand(string qr)
        {
            con.Open();
            cmd = new SqlCommand(qr,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet ViewCommand(string qr)
        {
            ds = new DataSet();
            con.Open();
            cmd = new SqlCommand(qr,con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            con.Close();
            return ds;
        }

        public void InsertMessage()
        {
            MessageBox.Show("Inserted Successfully");
        }

        public void UpdateMessage()
        {
            MessageBox.Show("Updated Successfully");
        }

        public void DeleteMessage()
        {
            MessageBox.Show("Deleted Successfully");
        }
    }
}
