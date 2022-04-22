using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemoApp
{
    class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;

        public Account()
        {
            System.Windows.Forms.MessageBox.Show("Object Created");
        }

        ~Account()
        {
            System.Windows.Forms.MessageBox.Show("Object Destroyed");
        }

    }
}
