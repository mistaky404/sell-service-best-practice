using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
    public class MonetaryUnitService
    {
        private string languaguechoosed;
        public string languagueChoosed

        {
            get { return languaguechoosed; }
            set { languaguechoosed = value; }
        }
        public string Choose()
        {
            LanguagueService languague = new LanguagueService();
            int chooseLanguague = 0;
            switch (chooseLanguague)
            {
                case 1:
                    Console.WriteLine("           Choose Currency ( 1 for USD - 2 for RD$)        ");
                    Console.WriteLine("-----------------------------------------------------------");
                    break;
                case 2:

                    Console.WriteLine("          Seleccione Divisa ( 1 for USD - 2 for RD$)       ");
                    Console.WriteLine("-----------------------------------------------------------");
                    break;
            }
            int chooseMonetaryUnit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");
            switch (chooseMonetaryUnit)
            {
                case 1:
                    languague.languagueChoosed = languague.languagueChoosed + "USD";
                    break;

                case 2:
                    languague.languagueChoosed = languague.languagueChoosed + "RD";
                    break;

                default:

                    Console.WriteLine(" Invalid Selection ");
                    break;
            }



            return languagueChoosed;







        }
    }
}

