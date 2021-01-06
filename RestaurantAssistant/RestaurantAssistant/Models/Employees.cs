using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssistant.Models
{
    public class Employees
    {
        SqlConnection conn;
        public Employees()
        {
        }
        public Employees(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Employees VALUES ('{0}','{1}','{2}','{3}','{4}')", employee.Name, employee.Username, employee.Password, employee.Email, employee.Phone);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public Employee AuthenticateEmployee(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Username = reader.GetString(reader.GetOrdinal("Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employee.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
            }
            conn.Close();
            return employee;

        }

        public ArrayList GetAllEmployees()
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = "SELECT Id,Name,Username,Email,Phone FROM Employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Username = reader.GetString(reader.GetOrdinal("Username"));
                employee.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));

                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public Employee GetEmployee(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Username = reader.GetString(reader.GetOrdinal("Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employee.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
            }
            conn.Close();
            return employee;
        }
        public bool UpdateEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("UPDATE Employees SET Name='{0}',Username='{1}',Password='{2}',Phone='{3}',Email='{4}' WHERE Id='{5}'", employee.Name, employee.Username, employee.Password, employee.Phone, employee.Email, employee.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            else
                return false;
        }
        public bool DeleteEmployee(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Employees WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
    }
}
