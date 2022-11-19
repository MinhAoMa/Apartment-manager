using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_manager_app
{
    public partial class FrmThue : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;
        private string khname;
        public FrmThue()
        {
            InitializeComponent();
        }

        private void txtBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmThue_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from KhachHang");
            dgvCustomers.DataSource = tmp.Tables[0];
            SqlConnection con = connect.getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from canho where trangthai = N'Trống'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbbApartment.DataSource = dt;
            cbbApartment.DisplayMember = "Macanho";
            cbbApartment.ValueMember = "Macanho";
            con.Close();
        }
        
        private byte[] convert()
        {
            FileStream fs = new FileStream(txtpath.Text, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return data;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO KhachHang VALUES(@MaKhachHang,@TenKhachhang,@gioitinh,@anh,@Macanho,@ngaysinh,@quoctich,@dantoc,@sodienthoai,@quequan,@pathAnh)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@MaKhachHang",txtMa.Text);
            com.Parameters.AddWithValue("@TenKhachhang", txtName.Text);
            com.Parameters.AddWithValue("@gioitinh", rbMale.Checked ? "Nam" : "Nữ");
            com.Parameters.AddWithValue("@anh", convert());
            com.Parameters.AddWithValue("@Macanho", cbbApartment.SelectedValue.ToString());
            com.Parameters.AddWithValue("@ngaysinh", txtBirthday.Text);
            com.Parameters.AddWithValue("@quoctich", txtnational.Text);
            com.Parameters.AddWithValue("@dantoc", txtethnic.Text);
            com.Parameters.AddWithValue("@sodienthoai", txtphone.Text);
            com.Parameters.AddWithValue("@quequan", txtAddress.Text);
            com.Parameters.AddWithValue("@pathAnh", txtpath.Text);
            com.ExecuteNonQuery();
            con.Close();
            FrmThue_Load(sender, e);
        }

        private void btnchoose_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = open.FileName;
                pbPerson.ImageLocation = txtpath.Text;
            }
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewContact_Click(object sender, EventArgs e)
        {
            FrmContactsReport frm = new FrmContactsReport();
            frm.Show();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            if (dgvCustomers.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbfeMale.Checked = true;
            }
            MemoryStream memoryStream = new MemoryStream((byte[])dgvCustomers.CurrentRow.Cells[3].Value);
            pbPerson.Image = Image.FromStream(memoryStream);
            cbbApartment.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            txtBirthday.Text = dgvCustomers.CurrentRow.Cells[5].Value.ToString();
            txtnational.Text = dgvCustomers.CurrentRow.Cells[6].Value.ToString();
            txtethnic.Text = dgvCustomers.CurrentRow.Cells[7].Value.ToString();
            txtphone.Text = dgvCustomers.CurrentRow.Cells[8].Value.ToString();
            txtAddress.Text = dgvCustomers.CurrentRow.Cells[9].Value.ToString();
            txtpath.Text = dgvCustomers.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
