using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace RestaurantAssistant.Models
{
    public class Database
    {
        public Admins Admins { get; set; }
        public Customers Customers { get; set; }
        public Employees Employees { get; set; }
        public FoodItems FoodItems { get; set; }
        public Orders Orders { get; set; }
        public DiscountOffers DiscountOffers { get; set; }

        public Database()
        {
            //string connString = "Server=DESKTOP-06CPA49\SQLEXPRESS;Integrated Security=true;Database=Restaurant_DB";
            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-06CPA49\SQLEXPRESS;Integrated Security=true;Database=Restaurant_DB");
            Admins = new Admins(conn);
            Customers = new Customers(conn);
            Employees = new Employees(conn);
            FoodItems = new FoodItems(conn);
            Orders = new Orders(conn);
            DiscountOffers = new DiscountOffers(conn);
        }
    }
}
