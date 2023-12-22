using System;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class LanguagueData
    {
        private readonly List<LanguagueModel> _languagues;

        public LanguagueData()
        {
            _languagues = new List<LanguagueModel>();
        }

        public List<LanguagueModel> GetAll()
        {
            _languagues.Add(new LanguagueModel { Name = "English" });
            _languagues.Add(new LanguagueModel { Name = "Spanish" });
            return _languagues;
        }
    }
}
