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
    public partial class FrmPerson : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;       
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from dancu");
            dgvPerson.DataSource = tmp.Tables[0];
            total.Text = dgvPerson.Rows.Count.ToString();
            SqlConnection con = connect.getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Macanho from canho where trangthai = N'Đã thuê'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbbApartment.DataSource = dt;
            cbbApartment.DisplayMember = "Macanho";
            cbbApartment.ValueMember = "Macanho";            
            con.Close();           
        }

       

        private void guna2ComboBox1_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(cbbOption,"Click vào đề xem");
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = open.FileName;
                pbPerson.ImageLocation = txtpath.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
        private byte[] convert()
        {           
            FileStream fs = new FileStream(txtpath.Text, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();           
            return data;
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            titlePerson.Text = "Nhập thông tin cư dân";
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO dancu VALUES(@Madancu,@ten,@gioitinh,@anh,@Macanho,@ngaysinh,@quoctich,@dantoc,@sodienthoai,@quequan,@pathAnh)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Madancu", txtMa.Text.Trim());
            com.Parameters.AddWithValue("@ten", txtName.Text.Trim());
            com.Parameters.AddWithValue("@gioitinh", rbMale.Checked ? "Nam" : "Nữ");
            com.Parameters.AddWithValue("@anh", convert());
            com.Parameters.AddWithValue("@Macanho", cbbApartment.SelectedValue.ToString());
            com.Parameters.AddWithValue("@ngaysinh", txtBirthday.Text.Trim());
            com.Parameters.AddWithValue("@quoctich", txtnational.Text.Trim());
            com.Parameters.AddWithValue("@dantoc", txtethnic.Text.Trim());
            com.Parameters.AddWithValue("@sodienthoai", txtphone.Text.Trim());
            com.Parameters.AddWithValue("@quequan", txtAddress.Text.Trim());
            com.Parameters.AddWithValue("@pathAnh", txtpath.Text.Trim());
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmPerson_Load(sender, e);
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            titlePerson.Text = "Thông tin cư dân";
            stt = dgvPerson.CurrentRow.Cells[0].Value.ToString();
            txtMa.Text = dgvPerson.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvPerson.CurrentRow.Cells[1].Value.ToString();
            if (dgvPerson.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbfeMale.Checked = true;
            }
            MemoryStream memoryStream = new MemoryStream((byte[])dgvPerson.CurrentRow.Cells[3].Value);
            pbPerson.Image = Image.FromStream(memoryStream);       
            cbbApartment.Text = dgvPerson.CurrentRow.Cells[4].Value.ToString();
            txtBirthday.Text = dgvPerson.CurrentRow.Cells[5].Value.ToString();
            txtnational.Text = dgvPerson.CurrentRow.Cells[6].Value.ToString();
            txtethnic.Text = dgvPerson.CurrentRow.Cells[7].Value.ToString();
            txtphone.Text = dgvPerson.CurrentRow.Cells[8].Value.ToString();
            txtAddress.Text = dgvPerson.CurrentRow.Cells[9].Value.ToString();
            txtpath.Text = dgvPerson.CurrentRow.Cells[10].Value.ToString();
            ContainerData.Visible = true;   
            
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "update dancu set ten=@ten,gioitinh=@gioitinh,anh = @anh ,Macanho=@Macanho,ngaysinh=@ngaysinh, quoctich = @quoctich, dantoc = @dantoc, sodienthoai = @sodienthoai,quequan = @quequan where Madancu = " + stt;
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Madancu", txtMa.Text);
            com.Parameters.AddWithValue("@ten", txtName.Text);
            com.Parameters.AddWithValue("@gioitinh", rbMale.Checked ? "Nam" : "Nữ");
            com.Parameters.AddWithValue("@anh", convert());       
            com.Parameters.AddWithValue("@Macanho", cbbApartment.SelectedValue.ToString());
            com.Parameters.AddWithValue("@ngaysinh", txtBirthday.Text);
            com.Parameters.AddWithValue("@quoctich", txtnational.Text);
            com.Parameters.AddWithValue("@dantoc", txtethnic.Text);
            com.Parameters.AddWithValue("@sodienthoai", txtphone.Text);
            com.Parameters.AddWithValue("@quequan", txtAddress.Text); 
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmPerson_Load(sender, e);
        }

        private void BtnCreateNew_Click_1(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtpath.Text = txtMa.Text = txtName.Text = txtBirthday.Text = txtnational.Text = txtphone.Text = txtAddress.Text = txtethnic.Text =  " ";
            rbMale.Checked = false;
            rbfeMale.Checked = false;
            pbPerson.Image = null;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên đang chọn hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "delete from dancu where Madancu = " + stt;
                connect.setDatda(query);
                ContainerData.Visible = false;
                FrmPerson_Load(sender, e);               
            }
        }

        private void cbbOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbOption.SelectedItem.ToString() == "Quê quán")
            {
                panelfind.Visible = true;
                txtvalue2.PlaceholderText = "Nhập nơi cần tìm";               
            }
            else if(cbbOption.SelectedItem.ToString() == "Quốc tịch Vn")
            {
                string query = "select * from dancu where quoctich like N'Việt Nam' or quoctich like N'Viet Nam'";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }
            else if (cbbOption.SelectedItem.ToString() == "Khác quốc tịch Vn")
            {
                string query = "select * from dancu where  quoctich not like N'Viet Nam'";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }
            else if(cbbOption.SelectedItem.ToString() == "Dưới 18")
            {
                string query = "select * from dancu where YEAR(GETDATE()) - YEAR(ngaysinh) < 18";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }
            else if (cbbOption.SelectedItem.ToString() == "Từ 18 -65")
            {
                string query = "select * from dancu where YEAR(GETDATE()) - YEAR(ngaysinh) < 65 and YEAR(GETDATE()) - YEAR(ngaysinh) > =18 ";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }
            else if (cbbOption.SelectedItem.ToString() == "Trên 65")
            {
                string query = "select * from dancu where YEAR(GETDATE()) - YEAR(ngaysinh) > 65";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }
            else if (cbbOption.SelectedItem.ToString() == "Nam")
            {
                string query = "select * from dancu where gioitinh = N'Nam'";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }
            else if (cbbOption.SelectedItem.ToString() == "Nữ")
            {
                string query = "select * from dancu where gioitinh = N'Nữ'";
                DataSet tmp = connect.GetData(query);
                dgvPerson.DataSource = tmp.Tables[0];
                active.Text = dgvPerson.Rows.Count.ToString();
            }           
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            cbbOption.Text = "";
            active.Text = 0.ToString();
            txtvalue.Text = "";
            FrmPerson_Load(sender, e);
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPerson.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(txtvalue.Text))
                {
                    string query = $"select * from dancu where Madancu = '{txtvalue.Text}'";
                    DataSet tmp = connect.GetData(query);
                    dgvPerson.DataSource = tmp.Tables[0];
                }               
            }
        }

        private void findChilren_Click(object sender, EventArgs e)
        {
            string query = "select * from dancu where quequan like N'%" + txtvalue2.Text + "%'";
            DataSet tmp = connect.GetData(query);
            dgvPerson.DataSource = tmp.Tables[0];
            active.Text = dgvPerson.Rows.Count.ToString();
            panelfind.Visible = false;
            txtvalue2.Text = "";
        }

        private void btnfindapartment_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Macanho from canho where trangthai = N'Đã thuê'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            da.Fill(dt);
            cbbcanho.DataSource = dt;
            cbbcanho.DisplayMember = "Macanho";
            cbbcanho.ValueMember = "Macanho";
            con.Close();
        }

        private void cbbcanho_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "select * from dancu where Macanho = '"+cbbcanho.SelectedValue+"'";
            DataSet tmp = connect.GetData(query);
            dgvPerson.DataSource = tmp.Tables[0];
            active.Text = dgvPerson.Rows.Count.ToString();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dgvPerson.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvPerson.Columns.Count + 1; i++)
                {                  
                    XcelApp.Cells[1, i] = dgvPerson.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvPerson.Rows.Count; i++)
                {                  
                    for (int j = 0; j < dgvPerson.Columns.Count; j++)
                    {                      
                        XcelApp.Cells[i + 2, j + 1] = dgvPerson.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            FomReportPersons frm = new FomReportPersons();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbcanho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
