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
    public partial class FoodMenuCRUDForm : Form
    {
        public FoodMenuCRUDForm()
        {
            InitializeComponent();
            var foodItems = FoodItemController.GetAllFoodItems();
            GridFoodItem.DataSource = foodItems;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var foodItem = new
            {
                Name = tbName.Text,
                Price = tbPrice.Text,
            };
            bool result = FoodItemController.AddFoodItem(foodItem);
            if (result)
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item Could not be added");
            }
            var foodItems = FoodItemController.GetAllFoodItems();
            GridFoodItem.DataSource = foodItems;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;
            dynamic foodItem = FoodItemController.GetFoodItem(name);
            if (foodItem != null)
            {

                textBox1.Text = Convert.ToString(foodItem.Id);
                tbN.Text = foodItem.Name;
                tbP.Text =Convert.ToString( foodItem.Price);

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
            var foodItem = new
            {
                Id = textBox1.Text,
                Name = tbN.Text,
                Price = tbP.Text,

            };
            bool result = FoodItemController.UpdateFoodItem(foodItem);
            if (result)
            {
                MessageBox.Show("Item Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }

            var foodItems = FoodItemController.GetAllFoodItems();
            GridFoodItem.DataSource = foodItems;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var r = FoodItemController.DeleteFoodItem(tbN.Text);
            if (r)
            {
                MessageBox.Show("Item Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
            var foodItems = FoodItemController.GetAllFoodItems();
            GridFoodItem.DataSource = foodItems;
        }
    }
}
