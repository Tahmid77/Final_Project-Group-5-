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
using RestaurantAssistant;
namespace RestaurantAssistant.Views
{
    public partial class EmployeeCRUDForm : Form
    {
        public EmployeeCRUDForm()
        {
            InitializeComponent();
            var employees = EmployeeController.GetAllEmployees();
            GridEmployee.DataSource = employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employee = new
            {
                Name = tbName.Text,
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Email = tbEmail.Text,
                Phone = tbPhone.Text,
            };
            bool result = EmployeeController.AddEmployee(employee);
            if (result)
            {
                MessageBox.Show("Employee Added");
            }
            else
            {
                MessageBox.Show("Employee Could not be added");
            }
            var employees = EmployeeController.GetAllEmployees();
            GridEmployee.DataSource = employees;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string username = tbSearch.Text;
            dynamic employee = EmployeeController.GetEmployee(username);
            if (employee != null)
            {
                
                textBox1.Text =Convert.ToString( employee.Id);
                tbN.Text = employee.Name;
                tbU.Text = employee.Username;
                tbP.Text = employee.Password;
                tbE.Text = employee.Email;
                tbPh.Text = employee.Phone;

            }
            else
            {
                textBox1.Text = "";
                tbN.Text = "";
                tbU.Text = "";
                tbP.Text = "";
                tbE.Text = "";
                tbPh.Text = "";
                MessageBox.Show("No user found");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var employee = new
            {
                Id = textBox1.Text,
                Name = tbN.Text,
                Username = tbU.Text,
                Password = tbP.Text,
                Email = tbE.Text,
                Phone = tbPh.Text,

            };
            bool result = EmployeeController.UpdateEmployee(employee);
            if (result)
            {
                MessageBox.Show("User Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }

            var employees = EmployeeController.GetAllEmployees();
            GridEmployee.DataSource = employees;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var r = EmployeeController.DeleteEmployee(tbU.Text);
            if (r)
            {
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
            var employees = EmployeeController.GetAllEmployees();
            GridEmployee.DataSource = employees;
        }
    }
}
