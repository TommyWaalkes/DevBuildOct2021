using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        MovieDAL md = new MovieDAL();

        [HttpGet]
        public List<Movie> GetMovies()
        {
            return md.GetMovies();
        }

        [HttpGet("RandomList/{quantity}")]
        public List<Movie> GetRandomMovies(int quantity)
        {
            //Grab the full list of movies 
            //Randomly keep picking movies until we match quantity 

            //if quantity > movies.count, return full list of movies 
            List<Movie> movies = md.GetMovies();

            if (movies.Count <= quantity)
            {
                return movies;
            }
            else
            {
                List<Movie> output = new List<Movie>();

                while (output.Count < quantity)
                {
                    Random rng = new Random();
                    int pick = rng.Next(0, movies.Count);
                    output.Add(movies[pick]);
                    movies.RemoveAt(pick);
                }

                return output;
            }
        }

        [HttpGet("Categories")]
        public List<string> GetCategories()
        {
            return md.GetCategories();
        }

        [HttpGet("GetMovie/{title}")]
        public Movie GetMovie(string title)
        {
            List<Movie> movies = md.GetMovies();
            List<Movie> filtered = movies.Where(x => x.Title == title).ToList();
            if (filtered.Count > 0)
            {
              
                return filtered.First();
            }
            else
            {
                Movie error = new Movie();
                error.Title = "No movie found with that title: " + title;
                return error;
            }
        }

        [HttpGet("Search/{keyword}")]
        public List<Movie> SearchMovieByTitle(string keyword)
        {
            List<Movie> movies = md.GetMovies();
            List<Movie> filtered = movies.Where(x => x.Title.Contains(
                keyword.ToLower()) || x.Title.Contains(keyword.ToUpper())).ToList();
            if (filtered.Count > 0)
            {

                return filtered;
            }
            else
            {
                Movie error = new Movie();
                error.Title = "No movie found with that title: " + keyword;

                List<Movie> output = new List<Movie>();
                output.Add(error);
                return output;
            }
        }
    }
}
