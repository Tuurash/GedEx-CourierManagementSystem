using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierServiceManagement.PresentationLayer;
using CourierServiceManagement.DatabaseAccessLayer;
using CourierServiceManagement.BusinessLayer;

namespace CourierServiceManagement
{
    public delegate void LoginVisible();
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        static int count = 0;
        private DataSet Ds { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            LoginPanel.Visible = false;
        }
        

 
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (this.NameTxt.Text != "" && this.AdressTxt.Text != "" && this.PhoneNumberTxt1.Text != "" && PasswordTxt2.Text != "")
            {
                try
                {
                    CustomerRepository Newtemp = new CustomerRepository(this.NameTxt.Text, this.AdressTxt.Text, this.PhoneNumberTxt1.Text, PasswordTxt2.Text);

                    Newtemp.Insert();

                    Newtemp.DisplayId(this.NameTxt.Text);

                    Panel1.Visible = true;
                    Panel2.Visible = false;



                } catch (Exception exc) { MessageBox.Show("Error :" + exc); }
            }else
            { MessageBox.Show("Please fillup All Mendatory sections."); }

           
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
           
            if (UsernameTxt.Text=="Admin" && PasswordTxt.Text=="123")
            {
                LoginVisible LoginFromVisibility = new LoginVisible(this.Visibility);
                Manager man = new Manager(LoginFromVisibility);
                man.Visible = true;
                this.Visible = false;
            }
            else
            {
                if (count == 0)
                {
                    try
                    {
                        EmployeeRepository Emptemp = new EmployeeRepository();
                        this.Ds = Emptemp.SearchLoginData(this.UsernameTxt.Text, PasswordTxt.Text);
                        if (this.Ds.Tables[0].Rows.Count == 1)
                        {
                            
                            Employee emp = new Employee(Visibility);
                            emp.Visible = true;
                            this.Visible = false;
                        }
                        else { MessageBox.Show("User Name or Password Error"); }

                    }
                    catch (Exception exc) { MessageBox.Show("Login error : " + exc); }
                }
                else
                {
                    try
                    {
                        CustomerRepository custrepo = new CustomerRepository();
                        this.Ds = custrepo.SearchLoginData(this.UsernameTxt.Text, PasswordTxt.Text);
                        if (this.Ds.Tables[0].Rows.Count == 1)
                        {
                            MessageBox.Show("Success!");
                            Customer cus = new Customer(UsernameTxt.Text,Visibility);
                            cus.Visible = true;
                            this.Visible = false;

                            Customer passCustomer = new Customer(UsernameTxt.Text,Visibility);
                        }
                        else { MessageBox.Show("User Name or Password Error"); }

                    }
                    catch (Exception exc) { MessageBox.Show("Login error : " + exc); }
                }
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            count = 1;
            LoginPanel0.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            count = 0;
            LoginPanel0.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
        }

        private void Visibility()
        {
            this.Visible = true;
            this.UsernameTxt.Text = "";
            this.PasswordTxt.Text = "";
            this.NameTxt.Text = "";
            this.AdressTxt.Text = "";
            this.PhoneNumberTxt1.Text = "";
            this.Password.Text = "";
        }

        private void BtnBck_Click(object sender, EventArgs e)
        {
            
            LoginPanel0.Visible = true;
            LoginPanel.Visible = false;
        }
    }
}
