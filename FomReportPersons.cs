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
    public partial class FomReportPersons : Form
    {
        PersonsEntities db = new PersonsEntities();
        public FomReportPersons()
        {
            InitializeComponent();
        }

        private void FomReportPersons_Load(object sender, EventArgs e)
        {
            CrystalReportPerson rpt = new CrystalReportPerson();
            rpt.SetDataSource(db.dancus.Select(c => new { c.Madancu, c.ten, c.gioitinh, c.Macanho, c.quoctich, c.dantoc, c.sodienthoai, c.quequan }).ToList());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
