using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.Models
{
    public class Incoming : SecureEntity
    {
        public DateTime PurchaseDate { private set; get; }
        public string ProductId { private set; get; }
        public double Value { private set; get; }
        public int Quantity { private set; get; }
    }
}
