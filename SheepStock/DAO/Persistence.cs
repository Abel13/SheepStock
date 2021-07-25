using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.DAO
{
    public class Persistence
    {
        private static readonly string databasePath = "database.json";

        public void StoreData()
        {
            Database database = Database.GetInstance();
            var df = JsonConvert.SerializeObject(database);

            StreamWriter sr = new StreamWriter(databasePath);

            sr.Write(df);
            sr.Flush();
            sr.Close();
        }

        public void FetchData()
        {
            Database database = Database.GetInstance();
            FileInfo f = new FileInfo(databasePath);
            if (f.Exists)
            {
                StreamReader sr = new StreamReader(databasePath);

                var databaseJson = sr.ReadToEnd();

                var databaseObject = JsonConvert.DeserializeObject<Database>(databaseJson);

                database.SetProducts(databaseObject.Products);

                sr.Dispose();
                sr.Close();
            }
            else
            {
                var df = JsonConvert.SerializeObject(database);

                StreamWriter sr = new StreamWriter(databasePath);

                sr.Write(df);
                sr.Flush();
                sr.Close();
            }
        }
    }
}
