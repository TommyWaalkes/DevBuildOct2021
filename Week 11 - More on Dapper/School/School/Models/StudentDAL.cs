using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class StudentDAL
    {
        //Write a method for each CRUD actions

        public List<Student> GetStudents()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from students;";
                connect.Open();
                //Query will return an Ienumerable, how do we get it into a useable format (IE a list)?
                List<Student> students= connect.Query<Student>(sql).ToList();
                connect.Close();
                return students;
            }
        }

        public void AddStudent(Student s)
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into students values(0, '{s.fullName}', {s.GPA}, '{s.favoriteSubject}', {s.Age});";
                connect.Open();
                connect.Query<Student>(sql);
                connect.Close();
            }
        }

        public void DeleteStudent(int id)
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "delete from students where id =" + id;
                connect.Open();
                connect.Query<Student>(sql);
                connect.Close();
            }
        }

        public void UpdateStudent(Student s)
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update students " +
                    $"set fullName= '{s.fullName}', age={s.Age}, GPA={s.GPA}, favoriteSubject='{s.favoriteSubject}' " +
                    $"where id={s.Id};";

                connect.Open();
                connect.Query<Student>(sql);
                connect.Close();
            }
        }
    }
}
