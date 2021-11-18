using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Rate;
using System;

namespace RateTest
{
    [TestClass()]
    public class RateTest
    {
        [TestMethod()]
        public void ChoiseValuteTest()
        {
            //arrange
            Parsing.XmlToList();
            List<int> expected = new List<int>() { 11, 0 };
            string val1 = "AUD";
            string val2 = "RUB";
            //act
            CalculatingExchangeRate.ChoiseValute(val1, val2);
            //assert
            Assert.AreEqual(expected[0], CalculatingExchangeRate.PairIndex[0]);
            Assert.AreEqual(expected[1], CalculatingExchangeRate.PairIndex[1]);
        }

        [TestMethod()]
        public void CalculationTest()
        {
            //arrange
            CalculatingExchangeRate.PairIndex.Clear();
            CalculatingExchangeRate.PairIndex.Add(11);
            CalculatingExchangeRate.PairIndex.Add(0);
            Parsing.XmlToList();
            double expexted = Math.Round(CurrencyPriceValute.ValuteList[11].PriceValute * 2, 2, MidpointRounding.AwayFromZero);
            //act
            double actual = CalculatingExchangeRate.Calculation(2);
            //assert
            Assert.AreEqual(expexted, actual);
        }
    }
}
