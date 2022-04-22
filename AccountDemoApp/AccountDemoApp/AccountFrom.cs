using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountDemoApp
{
    public partial class AccountFrom : Form
    {
        public AccountFrom()
        {
            InitializeComponent();
        }
        Account a;                   // a is refrence variable of type account.
                                    // a = null;
                                    
        private void AccountFrom_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = a.Id.ToString();
            txtname.Text = a.Name.ToString();
            txtbalance.Text = a.Balance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtid.Text);
            a.Name = txtname.Text;
            a.Balance = decimal.Parse(txtbalance.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Account();                      //a = new Account(); //1. Account object is created on heap.
                                                                        //2. All Member of the account object are allocated memory.
                                                                        //3. All Member are by default initialized based on datatype.
                                                                        //4. 'new' operator it return the  reference to the account object.
                                                                        //5. Assigned to "a".
                                                    //HENCE 'a' is reference to Account Object.
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtbalance.Text = "";
        }

        private void btndestroy_Click(object sender, EventArgs e)
        {
            a = null;
        }

        private void btngc_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
