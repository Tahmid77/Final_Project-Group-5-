using RestaurantAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace RestaurantAssistant.Controllers
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string username, string password)
        {
            return db.Admins.AuthenticateAdmin(username, password);
        }
    }
}
