using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAPIDapper
{
    public class CatDAL
    {
       public List<Cat> GetAllCats()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from kitties";
                connect.Open();
                List<Cat> cats = connect.Query<Cat>(sql).ToList();
                connect.Close();

                return cats;
            }

        }

        public void InsertCat(Cat newCat)
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into kitties values(0, '{newCat.fName}', {newCat.IsDeclawed}, {newCat.Age})";

                connect.Open();
                connect.Query<Cat>(sql);
                connect.Close();
            }
        }

        public void DeleteCat(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"delete from kitties where id={id}";

                connect.Open();
                connect.Query<Cat>(sql);
                connect.Close();
            }
        }

        public Cat GetCat(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"select * from kitties where id = {id}";
                try
                {
                    connect.Open();
                    Cat c = connect.Query<Cat>(sql).ToList().First();
                    connect.Close();
                    return c;
                }
                catch (InvalidOperationException)
                {
                    Cat error = new Cat();
                    error.fName = "No cat found at " + id;
                    return error;
                }

            }
        }

        public void UpdateCat(int id, Cat updatedCat)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update kitties set fName= '{updatedCat.fName}', Age={updatedCat.Age}, IsDeclawed={updatedCat.IsDeclawed} where id={id}";

                connect.Open();
                connect.Query<Cat>(sql);
                connect.Close();
            }
        }
    }
}
