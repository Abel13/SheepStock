using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.Models
{
    public class Product : SecureEntity
    {
        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
    }
}
