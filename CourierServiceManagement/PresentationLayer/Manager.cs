using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using CourierServiceManagement.DatabaseAccessLayer;

namespace CourierServiceManagement.PresentationLayer
{
    public delegate void ManagerVisible();
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private LoginVisible LV { get; set; }
        private string TempId;
        public Manager(LoginVisible lv)
        {
            InitializeComponent();
            this.con = new Connection();
            this.LV = lv;
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvAll.Rows.Clear();

            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=CourierServiceDB;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select * from ProductDb", con);
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

        private void btnPending_Click(object sender, EventArgs e)
        {
            dgvAll.Rows.Clear();
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

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            LV();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            dgvAll.Rows.Clear();

            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=CourierServiceDB;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select * from ProductDb where Condition = 'Delivered'", con);
            DataTable dt = new DataTable();
            sql.Fill(dt);

            var topLeftHeaderCell = dgvAll.TopLeftHeaderCell;
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

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            var FormVisibilty = new ManagerVisible(this.Visibility);
            var ne = new NewEmployee(FormVisibilty);
            ne.Visible = true;
            this.Visible = false;
        }

        private void btnSubmitted_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp;
            temp = this.dgvAll.CurrentRow.Cells["productId"].Value.ToString();
            this.TempId = temp;
        }

        

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            var FormVisibilty = new ManagerVisible(this.Visibility);
            var empView = new EmployeeGrid(FormVisibilty);
            this.Visible = false;
            empView.Visible = true;
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            var FormVisibilty = new ManagerVisible(this.Visibility);
            var custview = new CustomerGrid(FormVisibilty);
            this.Visible = false;
            custview.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LV();
        }

        private void Visibility()
        {
            this.Visible = true;
        }
    }
}
