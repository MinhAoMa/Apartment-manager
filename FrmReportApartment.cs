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
    public partial class FrmReportApartment : Form
    {
        ApartmentEntities db = new ApartmentEntities();
        public FrmReportApartment()
        {
            InitializeComponent();
        }

        private void FrmReportApartment_Load(object sender, EventArgs e)
        {
            CrystalReportApartment rpt = new CrystalReportApartment();
            rpt.SetDataSource(db.canhoes.ToList());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
