using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate
{
    public class CurrencyPriceValute
    {
        public CurrencyPriceValute(string Name, string Code, double Price)
        {
            NameValute = Name;
            CodeValute = Code;
            PriceValute = Price;
        }

        //public const int Ruble = 1;

        //наименование валюты
        public string NameValute { get; set; }

        //charcode валюты
        public string CodeValute { get; set; }

        // цена валюты в рублях
        public double PriceValute { get; set; }

        public const double NumValute = 1;

        //список хранящий данные о валюте
        public static List<CurrencyPriceValute> ValuteList = new List<CurrencyPriceValute>();
    }
}
