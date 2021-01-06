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
    public partial class AdminOperationForm : Form
    {
        public AdminOperationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeeCRUDForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FoodMenuCRUDForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Revenue().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CompletedOrders().Show();
        }
    }
}
