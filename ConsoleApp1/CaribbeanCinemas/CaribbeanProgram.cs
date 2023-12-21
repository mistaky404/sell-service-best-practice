using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CaribbeanCinemas
{
    public class CaribbeanProgram
    {
        public void Main()
        {
            LanguagueService languague = new LanguagueService();
            languague.Choose();
         
            CombosService combo = new CombosService();
            combo.SetComboInfo();
            combo.SetComboPrice();
            combo.Menu();

            BillService bill = new BillService();
            bill.createBill();
            bill.payBill();
            bill.returnBreakdown();
        }
    }
}
