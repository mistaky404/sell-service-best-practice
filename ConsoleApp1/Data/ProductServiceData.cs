using System;
using ConsoleApp1.Models;
using ConsoleApp1.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class ProductServiceData
    {        

        private readonly List<ProductServiceModel> _products;
        public ProductServiceData()
        {
            _products = new List<ProductServiceModel>();
        }

        /// <summary>
        /// El esquema de la clase rompe principio, solo deberia tener nombre y precio y buscar una forma de manejar por separados los idioma
        /// El modelo debe tener una coleccion con los productos que pertenecen a ese servicio
        /// </summary>
        /// <returns></returns>
        public List<ProductServiceModel> GetAll()
        {
            _products.Add(new ProductServiceModel
            {
                NameEnglish = "Combo#1: " + _products[0].NameEnglish + ", " + _products[2].NameEnglish,
                NameSpanish = "Combo#1: " + _products[0].NameSpanish + ", " + _products[2].NameSpanish,
                PriceUSD = _products[0].PriceUSD + _products[2].PriceUSD,
                PriceRD = _products[0].PriceRD + _products[2].PriceRD,
            });
            _products.Add(new ProductServiceModel
            {
                NameEnglish = "Combo#2: " + _products[1].NameEnglish + ", " + _products[2].NameEnglish,
                NameSpanish = "Combo#2: " + _products[1].NameSpanish + " " + _products[2].NameSpanish,
                PriceUSD = _products[1].PriceUSD + _products[2].PriceUSD,
                PriceRD = _products[1].PriceRD + _products[2].PriceRD,
            });
            _products.Add(new ProductServiceModel
            {
                NameEnglish = "Combo#3: " + _products[0].NameEnglish + ", " + _products[1].NameEnglish + ", " + _products[2].NameEnglish,
                NameSpanish = "Combo#3: " + _products[0].NameSpanish + ", " + _products[1].NameSpanish + ", " + _products[2].NameSpanish,
                PriceUSD = _products[0].PriceUSD + _products[1].PriceUSD + _products[2].PriceUSD,
                PriceRD = _products[0].PriceRD + _products[1].PriceRD + _products[2].PriceRD,
            }); ;
            return _products;
        }
    }
}
