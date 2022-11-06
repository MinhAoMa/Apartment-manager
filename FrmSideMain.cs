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
    public partial class FrmSideMain : Form
    {
        public FrmSideMain()
        {
            
            InitializeComponent();
        }
        
        private void btnClose(object sender, EventArgs e)
        {
            FrmClose frm = new FrmClose();
            frm.ShowDialog();          
        }
        
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSideMain_Load(object sender, EventArgs e)
        {
            LbDate.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            LbDate.Text = DateTime.Now.ToString();
        }
    }
}
