﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        decimal old;
        string flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            result.Text += btn0.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            
            result.Text += btndot.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            result.Text += btn3.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            result.Text += btn6.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            result.Text += btn2.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            result.Text += btn5.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            result.Text += btn1.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            result.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            result.Text += btn4.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            result.Text += btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            result.Text += btn7.Text;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            //result.Text += btnmulti.Text;
            old = Convert.ToDecimal(result.Text);
            result.Text = "";
            flag = "multi";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            //result.Text += btnsub.Text;
            old = Convert.ToDecimal(result.Text);
            result.Text = "";
            flag = "sub";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            //result.Text += btndivide.Text;
            old = Convert.ToDecimal(result.Text);
            result.Text = "";
            flag = "divide";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //result.Text += btnadd.Text;
            old = Convert.ToDecimal(result.Text);
            result.Text = "";
            flag = "add";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            { 
              result.Text = Convert.ToString(old + Convert.ToDecimal(result.Text));
            }
            else if (flag == "sub")
            {
                result.Text = Convert.ToString(old - Convert.ToDecimal(result.Text));
            }
            else if (flag == "divide")
            {
                result.Text = Convert.ToString(old / Convert.ToDecimal(result.Text));
            }
            else if (flag == "multi")
            {
                result.Text = Convert.ToString(old * Convert.ToDecimal(result.Text));
            }
        }

        private void btncube_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(Math.Ceiling(Math.Pow(Convert.ToInt32(result.Text),(double)1/3)));
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(Math.Sqrt(Convert.ToInt32(result.Text)));
        }
    }
}