using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
    public class LanguagueService
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

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("     Choose Languague  ( 1 for English - 2 para Español)   ");
            Console.WriteLine("-----------------------------------------------------------");
            int chooseLanguague = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");
            switch (chooseLanguague)
            {
                case 1:
                    languague.languagueChoosed = "English";
                    break;

                case 2:
                    languague.languagueChoosed = "Spanish";
                    break;

                default:
                    Console.WriteLine(" Invalid Selection ");
                    break;
            }

            return languagueChoosed;

        }
    }
}
