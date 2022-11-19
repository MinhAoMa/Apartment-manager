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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apartment_manager_app
{
    public partial class FrmApartment : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;
        public FrmApartment()
        {
            InitializeComponent();
        }

        

        private void FrmApartment_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from canho");
            dgvdepartment.DataSource = tmp.Tables[0];      
            total.Text = dgvdepartment.Rows.Count.ToString();          
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtdientich.Text = txtMacanho.Text = txtLoai.Text = txtgia.Text = "";
            tooglestatus.Checked = false;
        }

        private void close(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {           
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "insert into canho values(@Macanho,@dientich,@loaicanho,@gia,@trangthai)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", txtMacanho.Text);
            com.Parameters.AddWithValue("@dientich", txtdientich.Text);
            com.Parameters.AddWithValue("@loaicanho", txtLoai.Text);
            com.Parameters.AddWithValue("@gia", txtgia.Text);
            com.Parameters.AddWithValue("@trangthai", tooglestatus.Checked ? "Đã thuê" : "Trống");
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmApartment_Load(sender, e);
        }

        private void dgvdepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = dgvdepartment.CurrentRow.Cells[0].Value.ToString();
            txtMacanho.Text = dgvdepartment.CurrentRow.Cells[0].Value.ToString();
            txtdientich.Text = dgvdepartment.CurrentRow.Cells[1].Value.ToString();
            txtLoai.Text = dgvdepartment.CurrentRow.Cells[2].Value.ToString();
            txtgia.Text = dgvdepartment.CurrentRow.Cells[3].Value.ToString();
            if (dgvdepartment.CurrentRow.Cells[4].Value.ToString() == "Đã thuê")
            {
                tooglestatus.Checked = true;
            }
            else
            {
                tooglestatus.Checked = false;
            }
            ContainerData.Visible = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "update canho set dientich=@dientich,loaicanho=@loaicanho,gia=@gia,trangthai=@trangthai where Macanho = " + stt;
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", txtMacanho.Text);
            com.Parameters.AddWithValue("@dientich", txtdientich.Text);
            com.Parameters.AddWithValue("@loaicanho", txtLoai.Text.ToUpper());
            com.Parameters.AddWithValue("@gia", txtgia.Text);
            com.Parameters.AddWithValue("@trangthai", tooglestatus.Checked ? "Đã thuê" : "Trống");
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmApartment_Load(sender, e);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên đang chọn hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "delete from canho where Macanho = " + stt;
                connect.setDatda(query);
                ContainerData.Visible = false;
                FrmApartment_Load(sender, e);
            }
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            FrmApartment_Load(sender, e);
        }

        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbbAparment.SelectedItem.ToString() == "Đã thuê")
            {
                string query = "select * from canho where trangthai = N'Đã thuê'";
                DataSet tmp = connect.GetData(query);
                dgvdepartment.DataSource = tmp.Tables[0];
                active.Text = dgvdepartment.Rows.Count.ToString();
            }
            else if (cbbAparment.SelectedItem.ToString() == "Trống")
            {
                string query = "select * from canho where trangthai = N'Trống'";
                DataSet tmp = connect.GetData(query);
                dgvdepartment.DataSource = tmp.Tables[0];
                active.Text = dgvdepartment.Rows.Count.ToString();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {                                                          
                foreach (DataGridViewRow row in dgvdepartment.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(txtvalue.Text))
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }           
        }

        private void cbbAparment_MouseHover(object sender, EventArgs e)
        {
            tooltipcbb.SetToolTip(cbbAparment, "Click vào đề xem");
        }

        private void btnexel_Click(object sender, EventArgs e)
        {
            if (dgvdepartment.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvdepartment.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvdepartment.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvdepartment.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvdepartment.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvdepartment.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            FrmReportApartment frm = new FrmReportApartment();
            frm.Show();
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
