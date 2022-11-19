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
    public partial class FrmElectric : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;
        public FrmElectric()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void FrmElectric_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from Dien");
            dgvElectric.DataSource = tmp.Tables[0];
            SqlConnection con = connect.getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from canho";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbbcanho.DataSource = dt;
            cbbcanho.DisplayMember = "Macanho";
            cbbcanho.ValueMember = "Macanho";
            con.Close();
            total.Text = dgvElectric.Rows.Count.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO Dien VALUES(@Macanho,@Thang,@sodien,@trangthai,@tongtien)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", cbbcanho.SelectedValue.ToString());
            com.Parameters.AddWithValue("@Thang", txtmonth.Text);
            com.Parameters.AddWithValue("@sodien", txtdien.Text);
            com.Parameters.AddWithValue("@trangthai", toogleStatus.Checked ? "Đã nộp" : "Chưa nộp");
            double sodien = double.Parse(txtdien.Text);
            double tiendien = 0;
            if(sodien > 0 && sodien < 50)
            {
                tiendien = sodien * 1.388;
            }
            else if(sodien >= 50 && sodien < 100)
            {
                tiendien = 50 * 1.388 + (sodien - 50) *1.433;
            }
            else if(sodien >= 100 && sodien < 200)
            {
                tiendien = 50 * 1.388 + 50 * 1.433 + (sodien - 100) * 1.660;
            }
            else
            {
                tiendien = 50 * 1.388 + 50 * 1.433 + 100 * 1.660 + (sodien - 200) * 2.082;
            }
            com.Parameters.AddWithValue("@tongtien",tiendien.ToString());
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmElectric_Load(sender, e);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtdien.Text = txtmonth.Text = "";
            toogleStatus.Checked = false;
        }

        private void dgvElectric_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = dgvElectric.CurrentRow.Cells[0].Value.ToString();
            cbbcanho.Text = dgvElectric.CurrentRow.Cells[1].Value.ToString();
            txtmonth.Text = dgvElectric.CurrentRow.Cells[2].Value.ToString();            
            txtdien.Text = dgvElectric.CurrentRow.Cells[3].Value.ToString();
            if (dgvElectric.CurrentRow.Cells[4].Value.ToString() == "Đã nộp")
            {
                toogleStatus.Checked = true;
            }
            else
            {
                toogleStatus.Checked = false;
            }
            ContainerData.Visible = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "update Dien set Macanho=@Macanho,Thang=@Thang,sodien=@sodien,trangthai=@trangthai where ID = " + stt;
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", cbbcanho.SelectedValue.ToString());
            com.Parameters.AddWithValue("@Thang", txtmonth.Text);
            com.Parameters.AddWithValue("@sodien", txtdien.Text);
            com.Parameters.AddWithValue("@trangthai", toogleStatus.Checked ? "Đã nộp" : "Chưa nộp");
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmElectric_Load(sender, e);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên đang chọn hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "delete from Dien where ID = " + stt;
                connect.setDatda(query);
                ContainerData.Visible = false;
                FrmElectric_Load(sender, e);
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            FrmElectric_Load(sender, e);
        }

        private void dgvElectric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvElectric.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(txtvalue.Text))
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void cbbmonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbmonth.SelectedItem.ToString() == "Đã nộp")
            {             
                string query = "select * from Dien where trangthai = N'Đã nộp'";
                DataSet tmp = connect.GetData(query);
                dgvElectric.DataSource = tmp.Tables[0];
                active.Text = dgvElectric.Rows.Count.ToString();
            }
            else if (cbbmonth.SelectedItem.ToString() == "Chưa nộp")
            {
                string query = "select * from Dien where trangthai = N'Chưa nộp'";
                DataSet tmp = connect.GetData(query);
                dgvElectric.DataSource = tmp.Tables[0];
                active.Text = dgvElectric.Rows.Count.ToString();
            }

        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dgvElectric.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvElectric.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvElectric.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvElectric.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvElectric.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvElectric.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
