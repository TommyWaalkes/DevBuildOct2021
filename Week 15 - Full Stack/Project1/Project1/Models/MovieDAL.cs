using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class MovieDAL
    {
        //The job of the DAL is to talk to our database and give data over to the controller
        public List<Movie> GetMovies()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies";
                connect.Open();
                List<Movie> output = connect.Query<Movie>(sql).ToList();
                connect.Close();
                return output;
            }
        }

        public Movie GetMovie(int id)
        {
            List<Movie> output = GetMovies();
            Movie match = output.Where(m => m.Id == id).First();
            return match;
        }
    }
}
