using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Other.CaribbeanCinemas
{
    public class OpenReset
    {
        LanguagueService languague = new LanguagueService();
        public void openProgram()
        {
            CaribbeanProgram Execute = new CaribbeanProgram();
            Execute.Main();
        }
        public void ExitReset()
        {
            if (languague.languagueChoosed.Contains("English"))
            {
                Console.WriteLine("       Press E to Exit or Any Other Key to New Bill      ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                Console.WriteLine(" Presione E para Cerrar u Otra Tecla para Nueva Factura  ");
                Console.WriteLine("-----------------------------------------------------------");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == 'E' || keyInfo.KeyChar == 'e')
            {
                return;
            }
            else
            {
                OpenReset newBill = new OpenReset();
                newBill.openProgram();
            }

        }
    }
}
