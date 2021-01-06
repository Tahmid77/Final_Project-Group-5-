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
    public partial class OfferCRUDForm : Form
    {
        public OfferCRUDForm()
        {
            InitializeComponent();
            var discountOffers = DiscountOfferController.GetAllDiscountOffers();
            GridFoodItem.DataSource = discountOffers;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var discountOffer = new
            {
                Name = tbName.Text,
                Price = tbPrice.Text,
            };
            bool result = DiscountOfferController.AddDiscountOffer(discountOffer);
            if (result)
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item Could not be added");
            }
            var discountOffers = DiscountOfferController.GetAllDiscountOffers();
            GridFoodItem.DataSource = discountOffers;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;
            dynamic discountOffer = DiscountOfferController.GetDiscountOffer(name);
            if (discountOffer != null)
            {

                textBox1.Text = Convert.ToString(discountOffer.Id);
                tbN.Text = discountOffer.Name;
                tbP.Text = Convert.ToString(discountOffer.Price);

            }
            else
            {
                textBox1.Text = "";
                tbN.Text = "";
                tbP.Text = "";
                MessageBox.Show("No Item found");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var discountOffer = new
            {
                Id = textBox1.Text,
                Name = tbN.Text,
                Price = tbP.Text,

            };
            bool result = DiscountOfferController.UpdateDiscountOffer(discountOffer);
            if (result)
            {
                MessageBox.Show("Item Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }

            var discountOffers = DiscountOfferController.GetAllDiscountOffers();
            GridFoodItem.DataSource = discountOffers;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var r = DiscountOfferController.DeleteDiscountOffer(tbN.Text);
            if (r)
            {
                MessageBox.Show("Item Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
            var discountOffers = DiscountOfferController.GetAllDiscountOffers();
            GridFoodItem.DataSource = discountOffers;
        }
    }
}
