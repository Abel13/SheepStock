using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.Models
{
    public class SecureEntity
    {
        public Guid Guid { private set; get; }

        public SecureEntity()
        {
            Guid = Guid.NewGuid();
        }
    }
}
