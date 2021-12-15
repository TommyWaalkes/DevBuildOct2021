using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class EmployeeDAL
    {
        //Get CRUD Actions working 
        //Once we get this working in employee we can then reuse most of this code for ToDo 
        public List<Employee> GetEmployees()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from employee";
                connect.Open();
                List<Employee> employees = connect.Query<Employee>(sql).ToList();
                connect.Close();
                return employees;
            }
        }

        public Employee GetEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from employee where id=" +id;
                connect.Open();
                Employee employee = connect.Query<Employee>(sql).ToList().First();
                connect.Close();
                return employee;
            }
        }

        public void AddEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into employee values(0, '{e.Name}', {e.HoursAvailible}, '{e.Title}')";
                connect.Open();
                connect.Query<Employee>(sql);
                connect.Close();
            }
        }
    }
}
