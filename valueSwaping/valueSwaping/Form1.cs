using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valueSwaping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();


        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void btnremove2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnshiftright_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnshiftleft_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems);
                listBox2.Items.Remove(listBox2.SelectedItems);
            }
        }

        private void multishiftright_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems);
                listBox1.Items.Remove(listBox1.SelectedItems);
            }
        }

        private void multishiftleft_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItems);
            listBox2.Items.Remove(listBox2.SelectedItems);
        }

        private void shiftalltoright_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void shiftalltoleft_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
