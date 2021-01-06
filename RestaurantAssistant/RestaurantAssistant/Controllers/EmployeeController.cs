using RestaurantAssistant.Models;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAssistant.Controllers
{
    public class EmployeeController
    {
        static Database db = new Database();
        public static Employee AuthenticateEmployee(string username, string password)
        {
            return db.Employees.AuthenticateEmployee(username, password);
        }
        public static bool AddEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.Password = employee.Password;
            e.Username = employee.Username;
            e.Email = employee.Email;
            e.Phone = employee.Phone;

            return db.Employees.AddEmployee(e);
        }
        public static Employee GetEmployee(string username)
        {
            return db.Employees.GetEmployee(username);
        }

        public static bool UpdateEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Id = Convert.ToInt32( employee.Id);
            e.Username = employee.Username;
            e.Name = employee.Name;
            e.Password = employee.Password;
            e.Phone = employee.Phone;
            e.Email = employee.Email;

            return db.Employees.UpdateEmployee(e);
        }
        public static ArrayList GetAllEmployees()
        {
            return db.Employees.GetAllEmployees();
        }
        public static bool DeleteEmployee(string username)
        {
            return db.Employees.DeleteEmployee(username);
        }
    }
}
