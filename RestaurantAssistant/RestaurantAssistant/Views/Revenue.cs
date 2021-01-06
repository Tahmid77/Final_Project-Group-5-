using RestaurantAssistant.Controllers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAssistant.Views
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            

        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            double sum = OrderController.GetSales();
            richTextBox1.Text = String.Format("Total sales : {0} Taka", sum);
        }
    }
}
