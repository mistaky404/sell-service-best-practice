using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ServiceModel
    {
        public ServiceModel()
        {
            Products = new List<ProductModel>();
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
