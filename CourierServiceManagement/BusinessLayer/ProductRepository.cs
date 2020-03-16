using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CourierServiceManagement.DatabaseAccessLayer;

namespace CourierServiceManagement.BusinessLayer
{
    class ProductRepository
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }

        private int Id { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
      
        private string Condition { get; set; }
        private string Recievernumber { get; set; }
        private string Sendernumber { get; set; }


        internal ProductRepository()

        {
            this.con = new Connection();
        }

        public DataSet Display(string sql = "select * from Product;")
        {
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public void Deliverproduct(string name)
        {
            try
            {
                string sql = "UPDATE ProductDb SET Condition = 'Delivered' WHERE ProductName = '" + name + "'; ";
                this.con.ExecuteUpdateQuery(sql);
                MessageBox.Show("Success.");
            }
            catch (Exception exc) { MessageBox.Show("Error: " + exc); }
        }

        public void Deleteproduct(string name)
        {
            try
            {
                string sql = "delete from ProductDb WHERE Condition='Pending' and ProductName = '" + name + "'; ";
                this.con.ExecuteUpdateQuery(sql);
                
            }
            catch (Exception exc) { MessageBox.Show("Error: " + exc); }
        }

        public void InsertProduct(string name, string address,string recieverNumber ,string sendernumber )
        {
            
           
               // try
               // {
               //     string sql = "select * from Customer where PhoneNumber='" + recieverNumber + "' ";
               //     this.con.ExecuteUpdateQuery(sql);
               //     MessageBox.Show("Reciever ID found.");

                try
                {
                    string sql = "insert into ProductDb values ('" + name + "','" + "Pending" + "', '" + address + "','" + recieverNumber + "','" + sendernumber + "');";
                    this.con.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.");
                }
                catch (Exception exc) { MessageBox.Show("Error:" + exc); }           

            
        }
    }
}
