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
    }
}
