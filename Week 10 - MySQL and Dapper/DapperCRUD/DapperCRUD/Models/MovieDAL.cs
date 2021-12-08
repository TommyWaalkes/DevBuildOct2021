using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUD.Models
{
    public class MovieDAL
    {
        //This will contain all of our code for talking to the DB, and can be reused anywhere in our app 

        //This have several methods, each one representing our CRUD 
        //C - Create 
        //R - Read (all, individual) 
        //U - Update (aka edit) 
        //D - Delete or Destroy 

        //Read all 
        public List<Movie> GetMovies()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from movies";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();

                return movies; 
            }
        }

        //Read single - take in an id and return the matching row
        public Movie GetMovie(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies where id=" +id;
                connect.Open();
                //Query always returns a list regardless of how many movies we want. 
                //Even if our query is mean to return 1 movie, we still need to pull it out of a list of count 1
                Movie m = connect.Query<Movie>(sql).First();
                connect.Close();

                return m;
            }
        }

        public void DeleteMovie(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "delete from Movies where id=" + id;
                connect.Open();
                
                connect.Query<Movie>(sql);
                connect.Close();
            }
        }

        public void UpdateMovie(Movie m)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "update movies " +
                    $"set title='{m.Title}', genre='{m.Genre}', `year`={m.Year}, runtime={m.RunTime} " +
                    $"where id={m.Id}";
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }
        }

        public void CreateMovie(Movie m)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "insert into movies " +
                    $"values(0, '{m.Title}', '{m.Genre}', {m.Year}, {m.RunTime} )";
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }
        }
    }
}
