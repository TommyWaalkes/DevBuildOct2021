using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    //The API is public facing and acts as the mailman of our app
    public class MovieController
    {
        MovieDAL db = new MovieDAL();

        [HttpGet]
        public List<Movie> GetMovies()
        {
            return db.GetMovies();
        }

        [HttpGet("get/{id}")]
        public Movie GetMovie(int id)
        {
            return db.GetMovie(id);
        }
    }
}
