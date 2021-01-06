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
    public partial class OrderForm : Form
    {
        int id;
        public OrderForm(int Id)
        {
            InitializeComponent();
            var foodItems = FoodItemController.GetAllFoodItems();
            GridFoodItem.DataSource = foodItems;
            id = Id;
            textBox1.Text =Convert.ToString( id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbItem1.Text = "";
            tbItem2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( textBox1.Text);
            string item1 = tbItem1.Text;
            string item2 = tbItem2.Text;
            if (item1 != null)
            {
                dynamic foodItem1 = FoodItemController.GetFoodItem(item1);
                if (foodItem1 != null)
                {

                    var order = new
                    {
                        CustId = id,
                        Name = foodItem1.Name,
                        Price = foodItem1.Price,
                    };
                    var result = OrderController.AddOrder(order);
                    if (result)
                    {
                        MessageBox.Show("Item 1 Ordered");
                    }
                    else
                        MessageBox.Show("Could not order 1");
                }
                else
                {
                    MessageBox.Show("Item 1 not found");
                }
            }
            if (item2 != null)
            {
                dynamic foodItem1 = FoodItemController.GetFoodItem(item2);
                if (foodItem1 != null)
                {

                    var order = new
                    {
                        CustId = id,
                        Name = foodItem1.Name,
                        Price = foodItem1.Price,
                    };
                    var result = OrderController.AddOrder(order);
                    if (result)
                    {
                        MessageBox.Show("Item 2 Orderd");
                    }
                    else
                        MessageBox.Show("Could not orderd");
                }
                else
                {
                    MessageBox.Show("Item 2 not found");
                }
            }
        }
    }
}
