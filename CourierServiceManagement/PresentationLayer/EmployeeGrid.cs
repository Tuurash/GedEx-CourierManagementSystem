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
    public partial class EmployeeGrid : MetroFramework.Forms.MetroForm
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private ManagerVisible MV { get; set; }
        private string TempId { get; set; }
        public EmployeeGrid(ManagerVisible man)
        {
            InitializeComponent();
            this.con = new Connection();
            this.MV = man;
            var emprepo = new EmployeeRepository();
            this.Ds = emprepo.Display();
            this.gridEmployee.DataSource = this.Ds.Tables[0];
        }

        private void EmployeeGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierServiceDBDataSet1.Employee1' table. You can move, or remove it, as needed.
            this.employee1TableAdapter.Fill(this.courierServiceDBDataSet1.Employee1);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var emprepo = new EmployeeRepository();
            this.Ds = emprepo.Display();
            this.gridEmployee.DataSource = this.Ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var emprepo = new EmployeeRepository();
            emprepo.DeleteEmployee(TempId);
            this.Ds = emprepo.Display();
            this.gridEmployee.DataSource = this.Ds.Tables[0];
        }

        private void gridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp;
            temp = this.gridEmployee.CurrentRow.Cells[0].Value.ToString();
            this.TempId = temp;
        }

        private void EmployeeGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            MV();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.MV();
        }
    }
}
