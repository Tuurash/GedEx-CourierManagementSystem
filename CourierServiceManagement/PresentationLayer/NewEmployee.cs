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
    public partial class NewEmployee : MetroFramework.Forms.MetroForm
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private ManagerVisible MV { get; set; }
        public NewEmployee(ManagerVisible man)
        {
            InitializeComponent();
            this.con = new Connection();
            this.MV = man;
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "" && this.txtPhone.Text != "" && this.dtJoin.Text != "" && this.txtPassword.Text != "" && this.txtAddress.Text != "")
            {
                try
                {
                    var emprepo = new EmployeeRepository();
                    emprepo.Insert(this.txtName.Text, this.txtPhone.Text, this.dtJoin.Text, this.txtPassword.Text, this.txtAddress.Text);

                    this.Close();
                    MV();
                }
                catch(Exception exc) { MessageBox.Show("Error: "+exc); }
            }else { MessageBox.Show("Please Fillup All the requirements."); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MV();
        }

        private void NewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            MV();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int MinLength = 4;
            int MaxLength = 4;
            string CharAvailable = "1234567890";

            StringBuilder password = new StringBuilder();
            Random rdm = new Random();

            int passwordlength = rdm.Next(MinLength, MaxLength + 1);
            while (passwordlength-- > 0)
                password.Append(CharAvailable[rdm.Next(CharAvailable.Length)]);

            txtPassword.Text = password.ToString();
        }
    }
}
