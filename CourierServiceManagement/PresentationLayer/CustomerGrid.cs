using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierServiceManagement.DatabaseAccessLayer;
using CourierServiceManagement.BusinessLayer;


namespace CourierServiceManagement.PresentationLayer
{
    public partial class CustomerGrid : MetroFramework.Forms.MetroForm
    {

        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private ManagerVisible MV { get; set; }
        private string TempId {get;set;}
        public CustomerGrid(ManagerVisible man)
        {
            InitializeComponent();
            this.con = new Connection();
            this.MV = man;
            var custrepo = new CustomerRepository();
            this.Ds = custrepo.Display();
            this.gridCustomer.DataSource = this.Ds.Tables[0];
        }

        private void CustomerGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierServiceDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.courierServiceDBDataSet.Customer);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var custrepo = new CustomerRepository();
            custrepo.DeleteCustomer(TempId);
            this.Ds = custrepo.Display();
            this.gridCustomer.DataSource= this.Ds.Tables[0];
        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp;
            temp = this.gridCustomer.CurrentRow.Cells[0].Value.ToString();
            this.TempId = temp;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var custrepo = new CustomerRepository();
            this.Ds = custrepo.Display();
            this.gridCustomer.DataSource = this.Ds.Tables[0];
        }

        private void CustomerGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            MV();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MV();
        }
    }
}
