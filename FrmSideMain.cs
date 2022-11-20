using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Apartment_manager_app
{
    public partial class FrmSideMain : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
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
            String query1 = "select COUNT(*) from dancu";
            DataSet a = connect.GetData(query1);
            labelPerson.Text = a.Tables[0].Rows[0][0].ToString();

            String query2 = "select COUNT(*) from canho";
            DataSet b = connect.GetData(query2);
            labelApartment.Text = b.Tables[0].Rows[0][0].ToString();

            String query3 = "select COUNT(*) from Nhanvien where chucvu like N'Quản lý'";
            DataSet c = connect.GetData(query3);
            labelManager.Text = c.Tables[0].Rows[0][0].ToString();

            String query4 = "select count(*) from dancu where gioitinh = N'Nam'";
            DataSet d = connect.GetData(query4);
            double countMan = double.Parse(d.Tables[0].Rows[0][0].ToString());

            String query5 = "select count(*) from dancu where gioitinh = N'Nữ'";
            DataSet grild = connect.GetData(query5);
            double countGrild = double.Parse(grild.Tables[0].Rows[0][0].ToString());
            double value = (countMan / (countGrild + countMan)) * 100;
            bieudogioitinh.Value = int.Parse(value.ToString());

            string query = "select count(*) from canho where trangthai = N'Đã thuê'";
            DataSet f = connect.GetData(query);
            double ApartmentNotnull = double.Parse(f.Tables[0].Rows[0][0].ToString());

            string query7 = "select count(*) from canho where trangthai = N'Trống'";
            DataSet g = connect.GetData(query7);
            double Apartmentnull = double.Parse(g.Tables[0].Rows[0][0].ToString());           
            double valueApartment = (ApartmentNotnull / (ApartmentNotnull + Apartmentnull)) * 100;          
            bieudocanho.Value = int.Parse(Math.Round(valueApartment).ToString());
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LbDate.Text = DateTime.Now.ToString();
        }

        
        private void FrmSideMain_BackColorChanged(object sender, EventArgs e)
        {
            if(this.BackColor == Color.FromArgb(60, 60, 60))
            {
                LbOverview.ForeColor = System.Drawing.Color.White;
                LbDashboard.ForeColor = System.Drawing.Color.DeepSkyBlue;
                LbUsername.ForeColor = System.Drawing.Color.White;
                LbDate.ForeColor = System.Drawing.Color.White;
                LbFacebook.ForeColor = System.Drawing.Color.White;
                LbGmail.ForeColor = System.Drawing.Color.White;
                LbLocation.ForeColor = System.Drawing.Color.White;
                Lbphone.ForeColor = System.Drawing.Color.White;
                Lbinfo.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                LbOverview.ForeColor = System.Drawing.Color.Black;
                LbDashboard.ForeColor = System.Drawing.Color.FromArgb(45, 85, 219);
                LbUsername.ForeColor = System.Drawing.Color.Black;
                LbDate.ForeColor = System.Drawing.Color.Black;
                LbFacebook.ForeColor = System.Drawing.Color.Black;
                LbGmail.ForeColor = System.Drawing.Color.Black;
                LbLocation.ForeColor = System.Drawing.Color.Black;
                Lbphone.ForeColor = System.Drawing.Color.Black;
                Lbinfo.ForeColor = System.Drawing.Color.Black;
            }
           


        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void FrmSideMain_ForeColorChanged(object sender, EventArgs e)
        {
            this.BackColor = this.MdiParent.BackColor;
        }
    }
}
