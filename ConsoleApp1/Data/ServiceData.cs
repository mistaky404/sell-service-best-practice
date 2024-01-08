using System;
using ConsoleApp1.Models;
using ConsoleApp1.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class ServiceData
    {
        private readonly List<ServiceModel> _services;
        public ServiceData()
        {
            _services = new List<ServiceModel>();
        }

        public List<ServiceModel> GetAll()
        {
            List<ProductModel> productsCombo1 = new List<ProductModel>();

            ProductModel product1 = new ProductModel();
            product1.Price = 5;
            product1.Name = "PopCorn";
            productsCombo1.Add(product1);

            ProductModel product2 = new ProductModel();
            product2.Price = 2;
            product2.Name = "Soda";
            productsCombo1.Add(product2);

            ServiceModel service1 = new ServiceModel();
            service1.Price = 7;
            service1.Name = "Combo 1";
            service1.Products = productsCombo1;

            List<ProductModel> productsCombo2 = new List<ProductModel>();

            ProductModel combo2product1 = new ProductModel();
            combo2product1.Price = 8;
            combo2product1.Name = "Nachos";
            productsCombo2.Add(combo2product1);

            ProductModel combo2product2 = new ProductModel();
            combo2product2.Price = 2;
            combo2product2.Name = "Soda";
            productsCombo2.Add(combo2product2);

            ServiceModel service2 = new ServiceModel();
            service2.Price = 10;
            service2.Name = "Combo 2";
            service2.Products = productsCombo2;

            List<ProductModel> productsCombo3 = new List<ProductModel>();

            ProductModel combo3product1 = new ProductModel();
            combo3product1.Price = 8;
            combo3product1.Name = "Nachos";
            productsCombo3.Add(combo3product1);

            ProductModel combo3product2 = new ProductModel();
            combo3product2.Price = 5;
            combo3product2.Name = "Popcorn";
            productsCombo3.Add(combo3product2);

            ProductModel combo3product3 = new ProductModel();
            combo3product3.Price = 2;
            combo3product3.Name = "Soda";
            productsCombo3.Add(combo3product3);

            ServiceModel service3 = new ServiceModel();
            service3.Price = 15;
            service3.Name = "Combo 3";
            service3.Products = productsCombo3;

            _services.Add(service1);
            _services.Add(service2);
            _services.Add(service3);

            return _services;
        }
    }
}
