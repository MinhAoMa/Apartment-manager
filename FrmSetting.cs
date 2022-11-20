using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Apartment_manager_app
{
    public partial class FrmSetting : Form
    {
        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        private int _Language = 1;
        private int _Darkmode = 0;
        public FrmSetting()
        {
            
            InitializeComponent();
        }

        private void btnkeyboard_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();    
            frm.ShowDialog();
        }

        private void ToogleBackGround_CheckedChanged(object sender, EventArgs e)
        {
            if(ToogleBackGround.Checked == false)
            {
                
                this.BackColor = System.Drawing.Color.FromArgb(60,60,60);
                this.MdiParent.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                this.MdiParent.ForeColor = System.Drawing.Color.White;
                
                _Darkmode = 1;

                if (_Language == 0)
                {
                    LbDarkMode.Text = "Tối";
                }
                else
                {
                    LbDarkMode.Text = "Dark";
                }
            }
            else if(ToogleBackGround.Checked == true)
            {
                
                this.BackColor = System.Drawing.Color.White;
                this.MdiParent.BackColor = System.Drawing.Color.White;
                this.MdiParent.ForeColor = System.Drawing.Color.Black;

                _Darkmode = 0;
                if (_Language == 0)
                {
                    LbDarkMode.Text = "Sáng";
                }
                else
                {
                    LbDarkMode.Text = "Light";
                }
                
            }
        }

        private void FrmSetting_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void CbbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbbLanguages.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                    _Language = 0;

                    break;
                case 1:

                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    _Language = 1;
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();
            if(_Darkmode == 0)
            {
                this.BackColor = System.Drawing.Color.White;
                this.MdiParent.BackColor = System.Drawing.Color.White;
                this.MdiParent.ForeColor = System.Drawing.Color.Black;
                ToogleBackGround.Checked = true;
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                this.MdiParent.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                this.MdiParent.ForeColor = System.Drawing.Color.White;
                
                ToogleBackGround.Checked = false;
            }


            if (_Language == 0)
            {
                this.PicFlag.Image = System.Drawing.Image.FromFile("D:\\lastClone\\Apartment-manager\\Resources\\vietnam.png");
            }
            else
            {
                this.PicFlag.Image = System.Drawing.Image.FromFile("D:\\lastClone\\Apartment-manager\\Resources\\united-kingdom.png");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
            
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            string query = "select top 1 saveValue from saveUser order by ID desc";
            DataSet a = connect.GetData(query);
            labeltk.Text = a.Tables[0].Rows[0][0].ToString();
        }
    }
}
