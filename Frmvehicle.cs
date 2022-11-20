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
    public partial class Frmvehicle : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;

        public Frmvehicle()
        {
            InitializeComponent();
        }

        private void btnBacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtoto.Text = txtxedap.Text = txtxemay.Text = "";
        }

        private void Frmvehicle_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from Phuongtien");
            dgvElectric.DataSource = tmp.Tables[0];
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
            DataSet tmp1 = connect.GetData("select Sum(Xedap) from Phuongtien");
            valueXedap.Text = tmp1.Tables[0].Rows[0][0].ToString();
            DataSet tmp2 = connect.GetData("select Sum(Xemay) from Phuongtien");
            valuexemay.Text = tmp2.Tables[0].Rows[0][0].ToString();
            DataSet tmp3 = connect.GetData("select Sum(Oto) from Phuongtien");
            valueoto.Text = tmp3.Tables[0].Rows[0][0].ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO Phuongtien VALUES(@Macanho,@Xedap,@Xemay,@Oto)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", cbbcanho.SelectedValue.ToString());
            com.Parameters.AddWithValue("@Xedap", txtxedap.Text);
            com.Parameters.AddWithValue("@Xemay", txtxemay.Text);
            com.Parameters.AddWithValue("@Oto", txtoto.Text);
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            Frmvehicle_Load(sender, e);
        }

        private void dgvElectric_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = dgvElectric.CurrentRow.Cells[0].Value.ToString();
            cbbcanho.Text = dgvElectric.CurrentRow.Cells[1].Value.ToString();
            txtxedap.Text = dgvElectric.CurrentRow.Cells[2].Value.ToString();
            txtxemay.Text = dgvElectric.CurrentRow.Cells[3].Value.ToString();
            txtoto.Text = dgvElectric.CurrentRow.Cells[4].Value.ToString();
            ContainerData.Visible = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "update Phuongtien set Macanho=@Macanho,Xedap=@Xedap,Xemay=@Xemay,Oto=@Oto where ID = " + stt;
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Macanho", cbbcanho.SelectedValue.ToString());
            com.Parameters.AddWithValue("@Xedap", txtxedap.Text);
            com.Parameters.AddWithValue("@Xemay", txtxemay.Text);
            com.Parameters.AddWithValue("@Oto", txtoto.Text);
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            Frmvehicle_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvElectric.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(txtvalue.Text))
                {
                    string query = $"select * from Phuongtien where Macanho = '{txtvalue.Text}'";
                    DataSet tmp = connect.GetData(query);
                    dgvElectric.DataSource = tmp.Tables[0];
                }
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Frmvehicle_Load(sender, e);
        }
    }
}
