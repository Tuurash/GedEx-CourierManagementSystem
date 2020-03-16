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
    public partial class OrderSubmit :MetroFramework.Forms.MetroForm
    {  
        
        private DataSet Ds { get; set; }
        private CustomerVisible CV { get; set; }

        
        
        public OrderSubmit(CustomerVisible cv)
        {
            InitializeComponent();
            this.CV = cv;
        }

        private void OrderSubmit_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (this.NameTxt.Text != "" && this.AddressTxt.Text != "" && this.TxtPhoneNumber.Text != "" && this.TxtNumberSender.Text != "")
            {
                CustomerRepository Customtemp = new CustomerRepository();
                this.Ds= Customtemp.SearchByNumber(TxtPhoneNumber.Text);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {

                    try
                    {
                        ProductRepository producttemp = new ProductRepository();
                        producttemp.InsertProduct(this.NameTxt.Text, this.AddressTxt.Text, this.TxtPhoneNumber.Text, this.TxtNumberSender.Text);

                        this.Close();
                        CV();

                    }
                    catch (Exception exc) { MessageBox.Show("Error :" + exc); }
                }
                else{ MessageBox.Show("Reciever not Found."); }
            }
            else
            { MessageBox.Show("Please Fillup Mendatory Requirments "); }

           
        }

        private void OrderSubmit_FormClosing(object sender, FormClosingEventArgs e)
        {
            CV();
        }

        private void OrderSubmit_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CV();
            
         
           
        }
    }
}

