using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPPracticeSession2
{
    public partial class FrmSubCategory : Form
    {
        public FrmSubCategory()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("InsertSubCategoryDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYID", comboBoxCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUBCATEGORYNAME", txtSubCategory.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryMaster.GetSubCategoryDetails);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }


        private void Update()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateSubCategoryDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUBCATEGORYID", txtSubCategory.Tag).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@CATEGORYID", comboBoxCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUBCATEGORYNAME", txtSubCategory.Text).DbType = DbType.String;

            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryMaster.GetSubCategoryDetails);

        }

        private void Delete()
        {
            SqlMethods.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteSubCategoryDetails", SqlMethods.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SUBCATEGORYID", txtSubCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SqlMethods.con.Close();

            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryMaster.GetSubCategoryDetails);
        }

        private void FillData()
        {
            txtSubCategory.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxCategoryName.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSubCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }



       

        private void FrmSubCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subCategoryMaster.GetSubCategoryDetails' table. You can move, or remove it, as needed.
            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryMaster.GetSubCategoryDetails);
            // TODO: This line of code loads data into the 'listCategoryNames.ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryNames.ListCategoryDetails);

            //comboBoxCategoryName.SelectedIndex = 0;

        }

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryMaster.GetSubCategoryDetails);
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }
    }
}
