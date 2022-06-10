﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }


        //MDI Parent UI Design
        public void CustomizeDesign()
        {
            MastersSubPanel.Visible = false;
            
        }


        public void HideSubMenu()
        {
            if (MastersSubPanel.Visible == true)
                MastersSubPanel.Visible = false;
        }

        public void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            Bodypanel.Controls.Add(childFrom);
            Bodypanel.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        //-------------------------------------------------------------------------------------------------------------------------------





        //Other Default Features in MDI
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

       //---------------------------------------------------------------------------------------------------------------

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCategory());
            HideSubMenu();

            
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSubCategory());
            HideSubMenu();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProductMasterAndDetails());
            HideSubMenu();
        }

        

        private void btnMaster_Click(object sender, EventArgs e)
        {
            ShowSubMenu(MastersSubPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSupplierMaster());
            HideSubMenu();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
