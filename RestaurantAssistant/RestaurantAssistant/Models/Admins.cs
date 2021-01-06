using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace RestaurantAssistant.Models
{
    public class Admins
    {
        SqlConnection conn;
        public Admins()
        {
        }
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public Admin AuthenticateAdmin(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admins WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetString(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;

        }
    }
}
