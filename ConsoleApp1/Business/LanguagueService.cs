using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.View;
using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp1.Business
{
    public class LanguagueService
    {
        private readonly LanguagueData _languagueData;
        public LanguagueService()
        {
            _languagueData = new LanguagueData();
        }
        public List<LanguagueModel> GetAll() 
        {
            return _languagueData.GetAll();
        }
    }
}
