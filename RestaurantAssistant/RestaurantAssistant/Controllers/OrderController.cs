using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RestaurantAssistant.Models;

namespace RestaurantAssistant.Controllers
{
    public class OrderController
    {
        static Database db = new Database();
        public static bool AddOrder(dynamic order)
        {
            Order o = new Order();
            o.CustId = Convert.ToInt32(order.CustId);
            o.FoodName = order.Name;
            o.Price = Convert.ToDouble(order.Price);

            return db.Orders.AddOrder(o);
        }
        public static ArrayList GetAllOrders()
        {
            return db.Orders.GetAllOrders();
        }
        public static double GetSales()
        {
            return db.Orders.GetSales();
        }
        public static ArrayList GetOrder(int Id)
        {
            return db.Orders.GetOrder(Id);
        }
    }
}
