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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = AdminUsername.Text;
            string password = AdminPassword.Text;
            var result = AdminController.AuthenticateAdmin(username, password);
            if (result != null)
            {
                new AdminOperationForm().Show();
            }
            else
                MessageBox.Show("User Not Valid");
        }
    }
}
