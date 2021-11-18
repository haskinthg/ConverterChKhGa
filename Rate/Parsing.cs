using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;

namespace Rate
{
    public class Parsing
    {
        //по данным из XML создаются объекты класса CurrencyPriveValute и добавляются в список ValuteList
        public static void XmlToList()
        {
            //добавление рубля
            CurrencyPriceValute.ValuteList.Add(new CurrencyPriceValute("Российский рубль", "RUB", 1));
            WebClient client = new WebClient();
            string Xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily_utf8.xml");
            //англ версия
            //string Xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily_eng_utf8.xml");
            XDocument XmlParse = XDocument.Parse(Xml);

            //выбор элементов в класс CurrencyPriceValute
            var ExXml = XmlParse.Element("ValCurs").Elements("Valute");
            foreach (XElement element in ExXml)
            {
                string Name = element.Element("Name").Value;
                string CharCode = element.Element("CharCode").Value;
                double Value = Convert.ToDouble(element.Element("Value").Value);
                double Nominal = Convert.ToDouble(element.Element("Nominal").Value);
                Value /= Nominal;

                //добавление объектов класса CurrencyPriceValue в список 
                CurrencyPriceValute.ValuteList.Add(new CurrencyPriceValute(Name, CharCode, Value));
            }
        }
    }
}
