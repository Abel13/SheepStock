using SheepStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.DAO
{
    public class ProductDAO: IDAO
    {
        Persistence persistence = new Persistence();
        public void Add<T>(T item)
        {
            var database = Database.GetInstance();

            database.Products.Add((Product)(object)item);

            persistence.StoreData();
        }

        public void Delete<T>(T item)
        {
            throw new NotImplementedException();
        }

        public void Edit<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
