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
    public partial class FrmContactsReport : Form
    {
        CustomersEntities db = new CustomersEntities();
        public FrmContactsReport()
        {
            InitializeComponent();
        }

        private void FrmContactsReport_Load(object sender, EventArgs e)
        {
            CrystalReportContacts rpt = new CrystalReportContacts();
            rpt.SetDataSource(db.KhachHangs.Select(c => new { c.MaKhachHang, c.TenKhachhang, c.gioitinh, c.Macanho, c.quoctich, c.dantoc, c.sodienthoai, c.quequan }).ToList());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
