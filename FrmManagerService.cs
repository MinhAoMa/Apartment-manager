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
    public partial class FrmManagerService : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();

        public FrmManagerService()
        {
            InitializeComponent();
        }

        private void FrmManagerService_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select DISTINCT macanho,tendichvu from qlDichVu");
            dgvql.DataSource = tmp.Tables[0];
        }
    }
}
