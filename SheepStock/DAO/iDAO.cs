using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.DAO
{
    interface IDAO
    {
        void Add<T>(T item);

        void Delete<T>(T item);

        void Edit<T>(T item);
    }
}
