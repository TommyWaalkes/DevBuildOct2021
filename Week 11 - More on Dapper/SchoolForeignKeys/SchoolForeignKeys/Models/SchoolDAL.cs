using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolForeignKeys.Models
{
    public class SchoolDAL
    {
        public Teacher GetTeacher(int id)
        {
            //Grab the teacher by Id 
            //Then grab all students with a matching foreign key 

            using(var connect = new MySqlConnection(Secret.Connection))
            {
                //Dapper doesn't care if you put your semicolon on, unlike mySQL
                string getTeacherSql = "select * from teachers where id=" + id+";";
                string getStudentsSql = "select * from students where taughtBy=" + id ;

                connect.Open();
                Teacher t = connect.Query<Teacher>(getTeacherSql).First();
                t.Students = connect.Query<Student>(getStudentsSql).ToList();
                connect.Close();

                return t;
            }
        }

        public List<Teacher> GetTeachers()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from teachers";
                connect.Open();
                List<Teacher> teachers = connect.Query<Teacher>(sql).ToList();
                connect.Close();
                return teachers;
            }
        }
    }
}
