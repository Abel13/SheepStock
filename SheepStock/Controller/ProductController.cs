using SheepStock.DAO;
using SheepStock.Models;
using SheepStock.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.Controller
{
    public class ProductController
    {
        Database database = Database.GetInstance();
        public ProductViewModel ProductViewModel { get; set; }

        public ProductController()
        {
            ProductViewModel = new ProductViewModel();
        }

        public void SaveProduct(ProductViewModel productViewModel)
        {
            if (productViewModel is null)
            {
                throw new ArgumentNullException(nameof(productViewModel));
            }

            ProductDAO productDAO = new ProductDAO();
            Product product = new Product(name: productViewModel.Name, quantity: 0);

            productDAO.Add(product);

            ProductViewModel.Name = String.Empty;
        }

        internal IEnumerable GetProducts()
        {
            return database.Products;
        }
    }
}
