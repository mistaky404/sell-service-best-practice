using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class TextView
    {
        public void LanguagueSelection()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("     Choose Languague  ( 1 for English - 2 para Español)   ");
            Console.WriteLine("-----------------------------------------------------------");

        }
        public void SeparationLine()
        { Console.WriteLine("-----------------------------------------------------------"); }

        public void InvalidSelection()
        { Console.WriteLine(" Invalid Selection "); }

        public void EmptyLine()
        { Console.WriteLine(); }

        public void ChooseCurrencyEnglish()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("           Choose Currency ( 1 for USD - 2 for RD$)        ");
            Console.WriteLine("-----------------------------------------------------------");
        }

        public void ChooseCurrencySpanish()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("          Seleccione Divisa ( 1 for USD - 2 for RD$)       ");
            Console.WriteLine("-----------------------------------------------------------");
        }

    }
}
