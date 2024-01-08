using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
    public class ServiceBusiness
    {
        private readonly ServiceData _serviceData;
        public ServiceBusiness()
        {
            _serviceData = new ServiceData();
        }

        public List<ServiceModel> GetAll()
        {
            return _serviceData.GetAll();
        }

    }
}
