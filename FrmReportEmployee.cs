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
    public partial class FrmReportEmployee : Form
    {
        EmployeeEntities db = new EmployeeEntities();      
        public FrmReportEmployee()
        {
            InitializeComponent();
        }

        private void FrmReportEmployee_Load(object sender, EventArgs e)
        {

            CrystalReportEmployee rpt = new CrystalReportEmployee ();
            rpt.SetDataSource(db.NhanViens.Select(c => new { c.Manhanvien, c.ten, c.gioitinh, c.sodienthoai, c.chucvu, c.quequan}).ToList());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
