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
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            
            InitializeComponent();
        }

        private void btnkeyboard_Click(object sender, EventArgs e)
        {
            //bool isExits = false;
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f.Name == "FrmKeyShortcut")
            //    {
            //        f.Activate();
            //        isExits = true;
            //        break;
            //    }
            //}
            //if (!isExits)
            //{
            //    FrmKeyShortcut frm = new FrmKeyShortcut();
            //    frm.MdiParent = this;
            //    frm.Dock = DockStyle.Fill;
            //    frm.Show();
            //}
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(FrmKeyShortcut))
            //    {
            //        form.Activate();
            //        form.Show();                   
            //        return;
            //    }
            //}
            //FrmKeyShortcut frm = new FrmKeyShortcut();
            //frm.Show();
        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();    
            frm.ShowDialog();
        }

        private void ToogleBackGround_CheckedChanged(object sender, EventArgs e)
        {
            if(ToogleBackGround.Checked == false)
            {
                this.BackColor = System.Drawing.Color.FromArgb(60,60,60);
                foreach (Form frm in Application.OpenForms)
                {
                    frm.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                    frm.ForeColor = System.Drawing.Color.White;
                    LbDarkMode.Text = "Tối";


                }
            }
            else if(ToogleBackGround.Checked == true)
            {               
                this.BackColor = System.Drawing.Color.White;
                //System.Windows.Forms = System.Drawing.Color.White;
                foreach (Form frm in Application.OpenForms)
                {
                    LbDarkMode.Text = "Sáng";
                    frm.BackColor = System.Drawing.Color.White;
                    frm.ForeColor = System.Drawing.Color.Black;
                }

            }
        }

        private void FrmSetting_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}
