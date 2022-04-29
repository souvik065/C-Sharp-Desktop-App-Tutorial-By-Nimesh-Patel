using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace RDBMSExercise
{
    class sqlmethods
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KP7KMGJ;Initial Catalog=RDBMSExercise;User ID=sa;Password=123456");
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
            cmd = new SqlCommand(qr, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void InsertMessage()
        {
            MessageBox.Show("Inserted Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information); 
        }

        public void UpdateMessage()
        {
            MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteMessage()
        {
            MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
