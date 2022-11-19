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
    public partial class FrmContacts : Form
    {
        public FrmContacts()
        {
            InitializeComponent();
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmThue")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                FrmThue frm = new FrmThue();
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BackColor = this.BackColor;
            }
            
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
