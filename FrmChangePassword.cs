using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Apartment_manager_app
{
    public partial class FrmChangePassword : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnChange_Click(object sender, EventArgs e)
        {
            string query = "select top 1 saveValue from saveUser order by ID desc";
            DataSet a = connect.GetData(query);
            if(txttentk.Text.Trim() == "" || txtmkmoi.Text.Trim() == "" || txtmkmoi2.Text.Trim() == "" || txtmatkhaucu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }          
            else if(txtmkmoi.Text == txtmkmoi2.Text && txttentk.Text == a.Tables[0].Rows[0][0].ToString())
            {
                String query1 = "update taikhoan set matkhau ='" + txtmkmoi.Text + "' where tentaikhoan = '"+ a.Tables[0].Rows[0][0].ToString() + "'";
                connect.setDatda(query1);
                MessageBox.Show("Đổi thành công");
            }            
        }
    }
}
