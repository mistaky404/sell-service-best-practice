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
            _products.Add(new ProductModel { NameEnglish = "PopCorn", NameSpanish = "Palomitas", PriceUSD = 10, PriceRD = 100});
            _products.Add(new ProductModel { NameEnglish = "Nachos", NameSpanish = "Nachos", PriceUSD = 15, PriceRD = 150});
            _products.Add(new ProductModel { NameEnglish = "Soda", NameSpanish = "Soda", PriceUSD = 5, PriceRD = 50 });
            return _products;
        }
    }
}
