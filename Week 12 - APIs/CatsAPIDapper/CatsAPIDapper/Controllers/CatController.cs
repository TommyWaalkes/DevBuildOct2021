using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAPIDapper.Controllers
{
    //Generally each table gets its own API controller 
    //Unless 2 tables have a foreign key or all the database are small/simple 
    //In which case you would put multiple into the same controller 
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        CatDAL catDb = new CatDAL();

        //It is common for an API section at its base url to return the full listing it's pulling from the 
        //database
        [HttpGet]
        public List<Cat> GetCats()
        {
            return catDb.GetAllCats();
        }

        [HttpPost("CreateCat")]
        public string CreateCat(Cat c)
        {
            catDb.InsertCat(c);
            return $"{c.fName} has been create in the database";
        }

        //If I put in id in curly brackets into my route, I am telling the API accept a parameter via the url 
        //named id. Then we specify the data type of that parameter in our method signature
        [HttpDelete("Delete/{id}")]
        public string Delete(int id)
        {
            catDb.DeleteCat(id);
            return $"Cat at id {id} has been deleted";
        }

        [HttpGet("GetCat/{id}")]
        public Cat GetCat(int id)
        {
            Cat c = catDb.GetCat(id);
            return c;
        }

        [HttpPut("UpdateCat/{id}")]
        public string UpdateCat(int id, Cat updatedCat)
        {
            //We want our to be able to select which properies they wish to change and leave the rest alone 
            //This will make it so that for properties we wish to leave alone, we don't have to renter their values
            Cat oldCat = catDb.GetCat(id);

            //check our updated cat for change properties
            if(updatedCat.fName == null)
            {
                updatedCat.fName = oldCat.fName;
            }

            if(updatedCat.Age == 0)
            {
                updatedCat.Age = oldCat.Age;
            }

            catDb.UpdateCat(id, updatedCat);
            return $"{updatedCat.fName} at id {id} has been updated";
            //if(updatedCat.IsDeclawed == true)
            //{

            //}
        }
    }
}
