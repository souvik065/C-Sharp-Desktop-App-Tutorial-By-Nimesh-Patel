using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
                   
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            richTextBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void btncut_Click(object sender, EventArgs e)
        {
           // Clipboard.SetData(DataFormats.Text,richTextBox1.SelectedText);
            richTextBox1.Cut();
        }

        private void btnpaste_Click(object sender, EventArgs e)
        {
           // richTextBox1.Text = Clipboard;
            richTextBox1.Paste();
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
    }
}
