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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose(object sender, EventArgs e)
        {
            FrmClose frm = new FrmClose();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LbDate.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbDate.Text = DateTime.Now.ToString();
        }

        private void btnBackforward_Click(object sender, EventArgs e)
        {
            FrmSideMain frm = new FrmSideMain();
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.BackColor = this.BackColor;

        }

        private void FrmMenu_BackColorChanged(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(60, 60, 60))
            {
                LbDate.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                LbDate.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmPerson")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmPerson frm = new FrmPerson();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void FrmMenu_ForeColorChanged(object sender, EventArgs e)
        {
            this.BackColor = this.MdiParent.BackColor;
        }

        private void appApartment_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmApartment")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmApartment frm = new FrmApartment();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmElectric")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmElectric frm = new FrmElectric();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmEmployee")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmEmployee frm = new FrmEmployee();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmServices")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmServices frm = new FrmServices();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmManagerService")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmManagerService frm = new FrmManagerService();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void appContact_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmContacts")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmContacts frm = new FrmContacts();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void AppCustomer_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmCustomers")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmCustomers frm = new FrmCustomers();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmWater")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmWater frm = new FrmWater();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Frmvehicle")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                Frmvehicle frm = new Frmvehicle();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
        }
    }
}
