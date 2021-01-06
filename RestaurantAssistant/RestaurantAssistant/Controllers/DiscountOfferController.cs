using RestaurantAssistant.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssistant.Controllers
{
    public class DiscountOfferController
    {
        static Database db = new Database();
        public static bool AddDiscountOffer(dynamic discountOffer)
        {
            DiscountOffer d = new DiscountOffer();
            d.Name = discountOffer.Name;
            d.Price = Convert.ToDouble(discountOffer.Price);

            return db.DiscountOffers.AddDiscountOffer(d);
        }
        public static DiscountOffer GetDiscountOffer(string name)
        {
            return db.DiscountOffers.GetDiscountOffer(name);
        }

        public static bool UpdateDiscountOffer(dynamic discountOffer)
        {
            DiscountOffer d = new DiscountOffer();
            d.Id = Convert.ToInt32(discountOffer.Id);
            d.Name = discountOffer.Name;
            d.Price = Convert.ToDouble(discountOffer.Price);
            return db.DiscountOffers.UpdateDiscountOffer(d);
        }
        public static ArrayList GetAllDiscountOffers()
        {
            return db.DiscountOffers.GetAllDiscountOffers();
        }
        public static bool DeleteDiscountOffer(string name)
        {
            return db.DiscountOffers.DeleteDiscountOffer(name);
        }
    }
}
