using RestaurantAssistant.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAssistant.Views
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CustomerRegistration().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = CustomerUsername.Text;
            string password = CustomerPassword.Text;
            var result = CustomerController.AuthenticateCustomer(username, password);
            if (result != null)
            {
                new CustomerForm(result.Id).Show();
            }
            else
                MessageBox.Show("User Not Valid");
        }
    }
}
