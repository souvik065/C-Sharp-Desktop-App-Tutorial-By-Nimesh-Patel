using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class MDIParent1 : Form
    {
       public MDIParent1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

       public void CustomizeDesign()
       {
           MenuSubpanel.Visible = false;
           panel2.Visible = false;
       }

       public void HideSubMenu()
       {
           if (MenuSubpanel.Visible == true)
               MenuSubpanel.Visible = false;
           if (panel2.Visible == true)
               panel2.Visible = false;     
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
           panelchildform.Controls.Add(childFrom);
           panelchildform.Tag = childFrom;
           childFrom.BringToFront();
           childFrom.Show();
       }


       private void partyMasterToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmPartyMaster partymaster = new FrmPartyMaster();
           
           partymaster.ShowDialog();
       }



       private void MDIParent1_Load(object sender, EventArgs e)
       {
           
       }

       private void btnmenu_Click(object sender, EventArgs e)
       {
           ShowSubMenu(MenuSubpanel);
       }

       private void subbtnpartymaster_Click(object sender, EventArgs e)
       {
           OpenChildForm(new FrmPartyMaster());
           HideSubMenu();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           OpenChildForm(new FrmSource());
           HideSubMenu();
       }

       private void button4_Click(object sender, EventArgs e)
       {
           OpenChildForm(new FrmQuery());
           HideSubMenu();
       }

       private void button2_Click(object sender, EventArgs e)
       {
           OpenChildForm(new PartyQuery());
           HideSubMenu();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           ShowSubMenu(panel2);
       }

       private void btnIncomeMaster_Click(object sender, EventArgs e)
       {
           OpenChildForm(new FrmIncomeMaster());
           HideSubMenu();
       }

       private void SubBtnExpenseMaster_Click(object sender, EventArgs e)
       {
           OpenChildForm(new FrmExpenseMaster());
           HideSubMenu();
       }

       private void button2_Click_1(object sender, EventArgs e)
       {
           OpenChildForm(new FrmIncomeQuery());
           HideSubMenu();
       }

       private void SubBtnDebitOrCreditQuery_Click(object sender, EventArgs e)
       {
           OpenChildForm(new FrmDebitOrCreditQuery());
           HideSubMenu();
       }
}
}
