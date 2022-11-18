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
    public partial class FrmServices : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public string stt;
        public FrmServices()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ContainerData.Visible = true;
            txtmadv.Text = txttendv.Text = giadv.Text ="";
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            DataSet tmp = connect.GetData("select * from Dichvu");
            dgvSrevices.DataSource = tmp.Tables[0];
            SqlConnection con = connect.getConnection();
            total.Text = dgvSrevices.Rows.Count.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = "INSERT INTO Dichvu VALUES(@Madichvu,@tendichvu,@giatien)";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@Madichvu",txtmadv.Text);
            com.Parameters.AddWithValue("@tendichvu", txttendv.Text);
            com.Parameters.AddWithValue("@giatien", giadv.Text);
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmServices_Load(sender, e);
        }

        private void dgvSrevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = dgvSrevices.CurrentRow.Cells[0].Value.ToString();           
            txtmadv.Text = dgvSrevices.CurrentRow.Cells[0].Value.ToString();
            txttendv.Text = dgvSrevices.CurrentRow.Cells[1].Value.ToString();
            giadv.Text = dgvSrevices.CurrentRow.Cells[2].Value.ToString();
            ContainerData.Visible = true;
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = connect.getConnection();
            con.Open();
            string commandText = $"update Dichvu set tendichvu=@tendichvu,giatien=@giatien where Madichvu = '{stt}'";
            SqlCommand com = new SqlCommand(commandText, con);
            com.Parameters.AddWithValue("@tendichvu", txttendv.Text);
            com.Parameters.AddWithValue("@giatien", giadv.Text);
            com.ExecuteNonQuery();
            con.Close();
            ContainerData.Visible = false;
            FrmServices_Load(sender, e);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên đang chọn hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = $"delete from Dichvu where Madichvu = '{stt}'";
                connect.setDatda(query);
                ContainerData.Visible = false;
                FrmServices_Load(sender, e);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSrevices.Rows)
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
    }
}
