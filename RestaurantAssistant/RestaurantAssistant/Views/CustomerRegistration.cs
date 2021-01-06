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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var customer = new
            {
                Name = tbName.Text,
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Email = tbEmail.Text,
            };

            bool result = CustomerController.AddCustomer(customer);
            if (result)
            {
                MessageBox.Show("Registered");
            }
            else
            {
                MessageBox.Show("Could not Register");
            }
        }
    }
}
