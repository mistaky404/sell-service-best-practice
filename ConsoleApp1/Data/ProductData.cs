using System;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class ProductData
    {
        private readonly List<ProductModel> _products;

        public ProductData()
        {
            _products = new List<ProductModel>();
        }

        public List<ProductModel> GetAll()
        {
            _products.Add(new ProductModel { Name = "PopCorn", Price = 5});
            _products.Add(new ProductModel { Name = "Nachos", Price = 8});
            _products.Add(new ProductModel { Name = "Soda", Price = 2 });
            return _products;
        }
    }
}
