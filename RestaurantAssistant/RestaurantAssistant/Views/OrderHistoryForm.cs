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
    public partial class OrderHistoryForm : Form
    {
        int id;
        public OrderHistoryForm(int Id)
        {
            InitializeComponent();
            id = Id; 
            var orders = OrderController.GetOrder(id);
            dataGridViewHistory.DataSource = orders;
        }
    }
}
