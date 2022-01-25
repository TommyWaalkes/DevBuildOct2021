﻿using Dapper;
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
            Movie match;
            try
            {
                match = output.Where(m => m.Id == id).First();
            }
            catch (InvalidOperationException)
            {
                match = new Movie();
                match.Title = $"Movie at index {id} does not exist, please try another id";
            }
            return match;
        }

        public void InsertMovie(Movie m)
        {
            string sql = $"insert into movies values(0, '{m.Title}', '{m.Genre}', {m.Year}, {m.RunTime})";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }

        }

        public void DeleteMovie(int id)
        {
            string sql = $"delete from movies where id ={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }
        }

        public void UpdateMovie(int id, Movie newValues)
        {
            string sql = $"update movies set title='{newValues.Title}', genre='{newValues.Genre}', runtime={newValues.RunTime}, year={newValues.Year} where id={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }

        }
    }
}
