using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperForeignKeys.Models
{
    public class SchoolDAL
    {
        public Teacher GetTeacher(int id)
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from Teachers where id=" + id;
                connect.Open();
                Teacher t = connect.Query<Teacher>(sql).First();
                connect.Close();
                return t;
            }
        }

        public List<Student> GetStudentsByTeacher(int teacherId)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from Students where id=" + teacherId;
                connect.Open();
                List<Student> students = connect.Query<Student>(sql).ToList();
                connect.Close();
                return students;
            }
        }
    }
}
