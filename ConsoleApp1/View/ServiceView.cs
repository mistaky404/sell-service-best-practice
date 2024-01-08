using ConsoleApp1.Business;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class ServiceView
    {
        private readonly ServiceBusiness _service;
        public ServiceView()
        {
            _service = new ServiceBusiness();
        }
        public void ServicesView()
        {
            List<ServiceModel> services = new List<ServiceModel>();
            services = _service.GetAll();
            
            foreach (ServiceModel service in services)
            {
                string products = "";
                foreach (ProductModel product in service.Products)
                {
                    products += product.Name + ", ";
                }
                Console.WriteLine(service.Name + ": " + products);
                
            }

        }
    }
    
}
