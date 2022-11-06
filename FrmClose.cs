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
    public partial class FrmClose : Form
    {
        public FrmClose()
        {
            InitializeComponent();
        }

        private void btnYes(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNo(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnformClose(object sender, EventArgs e)
        {
            btnNo(sender, e);
        }
    }
}
