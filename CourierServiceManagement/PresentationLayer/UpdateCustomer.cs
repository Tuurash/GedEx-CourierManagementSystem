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
using CourierServiceManagement.DatabaseAccessLayer;
using CourierServiceManagement.BusinessLayer;

namespace CourierServiceManagement.PresentationLayer
{
    public partial class UpdateCustomer : MetroFramework.Forms.MetroForm
    {
        private DataSet Ds { get; set; }
        private CustomerVisible CV { get; set; }

        public UpdateCustomer(CustomerVisible cv)
        {
            InitializeComponent();
            this.CV = cv;

        }

        

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            CustomerRepository Newtemp = new CustomerRepository(this.NameTxt.Text, this.AdressTxt.Text, this.PhoneNumberTxt1.Text, PasswordTxt2.Text);

            Newtemp.Insert();

            Newtemp.DisplayId(this.NameTxt.Text);

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CV();
        }

        private void UpdateCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CV();
        }
    }
}
