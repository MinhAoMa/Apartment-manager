using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apartment_manager_app
{
    public partial class FrmLogin : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public FrmLogin()
        {
            
            InitializeComponent();
        }                    
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Tài khoản đăng nhập của người dùng
            List<string> user = new List<string>();
            DataSet tmp = connect.GetData("select * from canho");
            foreach (DataRow dr in tmp.Tables[0].Rows)
            {
                user.Add(dr["Macanho"].ToString());
            }
            for (int i = 0; i < user.Count; i++)
            {                
                if (user[i].ToString() == txtUsername.Text && txtPassword.Text == "1")
                {
                    SqlConnection con = connect.getConnection();
                    con.Open();
                    string commandText = "INSERT INTO saveUser VALUES(@saveValue)";
                    SqlCommand com = new SqlCommand(commandText, con);
                    com.Parameters.AddWithValue("@saveValue", txtUsername.Text.Trim());
                    com.ExecuteNonQuery();
                    con.Close();
                    FrmUser frm = new FrmUser();
                    frm.Show();
                }
            }        
            // Tài khoản đăng nhâp của nhân viên quản lý
            List<string> Employee = new List<string>();
            DataSet tmp1 = connect.GetData("select Manhanvien from NhanVien where chucvu like N'%Quản lý%'");
            foreach (DataRow dr in tmp1.Tables[0].Rows)
            {
                Employee.Add(dr["Manhanvien"].ToString());
            }
            for (int i = 0; i < Employee.Count; i++)
            {               
                if (Employee[i].ToString().Trim() == txtUsername.Text)
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                }
            }                                 
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
