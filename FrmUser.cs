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
    public partial class FrmUser : Form

    {

        public Apartment_manager_app.ClassCallConnection connect = new ClassCallConnection();
        string query;
        int totalPrice = 0;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            
            // Load các dịch vụ ra
            DataSet tmp = connect.GetData("select tendichvu,giatien from Dichvu");
            dgvdangky.DataSource = tmp.Tables[0];
            //
            string count = "select top 1 saveValue from saveUser order by ID desc";
            DataSet countMacanho = connect.GetData(count);
            //
            MessageBox.Show(countMacanho.Tables[0].Rows[0][0].ToString());          


            string newquery = $"select DISTINCT tendichvu from qlDichVu where macanho = {countMacanho.Tables[0].Rows[0][0].ToString()}";

            DataSet dataTendv = connect.GetData(newquery);
            List<string> Savedv = new List<string>();
            foreach (DataRow dr in dataTendv.Tables[0].Rows)
            {
                Savedv.Add(dr["tendichvu"].ToString());
            }
                 
            for(int i =0; i < Savedv.Count; i++)
            {
                for(int j = 0; j < dgvdangky.Rows.Count; j++)
                {
                    if(Savedv[i] == dgvdangky.Rows[j].Cells[1].Value.ToString())
                    {                       
                        dgvdangky.Rows[j].Cells[0].Value = true;                     
                    }
                   
                }
            }
            
            foreach(DataGridViewRow row in dgvdangky.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    totalPrice += int.Parse(row.Cells[2].Value.ToString());
                    price.Text = totalPrice.ToString();
                }
            }
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string queryDelete = "delete  from qlDichVu";
            DataSet lol = connect.GetData(queryDelete);
            foreach (DataGridViewRow row in dgvdangky.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    query = "select top 1 saveValue from saveUser order by ID desc";
                    DataSet a = connect.GetData(query);                   
                    String query1 = "INSERT INTO qlDichVu VALUES('"+ a.Tables[0].Rows[0][0].ToString()+"'," +
                        "N'"+row.Cells[1].Value.ToString()+"')";
                    connect.setDatda(query1);                    
                    totalPrice += int.Parse(row.Cells[2].Value.ToString());
                    price.Text = totalPrice.ToString();
                }               
            }               
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            string queryDelete = "delete  from saveUser";
            DataSet lol = connect.GetData(queryDelete);
        }
    }
}
