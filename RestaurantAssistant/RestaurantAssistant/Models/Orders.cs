using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace RestaurantAssistant.Models
{
    public class Orders
    {
        SqlConnection conn;
        public Orders()
        {
        }
        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddOrder(dynamic order)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Orders VALUES ('{0}','{1}','{2}')", order.CustId, order.FoodName, order.Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
       
        public double GetSales()
        {
            conn.Open();
            string query = "SELECT SUM(Price) FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            double count = (double)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }

        public ArrayList GetAllOrders()
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.CustId = reader.GetInt32(reader.GetOrdinal("CustId"));
                order.FoodName = reader.GetString(reader.GetOrdinal("FoodName"));
                order.Price = reader.GetDouble(reader.GetOrdinal("Price"));

                orders.Add(order);
            }
            conn.Close();
            return orders;
        }
        public ArrayList GetOrder(int id)
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = String.Format("SELECT * FROM Orders WHERE CustId='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order = null;
            while (reader.Read())
            {
                order = new Order();
                order.CustId = reader.GetInt32(reader.GetOrdinal("CustId"));
                order.FoodName = reader.GetString(reader.GetOrdinal("FoodName"));
                order.Price = reader.GetDouble(reader.GetOrdinal("Price"));
                orders.Add(order);
            }
            conn.Close();
            return orders;
        }
    }
}
