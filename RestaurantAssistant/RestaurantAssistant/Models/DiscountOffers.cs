using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssistant.Models
{
    public class DiscountOffers
    {
        SqlConnection conn;
        public DiscountOffers()
        {
        }
        public DiscountOffers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddDiscountOffer(DiscountOffer discountOffer)
        {
            conn.Open();
            string query = String.Format("INSERT INTO DiscountOffers VALUES ('{0}','{1}')", discountOffer.Name, discountOffer.Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public ArrayList GetAllDiscountOffers()
        {
            ArrayList discountOffers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM DiscountOffers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DiscountOffer discountOffer = new DiscountOffer();
                discountOffer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                discountOffer.Name = reader.GetString(reader.GetOrdinal("Name"));
                discountOffer.Price = reader.GetDouble(reader.GetOrdinal("Price"));

                discountOffers.Add(discountOffer);
            }
            conn.Close();
            return discountOffers;
        }
        public DiscountOffer GetDiscountOffer(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM DiscountOffers WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DiscountOffer discountOffer = null;
            while (reader.Read())
            {
                discountOffer = new DiscountOffer();
                discountOffer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                discountOffer.Name = reader.GetString(reader.GetOrdinal("Name"));
                discountOffer.Price = reader.GetDouble(reader.GetOrdinal("Price"));

            }
            conn.Close();
            return discountOffer;
        }
        public bool UpdateDiscountOffer(DiscountOffer discountOffer)
        {
            conn.Open();
            string query = String.Format("UPDATE DiscountOffers SET Name='{0}',Price='{1}' WHERE Id='{2}'", discountOffer.Name, discountOffer.Price, discountOffer.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            else
                return false;
        }
        public bool DeleteDiscountOffer(string name)
        {
            conn.Open();
            string query = String.Format("DELETE FROM DiscountOffers WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
    }
}
