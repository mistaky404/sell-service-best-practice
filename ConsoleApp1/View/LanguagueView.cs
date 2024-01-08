using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Business;

namespace ConsoleApp1.View
{
    public class LanguagueView
    {
        TextView text = new TextView();
        public int selection = 0;
        public void languagueSelectionView()
        
        {
            text.LanguagueSelection();
            selection = selection = Convert.ToInt16(Console.ReadLine());
                switch (selection)
            {
                default:text.InvalidSelection();
                    break;
                case 1:
                    break; 
                case 2:
                    break;
            }
            //The swtich needs to be at LanguagueService
        }

        
            

        
    }
}
