using SheepStock.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.Controller
{
    public class MainController
    {
        public void LoadDatabase()
        {
            Persistence persistence = new Persistence();
            persistence.FetchData();
        }
    }
}
