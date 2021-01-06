using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RestaurantAssistant.Models;

namespace RestaurantAssistant.Controllers
{
    class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string username, string password)
        {
            return db.Customers.AuthenticateCustomer(username, password);
        }
        public static bool AddCustomer(dynamic customer)
        {
            Customer c = new Customer();
            c.Name = customer.Name;
            c.Password = customer.Password;
            c.Username = customer.Username;
            c.Email = customer.Email;

            return db.Customers.AddCustomer(c);
        }
    }
}
