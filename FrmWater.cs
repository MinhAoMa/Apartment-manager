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

    public partial class FrmWater : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;

        public FrmWater()
        {
            InitializeComponent();
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void FrmWater_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from Nuoc");
            dgvWater.DataSource = tmp.Tables[0];
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
            total.Text = dgvWater.Rows.Count.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO Nuoc VALUES(@Macanho,@Thang,@SoNuoc,@trangthai,@tongtien)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", cbbcanho.SelectedValue.ToString());
            com.Parameters.AddWithValue("@Thang", txtmonth.Text);
            com.Parameters.AddWithValue("@SoNuoc", txtnuoc.Text);
            com.Parameters.AddWithValue("@trangthai", toogleStatus.Checked ? "Đã nộp" : "Chưa nộp");
            double tiennuoc = 0;
            double sonuoc = double.Parse(txtnuoc.Text);
            tiennuoc = sonuoc * 18000;
            com.Parameters.AddWithValue("@tongtien", tiennuoc.ToString());
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmWater_Load(sender, e);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtnuoc.Text = txtmonth.Text = "";
            toogleStatus.Checked = false;
        }

        private void dgvWater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = dgvWater.CurrentRow.Cells[0].Value.ToString();
            cbbcanho.Text = dgvWater.CurrentRow.Cells[1].Value.ToString();
            txtmonth.Text = dgvWater.CurrentRow.Cells[2].Value.ToString();
            txtnuoc.Text = dgvWater.CurrentRow.Cells[3].Value.ToString();
            if (dgvWater.CurrentRow.Cells[4].Value.ToString() == "Đã nộp")
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
            string commandText = "update Nuoc set Macanho=@Macanho,Thang=@Thang,sodien=@sodien,trangthai=@trangthai where ID = " + stt;
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", cbbcanho.SelectedValue.ToString());
            com.Parameters.AddWithValue("@Thang", txtmonth.Text);
            com.Parameters.AddWithValue("@sodien", txtnuoc.Text);
            com.Parameters.AddWithValue("@trangthai", toogleStatus.Checked ? "Đã nộp" : "Chưa nộp");
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmWater_Load(sender, e);
        }

        private void cbbmonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbmonth.SelectedItem.ToString() == "Đã nộp")
            {
                string query = "select * from Nuoc where trangthai = N'Đã nộp'";
                DataSet tmp = connect.GetData(query);
                dgvWater.DataSource = tmp.Tables[0];
                active.Text = dgvWater.Rows.Count.ToString();
            }
            else if (cbbmonth.SelectedItem.ToString() == "Chưa nộp")
            {
                string query = "select * from Nuoc where trangthai = N'Chưa nộp'";
                DataSet tmp = connect.GetData(query);
                dgvWater.DataSource = tmp.Tables[0];
                active.Text = dgvWater.Rows.Count.ToString();
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            FrmWater_Load(sender, e);
        }
    }
}
