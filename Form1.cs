using System.Windows.Forms;
using System;
using System.Web.Mvc;
using System.Collections;
using IT481_Weaver_Unit03;
using System.Linq;

namespace IT481_Weaver_Unit3
{
    public partial class Form1 : Form
    {
        DB database;
        private string user;
        private string password;
        private string server;
        private string dbase;
        public Form1()
        {

            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            dbase = textBox4.Text;

            if (user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || dbase.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter user name, password, server, and database values");
            }
            ///New Password Requirements
            else if(password.Length < 12)
            {
                isValid = false;
                MessageBox.Show("Password length must be 12 characters or more");
            }
            else
            {
                if (password.All(char.IsLetterOrDigit) && password.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    isValid = false;
                    MessageBox.Show("You must enter alphanumeric and special characters for the password.");
                }
            }
            //End of New Password Requirements
            if (isValid)
            {
                MessageBox.Show("Connection Information Sent");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerNames();
            MessageBox.Show(count, "Customer Names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string count = database.getOrder();
            MessageBox.Show(count, "OrderID");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeLastName();
            MessageBox.Show(count, "Employee Last Name");
        }

    }
}
