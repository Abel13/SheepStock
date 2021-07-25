using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.Models
{
    public class Outgoing : SecureEntity
    {
        public string ProductId { private set; get; }
        public DateTime PurchaseDate { private set; get; }
        public int Quantity { private set; get; }
    }
}
