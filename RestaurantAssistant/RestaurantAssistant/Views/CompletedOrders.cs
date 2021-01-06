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
    public partial class CompletedOrders : Form
    {
        public CompletedOrders()
        {
            InitializeComponent();
            var orders = OrderController.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void CompletedOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
