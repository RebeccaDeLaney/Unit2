using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_RebeccaDeLaney_Unit2
{
    class DB
    {
        string connectionString;
        SqlConnection cnn;

        public DB()
        {
            connectionString = "Server = LINDI\\SQLEXPRESS01; " +
                              "Trusted_Connection = true; " +
                              "Database = Northwind; " +
                              "User Instance = false; " +
                              "Connection timeout = 30";
        }

        public DB(string conn) 
        {
            connectionString = conn;
        }

        public string getCustomerCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT COUNT(*) FROM dbo.Customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);  
            }
            return count.ToString();
        }

        public string getCompanyNames()
        {
            string names = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string nameQuery = "SELECT CompanyName FROM dbo.Customers;";
            SqlCommand cmd = new SqlCommand(nameQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }

        public string getOrderCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT COUNT(*) FROM dbo.Orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        public string getOrders()
        {
            string orderIDs = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string nameQuery = "SELECT OrderID FROM dbo.Orders;";
            SqlCommand cmd = new SqlCommand(nameQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    orderIDs = orderIDs + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return orderIDs;
        }

        public string getEmployeeCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT COUNT(*) FROM dbo.Employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        public string getEmployeeLastNames()
        {
            string orderIDs = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string nameQuery = "SELECT LastName FROM dbo.Employees;";
            SqlCommand cmd = new SqlCommand(nameQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    orderIDs = orderIDs + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return orderIDs;
        }
    }
}
