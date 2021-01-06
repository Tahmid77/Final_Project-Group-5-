using RestaurantAssistant.Models;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssistant.Controllers
{
    public class FoodItemController
    {
        static Database db = new Database();
        public static bool AddFoodItem(dynamic foodItem)
        {
            FoodItem f = new FoodItem();
            f.Name = foodItem.Name;
            f.Price = Convert.ToDouble(foodItem.Price);

            return db.FoodItems.AddFoodItem(f);
        }
        public static FoodItem GetFoodItem(string name)
        {
            return db.FoodItems.GetFoodItem(name);
        }

        public static bool UpdateFoodItem(dynamic foodItem)
        {
            FoodItem f = new FoodItem();
            f.Id = Convert.ToInt32(foodItem.Id);
            f.Name = foodItem.Name;
            f.Price =Convert.ToDouble( foodItem.Price);
            return db.FoodItems.UpdateFoodItem(f);
        }
        public static ArrayList GetAllFoodItems()
        {
            return db.FoodItems.GetAllFoodItems();
        }
        public static bool DeleteFoodItem(string name)
        {
            return db.FoodItems.DeleteFoodItem(name);
        }
    }
}
