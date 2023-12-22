using System;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class MonetaryUnitData
    {
        private readonly List<MonetaryUnitModel> _monetaryUnits;

        public MonetaryUnitData()
        {
            _monetaryUnits = new List<MonetaryUnitModel>();
        }

        public List<MonetaryUnitModel> GetAll()
        {
            _monetaryUnits.Add(new MonetaryUnitModel { Name = "USD" });
            _monetaryUnits.Add(new MonetaryUnitModel { Name = "RD" });
            return _monetaryUnits;
        }
    }
}
