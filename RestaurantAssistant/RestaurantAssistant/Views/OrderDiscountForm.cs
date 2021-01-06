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
    public partial class OrderDiscountForm : Form
    {
        int Id;
        public OrderDiscountForm(int id)
        {
            InitializeComponent();
            var discountOffers = DiscountOfferController.GetAllDiscountOffers();
            GridFoodItem.DataSource = discountOffers;
            Id = id;
            textBox1.Text = Convert.ToString(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbItem1.Text = "";
            tbItem2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string item1 = tbItem1.Text;
            string item2 = tbItem2.Text;
            if (item1 != null)
            {
                dynamic orderItem = DiscountOfferController.GetDiscountOffer(item1);
                if (orderItem != null)
                {

                    var order = new
                    {
                        CustId = id,
                        Name = orderItem.Name,
                        Price = orderItem.Price,
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
                dynamic orderItem = DiscountOfferController.GetDiscountOffer(item2);
                if (orderItem != null)
                {

                    var order = new
                    {
                        CustId = id,
                        Name = orderItem.Name,
                        Price = orderItem.Price,
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
