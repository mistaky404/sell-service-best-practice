using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
    public class MonetaryUnitService
    {
        private readonly MonetaryUnitData _monetaryData;
        public MonetaryUnitService()
        {
            _monetaryData = new MonetaryUnitData();
        }
        public List<MonetaryUnitModel> GetAll()
        {
            return _monetaryData.GetAll();
        }

    }
}

