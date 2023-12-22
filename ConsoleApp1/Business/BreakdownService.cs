using ConsoleApp1.Other.CaribbeanCinemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
    public class BreakdownService
    {
        LanguagueService languague = new LanguagueService();
        CombosService combo = new CombosService();
        public void billUsage()
        {
            int twoThousandBillUsage = 0;
            int oneThousandBillUsage = 0;
            int fiveHundredBillUsage = 0;
            int twoHundredBillUsage = 0;
            int oneHundredBillUsage = 0;
            int fiftyBillUsage = 0;
            int twentyfiveBillUsage = 0;
            int twentyBillUsage = 0;
            int tenBillUsage = 0;
            int fiveBillUsage = 0;
            int twoBillUsage = 0;
            int oneBillUsage = 0;

            if (combo.payAmount >= combo.totalBill && languague.languagueChoosed.Contains("USD"))
            {
                int cashReturn = combo.payAmount - combo.totalBill;
                while (cashReturn > 0)
                {

                    if (cashReturn >= Constant.ONE_HUNDRED_BILL)
                    {
                        cashReturn = cashReturn - Constant.ONE_HUNDRED_BILL;
                        oneHundredBillUsage = oneHundredBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.FIFTY_BILL)
                    {
                        cashReturn = cashReturn - Constant.FIFTY_BILL;
                        fiftyBillUsage = fiftyBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.TWENTY_BILL)
                    {
                        cashReturn = cashReturn - Constant.TWENTY_BILL;
                        twentyBillUsage = twentyBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.TEN_BILL)
                    {
                        cashReturn = cashReturn - Constant.TEN_BILL;
                        tenBillUsage = tenBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.FIVE_BILL)
                    {
                        cashReturn = cashReturn - Constant.FIVE_BILL;
                        fiveBillUsage = fiveBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.TWO_BILL)
                    {
                        cashReturn = cashReturn - Constant.TWO_BILL;
                        twoBillUsage = twoBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.ONE_BILL)
                    {
                        cashReturn = cashReturn - Constant.ONE_BILL;
                        oneBillUsage = oneBillUsage + 1;
                    }
                }
                Console.WriteLine("100  => " + oneHundredBillUsage);
                Console.WriteLine("50   => " + fiftyBillUsage);
                Console.WriteLine("20   => " + twentyBillUsage);
                Console.WriteLine("10   => " + tenBillUsage);
                Console.WriteLine("5   => " + fiveBillUsage);
                Console.WriteLine("2  => " + twoBillUsage);
                Console.WriteLine("1  => " + oneBillUsage);
            }
            else if (combo.payAmount >= combo.totalBill && languague.languagueChoosed.Contains("RD"))
            {
                int cashReturn = combo.payAmount - combo.totalBill;
                while (cashReturn > 0)
                {
                    if (cashReturn >= Constant.TWO_THOUSAND_BILL)
                    {
                        cashReturn = cashReturn - Constant.TWO_THOUSAND_BILL;
                        twoThousandBillUsage = twoThousandBillUsage + 1;
                    }
                    if (cashReturn >= Constant.ONE_THOUSAND_BILL)
                    {
                        cashReturn = cashReturn - Constant.ONE_THOUSAND_BILL;
                        oneThousandBillUsage = oneThousandBillUsage + 1;
                    }
                    if (cashReturn >= Constant.FIVE_HUNDRED_BILL)
                    {
                        cashReturn = cashReturn - Constant.FIVE_HUNDRED_BILL;
                        fiveHundredBillUsage = fiveHundredBillUsage + 1;
                    }
                    if (cashReturn >= Constant.TWO_HUNDRED_BILL)
                    {
                        cashReturn = cashReturn - Constant.TWO_HUNDRED_BILL;
                        twoHundredBillUsage = twoHundredBillUsage + 1;
                    }
                    if (cashReturn >= Constant.ONE_HUNDRED_BILL)
                    {
                        cashReturn = cashReturn - Constant.ONE_HUNDRED_BILL;
                        oneHundredBillUsage = oneHundredBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.FIFTY_BILL)
                    {
                        cashReturn = cashReturn - Constant.FIFTY_BILL;
                        fiftyBillUsage = fiftyBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.TWENTY_FIVE_BILL)
                    {
                        cashReturn = cashReturn - Constant.TWENTY_FIVE_BILL;
                        twentyfiveBillUsage = twentyfiveBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.TEN_BILL)
                    {
                        cashReturn = cashReturn - Constant.TEN_BILL;
                        tenBillUsage = tenBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.FIVE_BILL)
                    {
                        cashReturn = cashReturn - Constant.FIVE_BILL;
                        fiveBillUsage = fiveBillUsage + 1;
                    }
                    else if (cashReturn >= Constant.ONE_BILL)
                    {
                        cashReturn = cashReturn - Constant.ONE_BILL;
                        oneBillUsage = oneBillUsage + 1;
                    }
                }
                Console.WriteLine("2000  => " + twoThousandBillUsage);
                Console.WriteLine("1000  => " + oneThousandBillUsage);
                Console.WriteLine("500  => " + fiveHundredBillUsage);
                Console.WriteLine("200  => " + twoHundredBillUsage);
                Console.WriteLine("100  => " + oneHundredBillUsage);
                Console.WriteLine("50   => " + fiftyBillUsage);
                Console.WriteLine("25   => " + twentyfiveBillUsage);
                Console.WriteLine("10   => " + tenBillUsage);
                Console.WriteLine("5   => " + fiveBillUsage);
                Console.WriteLine("1  => " + oneBillUsage);
            }
        }
        public void returnBreakdown()
        {
            if (languague.languagueChoosed.Contains("English"))
            {
                Console.WriteLine("                     Return Breakdown                      ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                   Your Return is " + (combo.payAmount - combo.totalBill));
                Console.WriteLine("");
                billUsage();
            }
            else
            {
                Console.WriteLine("                    Desglose de Devuelta                   ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                   Tu devuelta es " + (combo.payAmount - combo.totalBill));
                Console.WriteLine("");
                billUsage();
            }
        }
    }
}
