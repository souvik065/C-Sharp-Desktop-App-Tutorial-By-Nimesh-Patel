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


namespace connectivityprog
{
    
    public partial class Form1 : Form
    {
        string gender;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KP7KMGJ;Initial Catalog=StudentMaster;User ID=sa;Password=123456");
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked == true)
            {
                gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked == true)
            {
                gender = radioButtonFemale.Text;
            }

            con.Open();
            cmd = new SqlCommand("INSERT INTO StudentRegistration(FullName,Gender,DOB,Course,Semester,Address,MobileNo) VALUES('"+txtfullname.Text+"','"+gender+"','"+dateTimePicker1.Text+"','"+comboBoxCourse.Text+"','"+comboBoxSemester.Text+"','"+richTextBoxAddress.Text+"','"+txtmobile.Text+"')",con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Data Inserted Successfully");
            txtfullname.Clear();
            gender = "";
            dateTimePicker1.Text = "";
            comboBoxCourse.Text = "";
            comboBoxSemester.Text = "";
            richTextBoxAddress.Clear();
            txtmobile.Clear();


        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBoxCourse.SelectedText == "BCA" || comboBoxCourse.SelectedText == "BBA")
           // {
                comboBoxSemester.Items.Add("SEM-1");
                comboBoxSemester.Items.Add("SEM-2");
                comboBoxSemester.Items.Add("SEM-3");
                comboBoxSemester.Items.Add("SEM-4");
                comboBoxSemester.Items.Add("SEM-5");
                comboBoxSemester.Items.Add("SEM-6");
          //  }
           // else //if(comboBoxCourse.SelectedText == "MCA" || comboBoxCourse.SelectedText == "MBA")
           // {
           /*     comboBoxSemester.Items.Clear();
                comboBoxSemester.Items.Add("SEM-1");
                comboBoxSemester.Items.Add("SEM-2");
                comboBoxSemester.Items.Add("SEM-3");
                comboBoxSemester.Items.Add("SEM-4");
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM StudentRegistration",con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            //dt = new DataTable();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            

            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked == true)
            {
                gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked == true)
            {
                gender = radioButtonFemale.Text;
            }

            con.Open();
            cmd = new SqlCommand("UPDATE StudentRegistration SET FullName = '"+txtfullname.Text+"',Gender = '"+gender+"',DOB = '"+dateTimePicker1.Text+"',Course = '"+comboBoxCourse.Text+"',Semester = '"+comboBoxSemester.Text+"',Address = '"+richTextBoxAddress.Text+"',MobileNo = '"+txtmobile.Text+"' WHERE StudentID = "+txtfullname.Tag+"",con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM StudentRegistration WHERE StudentID = "+txtfullname.Tag+"",con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtfullname.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfullname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //gender = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txtmobile.Text = gender;
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Male ")
            {
                radioButtonMale.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }



            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxCourse.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxSemester.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtmobile.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }
    }
}
