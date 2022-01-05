using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorAPICreation.Controllers
{
    //API Controller make heavy use of attributes, these attribute may do the following: 
    //1) Tell .Net this controller is to be treated as an api 
    //2) Set the route to get an endpoint
    //3) Set the HTTP method (GET, PUT etc) to be used on that endpoint 
    //4) Plus much much more
    [ApiController]

    //Route above the class, help to set the base URL for the API 
    //this one in particualr sets the base url to match the name of the controller
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //Each method inside an API Represent a different endpoint 
        //We can set the HTTP method as well as the name of the endpoint using attributes

        //When there is nothing specifying the route, this default to the base url 
        //API Methods will automatically convert any object you return into JSON 
        //And it will turn any array or list you return into an array of JSON objects 
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
