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
    class EmployeeRepository
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }

        private int Id { get; set; }
        private string Name { get; set; }
        private string PhoneNumber { get; set; }
        private string JoiningDate { get; set; }
        private int DeliveryCount { get; set; }
        private string Password { get; set; }
        private string Address { get; set; }
        private string Position { get; set; }

        internal EmployeeRepository()
        {
            this.con = new Connection();
        }

        internal EmployeeRepository(string name, string phoneNumber, string joiningDate, string password, string address)
        {
            this.con = new Connection();
            //this.Id= id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.JoiningDate = joiningDate;
            //this.DeliveryCount = deliveryCount;
            this.Address = address;
            //this.Position = position;
        }

        internal EmployeeRepository(int id, string name, string phoneNumber, string joiningDate, int deliveryCount,string password, string address, string position)
        {
            this.con = new Connection();
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.JoiningDate = joiningDate;
            this.DeliveryCount = deliveryCount;
            this.Password = password;
            this.Address = address;
            this.Position = position;
        }

        public DataSet Display(string sql="select * from Employee1;")
        {
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public DataSet SearchLoginData(string name, string password)
        {
            string sql = "select * from Employee1 where EmpName = '" + name + "'  AND Password = '" + password + "';";
            this.Ds = this.con.ExecuteQuery(sql);
            MessageBox.Show("Success!");
            return this.Ds;
        }

        public DataSet SearchUser(string name)
        {
            string sql = "select * from Employee1 where EmpName = '" + name + "';";
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }


        public void Insert(string name, string phone, string joiningDate, string password, string address)
        {

            //string sql = "select * from Employee1 where EmpId ='" + this.Id + "';";
            //this.Ds = this.con.ExecuteQuery(sql);

            //if (this.Ds.Tables[0].Rows.Count == 1)
            //{
            //    sql = @"update Employee1
            //    set EmpName = '" + this.Name + @"',
            //    Address = '" + this.Address + @"',
            //    JoiningDate = '" + this.JoiningDate + @"',
            //    PhoneNumber = '" + this.PhoneNumber + @"',
            //    Password = '" + this.Password + @"'
            //    Position = '"+this.Position+ @"'
            //    where EmpId = '" + this.Id + "';";

            //    try
            //    {
            //        this.con.ExecuteUpdateQuery(sql);
            //        MessageBox.Show("Upgradation Done.");

            //    }
            //    catch (Exception exc)
            //    {
            //        MessageBox.Show("Error: " + exc.Message);
            //    }
            //}
            //else
            //{
            try
            {
                string sql = @"insert into Employee1
                values ('" + name + "','" + phone + "', '" + joiningDate + @"'
                , '" + password + "','" + address + "', '" + "Deliveryman" + "');";
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
            catch { MessageBox.Show("Please Fillup All the requirements."); }
            



        }

        public void DeleteEmployee(string id)
        {
            string sql = "delete from Employee1 where EmpId = '" + id + "';";
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
                                   
                                    