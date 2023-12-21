namespace ConsoleApp1.CaribbeanCinemas
{
    public class CombosService
    {
        public List<short> combosPrice = new List<short>();
        public List<String> combosInfo = new List<String>();
        public List<int> selectionPrice  = new List<int>();
        public List<int> selectionNumber = new List<int>();
        public List<int> selectionAmount = new List<int>();

        private int totalbill;
        public int totalBill 
        {
            get { return totalbill; } 
            set { totalbill = value; } 
        }
        private int payamount;
        public int payAmount
        {
            get { return payamount; }
            set { payamount = value; }
        }

        LanguagueService languague = new LanguagueService();
        public void Menu()
        {
            if (languague.languagueChoosed.Contains("English"))
            {    
                Console.WriteLine("               Welcome to Caribbean Cinemas                ");
                Console.WriteLine("-----------------------------------------------------------");
                for (int i = 0; i < combosInfo.Count; i++)
                    Console.WriteLine(combosInfo[i] + combosPrice[i]);
            }

            else
            {   
                Console.WriteLine("              Bienvenido a Caribbean Cinemas               ");
                Console.WriteLine("-----------------------------------------------------------");
                for (int i = 0; i < combosInfo.Count; i++)
                    Console.WriteLine(combosInfo[i] + combosPrice[i]);
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void SetComboPrice()
        {
            if (languague.languagueChoosed.Contains("USD"))
            {
                combosPrice.Add(15);
                combosPrice.Add(20);
                combosPrice.Add(18);
                combosPrice.Add(23);
                combosPrice.Add(25);
                combosPrice.Add(30);
                combosPrice.Add(33);
                combosPrice.Add(45);
            }
            else
            {
                combosPrice.Add(150);
                combosPrice.Add(200);
                combosPrice.Add(180);
                combosPrice.Add(230);
                combosPrice.Add(250);
                combosPrice.Add(300);
                combosPrice.Add(330);
                combosPrice.Add(450);
            }
        }
        public void SetComboInfo()
        {
            
            if (languague.languagueChoosed.Contains("English"))
            {
                combosInfo.Add("Combo#1: Regular Popcorn, Regular soda ");
                combosInfo.Add("Combo#2: Regular Nachos, Regular soda ");
                combosInfo.Add("Combo#3: Big Popcorn, Regular Soda ");
                combosInfo.Add("Combo#4: Big Popcorn, Big soda ");
                combosInfo.Add("Combo#5: Big Nachos, Regular soda ");
                combosInfo.Add("Combo#6: Big Nachos, Big soda ");
                combosInfo.Add("Combo#7: Regular Popcorn, Regular Nachos, Regular soda ");
                combosInfo.Add("Combo#8: Big Popcorn, Big Nachos, Big soda ");
            }
            else
            {
                combosInfo.Add("Combo#1: Palomitas Regulares, Soda Regular ");
                combosInfo.Add("Combo#2: Nachos Regulares, Soda Regular ");
                combosInfo.Add("Combo#3: Palomitas Grandes, Soda Regular ");
                combosInfo.Add("Combo#4: Palomitas Grandes, Soda Grande ");
                combosInfo.Add("Combo#5: Nachos Grandes, Soda Regular ");
                combosInfo.Add("Combo#6: Nachos Grandes, Soda Grande ");
                combosInfo.Add("Combo#7: Palomitas Regulares, Nachos Regulares, Soda Regular ");
                combosInfo.Add("Combo#8: Palomitas Grandes, Nachos Grandes, Soda Grande ");
            }

        }
        public void Selection()
        {
            int comboNumber = 0;
            int comboAmount = 0;
            int comboPrice = 0;
            int total = 0;

            if (languague.languagueChoosed.Contains("English"))
            {
                Console.WriteLine("                  Insert Combo Selection                   ");
                Console.WriteLine("-----------------------------------------------------------");
                comboNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                   Insert combos Amount                    ");
                Console.WriteLine("-----------------------------------------------------------");

                comboAmount = Convert.ToInt32(Console.ReadLine());
                comboPrice = combosPrice[comboNumber];
                total = comboPrice * comboAmount;
            }
            else
            {
                Console.WriteLine("              Inserte su Seleccion de Combo                ");
                Console.WriteLine("-----------------------------------------------------------");
                comboNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("              Inserte Cantidad de Combo                    ");
                Console.WriteLine("-----------------------------------------------------------");
                comboAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------");
                comboPrice = combosPrice[comboNumber];
                total = comboPrice * comboAmount;
            }

            totalBill = totalBill + total;
            selectionNumber.Add(comboNumber);
            selectionAmount.Add(comboAmount);
            selectionPrice.Add(comboPrice);
        }

        public void SelectionList()
        {
            for (int i = 0; i < selectionNumber.Count; i++)
            Console.WriteLine(combosInfo[(selectionNumber[i])] + " - " + + selectionPrice[i] + " - " + selectionAmount[i]);
        }
        public void PrintSelection()
        {
            if (languague.languagueChoosed.Contains("English"))
            {
                Console.WriteLine("                           Bill                            ");
                Console.WriteLine();
                Console.WriteLine("   Combo Selected  -      Price Unit  -     Unit  Amount   ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();
                SelectionList();
                Console.WriteLine();
                Console.WriteLine("Total to Pay is " + totalBill);
            }
            else
            {
                Console.WriteLine("                        Factura                            ");
                Console.WriteLine(" Combo Seleccionado  - Precio Unidad  -  Cantidad Unidad   ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();
                SelectionList();
                Console.WriteLine();
                Console.WriteLine("Total a Pagar es " + totalBill);
            }
        }
    }
} 
