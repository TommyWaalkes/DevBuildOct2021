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
            }
        }
    }
}
