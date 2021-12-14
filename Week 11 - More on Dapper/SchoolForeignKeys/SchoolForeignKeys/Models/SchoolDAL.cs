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

        public List<TeacherSubject> GetTeacherSubjects()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                //When doing Dapper you want to make sure you match the name of the table 
                string tsSQL = "select * from teacherssubjects";
                List<TeacherSubject> teacherSubjects = connect.Query<TeacherSubject>(tsSQL).ToList();

                //1) Grab all subjects
                //2) Grab all teachers
                //3) Make a for loop 
                //4) Use linq to grab the right teacher and map them to the right subject 

                string teachSQL = "select * from teachers";
                string subjectsSQL = "select * from subjects";
                List<Teacher> teachers = connect.Query<Teacher>(teachSQL).ToList();
                List<Subject> subjects = connect.Query<Subject>(subjectsSQL).ToList();

                for(int i = 0; i < teacherSubjects.Count; i++)
                {
                    TeacherSubject ts = teacherSubjects[i];
                    ts.Teacher = teachers.Where(t => t.Id == ts.TeacherId).First();
                    ts.Subject = subjects.Where(s => s.Id == ts.SubjectId).First();
                }
                connect.Close();
                return teacherSubjects;
            }
        }
    }
}
