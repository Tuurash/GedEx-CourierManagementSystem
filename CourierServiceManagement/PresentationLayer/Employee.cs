using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CourierServiceManagement.DatabaseAccessLayer;
using CourierServiceManagement.BusinessLayer;

namespace CourierServiceManagement.PresentationLayer
{
    
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private string TempName { get; set; }

        private LoginVisible LV { get; set; }

        public Employee(LoginVisible lv)
        {
            InitializeComponent();
            this.LV = lv;
        }

        public void DisplayGrid()
        {
            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=CourierServiceDB;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select * from ProductDb where Condition = 'Pending'", con);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvAll.Rows.Add();
                dgvAll.Rows[n].Cells[0].Value = item[0].ToString();
                dgvAll.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                dgvAll.Rows[n].Cells[2].Value = item["Condition"].ToString();
                dgvAll.Rows[n].Cells[3].Value = item["Address"].ToString();
                dgvAll.Rows[n].Cells[4].Value = item["RecieverNumber"].ToString();
                dgvAll.Rows[n].Cells[5].Value = item["SenderNumber"].ToString();

            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DisplayGrid();
        }

        private void BtnDeliver_Click(object sender, EventArgs e)
        {
            var Productrepo = new ProductRepository();
            Productrepo.Deliverproduct(TempName);

            dgvAll.Rows.Clear();
        }

        private void dgvAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp;
            temp = this.dgvAll.CurrentRow.Cells[1].Value.ToString();
            this.TempName = temp;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvAll.Rows.Clear();
            DisplayGrid();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LV();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            LV();
        }
    }
}
