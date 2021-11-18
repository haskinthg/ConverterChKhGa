using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate
{
    public class CalculatingExchangeRate
    {
        //поиск индекса ValuteList и добавление в PairIndex по char коду валюты
        public static List<int> PairIndex = new List<int>();

        public static void ChoiseValute(string Val1, string Val2)
        {
            foreach (var Valute in CurrencyPriceValute.ValuteList)
            {
                if (Val1 == Valute.CodeValute)
                {
                    PairIndex.Add(CurrencyPriceValute.ValuteList.IndexOf(Valute));
                    break;
                }
            }
            foreach (var Valute in CurrencyPriceValute.ValuteList)
            {
                if (Val2 == Valute.CodeValute)
                {
                    PairIndex.Add(CurrencyPriceValute.ValuteList.IndexOf(Valute));
                    break;
                }
            }
        }

        //вычисление курса(цена первой валюты делится на цену второй валюты
        //и эта разность умножается  на количество валюты
        public static double Calculation(double value)
        {
            double Result = (value * CurrencyPriceValute.ValuteList[PairIndex[0]].PriceValute) /
                CurrencyPriceValute.ValuteList[PairIndex[1]].PriceValute;
            PairIndex.Clear();

            return Math.Round(Result, 2, MidpointRounding.AwayFromZero);
        }

    }
}
