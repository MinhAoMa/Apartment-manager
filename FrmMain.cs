using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_manager_app
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnApp_click(object sender, EventArgs e)
        {

        }

        private void btnHome_click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmSideMain")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmSideMain frm = new FrmSideMain();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            BtnMenu.Checked = false;
            BtnHome.Checked = true;
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmMenu")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmMenu frm = new FrmMenu();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            BtnHome.Checked = false;
            BtnMenu.Checked = true;    
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmSideMain frm = new FrmSideMain();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            BtnHome.Checked = true;
        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                
                if (f.Name == "FrmSideMain")
                {
                    BtnMenu.Checked = false;
                    BtnHome.Checked = true;
                    f.Show();
                    break;
                }
                if (f.Name == "FrmMenu")
                {
                    BtnHome.Checked = false;
                    BtnMenu.Checked = true;
                    f.Show();
                    break;
                }
            }
        }
    }
}
