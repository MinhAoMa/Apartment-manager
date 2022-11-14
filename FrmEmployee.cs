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
    public partial class FrmEmployee : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtpath.Text = txtma.Text = txtname.Text = txtbirthday.Text = txtphone.Text = txtjob.Text = txtAddress.Text = "";
            rbMale.Checked = false;
            rbfeMale.Checked = false;
            pbEmployee.Image = null;
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from Nhanvien");
            dgvEmployee.DataSource = tmp.Tables[0];
            lbtotal.Text = dgvEmployee.Rows.Count.ToString();
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = open.FileName;
                pbEmployee.ImageLocation = txtpath.Text;
            }
        }
        private byte[] convert()
        {
            FileStream fs = new FileStream(txtpath.Text, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return data;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO Nhanvien VALUES(@Manhanvien,@ten,@gioitinh,@ngaysinh,@sodienthoai,@chucvu,@quequan,@anh)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Manhanvien", txtma.Text);
            com.Parameters.AddWithValue("@ten", txtname.Text);
            com.Parameters.AddWithValue("@gioitinh", rbMale.Checked ? "Nam" : "Nữ");
            com.Parameters.AddWithValue("@ngaysinh", txtbirthday.Text);
            com.Parameters.AddWithValue("@sodienthoai", txtphone.Text);
            com.Parameters.AddWithValue("@chucvu", txtjob.Text);
            com.Parameters.AddWithValue("@quequan", txtAddress.Text);
            com.Parameters.AddWithValue("@anh", convert());
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmEmployee_Load(sender, e);

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "update Nhanvien set ten=@ten,gioitinh=@gioitinh,anh = @anh ,ngaysinh=@ngaysinh, sodienthoai = @sodienthoai,chucvu = @chucvu,quequan = @quequan where Manhanvien = " + stt;
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Manhanvien", txtma.Text);
            com.Parameters.AddWithValue("@ten", txtname.Text);
            com.Parameters.AddWithValue("@gioitinh", rbMale.Checked ? "Nam" : "Nữ");
            com.Parameters.AddWithValue("@ngaysinh", txtbirthday.Text);
            com.Parameters.AddWithValue("@sodienthoai", txtphone.Text);
            com.Parameters.AddWithValue("@chucvu", txtjob.Text);
            com.Parameters.AddWithValue("@quequan", txtAddress.Text);
            com.Parameters.AddWithValue("@anh", convert());
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmEmployee_Load(sender, e);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtma.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            if (dgvEmployee.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbfeMale.Checked = true;
            }
            txtbirthday.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtphone.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtjob.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgvEmployee.CurrentRow.Cells[6].Value.ToString();
            MemoryStream memoryStream = new MemoryStream((byte[])dgvEmployee.CurrentRow.Cells[7].Value);
            pbEmployee.Image = Image.FromStream(memoryStream);
            ContainerData.Visible = true;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên đang chọn hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "delete from Nhanvien where Manhanvien = " + stt;
                connect.setDatda(query);
                ContainerData.Visible = false;
                FrmEmployee_Load(sender, e);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
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

        private void cbbfind_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbfind.SelectedItem.ToString() == "An ninh")
            {
                string query = "select * from Nhanvien where chucvu = N' An ninh '";
                DataSet tmp = connect.GetData(query);
                dgvEmployee.DataSource = tmp.Tables[0];
                lbactive.Text = dgvEmployee.Rows.Count.ToString();
            }
            else if (cbbfind.SelectedItem.ToString() == "Vệ sinh")
            {
                string query = "select * from Nhanvien where chucvu = N' Vệ sinh '";
                DataSet tmp = connect.GetData(query);
                dgvEmployee.DataSource = tmp.Tables[0];
                lbactive.Text = dgvEmployee.Rows.Count.ToString();
            }
            else if (cbbfind.SelectedItem.ToString() == "Quản lý")
            {
                string query = "select * from Nhanvien where chucvu = N' Quản lý '";
                DataSet tmp = connect.GetData(query);
                dgvEmployee.DataSource = tmp.Tables[0];
                lbactive.Text = dgvEmployee.Rows.Count.ToString();
            }
            else if (cbbfind.SelectedItem.ToString() == "Chăm sóc khách hàng")
            {
                string query = "select * from Nhanvien where chucvu = N' Chăm sóc khách hàng '";
                DataSet tmp = connect.GetData(query);
                dgvEmployee.DataSource = tmp.Tables[0];
                lbactive.Text = dgvEmployee.Rows.Count.ToString();
            }
            else if (cbbfind.SelectedItem.ToString() == "Y tế")
            {
                string query = "select * from Nhanvien where chucvu = N' Y tế '";
                DataSet tmp = connect.GetData(query);
                dgvEmployee.DataSource = tmp.Tables[0];
                lbactive.Text = dgvEmployee.Rows.Count.ToString();
            }
            else if (cbbfind.SelectedItem.ToString() == "Kĩ thuật")
            {
                string query = "select * from Nhanvien where chucvu = N' Kĩ thuật '";
                DataSet tmp = connect.GetData(query);
                dgvEmployee.DataSource = tmp.Tables[0];
                lbactive.Text = dgvEmployee.Rows.Count.ToString();
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvEmployee.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvEmployee.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvEmployee.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvEmployee.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvEmployee.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            FrmReportEmployee frm = new FrmReportEmployee();
            frm.Show();
        }
    }
}
