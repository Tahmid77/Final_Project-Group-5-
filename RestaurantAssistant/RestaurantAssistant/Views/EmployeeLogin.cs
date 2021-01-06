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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = EmployeeUsername.Text;
            string password = EmployeePassword.Text;
            var result = EmployeeController.AuthenticateEmployee(username, password);
            if (result != null)
            {
                new OfferCRUDForm().Show();
            }
            else
                MessageBox.Show("User Not Valid");
        }
    }
}
