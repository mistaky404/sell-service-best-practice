using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// NO DEBE TENER PRECIOS DE USD Y DOP SINO QUE DEBERIA MANEJARLO COMO UNA LISTA DE PRECIO AGRUPADA POR MONEDA
    /// </summary>
    public class ProductServiceModel
    {
        public string NameEnglish { get; set; }
        public string NameSpanish { get; set; }
        public int PriceUSD { get; set; }
        public int PriceRD { get; set; }


    }
}
