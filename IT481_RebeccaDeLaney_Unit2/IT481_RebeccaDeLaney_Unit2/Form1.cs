using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_RebeccaDeLaney_Unit2
{
    public partial class Form1 : Form
    {
        DB database;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB("Server = LINDI\\SQLEXPRESS01; " +
                              "Trusted_Connection = true; " +
                              "Database = Northwind; " +
                              "User Instance = false; " +
                              "Connection timeout = 30");
            MessageBox.Show("Connection information sent.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company Names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order Count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string orderid = database.getOrders();
            MessageBox.Show(orderid, "OrderID");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastNames();
            MessageBox.Show(names, "Employee Last Names");
        }

    }
}
