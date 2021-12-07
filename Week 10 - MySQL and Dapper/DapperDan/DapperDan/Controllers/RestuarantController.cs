using Dapper;
using DapperDan.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDan.Controllers
{
    //To make a controller subclass controller 
    //.Net expects your controller name to have the word controller at the end
    public class RestuarantController : Controller
    {
        
        public IActionResult Index()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                //So using dapper, we are able to put sql queries into a string 
                //and pass them along to our DB 
                //All MySql syntax is useable here 
                string sql = "select * from dishes";


                //open our connection to the DB 
                connect.Open();

                //We need to go and pass the sql string to the database 
                //Expecting to return a single model or a list of models, or nothing, 
                //depending on the query 
                List<Dish> dishes = connect.Query<Dish>(sql).ToList();

                //Close our connection to our DB, if we don't, then the database may not let another 
                //Method use it. 
                connect.Close();

                Dish d = dishes[0];
                return View(d);
            }
        }
    }
}
