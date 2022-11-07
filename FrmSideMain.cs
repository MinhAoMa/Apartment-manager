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


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LbDate.Text = DateTime.Now.ToString();
        }


        private void FrmSideMain_BackColorChanged(object sender, EventArgs e)
        {
            LbOverview.ForeColor = System.Drawing.Color.White;
            LbDashboard.ForeColor = System.Drawing.Color.DeepSkyBlue;
            LbUsername.ForeColor = System.Drawing.Color.White;
            LbDate.ForeColor = System.Drawing.Color.White;
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
