using SheepStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.DAO
{
    public class Database
    {
        private Database() {
            Products = new List<Product>();
        }

        private static Database _databaseInstance;

        public static Database GetInstance()
        {
            if (_databaseInstance == null)
            {
                _databaseInstance = new Database();
            }
            return _databaseInstance;
        }

        public List<Product> Products { get; private set; }
        public List<Incoming> Incomings { get; private set; }
        public List<Outgoing> Outgoings { get; private set; }

        internal void SetProducts(List<Product> products)
        {
            Products = products;
        }
    }
}
