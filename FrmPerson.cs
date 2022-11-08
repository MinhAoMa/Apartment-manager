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
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void btnbackmenu_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            ContainerData.Hide();
        }

        private void BtnCreateNew_Click(object sender, EventArgs e)
        {
            ContainerData.Show();
            BtnCreateNew.Hide();
        }

        private void guna2ComboBox1_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(cbbOption,"Click vào đề xem");
        }
    }
}
