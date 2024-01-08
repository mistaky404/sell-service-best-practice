using ConsoleApp1.Other.CaribbeanCinemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
    public class BillService
    {
        LanguagueService languague = new LanguagueService();
        CombosService combo = new CombosService();
        public void createBill()
        {
            CombosService Bill = new CombosService();
            Bill.Selection();

            int confirmation;
            Console.WriteLine("-----------------------------------------------------------");
            if (1 == 1)
            {
                Console.WriteLine("                  Want To Add A Selection?                 ");
                Console.WriteLine("                  ( 1 for Yes - 2 for No)                  ");
                Console.WriteLine("-----------------------------------------------------------");
                confirmation = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("               Quiere Añadir Una Seleccion?                ");
                Console.WriteLine("                 ( 1 para Si - 2 para No)                  ");
                Console.WriteLine("-----------------------------------------------------------");
                confirmation = Convert.ToInt32(Console.ReadLine());
            }
            switch (confirmation)
            {
                case 1:
                    createBill();
                    break;
                case 2:
                    Console.WriteLine("-----------------------------------------------------------");

                    break;
            }
        }
        public void payBill()
        {
            CombosService Bill = new CombosService();
            Bill.PrintSelection();

            if ("English" == "English")
            {
                Console.WriteLine("                      Insert Pay Amount                    ");
                Console.WriteLine("-----------------------------------------------------------");
                combo.payAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("                  Inserte Cantidad de Pago                 ");
                Console.WriteLine("-----------------------------------------------------------");
                combo.payAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------");
            }

            if (combo.payAmount < combo.totalBill)
            {
                Console.WriteLine("                     Invalid Pay Amount                    ");
            }

        }
    }
}
