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
            if(txtUsername.Text.Trim() == "" ||txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu");
            }
            else if(txtUsername.Text.Trim() != "" || txtPassword.Text.Trim() != "")
            {
                String query1 = "select * from taikhoan";
                DataSet a = connect.GetData(query1);
                for(int i = 0;i< a.Tables[0].Rows.Count; i++)
                {
                    if(txtUsername.Text.Trim() == a.Tables[0].Rows[i][1].ToString().Trim() && txtPassword.Text.Trim() == a.Tables[0].Rows[i][2].ToString().Trim())
                    {
                        if (txtUsername.Text.Trim().Contains("nv"))
                        {
                            SqlConnection con = connect.getConnection();
                            con.Open();
                            string commandText = "INSERT INTO saveUser VALUES(@saveValue)";
                            SqlCommand com = new SqlCommand(commandText, con);
                            com.Parameters.AddWithValue("@saveValue", txtUsername.Text.Trim());
                            com.ExecuteNonQuery();
                            con.Close();
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                        }
                        else
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
                    }
            }                                
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {

        }
    }
}
