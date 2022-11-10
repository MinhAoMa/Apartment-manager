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
            btnSetting.Checked = false;

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
            btnSetting.Checked = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmSideMain frm = new FrmSideMain();
            FrmMenu fmn = new FrmMenu();
            fmn.MdiParent = this;
            fmn.Dock = DockStyle.Fill;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            fmn.Show();
            frm.Show();
            BtnMenu.Checked = false;
            BtnHome.Checked = true; 
            
            
        }


        private void btnLogoClick(object sender, EventArgs e)
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
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            BtnMenu.Checked = false;
            BtnHome.Checked = true;
            btnSetting.Checked = false;
        }

        private void eventKey(object sender, KeyPressEventArgs e)
        {
            
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FrmClose frm = new FrmClose();
                frm.Show();
            }
            else if(e.KeyCode ==  Keys.F1)
            {
                FrmMain_Load(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnApp_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnSettingClick(sender, e);
            }
        }

        private void btnSettingClick(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmSetting")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name != "FrmSetting")
                {
                    f.Close();
                    
                }
            }
            if (!isExits)
            {
                FrmSetting frm = new FrmSetting();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            BtnHome.Checked = false;
            BtnMenu.Checked = false;
            btnSetting.Checked = true;   
        }

        private void FrmMain_BackColorChanged(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.BackColor = this.BackColor;
                
            }
        }

        private void FrmMain_ForeColorChanged(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.ForeColor = this.ForeColor;

            }

        }
    }
}
