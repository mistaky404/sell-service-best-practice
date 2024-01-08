using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class MonetaryUnitView
    {
        TextView text = new TextView();
        public int selection = 0;
        public void MonetarySelectionView()

        {
            text.ChooseCurrencyEnglish();
            selection = selection = Convert.ToInt16(Console.ReadLine());
            switch (selection)
            {
                default:
                    text.InvalidSelection();
                    break;
                case 1:
                    break;
                case 2:
                    break;

            }
            text.ChooseCurrencySpanish();
            selection = selection = Convert.ToInt16(Console.ReadLine());
            switch (selection)
            {
                default:
                    text.InvalidSelection();
                    break;
                case 1:
                    break;
                case 2:
                    break;

            }
            //The swtich needs to be at MonetaryUnitService
        }
    }
}
