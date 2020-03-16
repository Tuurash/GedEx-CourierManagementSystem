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
    class CustomerRepository
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }

        private int Id { get; set; }
        private string Name { get; set; }
        private string PhoneNumber { get; set; }
        private string Password { get; set; }
        private string Address { get; set; }

        internal CustomerRepository(int id, string name, string address, string phoneNumber,string password)
        {
            this.con = new Connection();
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Password = password;
            this.Address = address;
        }

        public DataSet Display(string sql = "select * from Customer;")
        {
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public DataSet SearchLoginData(string name, string password)
        {
            string sql = "select * from Customer where EmpName = '" + name + "'  AND Password = '" + password + "';";
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public DataSet SearchUser(string name)
        {
            string sql = "select * from Customer where EmpName = '" + name + "';";
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public void Insert()
        {
            string sql = "select * from Customer where EmpId ='" + this.Id + "';";
            this.Ds = this.con.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update Customer
                set EmpName = '" + this.Name + @"',
                Address = '" + this.Address + @"',
                PhoneNumber = '" + this.PhoneNumber + @"',
                Password = '" + this.Password + @"'
                where EmpId = '" + this.Id + "';";

                try
                {
                    this.con.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                sql = @"insert into Customer
                values ('" + this.Name + "','" + this.PhoneNumber  + @"'
                ,'" +  this.Password + "','" + this.Address + "');";
                try
                {
                    this.con.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }



        }

        public void DeleteCustomer()
        {
            string sql = "delete from Customer where EmpId = '" + this.Id + "';";
            try
            {
                this.con.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
