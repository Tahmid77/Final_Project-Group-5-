using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantAssistant.Models
{
    public class FoodItems
    {
        SqlConnection conn;
        public FoodItems()
        {
        }
        public FoodItems(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddFoodItem(FoodItem foodItem)
        {
            conn.Open();
            string query = String.Format("INSERT INTO FoodItems VALUES ('{0}','{1}')", foodItem.Name, foodItem.Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public ArrayList GetAllFoodItems()
        {
            ArrayList foodItems = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM FoodItems";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FoodItem foodItem = new FoodItem();
                foodItem.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                foodItem.Name = reader.GetString(reader.GetOrdinal("Name"));
                foodItem.Price = reader.GetDouble(reader.GetOrdinal("Price"));

                foodItems.Add(foodItem);
            }
            conn.Close();
            return foodItems;
        }
        public FoodItem GetFoodItem(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM FoodItems WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            FoodItem foodItem = null;
            while (reader.Read())
            {
                foodItem = new FoodItem();
                foodItem.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                foodItem.Name = reader.GetString(reader.GetOrdinal("Name"));
                foodItem.Price = reader.GetDouble(reader.GetOrdinal("Price"));
                
            }
            conn.Close();
            return foodItem;
        }
        public bool UpdateFoodItem(FoodItem foodItem)
        {
            conn.Open();
            string query = String.Format("UPDATE FoodItems SET Name='{0}',Price='{1}' WHERE Id='{2}'", foodItem.Name, foodItem.Price,  foodItem.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            else
                return false;
        }
        public bool DeleteFoodItem(string name)
        {
            conn.Open();
            string query = String.Format("DELETE FROM FoodItems WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
    }
}
