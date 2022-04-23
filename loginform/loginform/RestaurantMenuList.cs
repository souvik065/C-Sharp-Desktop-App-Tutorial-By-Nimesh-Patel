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
    public partial class RestaurantMenuList : Form
    {
        int total = 0;
        public RestaurantMenuList()
        {
            InitializeComponent();
        }

        private void RestaurantMenuList_Load(object sender, EventArgs e)
        {
            category.Items.Add("Punjabi");
            category.Items.Add("South Indian");
            category.Items.Add("North Indian");
            category.Items.Add("Chines");

        }

 
        private void simpleCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleCalculator simpcal = new SimpleCalculator();
            simpcal.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.ShowDialog();
        }

        private void restaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurantMenuList res = new RestaurantMenuList();
            res.ShowDialog();
        }

        private void dishes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            labelcategory.Text = category.SelectedItem.ToString();
            labeldishname.Text = dishes.SelectedItem.ToString();


            if (labeldishname.Text == "Punjabi Thali")
            {
                labelrate.Text = "150";
            }
            else if (labeldishname.Text == "Punjabi lassi")
            {
                labelrate.Text = "80";
            }
            else if (labeldishname.Text == "Amritsari Kulcha")
            {
                labelrate.Text = "60";
            }
            else if (labeldishname.Text == "Chhole-Bhature")
            {
                labelrate.Text = "50";
            }
            else if (labeldishname.Text == "Amritsari Kulcha")
            {
                labelrate.Text = "70";
            }
            else if (labeldishname.Text == "Tandoori Chicken")
            {
                labelrate.Text = "150";
            }
            else if (labeldishname.Text == "Gobhi-Shalgam-Gajar Pickle")
            {
                labelrate.Text = "110";
            }
            else if (labeldishname.Text == "Chicken Chettinad")
            {
                labelrate.Text = "120";
            }
            else if (labeldishname.Text == "Andhra Style")
            {
                labelrate.Text = "100";
            }
            else if (labeldishname.Text == "Masala Dosa")
            {
                labelrate.Text = "40";
            }
            else if (labeldishname.Text == "Rogan Josh")
            {
                labelrate.Text = "75";
            }
            
        }

        private void category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dishes.Items.Clear();

            if (category.SelectedItem == "Punjabi")
            {
                dishes.Items.Add("Punjabi Thali");

                dishes.Items.Add("Punjabi lassi");
                dishes.Items.Add("Amritsari Kulcha");
                dishes.Items.Add("Chhole-Bhature");
                dishes.Items.Add("Tandoori Chicken");
                dishes.Items.Add("Gobhi-Shalgam-Gajar Pickle");
            }
            else if (category.SelectedItem == "South Indian")
            {
                dishes.Items.Add("Chicken Chettinad");
                dishes.Items.Add("Andhra Style");
                dishes.Items.Add("Masala Dosa");

            }
            else if (category.SelectedItem == "North Indian")
            {
                dishes.Items.Add("Rogan Josh");
                dishes.Items.Add("Aloo Samosa");
                dishes.Items.Add("Chicken Dum Biryani");
            }
            else if (category.SelectedItem == "Chines")
            {
                dishes.Items.Add("Dim sums");
                dishes.Items.Add("Szechwan Chilli Chicken");
                dishes.Items.Add("Spring Rolls");
            }
        }

        private void orderlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderlist.SelectedItem == "Punjabi Thali")
            {
                labelrate.Text = "150";
            }
            else if (orderlist.SelectedItem == "Punjabi lassi")
            {
                labelrate.Text = "80";
            }
            else if (orderlist.SelectedItem == "Amritsari Kulcha")
            {
                labelrate.Text = "60";
            }
            else if (orderlist.SelectedItem == "Chhole-Bhature")
            {
                labelrate.Text = "50";
            }
            else if (orderlist.SelectedItem == "Amritsari Kulcha")
            {
                labelrate.Text = "70";
            }
            else if (orderlist.SelectedItem == "Tandoori Chicken")
            {
                labelrate.Text = "150";
            }
            else if (orderlist.SelectedItem == "Gobhi-Shalgam-Gajar Pickle")
            {
                labelrate.Text = "110";
            }
            else if (orderlist.SelectedItem == "Chicken Chettinad")
            {
                labelrate.Text = "120";
            }
            else if (orderlist.SelectedItem == "Andhra Style")
            {
                labelrate.Text = "100";
            }
            else if (orderlist.SelectedItem == "Masala Dosa")
            {
                labelrate.Text = "40";
            }
            else if (orderlist.SelectedItem == "Rogan Josh")
            {
                labelrate.Text = "75";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            orderlist.Items.Add(dishes.SelectedItem);
            total = total + Convert.ToInt32(labelrate.Text);
            totalamount.Text = Convert.ToString(total);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (orderlist.SelectedItem == "Punjabi Thali")
            {
                labelrate.Text = "150";
                orderlist.Items.Remove(orderlist.SelectedItem);
                total = total - Convert.ToInt32(labelrate.Text);
                totalamount.Text = Convert.ToString(total);

            }
            else if (orderlist.SelectedItem == "Punjabi lassi")
            {
                labelrate.Text = "80";
                orderlist.Items.Remove(orderlist.SelectedItem);
                total = total - Convert.ToInt32(labelrate.Text);
                totalamount.Text = Convert.ToString(total);
            }
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            ftotal.Text = totalamount.Text;
            gst.Text = Convert.ToString(Convert.ToInt32(ftotal.Text) * 18 / 100);
            finalamount.Text = Convert.ToString(Convert.ToInt32(ftotal.Text) + Convert.ToInt32(gst.Text));
        }
    }
}
    

