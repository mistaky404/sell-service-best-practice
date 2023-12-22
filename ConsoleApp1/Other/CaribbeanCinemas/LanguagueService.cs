namespace ConsoleApp1.Other.CaribbeanCinemas
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
