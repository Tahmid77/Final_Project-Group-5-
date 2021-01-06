using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssistant.Models
{
    public class Order
    {
        public int CustId { get; set; }
        public string FoodName { get; set; }
        public double Price { get; set; }
    }
}
