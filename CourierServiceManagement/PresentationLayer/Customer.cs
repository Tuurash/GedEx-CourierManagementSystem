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
    public delegate void CustomerVisible();

    public partial class Customer : MetroFramework.Forms.MetroForm
    {

        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private LoginVisible LV { get; set; }
        private string TempName { get; set; }

        public Customer(string name,LoginVisible lv)
        {
            InitializeComponent();
            LblName.Text = name;
            this.LV = lv;
        }


        private void BtnSubmitted_Click(object sender, EventArgs e)
        {
            dgvAll.Rows.Clear();

            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=CourierServiceDB;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select * from ProductDb where Condition = 'Pending' and SenderNumber =(select PhoneNumber from Customer where Name= '" + LblName.Text + "') ", con);
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

        private void BtnRecieved_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelivered_Click(object sender, EventArgs e)
        {
            dgvAll.Rows.Clear();

            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=CourierServiceDB;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select * from ProductDb where Condition='Delivered' and RecieverNumber=(select PhoneNumber from Customer where Name= '" + LblName.Text + "') ", con);
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

        private void BtnNwOrder_Click(object sender, EventArgs e)
        {
            var FormVisibility = new CustomerVisible(this.Visibility);
            var ordersub = new OrderSubmit(Visibility);
            ordersub.Visible = true;
            this.Visible = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LV();
        }

        private void Visibility()
        {
            this.Visible = true;
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            LV();
        }

        private void dgvAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp;
            temp = this.dgvAll.CurrentRow.Cells[1].Value.ToString();
            this.TempName = temp;
        }

        private void BtnDlt_Click(object sender, EventArgs e)
        {
            var Productrepo = new ProductRepository();
            Productrepo.Deleteproduct(TempName);

            dgvAll.Rows.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var FormVisibility = new CustomerVisible(this.Visibility);
            var Updateform = new UpdateCustomer(Visibility);
            Updateform.Visible = true;
            this.Visible = false;


        }
    }
}
