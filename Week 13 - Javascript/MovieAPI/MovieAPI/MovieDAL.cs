using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI
{
    public class MovieDAL
    {
        public List<Movie> GetMovies()
        {
            string sql = "select * from Movies";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();
                return movies;
            }
        }

        public List<string> GetCategories()
        {

            string sql = "select distinct genre from Movies";

            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<string> categories = connect.Query<string>(sql).ToList();
                connect.Close();
                return categories;
            }
        }
    }
}
